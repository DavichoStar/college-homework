import java.util.Scanner;

class Main2 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Ingresa el valor de N:");
        int N = in.nextInt();
        in.close();
        int A = 0, B = 1, M = 1;
        System.out.println("El valor de A es: " + A + " y el valor de B es: " + B);

        while (M <= (N - 2)) {
            int C = A + B;
            System.out.println("El valor de C es: " + C);
            A = B;
            B = C;
            M++;
        }
    }
}