algoritmo "semnome"
var num:vetor [1..10] de inteiro
cont:inteiro
inicio
para cont de 1 ate 10 faca
   escreva(" insira o", cont, "° número : ")
   leia (num[cont])
fimpara
limpatela
escreval("Números maiores que 10")
para cont de 1 ate 10 faca
   se (num[cont])>10 entao
   escreval("")
      escreval(cont, "° número: ", (num[cont]) )
   fimse
fimpara
fimalgoritmo
