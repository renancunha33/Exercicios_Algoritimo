Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "jogador 1"
    End Sub

    Private Sub qd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd1.Click
        If Label2.Text = "jogador 1" Then
            qd1.Text = "x"
        Else
            qd1.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd1.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
        Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
        Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
        Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
        Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
        Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
        Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
        Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd9.Click
        If Label2.Text = "jogador 1" Then
            qd9.Text = "x"
        Else
            qd9.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd9.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
 Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
 Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
 Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
 Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
 Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
 Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
 Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd8.Click
        If Label2.Text = "jogador 1" Then
            qd8.Text = "x"
        Else
            qd8.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd8.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd7.Click
        If Label2.Text = "jogador 1" Then
            qd7.Text = "x"
        Else
            qd7.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd7.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd4.Click
        If Label2.Text = "jogador 1" Then
            qd4.Text = "x"
        Else
            qd4.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd4.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd5.Click
        If Label2.Text = "jogador 1" Then
            qd5.Text = "x"
        Else
            qd5.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd5.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd6.Click
        If Label2.Text = "jogador 1" Then
            qd6.Text = "x"
        Else
            qd6.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd6.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd3.Click
        If Label2.Text = "jogador 1" Then
            qd3.Text = "x"
        Else
            qd3.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd3.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If
    End Sub

    Private Sub qd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qd2.Click
        If Label2.Text = "jogador 1" Then
            qd2.Text = "x"
        Else
            qd2.Text = "o"
        End If
        If Label2.Text = "jogador 1" Then
            Label2.Text = "jogador 2"
        Else
            Label2.Text = "jogador 1"
        End If
        qd2.Enabled = False
        If (qd1.Text = "x" And qd2.Text = "x" And qd3.Text = "x") _
Or (qd4.Text = "x" And qd5.Text = "x" And qd6.Text = "x") _
Or (qd7.Text = "x" And qd8.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd4.Text = "x" And qd1.Text = "x") _
Or (qd2.Text = "x" And qd5.Text = "x" And qd8.Text = "x") _
Or (qd3.Text = "x" And qd6.Text = "x" And qd9.Text = "x") _
Or (qd7.Text = "x" And qd5.Text = "x" And qd3.Text = "x") _
Or (qd1.Text = "x" And qd5.Text = "x" And qd9.Text = "x") Then
            MessageBox.Show("JOGADOR 1 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "o" And qd2.Text = "o" And qd3.Text = "o") _
        Or (qd4.Text = "o" And qd5.Text = "o" And qd6.Text = "o") _
        Or (qd7.Text = "o" And qd8.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd4.Text = "o" And qd1.Text = "o") _
        Or (qd2.Text = "o" And qd5.Text = "o" And qd8.Text = "o") _
        Or (qd3.Text = "o" And qd6.Text = "o" And qd9.Text = "o") _
        Or (qd7.Text = "o" And qd5.Text = "o" And qd3.Text = "o") _
        Or (qd1.Text = "o" And qd5.Text = "o" And qd9.Text = "o") Then
            MessageBox.Show("JOGADOR 2 GANHOU!!!")
            novo()
        End If
        If (qd1.Text = "x" Or qd1.Text = "o") And (qd2.Text = "x" Or qd2.Text = "o") And (qd3.Text = "x" Or qd3.Text = "o") And _
        (qd4.Text = "x" Or qd4.Text = "o") And (qd5.Text = "x" Or qd5.Text = "o") And (qd6.Text = "x" Or qd6.Text = "o") And _
        (qd7.Text = "x" Or qd7.Text = "o") And (qd8.Text = "x" Or qd8.Text = "o") And (qd9.Text = "x" Or qd9.Text = "o") Then
            MessageBox.Show("Fim de jogo!")
            novo()
        End If

    End Sub
    Private Sub novo()
        qd1.Text = ""
        qd1.Enabled = True
        qd2.Text = ""
        qd2.Enabled = True
        qd3.Text = ""
        qd3.Enabled = True
        qd4.Text = ""
        qd4.Enabled = True
        qd5.Text = ""
        qd5.Enabled = True
        qd6.Text = ""
        qd6.Enabled = True
        qd7.Text = ""
        qd7.Enabled = True
        qd8.Text = ""
        qd8.Enabled = True
        qd9.Text = ""
        qd9.Enabled = True
        Label2.Text = "jogador 1"
    End Sub

    Private Sub Bt_iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_iniciar.Click
        novo()
    End Sub
End Class
