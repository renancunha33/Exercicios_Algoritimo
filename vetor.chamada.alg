algoritmo "semnome"
var nome:vetor [1..30] de caractere
cont:inteiro
x:caractere
inicio
para cont de 1 ate 30 faca
   escreval("N�mero", cont,": ")
   leia (nome[cont])
fimpara
x:="s"
enquanto x="s" faca
   escreva ("escreva o n�mero do aluno a ser procurado: ")
   leia(cont)
   se (cont>30) ou (cont=0) entao
      escreval("***n�mero inv�lido***")
   senao
      escreval("")
      escreval(nome[cont])
   fimse
   escreval("")
   escreval("deseja procurar outro?[se 'sim' digite 'S']")
   leia (x)
fimenquanto
fimalgoritmo
