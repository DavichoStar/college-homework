import java.util.Scanner;

class Main1 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int SU = 0;

        for (int i = 0; i < 10; i++) {
            System.out.println("Ingresa el valor " + (i + 1) + ":");
            int VA = in.nextInt();
            SU += VA;
        }
        in.close();
        System.out.println("El valor total es: " + SU);
    }
}