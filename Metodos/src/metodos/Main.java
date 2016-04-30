package metodos;
import java.util.*;

public class Main {
public static void soma(){
    int a, b, soma;
    Scanner h=new Scanner(System.in);
    System.out.println("Digite o 1° numero");a=h.nextInt();
    System.out.println("Digite o 2° numero");b=h.nextInt();
    soma = a+b;
     System.out.println("Soma :"+ soma);
}
    public static void main(String[] args) {
       soma();
    }
}
