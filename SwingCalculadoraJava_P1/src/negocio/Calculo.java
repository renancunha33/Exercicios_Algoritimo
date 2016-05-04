/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package negocio;

/**
 *
 * @author curso_ayrton
 */
public class Calculo implements ICalculadora{

    @Override
    public int Somar(int v1, int v2) {
    return v1+v2;   
    }

    @Override
    public int Subtrair(int v1, int v2) {
       return v1-v2;
    }

    @Override
    public int Multiplicar(int v1, int v2) {
        return v1*v2;
    }

    @Override
    public double Dividir(double v1, double v2) {
       if(v2!=0) 
           return v1/v2;
        else
           return 0;
    }
    
}
