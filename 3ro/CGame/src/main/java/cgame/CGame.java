package cgame;

import java.applet.*;
import java.awt.*;
import javax.swing.*;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;
import java.awt.event.MouseMotionListener;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.File;
import java.net.MalformedURLException;
import java.nio.file.*;

class CGame extends javax.swing.JFrame implements ActionListener, Runnable, MouseMotionListener, MouseListener {
    private static final long serialVersionUID = 1L;
    private JPanel panel;
    private JButton BIniciar, BPausar;
    private JLabel JVidas, JPuntos, JRecord;
    private int vidas = 3, puntos = 0, record = 0;
    
    private Alien alien;
    private Defensor defensor;
    private Laser laser;
    private Bomba bomba;
    
    private Thread thread;
    private boolean continuar;

    Path path = FileSystems.getDefault().getPath("").toAbsolutePath();
    private AudioClip disparo, explosion, caida;

    public static void main(final String[] args) {
        final CGame game = new CGame();
        game.setSize(520, 640);
        game.setLocationRelativeTo(null);//== Muestra la ventana al centro
        game.setTitle("CGame");
        game.crearInterfaz();
        game.setVisible(true);
    }
    public void crearInterfaz() {
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        final Container ventana = getContentPane();
        ventana.setBackground(Color.DARK_GRAY);
        ventana.setLayout(new FlowLayout(FlowLayout.CENTER));

        JVidas = new JLabel("Vidas: " + vidas, JLabel.CENTER);
        JVidas.setForeground(Color.WHITE);
        ventana.add(JVidas);

        JPuntos = new JLabel("Puntos: " + puntos, JLabel.CENTER);
        JPuntos.setForeground(Color.WHITE);
        ventana.add(JPuntos);
        
        JRecord = new JLabel("Record: " + record, JLabel.CENTER);
        JRecord.setForeground(Color.WHITE);
        ventana.add(JRecord);

        panel = new JPanel();
        panel.setPreferredSize(new Dimension(480, 530));
        panel.setBackground(Color.WHITE);
        ventana.add(panel);

        panel.addMouseMotionListener(this);
        panel.addMouseListener(this);
        
        BIniciar = new JButton("Iniciar Juego");
        BIniciar.setForeground(Color.BLACK);
        BIniciar.setBackground(Color.WHITE);
        ventana.add(BIniciar);
        BIniciar.addActionListener(this);

        
        BPausar = new JButton("Pausar");
        BPausar.setForeground(Color.BLACK);
        BPausar.setBackground(Color.WHITE);
        ventana.add(BPausar);
        BPausar.addActionListener(this);
        
        alien = new Alien();
        defensor = new Defensor();
        caragarAudios();
    }
    //== Evento para manejar las acciones del boton
    @Override
    public void actionPerformed(final ActionEvent evento){
        if (evento.getSource() == BIniciar && thread == null) {
            thread = new Thread(this);
            thread.start();
            BIniciar.setText("Terminar Juego");
            System.out.println("> El Juego Ha Comenzado <");
        } else if (evento.getSource() == BIniciar && thread != null) {
            continuar = false;
            thread = null;
            resetearValores();
            panel.repaint();
            BIniciar.setText("Iniciar Juego");
            BPausar.setText("Pausar");
            System.out.println("> El Juego Ha Terminado <");
        } else if (evento.getSource() == BPausar && continuar && thread != null) {
            continuar = false;
            BPausar.setText("Continuar");
            System.out.println("> Juego Pausado <");
        } else if (evento.getSource() == BPausar && !continuar && thread != null) {
            thread = new Thread(this);
            thread.start();
            BPausar.setText("Pausar");
            System.out.println("> Juego Reanudado <");
        }
    }
    // == Evento principal de la ejeccion del thread
    @Override
    public void run() {
        continuar = true;
        while(continuar) {
            if (bomba == null) {
                caida.play();
                bomba = new Bomba(alien.getX(), alien.getY());
            }
            dibujarTodo();
            moverTodo();
            verificarEstado();
            retrasar();
        }
    }
    
    public void dibujarTodo() {
        final Graphics lienzo = panel.getGraphics();
        lienzo.setColor(Color.white);
        lienzo.fillRect(0, 0, panel.getWidth(), panel.getHeight());
        alien.dibujar(panel);
        defensor.dibujar(panel);
        
        if (laser != null) laser.dibujar(panel);
        if (bomba != null) bomba.dibujar(panel);
    }
    
    public void moverTodo() {
        alien.mover();

        if (laser != null) laser.mover();
        if (bomba != null) bomba.mover();
    } 
    
    public void retrasar() {
        try {
            Thread.sleep(100);
        } catch (final InterruptedException ignored) {}
    }
    
    public void resetearValores() {
        alien.x = 0;
        alien.y = 0;
        defensor.x = 140;
        defensor.y = 450;
        laser = null;
        bomba = null;
        vidas = 3;
        puntos = 0;
        JPuntos.setText("Puntos: " + puntos);
        JVidas.setText("Vidas: " + vidas);
        JRecord.setText("Record: " + record);
    }

    @Override
    public void update(final Graphics g) {
        paint(g);
    }

    private void caragarAudios(){
        try {
            disparo = Applet.newAudioClip(new File(path + "/sounds/laser.wav").toURL());
        } catch (MalformedURLException e) {
            e.printStackTrace();
        }
        try {
            explosion = Applet.newAudioClip(new File(path + "/sounds/explosion.wav").toURL());
        } catch (MalformedURLException e) {
            e.printStackTrace();
        }
        try {
            caida = Applet.newAudioClip(new File(path + "/sounds/caida_de_bomba.wav").toURL());
        } catch (MalformedURLException e) {
            e.printStackTrace();
        }
    }
    public void verificarEstado() {
        if (colisio(laser, alien)) finalizarPartida(alien);
        if (colisio(bomba, defensor)) finalizarPartida(defensor);
        if (colisio(laser, bomba) || colisio(bomba, laser)) finalizarPartida(laser);

        if (laser != null && laser.getY() < 0) laser = null;
        if (bomba != null && bomba.getY() > panel.getHeight()) bomba = null;
    }
    
    private boolean colisio(final Sprite objeto, final Sprite sujeto) {
        if (objeto == null || sujeto == null) return false;
        else {
            final boolean colision = objeto.getY() >= sujeto.getY()
                && objeto.getY() <= (sujeto.getY() + sujeto.getHeight() - 10)
                && objeto.getX() >= sujeto.getX()
                && objeto.getX() <= (sujeto.getX() + sujeto.getWidth());
            final boolean colision2 = (objeto.getY() + objeto.getHeight()) >= sujeto.getY()
                && (objeto.getY() + objeto.getHeight()) <= sujeto.getY()
                && (objeto.getX() + objeto.getWidth()) >= sujeto.getX()
                && (objeto.getX() + objeto.getWidth()) <= (sujeto.getX() + sujeto.getWidth());

            return colision || colision2;
        }
    }
    
    private void finalizarPartida(final Sprite sujeto) {
        if (sujeto == defensor) {
            explosion.play();
            vidas--;
            JVidas.setText("Vidas: " + (Math.max(vidas, 0)));
            if (vidas < 0) {
                String recordText = "Puntos: " + puntos + " | " + (record - puntos) + " más para superar el record.";
                if (puntos > record) {
                    recordText = "Nuevo Record: " + puntos;
                    record = puntos;
                }
                JOptionPane.showMessageDialog(null, "Te has quedado sin vidas. " + recordText, "Game Over", JOptionPane.INFORMATION_MESSAGE);
                System.out.println("> Game Over <");
                resetearValores();
                continuar = false;
                thread = null;
                panel.repaint();
                BIniciar.setText("Iniciar Juego");
            } else {
                continuar = false;
                JOptionPane.showMessageDialog(null, "Vidas restantes: " + vidas, "Game Over", JOptionPane.INFORMATION_MESSAGE);
                thread = null;
                bomba = null;
                laser = null;
                panel.repaint();
                BIniciar.setText("Continuar");
            }
            BPausar.setText("Pausar");
            System.out.println("> Vidas: " + vidas + " Puntos: " + puntos + " <");
        } else if (sujeto == alien) {
            puntos += 10;
            int AVelocidad = alien.velocidad > 0 ? alien.velocidad++ : alien.velocidad--;
            alien = null;
            alien = new Alien();
            alien.velocidad = AVelocidad;
            bomba.velocidad += 3;
            JPuntos.setText("Puntos: " + puntos);
            System.out.println("> Vidas: " + vidas + " Puntos: " + puntos + " <");
        } else if (sujeto == laser) {
            laser = null;
            bomba = null;
        }
        
    }

    // == Evento al mover el mouse
    @Override
    public void mouseMoved(final MouseEvent evento){
        //System.out.println("movimiento del mouse");
        final int posIniX = evento.getX();
        defensor.mover(posIniX);
    }
    
    // == Evento al ciclear el mouse
    @Override
    public void mouseClicked(final MouseEvent evento) {
        final int posiX = defensor.getX();
        final int posiY = defensor.getY();

        if (laser == null) {
            laser = new Laser(posiX, posiY);
            disparo.play();
        }
    }
    
    
    
    @Override
    public void mouseDragged(final MouseEvent e) {}
    @Override
    public void mousePressed(final MouseEvent e) {}
    @Override
    public void mouseReleased(final MouseEvent e) {}
    @Override
    public void mouseEntered(final MouseEvent e) {}
    @Override
    public void mouseExited(final MouseEvent e) {}
}