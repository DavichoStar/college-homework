import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String texto = "";
        int opcion = 0, tabla = 0, temp;
        boolean validar = false, regresar = false;

        do {
            do {
                System.out.println("##### Tablas de multiplicar #####\n\n1.- Mostrar una tabla específica\n2.- Mostrar tablas del 1 – 10\n3.- Salir");
                
                if (in.hasNextInt()) {
                    opcion = in.nextInt();
                    validar = true;
                }
                else {
                    in.next();
                    System.out.println("La opcion no es valida");
                    validar = false;
                }
            } while (!validar);
            validar = false;

            if (opcion == 1) {
                do {
                    do {
                        texto = "";
                        System.out.println("Indique el número de la tabla a mostrar:");
                        
                        if (in.hasNextInt()) {
                            tabla = in.nextInt();
                            validar = true;
                        }
                        else {
                            in.next();
                            System.out.println("La opcion no es valida");
                            validar = false;
                        }
                    } while (!validar);
                    validar = false;

                    for (int i = 1; i <= 10; i++) {
                        texto += tabla + " x " + i + " = " + (tabla*i) + "\n";
                    }

                    System.out.println(texto);
                    do {
                        System.out.println("¿Desea mostrar una nueva tabla (1. Si, 2. No)?");
                        if (in.hasNextInt()) {
                            temp = in.nextInt();
                            if (temp == 1) {
                                regresar = false;
                                validar = true;
                            } else if (temp == 2) {
                                regresar = true;
                                validar = true;
                            } else System.out.println("La opcion no es valida");
                        }
                        else {
                            in.next();
                            System.out.println("La opcion no es valida");
                            validar = false;
                        }
                    } while (!validar);
                } while (!regresar);
            } else if (opcion == 2) {
                texto = "";
                for (int u = 1; u <= 10; u++) {
                    for (int i = 1; i <= 10; i++) {
                        texto += u + " x " + i + " = " + (u*i) + "\n";
                    }
                    texto += "\n";
                }
                System.out.println(texto);
            } else if (opcion > 3 || opcion < 1) System.out.println("La opcion no es valida");
        } while (opcion != 3);
        in.close();
        System.out.println("Cerrando programa... Hasta luego.");
    }
}
