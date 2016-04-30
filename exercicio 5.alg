algoritmo "Mestre da Viagem"
// Função :
// Autor :
// Data : 15/03/2011
// Seção de Declarações 
var
km, prl, kml, lpv, pr:real
inicio
// Seção de Comandos
escreval("***BEM VINDO AO MESTRE DA VIAGEM***")
escreval("digite a distâcia em Km da sua viagem:")
leia(km)
escreval("digite o preço do litro da gasolina:")
leia(prl)
escreval("digite a media de quantos Km seu carro faz com um litro de Gasolina:")
leia (kml)
lpv <- km/kml
pr <- prl*lpv
escreva("você irá precisar ,no mínimo ,de R$", pr)
escreval (" em gasolina para viajar.")
escreva ("***BOA VIAGEM***")
fimalgoritmo
