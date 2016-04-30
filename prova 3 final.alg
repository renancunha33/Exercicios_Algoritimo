algoritmo "semnome"
var
pess, tipo, dec, voto:inteiro
alu, func,prof:inteiro
c1, c2, c3, c4, c5, nulo:vetor [1..3] de inteiro
vez, vez2:inteiro
cont:inteiro
inicio
escreval("digite o númer de eleitores")
leia (pess)
escreval("votos de alunos e funcionários=1 ponto, professores = 3 pontos")
enquanto vez2<pess faca
   voto:=0
   vez:=0
   escreval("digite 1-aluno 2-funcionario ou 3-professor")
   leia(tipo)
   escolha tipo
   caso (1)
      voto:=1
      alu:=alu+1
      cont:=1
      enquanto vez<3 faca
         escreval("digite o numero de seu candidato:(de 1 a 5.outro valor=nulo/pulo)")
         leia (dec)
         escolha (dec)
         caso (1)
            c1[cont]:=voto+c1[cont]
         caso (2)
            c2[cont]:=voto+c2[cont]
         caso (3)
            c3[cont]:=voto+c3[cont]
         caso (4)
            c4[cont]:=voto+c4[cont]
         caso (5)
            c5[cont]:=voto+c5[cont]
         outrocaso
            nulo[cont]:=voto+nulo[cont]
         fimescolha
         vez:= vez+1
      fimenquanto
      limpatela
   caso(2)
      voto:=1
      func:=func+1
      cont:=2
      enquanto vez<3 faca
         escreval("digite o numero de seu candidato:(de 1 a 5.outro valor=nulo/pulo)")
         leia (dec)
         escolha (dec)
         caso (1)
            c1[cont]:=voto+c1[cont]
         caso (2)
            c2[cont]:=voto+c2[cont]
         caso (3)
            c3[cont]:=voto+c3[cont]
         caso (4)
            c4[cont]:=voto+c4[cont]
         caso (5)
            c5[cont]:=voto+c5[cont]
         outrocaso
            nulo[cont]:=voto+nulo[cont]
         fimescolha
         vez:= vez+1
      fimenquanto
      limpatela
   caso(3)
      voto:=3
      prof:=prof+1
      cont:=3
      enquanto vez<3 faca
         escreval("digite o numero de seu candidato:(de 1 a 5.outro valor=nulo/pulo)")
         leia (dec)
         escolha (dec)
         caso (1)
            c1[cont]:=voto+c1[cont]
         caso (2)
            c2[cont]:=voto+c2[cont]
         caso (3)
            c3[cont]:=voto+c3[cont]
         caso (4)
            c4[cont]:=voto+c4[cont]
         caso (5)
            c5[cont]:=voto+c5[cont]
         outrocaso
            nulo[cont]:=voto+nulo[cont]
         fimescolha
         vez:= vez+1
      fimenquanto
      limpatela
   fimescolha
   vez2:= vez2+1
fimenquanto
limpatela
escreval("resultado geral em pontos")
escreval("____________________________________________________________________________________________")
escreval("alunos            Funcionarios      Professores")
escreval("candidato 1:", c1[1], "   ", "candidato 1:", c1[2], "   ", "candidato 1:", c1[3])
escreval("candidato 2:", c2[1], "   ", "candidato 2:", c2[2], "   ", "candidato 2:", c2[3])
escreval("candidato 3:", c3[1], "   ", "candidato 3:", c3[2], "   ", "candidato 3:", c3[3])
escreval("candidato 4:", c4[1], "   ", "candidato 4:", c4[2], "   ", "candidato 4:", c4[3])
escreval("candidato 5:", c5[1], "   ", "candidato 5:", c5[2], "   ", "candidato 5:", c5[3])
escreval("nulo:", nulo[1], "          ", "nulo:", nulo[2], "          ", "nulo:", nulo[3])
escreval("")
escreval("____________________________________________________________________________________________")
escreval("total")
escreval("candidato 1:", c1[3]+c1[2]+c1[1])
escreval("candidato 2:", c2[3]+c2[2]+c2[1])
escreval("candidato 3:", c3[3]+c3[2]+c3[1])
escreval("candidato 4:", c4[3]+c4[2]+c4[1])
escreval("candidato 5:", c5[3]+c5[2]+c5[1])
escreval("nulo:", nulo[3]+nulo[2]+nulo[1])
escreval("____________________________________________________________________________________________")
escreval("votos por pessoas")
escreval("")
escreval("alunos:", alu)
escreval("funcionários:", func)
escreval("professores:", prof)
fimalgoritmo
