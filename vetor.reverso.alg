algoritmo "semnome"
var
nome:vetor [1..10] de caractere
cont:inteiro
x:caracter
inicio
para cont de 1 ate 10 faca
   escreval(cont, "º nome: ")
   leia (nome[cont])
fimpara
escreval ("________________________________________________________________________________________")
Escreval("                        ***Ordem dos nomes*** ")
escreval ("________________________________________________________________________________________")
escreval("10° nome: ", (nome[10]))
escreval( " 9° nome: ", (nome[9]) )
escreval( " 8° nome: ", (nome[8]) )
escreval( " 7° nome: ", (nome[7]) )
escreval( " 6° nome: ", (nome[6]) )
escreval( " 5° nome: ", (nome[5]) )
escreval( " 4° nome: ", (nome[4]) )
escreval( " 3° nome: ", (nome[3]) )
escreval( " 2° nome: ", (nome[2]) )
escreval( " 1° nome: ", (nome[1]) )
escreval ("________________________________________________________________________________________")
escreval("Deseja sair?[s/n]")
leia (x)
se x = "n" entao
   limpatela
   repita
      para cont de 1 ate 10 faca
         escreval(cont, "º nome: ")
         leia (nome[cont])
      fimpara
      escreval ("________________________________________________________________________________________")
      Escreval("                        ***Ordem dos nomes*** ")
      escreval ("________________________________________________________________________________________")
      escreval("10° nome: ", (nome[10]))
      escreval( " 9° nome: ", (nome[9]) )
      escreval( " 8° nome: ", (nome[8]) )
      escreval( " 7° nome: ", (nome[7]) )
      escreval( " 6° nome: ", (nome[6]) )
      escreval( " 5° nome: ", (nome[5]) )
      escreval( " 4° nome: ", (nome[4]) )
      escreval( " 3° nome: ", (nome[3]) )
      escreval( " 2° nome: ", (nome[2]) )
      escreval( " 1° nome: ", (nome[1]) )
      escreval ("________________________________________________________________________________________")
      escreval("Deseja sair?[s/n]")
      leia (x)
   ate x = "s"
   fimse
   fimalgoritmo
