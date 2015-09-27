
public class Main {

	public static void main(String[] args)
	  {
	   
	    System.out.print("Hello World!");
	    int num[] = {1,2,3,4,5};
	    int divisores =0;
	     
	    for(int i=0;i<5;i++){
	       System.out.print("Digite um numero\n\n");
	  
	      for(int h=0; h<num[i];h++){
	        if(num[i] % (h+1)==0){
	          divisores++;
	        }
	   }
	      System.out.print(num[i]+"\n");
	      if(divisores==2) System.out.print("PRIMO\n");
	      else System.out.print("NAO primo\n");
	      divisores=0;
	  }
	 }

}
