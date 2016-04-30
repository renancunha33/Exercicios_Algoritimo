algoritmo "gemeos"
var n1, n2, resp, re2:caracter
id1, id2:real
inicio
escreval("voceis são gemeos?[s/n]")
leia(resp)
se resp = "s" entao
   escrevaL ("***GEMEOS***")
senao
   limpatela
   escrevAL ("Digite o seu nome :")
   leia(n1)
   escreval("digite a sua idade:")
   leia(id1)
   escrevAL ("Digite o seu nome :")
   leia(n2)
   escreval("digite a sua idade:")
   leia(id2)
   se id1 < id2 entao
      escreval (n2, " é o mais velho")
   senao
      escreval (n1, " é o mais velho")
   fimse
fimse
escreval("deseja sair?[s/n]")
leia (re2)
se re2 = "s" entao
   ESCrEVA("")
senao
   repita
      limpatela
      escreval("voceis são gemeos?[s/n]")
      leia(resp)
      se resp = "s" entao
         escrevaL ("***gemeos***")
      senao
         escrevAL ("Digite o seu nome :")
         leia(n1)
         escreval("digite a sua idade:")
         leia(id1)
         escrevAL ("Digite o seu nome :")
         leia(n2)
         escreval("digite a sua idade:")
         leia(id2)
         se id1 < id2 entao
            escrevaL (n2, " é o mais velho")
         senao
            escrevaL (n1, " é o mais velho")
         fimse
      fimse
      escreval("deseja sair?[s/n]")
      leia (re2)
   ate re2 = "s"
fimse
fimalgoritmo
