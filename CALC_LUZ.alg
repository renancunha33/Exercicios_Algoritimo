algoritmo "CALC_LUZ"
var l1 ,l2, res : real
inicio
escreval("digite o valor atual do seu maracador de luz:")
leia(l1)
escreval("digite o valor que seu marcados mostrava a um mes atrás:")
leia(l2)
res:= (l1-l2)* 0.18 * 1.25
escreva("sua conta será de: R$", res)
fimalgoritmo
