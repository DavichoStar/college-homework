class Main4 {
    public static void main(String[] args) {
        int KA = 70, KB = 150, R = KB - KA;
        
        while(R > 0){
            KA++;
            KB--;
            R = KB - KA;
        }

        if (R == 0) KA = KB;
        else KA -= 0.5;

        System.out.println("Punto de encuentro = " + KA);
    }
}