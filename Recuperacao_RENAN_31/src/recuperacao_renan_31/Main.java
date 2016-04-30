package recuperacao_renan_31;
import java.util.Scanner;
public class Main {
public static int quad(int num){
    num=num*num;
return(num);
}
public static double expo(int i,int j){
double p=i;
for(int v=1;v<j;v++){
p=p*i;
}
return p;
}
public static void pole(){
for(int i=1;i<21;i++){
System.out.println(i+" cm = "+(i*2.54)+" Pol.");
}
}
public static int sair(int opc){
if(opc==1)opc=1010;
else
if(opc!=2&&opc!=1)System.out.println("Opc Invalida! Retornando ao menu!");
return(opc);
}
public static double fah(int c){
return c*1.8+32;
}
public static void main(String[] args) {
Scanner h=new Scanner(System.in); int opc;
do{
System.out.print("\n________________________\n****Escolha a opção*****\n________________________\n1-Quadrado\n2-Expoente\n3-Converão Polegadas\n4-Fahrenheit\n5-sair\n________________________\n ");
opc=h.nextInt();
switch(opc){
case 1:
int num;
System.out.println("Digite um numero:");
num=h.nextInt();
System.out.println("Resul.: "+quad(num));
break;
case 2:
int i,j;
System.out.println("Digite um numero:");
i=h.nextInt();
System.out.println("Digite o valor da potencia:");
j=h.nextInt();
System.out.println("Resul.: "+expo(i,j));
break;
case 3:
pole();
break;
case 4:
System.out.println("Digite um numero:");
int c=h.nextInt();
System.out.println(fah(c)+"° F");
break;
case 5:
System.out.println("Deseja realmente sair?(1-sim/2-nao)");
opc=h.nextInt();
opc=sair(opc);
break;
default:
System.out.println("Opc Invalida");
break;
}}while (opc!=1010);
}
}