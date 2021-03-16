package cgame;

import java.awt.Graphics;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.JPanel;

//== Bomba se heredanda de la clase Sprite
public class Bomba extends Sprite{
    private ImageIcon imgBomba;


    public Bomba(int nposX, int nposY){
        x = nposX + 15;
        y = nposY + 10;
        width = 40;
        height = 50;
        velocidad = 10;
        //== Cargamos la imagen
        imgBomba = new ImageIcon(new ImageIcon(path + "/images/Bomba.png").getImage().getScaledInstance(width, height,  Image.SCALE_SMOOTH));
    }
    //== Método encargado de dibujar la imagen
    public void dibujar(JPanel panel){
        Graphics lienzo = panel.getGraphics();
        imgBomba.paintIcon(null, lienzo, x, y);
    }
    //== Método encargado de mover la imagen
    public void mover() {
        y += velocidad;
    }
}