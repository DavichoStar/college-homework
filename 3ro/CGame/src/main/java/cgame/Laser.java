package cgame;

import java.awt.Graphics;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.JPanel;

//== Lase se heredanda de la clase Sprite
public class Laser extends Sprite{
    private ImageIcon imgLaser;
    private int tamMov;
    

    public Laser(int nposX, int nposY) {
        x = nposX + 20;
        y = nposY + 10;
        width = 5;
        height = 40;
        tamMov = 30;
        //== Cargamos la imagen
        imgLaser = new ImageIcon(new ImageIcon(path + "/images/Laser.png").getImage().getScaledInstance(width, height,  Image.SCALE_SMOOTH));
    }
    //== Método encargado de dibujar la imagen
    public void dibujar(JPanel panel){
        Graphics lienzo = panel.getGraphics();
        imgLaser.paintIcon(null, lienzo, x, y);
        
    }
    //== Método encargado de mover la imagen
    public void mover() {
        y -= tamMov;
    }
}