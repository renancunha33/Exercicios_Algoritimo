algoritmo "semnome"
var num:vetor [1..10] de inteiro
cont:inteiro
inicio
para cont de 1 ate 10 faca
   escreva(" insira o", cont, "� n�mero : ")
   leia (num[cont])
fimpara
limpatela
escreval("N�meros maiores que 10")
para cont de 1 ate 10 faca
   se (num[cont])>10 entao
   escreval("")
      escreval(cont, "� n�mero: ", (num[cont]) )
   fimse
fimpara
fimalgoritmo
