algoritmo "semnome"
var
pess, tipo, dec, voto, nulo:inteiro
alu, func,prof:inteiro
c1, c2, c3, c4, c5:inteiro
vez, vez2:inteiro
inicio
escreval("digite o númer de eleitores")
leia (pess)
repita
voto:=0
   escreval("digite 1-aluno 2-funcionario ou 3-professor")
   leia(tipo)
   escolha (tipo)
   caso (1)
      voto:=1
      alu:=alu+1
   caso(2)
      voto:=1
      func:=func+1
   caso(3)
      voto:=3
       prof:=prof+1
   outrocaso
      nulo:=1
   fimescolha
   vez:=0
  enquanto vez<3 faca
      escreval("digite o numero de seu candidato:(de 1 a 5.outro valor=nulo/pular)")
      leia (dec)
      escolha (dec)
      caso (1)
         c1:=voto+c1
      caso (2)
         c2:=voto+c2
      caso (3)
         c3:=voto+c3
      caso (4)
         c4:=voto+c4
      caso (5)
         c5:=voto+c5
      outrocaso
         nulo:=voto+nulo
      fimescolha
      vez:= vez+1
  fimenquanto
   vez2:= vez2+1
   limpatela
ate  vez2 = pess
escreval("resultado geral em pontos")
escreval("")
escreval("candidato 1:", c1)
escreval("candidato 2:", c2)
escreval("candidato 3:", c3)
escreval("candidato 4:", c4)
escreval("candidato 5:", c5)
escreval("nulo:", nulo)
escreval("")
escreval("votos por pessoas")
escreval("")
escreval("alunos:", alu)
escreval("funcionários:", func)
escreval("professores:", prof)
fimalgoritmo
