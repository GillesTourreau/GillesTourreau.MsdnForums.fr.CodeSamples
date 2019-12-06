Public Class Form1

    Private Sub ouvrirForm2_Click(sender As Object, e As EventArgs) Handles ouvrirForm2.Click
        Dim f As Form2
        f = New Form2(Me)
        f.ShowDialog()
    End Sub
End Class
