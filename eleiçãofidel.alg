algoritmo "semnome"
Var
candidato1 , candidato2 , candidato3 , candidato4 , brancos , nulos , voto , eleitores , contador : inteiro
pctnulos , pctbrancos : real
inicio
candidato1 := candidato2 := candidato3 := candidato4 := brancos := nulos := voto := eleitores := contador := 0
escreval("-----------------------------------------------------")
escreval(" > Eleição Presidencial <")
escreval("-----------------------------------------------------")
escreval("-----------------------------------------------------")
escreval(" > Quantidade de Eleitores <")
escreval("-----------------------------------------------------")
escreva("Digite a quantide total de eleitores: ")
leia(eleitores)
limpatela
repita
   voto:=0
   escreval("-----------------------------------------------------")
   escreval("1 :...Para o Candidato 1.")
   escreval("2 :...Para o Candidato 2.")
   escreval("3 :...Para o Candidato 3.")
   escreval("4 :...Para o Candidato 4.")
   escreval("5 :...Para Votos Nulos.")
   escreval("6 :...Para Votos em Branco.")
   escreval("-----------------------------------------------------")
   leia(voto)
   escolha(voto)
   caso (1)
      candidato1:= candidato1 + 1
   caso (2)
      candidato2:= candidato2 + 1
   caso (3)
      candidato3:= candidato3 + 1
   caso (4)
      candidato4:= candidato4 + 1
   caso (5)
      brancos:= brancos + 1
   caso (6)
      nulos:= nulos + 1

   fimescolha
   contador := contador + 1
   limpatela
ate (contador >= eleitores)
pctbrancos:= (eleitores/100)*brancos
pctbrancos:= (eleitores/100)*brancos
escreval("Total de votos para o Candidato 1: ",candidato1)
escreval("Total de votos para o Candidato 2: ",candidato2)
escreval("Total de votos para o Candidato 3: ",candidato3)
escreval("Total de votos para o Candidato 4: ",candidato4)
escreval("Total de votos Brancos: ",brancos)
escreval("Total de votos Nulos: ",nulos)
escreval(eleitores/100*brancos,"% de Votos Brancos.")
escreval(eleitores/100*nulos,"% de Votos Nulos.")

fimalgoritmo
