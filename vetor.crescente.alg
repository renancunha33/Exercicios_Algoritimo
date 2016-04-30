algoritmo "Ordem_crescente"
var
chamada : vetor[1..10] de inteiro
swap    : inteiro
count   : inteiro
count2  : inteiro
inicio

para count de 1 ate 10 faca
   escreva("Digite o ",count,"º valor:" )
   leia(chamada[count])
fimpara

para count2 de 1 ate 10 faca
   para count de 1 ate 9 faca
      se chamada[count]>chamada[count+1] entao
         swap := chamada[count+1]
         chamada[count+1] := chamada[count]
         chamada[count] := swap
      fimse
   fimpara
fimpara

para count de 1 ate 10 faca
   escreval(chamada[count])
fimpara

fimalgoritmo
