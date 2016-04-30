algoritmo "xxx"
var n1, n2, resul:real
opcao:numerico
inicio
escreval("______________________________________________________________________________________")
escreval("                        bem vindo ao calcoloinator 1.0")
escreval("______________________________________________________________________________________")
escreval("                                   instruções:")
escreval("")
escreval(" digite os números a serem usados no  calculo, ")
escreval(" sendo na ordem que serão utilizados no mesmo.")
escreval(" Após isso ,escolha a operação desejada  pela  ")
escreval(" numeração á seguir:")
escreval("1-Soma ;2-multiplicação ;3-divisão ;4-subtração")
escreval("______________________________________________________________________________________")
escreval("Digite o 1º número:")
leia (n1)
escreva("Digite o número da operação desejada: ")
leia (opcao)
escreval("Digite o 2º número:")
leia (n2)
escolha opcao
caso (1)
   resul:=n1+n2
   escreva ("o resultado é : ", resul)
caso (2)
   resul:=n1*n2
   escreva ("o resultado é : ", resul)
caso (3)
   resul:=n1/n2
   escreva ("o resultado é : ", resul)
caso (4)
   resul:=n1-n2
   escreva ("o resultado é : ", resul)
outrocaso
   escreval ("                           ***ESCOLHA INVALIDA!***")
fimescolha
fimalgoritmo
