Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center

        RichTextBox1.SelectedText = "this is a test"
    End Sub
End Class
