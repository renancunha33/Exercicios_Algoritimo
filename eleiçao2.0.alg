algoritmo "eleição"
var
c1, c2, c3, c4, br, voto, eleitor, nul, decisao:inteiro
inicio
c1:=0
c2:=0
c3:=0
c4:=0
br:=0
nul:=0
voto:=0
Escreva("antes de iniciar.digite o número de eleitores: ")
leia (eleitor)
se eleitor=0 entao
   escreva ("erro!!! reinicie o program com um número válido")
senao
   repita
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval(               "***bemvindo a eleição***")
      escreval("                                                   ")
      escreval("digite 1 para candidato 1")
      escreval("digite 2 para candidato 2")
      escreval("digite 3 para candidato 3")
      escreval("digite 4 para candidato 4")
      escreval("digite 5 para branco")
      ESCREVA("DIGITE SEU VOTO: ")
      leia (decisao)
      voto:= voto+1
      escolha decisao
      caso (1)
         c1:=c1+1
         ESCREVA("***VOTO COMPUTADO***")
      caso (2)
         c2:=c2+1
         ESCREVA("***VOTO COMPUTADO***")
      caso (3)
         c3:=c3+1
         ESCREVA("***VOTO COMPUTADO***")
      caso (4)
         c4:=c4+1
         ESCREVA("***VOTO COMPUTADO***")
      caso (5)
         br:=br+1
         ESCREVA("***VOTO COMPUTADO***")
      outrocaso
         nul:=nul+1
         Escreva("***VOTO COMPUTADO COMO NULO***")
      fimescolha
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
      escreval("")
   ate voto >= eleitor
   escreval (                     "***RESULTADO***")
   escreval("                                                  ")
   Escreval("total de votos:..... ", voto)
   EscrevaL("candidato 1:........ ", c1)
   EscrevaL("candidato 2:........ ", c2)
   EscrevaL("candidato 3:........ ", c3)
   EscrevaL("candidato 4:........ ", c4)
   EscrevaL("BRANCOS:,........... ", br*100/voto, "%")
   EscrevaL("NULOS:.............. ", nul*100/voto, "%")
   escreval("")
   escreval("")
   escreval("")
   escreval("")
   escreval("")
   escreval("")
   escreval("")
fimse
fimalgoritmo
