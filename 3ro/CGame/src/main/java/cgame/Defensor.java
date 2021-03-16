package cgame;

import java.awt.Graphics;
import java.awt.Image;
import javax.swing.ImageIcon;
import javax.swing.JPanel;

//== Defensor se heredanda de la clase Sprite
public class Defensor extends Sprite {
    private ImageIcon imgDefensor;
    

    public Defensor(){
        x = 140;
        y = 435;
        width = 40;
        height = 95;
        //== Cargamos la imagen
        imgDefensor = new ImageIcon(new ImageIcon(path + "/images/Defensor.png").getImage().getScaledInstance(width, height,  Image.SCALE_SMOOTH));
    }
    //== Método encargado de dibujar la imagen
    public void dibujar(JPanel panel) {
        Graphics lienzo = panel.getGraphics();
        imgDefensor.paintIcon(null, lienzo, x, y);
    }
    //== Método encargado de mover la imagen
    public void mover (int posiIniX) {
        x = posiIniX - 40;
    }
}