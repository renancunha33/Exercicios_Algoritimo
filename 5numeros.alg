algoritmo "semnome"
var
n1, n2, n3, n4, n5:real
r:caracter
inicio
escreval ("digite 5 números:")
leia(n1)
leia(n2)
leia(n3)
leia(n4)
leia(n5)
se (n1+n5)/(n2+n3+n4) >= 100 entao
   escreval((n1+n5)/(n2+n3+n4))
senao
   escreval("número menor que 100")
fimse
escreva ("deseja sair?[s/n]")
leia (r)
se r = "n" entao
   repita
      limpatela
      escreval ("digite 5 números:")
      leia(n1)
      leia(n2)
      leia(n3)
      leia(n4)
      leia(n5)
      se (n1+n5)/(n2+n3+n4) >=100 entao
         escreval((n1+n5)/(n2+n3+n4))
      fimse
      escreva ("deseja sair?[s/n]")
      leia (r)
   ate r = "s"
fimse
fimalgoritmo
