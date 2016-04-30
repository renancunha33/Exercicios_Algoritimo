package orientacaoaobjeto;
class Cliente{
    String nome;
    int codigo;
}
class CartaoDeCredito{
    int numero;
    String validade;
    Cliente Cliente;
    CartaoDeCredito(int numero){
        this.numero=numero;
    }
}
class Agencia{
    int numero;
}
class conta{
    double saldo/*=100.*/;
    Agencia Agencia;
    double limite=600.;
    //metodo deposita(metodo que modifica um aributo do proprio objeto)
    boolean deposita(double valor){
        if(valor>0){
        this.saldo+=valor;
        System.out.println("Ultimo deposito : "+valor);
        return true;
    }else{
        return false;
        }        
   }
    boolean Saque(double valor){
        if(valor>0 && valor<this.limite){
            this.saldo-=valor;
          System.out.println("Ultimo Saque : "+valor);
        return true;
    }else{
        return false;
   }
}
    void ImprimeExtrato(){
        System.out.println("Saldo: "+this.saldo);        
        System.out.println("limite diario de saque: 600,00 ");
    }
}
public class OrientacaoAObjeto {
    public static void main(String[] args) {
       /* Cliente c1= new Cliente();        
        c1.codigo=01;        
        c1.nome="Renan C.";        
        /////////////////////////////////////////////////////////        
        System.out.println("Codigo : "+ c1.codigo+"\n"+"Nome :"+c1.nome);
        //////////////////////////////////////////////////////////////////
        //teste cartao de credito
        CartaoDeCredito car1=new CartaoDeCredito();
        car1.numero=201101;
        car1.validade="20/04/2014";
        System.out.println("Nº Cartao: "+car1.numero+"\nValidade: "+car1.validade);
        //////////////////////////////////////////////////////////////////
        */
        Cliente C=new Cliente();
        CartaoDeCredito cdc=new CartaoDeCredito(10110);//atribuindo valor ao numero do cartao com o metodo construtor
        C.nome="Renan C.";  /*valor*/
        //cdc.numero=201101;  /*valor*/
        System.out.println("n° cartao: "+cdc.numero);
        System.out.println("nome titular: "+C.nome);
        //////////////////////////////////////////////////////////
        Agencia a=new Agencia();
        conta co=new conta();
        a.numero=178;   /*valor*/
        co.saldo=1000.;  /*valor*/
        co.Agencia=a;
        //utilizando metodo deposita
        boolean resposta = co.deposita(2000.58); /*valor*/
        boolean resp = co.Saque(550.); /*valor*/
        if (resposta){
            System.out.print("");
        }else{
            System.out.print("Deposito nao efetuado!\n");
        }
        if (resp){
            System.out.print("");
        }else{
            System.out.print("Saque nao efetuado!\n");
        }
        //////\\\\\\\\\\\\\\\/\/\/\/\/\/\\\\\\\\\\\\\\\\\////////
        System.out.println("Agencia: "+co.Agencia.numero);
        co.ImprimeExtrato();
        //System.out.println("Saldo: "+co.saldo);
        /////////////////////////////////////////////////////////
        
    }
}
