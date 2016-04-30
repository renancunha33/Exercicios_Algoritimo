algoritmo "vetor.time"
var time:vetor [1..10] de caractere
titulo_br:vetor [1..10] de inteiro
cont:inteiro
inicio
para cont de 1 ate 10 faca
   escreval("Digite o nome do ", cont, "° time: ")
   leia(time[cont])
   escreval("digite o número de Títulos nacionais desse time: ")
   leia(titulo_br[cont])
   escreval("")
fimpara
limpatela
EScreval("***times com 2 ou mais Títulos***")
escreval("")
para cont de 1 ate 10 faca
   se (titulo_br[cont])>=2 entao
      escreval (time[cont])
      escreval((titulo_br[cont]), " títulos")
      escreval("")
   fimse
fimpara
fimalgoritmo
