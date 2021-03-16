import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Tabla extends JFrame implements ActionListener, ItemListener {
    private static final long serialVersionUID = 1L;
    private JLabel label1, label2;
    private JTextArea tabla;
    private JScrollPane scrollPane1;
    private JButton BUna, BTodas, BCerrar, BMenu, BRegresar;
    private JComboBox CUna;

    public Tabla() {
        setLayout(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setTitle("Tablas de Multiplicar");
        getContentPane().setBackground(new Color(10, 30, 30));
        setIconImage(new ImageIcon(getClass().getResource("icono.jpg")).getImage());

        label1 = new JLabel("Tablas de Multiplicar");
        label1.setBounds(50, 10, 300, 20);
        label1.setFont(new Font("Andale Mono", 3, 18));
        label1.setForeground(new Color(255, 255, 255));
        add(label1);
        
        label2 = new JLabel("Mostrar:");
        label2.setBounds(100, 60, 300, 20);
        label2.setFont(new Font("Andale Mono", 3, 18));
        label2.setForeground(new Color(255, 255, 255));
        add(label2);
        
        tabla = new JTextArea();
        tabla.setFont(new Font("Andale Mono", 3, 12));
        tabla.setForeground(new Color(255, 255, 255));
        tabla.setBackground(new Color(10, 30, 30));
        tabla.setEditable(false);
        add(tabla);

        scrollPane1 = new JScrollPane(tabla);
        scrollPane1.setBounds(40, 60, 220, 220);
        scrollPane1.setBackground(new Color(10, 30, 30));
        scrollPane1.setVisible(false);
        add(scrollPane1);


        BUna = new JButton("Tabla \u00danica");
        BUna.setBounds(65, 100, 150, 40);
        BUna.setBackground(new Color(255, 255, 255));
        BUna.setFont(new Font("Andale Mono", 3, 12));
        BUna.setForeground(new Color(0, 0, 0));
        BUna.addActionListener(this);
        add(BUna);

        BTodas = new JButton("Todas Las Tablas");
        BTodas.setBounds(65, 150, 150, 40);
        BTodas.setBackground(new Color(255, 255, 255));
        BTodas.setFont(new Font("Andale Mono", 3, 12));
        BTodas.setForeground(new Color(0, 0, 0));
        BTodas.addActionListener(this);
        add(BTodas);

        BCerrar = new JButton("Salir");
        BCerrar.setBounds(100, 300, 90, 40);
        BCerrar.setBackground(new Color(255, 255, 255));
        BCerrar.setFont(new Font("Andale Mono", 3, 18));
        BCerrar.setForeground(new Color(0, 0, 0));
        BCerrar.addActionListener(this);
        add(BCerrar);

        BMenu = new JButton("Men\u00fa");
        BMenu.setBounds(100, 300, 90, 40);
        BMenu.setBackground(new Color(255, 255, 255));
        BMenu.setFont(new Font("Andale Mono", 3, 18));
        BMenu.setForeground(new Color(0, 0, 0));
        BMenu.setVisible(false);
        BMenu.addActionListener(this);
        add(BMenu);

        BRegresar = new JButton("Regresar");
        BRegresar.setBounds(100, 300, 90, 40);
        BRegresar.setBackground(new Color(255, 255, 255));
        BRegresar.setFont(new Font("Andale Mono", 3, 12));
        BRegresar.setForeground(new Color(0, 0, 0));
        BRegresar.setVisible(false);
        BRegresar.addActionListener(this);
        add(BRegresar);

        CUna = new JComboBox<>();
        CUna.setBounds(100, 100, 100, 20);
        CUna.setVisible(false);
        add(CUna);
        CUna.addItem("Defecto");
        CUna.addItem("1");
        CUna.addItem("2");
        CUna.addItem("3");
        CUna.addItem("4");
        CUna.addItem("5");
        CUna.addItem("6");
        CUna.addItem("7");
        CUna.addItem("8");
        CUna.addItem("9");
        CUna.addItem("10");
        CUna.addItemListener(this);
    }

    public static void main(String[] args) {
        Tabla tabla1 = new Tabla();
        tabla1.setBounds(0, 0, 300, 400);
        tabla1.setVisible(true);
        tabla1.setLocationRelativeTo(null);
        tabla1.setResizable(false);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        if (e.getSource() == BUna) {
            label2.setText("Indique el n\u00famero de la tabla a mostrar:");
            label2.setFont(new Font("Andale Mono", 3, 12));
            label2.setBounds(40, 60, 300, 20);
            BUna.setVisible(false);
            BTodas.setVisible(false);
            BCerrar.setVisible(false);
            BMenu.setVisible(true);
            CUna.setVisible(true);
        } else if (e.getSource() == BTodas) {
            String texto = "";
            for (int u = 1; u <= 10; u++) {
                for (int i = 1; i <= 10; i++) {
                    texto += u + " x " + i + " = " + (u*i) + "\n";
                }
                texto += "\n";
            }
            tabla.setText(texto);
            scrollPane1.setVisible(true);
            label2.setVisible(false);
            BUna.setVisible(false);
            BTodas.setVisible(false);
            BCerrar.setVisible(false);
            BMenu.setVisible(true);
            
        } else if (e.getSource() == BCerrar) {
            int resp = JOptionPane.showConfirmDialog(null, "\u00BFEsta seguro?", "Cerrando programa", JOptionPane.YES_NO_OPTION, JOptionPane.ERROR_MESSAGE);
            if (resp == 0) {
                JOptionPane.showMessageDialog(null, "Hasta luego.", "Cerrando programa...", JOptionPane.INFORMATION_MESSAGE);
                System.exit(0);
            }
        } else if (e.getSource() == BMenu) {
            label2.setText("Mostrar:");
            label2.setBounds(100, 60, 300, 20);
            label2.setFont(new Font("Andale Mono", 3, 18));
            label2.setVisible(true);
            BUna.setVisible(true);
            BTodas.setVisible(true);
            BCerrar.setVisible(true);
            BMenu.setVisible(false);
            CUna.setVisible(false);
            scrollPane1.setVisible(false);
        } else if (e.getSource() == BRegresar) {
            scrollPane1.setVisible(false);
            label2.setVisible(true);
            CUna.setVisible(true);
            BMenu.setVisible(true);
            BRegresar.setVisible(false);
        }

    }

    @Override
    public void itemStateChanged(ItemEvent e) {
        if (e.getSource() == CUna) {
            int seleccion = Integer.parseInt(CUna.getSelectedItem().toString());

            if (CUna.getSelectedItem().toString() != "Defecto") {
            String texto = "";
                for (int i = 1; i <= 10; i++) {
                    texto += seleccion + " x " + i + " = " + (seleccion*i) + "\n";
                }
                tabla.setText(texto);
                scrollPane1.setVisible(true);
                label2.setVisible(false);
                CUna.setVisible(false);
                BMenu.setVisible(false);
                BRegresar.setVisible(true);
            }
        }

    }
}