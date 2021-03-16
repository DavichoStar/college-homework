package cgame;

import java.awt.Graphics;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.JPanel;

//== Alien se heredanda de la clase Sprite
public class Alien extends Sprite {
    private ImageIcon imgAlien;
    

    public Alien(){
        x = 0;
        y = 0;
        width = 70;
        height = 45;
        velocidad = 20;
        //== Cargamos la imagen
        imgAlien = new ImageIcon(new ImageIcon(path + "/images/Alien.png").getImage().getScaledInstance(width, height,  Image.SCALE_SMOOTH));
    }
    //== Método encargado de dibujar la imagen
    public void dibujar(JPanel panel) {
        Graphics lienzo = panel.getGraphics();
        imgAlien.paintIcon(null, lienzo, x, y);
        
    }
    //== Método encargado de mover la imagen
    public void mover() {
        if (x > 380 || x < 0) velocidad = -velocidad;
        x = x + velocidad;
    }
}