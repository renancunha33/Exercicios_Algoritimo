package vetor;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        Scanner x=new Scanner(System.in);
        float nota[]=new float[4];
        for(int i=0;i<=3;i++){
            System.out.println("Digite a "+(i+1)+"° nota:");
            nota[i]=x.nextFloat();
        }
        System.out.println("a media é: "+((nota[0]+nota[1]+nota[2]+nota[3])/4));
    }
}
