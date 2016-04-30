algoritmo "semnome"
var
procedimento soma
inicio
res:= x+y
fimprocedimento
procedimento sub
inicio
res:= x-y
fimprocedimento
procedimento vez
inicio
res:= x*y
fimprocedimento
procedimento divi
inicio
res:= x/y
fimprocedimento
res, x, y:real
v:inteiro
inicio
escreval("escreva o 1ºnumero na tela:")
leia (x)

Escreval("escolha a operação")
escreval("1-soma, 2-subtração, 3-multiplicação, 4-divisão, 5-raiz quadrada")
leia(v)
se v=5 entao
   res:=raizq(x)
fimse
escreval("escreva o 2ºnumero na tela: ")
Leia(y)
escolha v
caso (1)
   soma
caso (2)
   sub
caso (3)
   vez
caso (4)
   divi
outrocaso
   escreval("ERRO, opção invalida!!!")
fimescolha
escreval("resultado: ", res)
fimalgoritmo
