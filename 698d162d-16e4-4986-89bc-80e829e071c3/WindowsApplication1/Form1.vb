Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TextBox1.Text = "Truc"
        Me.TextBox2.Text = "Toto"

        Me.TextBox1.SelectAll()
        Me.TextBox2.SelectAll()
    End Sub
End Class
