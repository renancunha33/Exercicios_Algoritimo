algoritmo "Mestre da Viagem"
// Fun��o :
// Autor :
// Data : 15/03/2011
// Se��o de Declara��es 
var
km, prl, kml, lpv, pr:real
inicio
// Se��o de Comandos
escreval("***BEM VINDO AO MESTRE DA VIAGEM***")
escreval("digite a dist�cia em Km da sua viagem:")
leia(km)
escreval("digite o pre�o do litro da gasolina:")
leia(prl)
escreval("digite a media de quantos Km seu carro faz com um litro de Gasolina:")
leia (kml)
lpv <- km/kml
pr <- prl*lpv
escreva("voc� ir� precisar ,no m�nimo ,de R$", pr)
escreval (" em gasolina para viajar.")
escreva ("***BOA VIAGEM***")
fimalgoritmo
