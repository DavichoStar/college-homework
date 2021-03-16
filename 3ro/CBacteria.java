// Erick David Flores Escobar | Sistemas Tercer Cuatrimestre
// Se importan las librerías que se ocuparán sus funciones y métodos
import java.util.Random;
import javax.swing.*;
import javax.swing.event.*;
import java.awt.*;
import java.awt.event.*;

// Inicia de la clase principal del archivo CBacteria
public class CBacteria extends JFrame implements ActionListener, ChangeListener{          // Se extiende de JFrame y se agrega las dos imprementaciones
    private static final long serialVersionUID = 8453228327932574220L;                    // Id que que genera el IDE.

    private JPanel panel;                          // Es una variable tipo JPanel que será la ventana gráfica.
    private Random random;                         // Se crea una variable tipo random para la utilización de números aleatorios.
    private javax.swing.Timer timer;               // Se crea una variable donde nos ayudará con intervalos de tiempo.
    private JSlider slider;                        // Se crea una variable para poner el objeto deslisable en la ventana.
    private JTextField gapField;                   // Se crea una variable para colocar texto. 
    private JLabel gapLabel;                       // Se crea una variable para mostrar objetos o texto en la ventana.
    private JButton BReiniciar, BAccion;           // Se declaran los botones que se usarán.
    private int rep = 1;                           // Se crea una variable para guardar un valor de tipo entero, que representa los las bacterias.
    private int contador = 1;                      // Se crea una variable para guardar un valor de tipo entero, que representa los segundos.

    public static void main(String[] args){        // Es la función principal de la clase que el compilador buscará y compilará.
        CBacteria frame = new CBacteria();         // Se crea una variable para guardara el panel y le asignamos el valor de la clase actual.
        frame.setSize(700, 500);                   // Se asigna el tamaño de la vetana.
        frame.createGUI();                         // Se usa la función de la clase CBacteria que está un par de líneas abajo.
        frame.setVisible(true);                    // Coloca como visible la ventana en pantalla.
    }
    
    public void createGUI() {                      // Inicia la función "createGUI".
        setDefaultCloseOperation(EXIT_ON_CLOSE);   // Se le da un comportamiento de salir y cerrar cuando se apreta el botón cerrar de la ventana.
        Container window = getContentPane();       // A la variable window se le asigna el objeto "frame" que es la ventana, le da todo su contenido de JFrame.
        window.setLayout(new FlowLayout());        // Se establece el administrador de diseño que se ocupará en la ventana.
        random = new Random();                     // Se le asigna el valor que es un constructor a la variable Random.
        panel = new JPanel();                      // Se le asigna un valor que es un constructor a la variable Panel.
        panel.setPreferredSize(new Dimension(680, 420));        // Se asigna el tamaño al panel dentro de la ventana.
        panel.setBackground(Color.white);          // Se le asigna un color al panel.
        window.add(panel);                         // Se agrega la variable "panel" a la ventana.
        
        BReiniciar = new JButton("Reiniciar");     // Se le asigna el valor al boton con un string: "Reiniciar".
        window.add(BReiniciar);                    // Se agrega la variable "BReiniciar" a la ventana.
        BReiniciar.addActionListener(this);        // Se agrega la escuha del evento al apretar el botón para poder manejar su comportamiento.
        
        BAccion = new JButton("Detener");          // Se le asigna el valor al boton con un string inicial: "Detener".
        window.add(BAccion);                       // Se agrega la variable "BAccion" a la ventana.
        BAccion.addActionListener(this);           // Se agrega la escuha del evento al apretar el botón para poder manejar su comportamiento.

        
        gapLabel = new JLabel ("Intervalo de tiempo: ");        // Se le asigna un valor string que se va a mostrar en pantalla.
        window.add(gapLabel);                      // Se agrega la variable "gapLabel" a la ventana.
        gapField = new JTextField(10);             // límite del cuadro para colocar texto, en este caso, números
        window.add(gapField);                      // Se agrega la variable "gapField" a la ventana.
        
        slider = new JSlider(JSlider.HORIZONTAL, 1, 10, 5);     //Se le asigna el valor que es un constructor a la variable Slider con límiyes y un valor "5" por defecto.
        window.add(slider);                        // Se agrega la variable "slider" a la ventana.
        slider.addChangeListener((ChangeListener) this);        // Se agrega la escuha del evento al deslizar el slider para poder manejar su comportamiento.
        
        gapField.setText(Integer.toString(slider.getValue()));  // Se obtiene el valor de slider y lo asigna como nuevo valor al texto de gapField.
        gapField.addActionListener((ActionListener) this);      // Se agrega la escuha del evento al dar enter en el gapField para poder manejar su comportamiento.
        timer = new javax.swing.Timer(1000, (ActionListener) this);// Se agrega la escuha del evento para poder manejar su comportamiento y un intervalo de un segundo.
        timer.start();                             // Iniciar el contador del tiempo.
    }

    public void actionPerformed(ActionEvent event) {            // Se declara la función "actionPerformed" para los dos botones y el timer.
        if (event.getSource() == timer) {                       // Si el evento pertenece a la variable timer
            if (!BAccion.isVisible()) BAccion.setVisible(true); // Si el botón BAccion no es visible, hacerlo visble.
            int x, y, size, con = rep/3;                        // Se declaran variables de tipo entero sin valor asignado menos a con que se le asigna el valor de rep entre tres.
            Graphics paper = panel.getGraphics(); // Se declara un a variable de tipo Graphics y se le asigna el valor de los graficos que ya estén en el panel.
            
            for(int i = 0; i < (rep - con); i++) {// Se inicia un ciclo for donde se incia un contador en 0, que se repitiera mientras en contador sea mayor que rep menos con y se incremente de uno en uno el contador.
                x = random.nextInt(680);          // Se obtiene un valor aleatorio de tipo entero con un límite de valor entre 0 a 680.
                y = random.nextInt(420);          // Se obtiene un valor aleatorio de tipo entero con un límite de valor entre 0 a 420.
                size = 9;                         // Se le asigna un valor a la variable size de tipo entero.
                paper.setColor(Color.red);        // Se le asigna un color rojo a la vaiable paper.
                paper.fillOval(x, y, size, size); // Se crea un cuadrado con el tamaño y coordenadas determinadas anteriormente. 
            }
            System.out.println("Segundo " + contador + " - Número de bacterias: " + rep); // Se imprime en consola el texto
            rep *= 3;                             // Se multiplica el valor de la variable rep por 3.
            contador++;                           // Se incrementa de uno por uno la variable contador, que representa los segundos.
            if (contador > Integer.parseInt(gapField.getText())) {                        // Si el contador es mayor a gapField:
                timer.stop();                     // Se detiene el contador de timer.
                BAccion.setVisible(false);        // Se establece como no visible el botón BAccion.
            }
        } else if (event.getSource() == BReiniciar) {           // Si el evento no pertenece a la variable timer pero pertenece a BReiniciar
            rep = 1;                              // Se reasigna el valor a la variable rep de tipo entero a uno.
            contador = 1;                         // Se reasigna el valor a la variable contador de tipo entero a uno.
            panel.repaint();                      // Se limpia/re-pinta el panel para vanciarlo.
            timer.start();                        // Se vuelve a iniciar el contador del tiempo.
        } else if (event.getSource() == BAccion) {              // Si el evento no pertenece a la variable BReiniciar pero pertenece a BAccion
            if (BAccion.getText() == "Detener") { // Si el texto del botón es igual a "Detener".
                timer.stop();                     // Se detiene el contador de timer.
                BAccion.setText("Continuar");     // Se restablece el texto del botón a "Continuar".
            } else {                              // Si no
                timer.start();                    // Se vuelve a iniciar el contador del tiempo.
                BAccion.setText("Detener");       // Se restablece el texto del botón a "Detener".
            }
        } else if (event.getSource() == gapField)               // Si el evento no pertenece a la variable BReiniciar pero pertenece a gapField.
            slider.setValue(Integer.parseInt(gapField.getText()));                        // Si establece el valor de slider al valor de gapField.
    }

    public void stateChanged(ChangeEvent e) {    // Se declara una función "stateChanged" para el slider.
        gapField.setText(Integer.toString(slider.getValue()));  // Se obtiene el valor de slider y se le asigna al valor de la variable "gapField".
    }
}