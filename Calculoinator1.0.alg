algoritmo "xxx"
var n1, n2, resul:real
opcao:numerico
inicio
escreval("______________________________________________________________________________________")
escreval("                        bem vindo ao calcoloinator 1.0")
escreval("______________________________________________________________________________________")
escreval("                                   instru��es:")
escreval("")
escreval(" digite os n�meros a serem usados no  calculo, ")
escreval(" sendo na ordem que ser�o utilizados no mesmo.")
escreval(" Ap�s isso ,escolha a opera��o desejada  pela  ")
escreval(" numera��o � seguir:")
escreval("1-Soma ;2-multiplica��o ;3-divis�o ;4-subtra��o")
escreval("______________________________________________________________________________________")
escreval("Digite o 1� n�mero:")
leia (n1)
escreva("Digite o n�mero da opera��o desejada: ")
leia (opcao)
escreval("Digite o 2� n�mero:")
leia (n2)
escolha opcao
caso (1)
   resul:=n1+n2
   escreva ("o resultado � : ", resul)
caso (2)
   resul:=n1*n2
   escreva ("o resultado � : ", resul)
caso (3)
   resul:=n1/n2
   escreva ("o resultado � : ", resul)
caso (4)
   resul:=n1-n2
   escreva ("o resultado � : ", resul)
outrocaso
   escreval ("                           ***ESCOLHA INVALIDA!***")
fimescolha
fimalgoritmo
