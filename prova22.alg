algoritmo "semnome"

var
res, x, y:real
ZZZ:inteiro
procedimento soma
res<- x+y
fimprocedimento
procedimento sub
res<- x-y
fimprocedimento
procedimento vez
res<- x*y
fimprocedimento
procedimento divi
res<- x/y
fimprocedimento
inicio
escreval("escreva o 1ºnumero na tela:")
leia (x)
Escreval("escolha a operação")
escreval("1-soma, 2-subtração, 3-multiplicação, 4-divisão, 5-raiz quadrada")
leia(ZZZ)
se ZZZ=5 entao
   res:=raizq(x)
   escreval("resultado : ", res)
fimse
escreval("escreva o 2ºnumero na tela: ")
Leia(y)
se ZZZ=1 entao
   soma
fimse
se ZZZ=2 entao
   sub
fimse
se ZZZ=3 entao
   vez
fimse
se ZZZ=4 entao
   divi
senao
escreval("ERRO, opção invalida!!!")
fimse
escreval("resultado : ", res)
fimalgoritmo
