algoritmo "mediador"
var nota1, nota2, nota3, nota4, med: real
inicio
escreval ("digite a primeira nota")
leia (nota1)
escreval ("digite a segunda nota")
leia (nota2)
escreval ("digite a terceira nota")
leia (nota3)
escreval ("digite a quarta nota")
leia (nota4)
med:= (nota1+nota2+nota3+nota4)/4
se >=6 entao
   escreval ("aprovado")
   escreval("a média é ", med)
senao
   escreval("reprovado")
   escreval("a média é ", med)
fimse
se nota4<3 entao
   escreval ("***REPROVADO POR NOTA MENOR QUE 3 NO ULTIMO BIMESTRE***")
fimse
fimalgoritmo
