Public Class Form1
    Dim temp As Double
    Private Sub Bt_sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_sair.Click
        End
    End Sub

    Private Sub Bt_calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_calcular.Click
        If TextBox1.Text = "" Then
            MsgBox("Insira um valor!!!")
        Else
            temp = Val(TextBox1.Text)
            If cf.Checked = True Then
                temp = 32 + (9 / 5 * temp)
            End If
            If fc.Checked = True Then
                temp = 5 / 9 * (temp - 32)
            End If
            If ck.Checked = True Then
                temp = temp + 273.15
            End If
            If kc.Checked = True Then
                temp = temp - 273.15
            End If
            MsgBox(temp.ToString + "° ")
        End If
    End Sub
End Class
