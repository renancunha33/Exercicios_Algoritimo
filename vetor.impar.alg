algoritmo "semnome"
var
nome:vetor [1..10] de caractere
cont:inteiro
inicio
para cont de 1 ate 10 faca
   escreval(" nome: ")
   leia (nome[cont])
fimpara
escreval ("")
para cont de 1 ate 10 faca
   se cont mod 2<>0 entao
      escreval(cont, "° nome: ", (nome[cont]) )
   fimse
fimpara
fimalgoritmo
