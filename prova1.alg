algoritmo "semnome"
var
relogio, relogio2:real
ltr:real
conta:real
x:caractere
inicio
x:="x"
enquanto x<>"s" faca
   limpatela
   escreval("digite o valor marcado pelo seu relogio de �gua no mes passado :(em m�)")
   leia(relogio)
   escreval("digite o valor marcado pelo seu relogio de �gua no mes atual :(em m�)")
   leia(relogio2)
   ltr:=relogio2- relogio
   se (ltr<=10) entao
      conta:=34*ltr*2
   fimse
   se (ltr>=11) e (ltr<=30) entao
      conta:=ltr*2*2,5*34
   fimse
   se(ltr>=11) e (ltr>30) entao
      conta:=ltr*2*3,5*34
   fimse
   ESCREVAl("sua conta �: R$", conta)
   escreval("deseja sair?(s/n)")
   leia(x)
fimenquanto
fimalgoritmo
