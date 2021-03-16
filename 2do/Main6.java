import java.util.Scanner;

class Main6 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int N;
        String TI, TP;
        double PA, TO, CA, TOT;
        
        System.out.println("Ingresa la cantidad de hambuerguesas a comprar:");
        N = in.nextInt();
        System.out.println("Ingresa el tipo de hamburguesa:\n-Sencilla\n-Doble\n-Tiple");
        TI = in.next();
        System.out.println("Ingresa el método de pago:\n-Tarjeta\n-Efectivo");
        TP = in.next();
        in.close();

        if (TI.equals("Sencilla")) {
            PA = 20;
        } else if (TI.equals("Doble")) {
            PA = 25;
        } else {
            PA = 28;
        }
        TO = PA * N;

        if (TP.equals("Tarjeta")) {
            CA = TO * 0.05;
        } else {
            CA = 0;
        }

        TOT = TO + CA;

        System.out.println("La hamburguesa costó " + PA);
        System.out.println("El total sin cargo " + TO);
        System.out.println("El cargo es " + CA);
        System.out.println("EL total por pagar es " + TOT);
    }
}