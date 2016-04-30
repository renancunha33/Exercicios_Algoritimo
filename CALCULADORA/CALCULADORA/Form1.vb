Public Class Form1
    Dim n, n1 As Integer
    Dim resultado As Double
    Dim cont As Char

    Private Sub bt0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt0.Click
        Txt1.Text = Txt1.Text + "0"
    End Sub

    Private Sub Bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt1.Click
        Txt1.Text = Txt1.Text + "1"
    End Sub

    Private Sub Bt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt2.Click
        Txt1.Text = Txt1.Text + "2"
    End Sub

    Private Sub Bt3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt3.Click
        Txt1.Text = Txt1.Text + "3"
    End Sub

    Private Sub Bt4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt4.Click
        Txt1.Text = Txt1.Text + "4"
    End Sub

    Private Sub Bt5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt5.Click
        Txt1.Text = Txt1.Text + "5"
    End Sub

    Private Sub Bt6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt6.Click
        Txt1.Text = Txt1.Text + "6"
    End Sub

    Private Sub Bt7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt7.Click
        Txt1.Text = Txt1.Text + "7"
    End Sub

    Private Sub Bt8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt8.Click
        Txt1.Text = Txt1.Text + "8"
    End Sub

    Private Sub Bt9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt9.Click
        Txt1.Text = Txt1.Text + "9"
    End Sub

    Private Sub BtC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtC.Click
        Txt1.Text = " "
        n = 0
        n1 = 0
        cont = " "
    End Sub

    Private Sub Bmais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bmais.Click
        n = Val(Txt1.Text)
        Txt1.Text = " "
        cont = "a"
    End Sub

    Private Sub Btmenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btmenos.Click
        n = Val(Txt1.Text)
        Txt1.Text = " "
        cont = "b"
    End Sub

    Private Sub Btvezes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btvezes.Click
        n = Val(Txt1.Text)
        Txt1.Text = " "
        cont = "c"
    End Sub

    Private Sub Btdiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btdiv.Click
        n = Val(Txt1.Text)
        Txt1.Text = " "
        cont = "d"
    End Sub

    Private Sub Btequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btequal.Click
        If cont = "a" Then
            n1 = Val(Txt1.Text)
            resultado = n + n1
            Txt1.Text = " "
            Txt1.Text = (resultado.ToString)
        Else
            If cont = "b" Then
                n1 = Val(Txt1.Text)
                resultado = n - n1
                Txt1.Text = " "
                Txt1.Text = (resultado.ToString)
            Else
                If cont = "c" Then
                    n1 = Val(Txt1.Text)
                    resultado = n * n1
                    Txt1.Text = " "
                    Txt1.Text = (resultado.ToString)
                Else
                    If cont = "d" Then
                        n1 = Val(Txt1.Text)
                        resultado = n / n1
                        Txt1.Text = " "
                        Txt1.Text = (resultado.ToString)
                    End If
                End If
            End If
        End If
    End Sub
End Class
