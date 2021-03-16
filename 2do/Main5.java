import java.util.Scanner;

class Main5 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int N, A = 0, B = 0, C = 0, T1 = 0, T2 = 0, T3 = 0, TT = 0, CN = 1;

        System.out.println("Ingresa el valor de N:");
        N = in.nextInt();

        while (CN < N) {
            System.out.println("Ingresa el valor de V:");
            int V = in.nextInt();

            if (V > 1000) {
                A++;
                T1++;
            } else if (V > 500) {
                B++;
                T2++;
            } else {
                C++;
                T3++;
            }
            TT += V;
            CN++;
        }
        in.close();

        System.out.println("Las ventas y el total de ventas 1 es: " + A + " | " + T1);
        System.out.println("Las ventas y el total de ventas 2 es: " + B + " | " + T2);
        System.out.println("Las ventas y el total de ventas 3 es: " + C + " | " + T3);
        System.out.println("El total de ventas es: " + TT);
    }
}