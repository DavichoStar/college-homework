package cgame;

import java.nio.file.FileSystems;
import java.nio.file.Path;

public class Sprite {
    //== Variables
    int x, y, width, height, velocidad;
    Path path = FileSystems.getDefault().getPath("").toAbsolutePath();
    
    //== Obtener la posicion de la variable X
    public int getX() {
        return x;
    }
    //== Obtener la posicion de la variable Y
    public int getY() {
        return y;
    }
    //== Obtener la posicion de la variable Width
    public int getWidth() {
        return width;
    }
    //== Obtener la posicion de la variable Height
    public int getHeight() {
        return height;
    }
}