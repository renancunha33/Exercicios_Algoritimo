Public Class Form1
    Dim vlinicio, vlfim, x As Integer
    Dim vlpl As Double
    Private Sub Btconvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btconvert.Click
        ListMedidas.Items.Clear()
        If (vlfim > vlinicio) Then
            For x = vlinicio To vlfim
                vlpl = x * 2.54
                ListMedidas.Items.Add(x.ToString + " cm = " + vlpl.ToString + " pol.")
            Next
        Else
            MsgBox("ErrOr Object detected!!! ")
            Numinicio.Value = 0
            Numfim.Value = 0
        End If
    End Sub

    Private Sub Numinicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Numinicio.ValueChanged
        vlinicio = Numinicio.Value
    End Sub

    Private Sub Numfim_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Numfim.ValueChanged
        vlfim = Numfim.Value
    End Sub
End Class
