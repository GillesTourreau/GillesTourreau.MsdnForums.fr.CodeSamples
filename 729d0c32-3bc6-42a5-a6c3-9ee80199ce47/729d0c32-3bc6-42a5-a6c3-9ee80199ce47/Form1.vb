Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As Form2
        f = New Form2()
        f.ShowDialog()

        MsgBox(f.TextBox1.Text)
    End Sub
End Class
