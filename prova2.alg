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
escreval("escreva o 1�numero na tela:")
leia (x)

Escreval("escolha a opera��o")
escreval("1-soma, 2-subtra��o, 3-multiplica��o, 4-divis�o, 5-raiz quadrada")
leia(v)
se v=5 entao
   res:=raizq(x)
fimse
escreval("escreva o 2�numero na tela: ")
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
   escreval("ERRO, op��o invalida!!!")
fimescolha
escreval("resultado: ", res)
fimalgoritmo
