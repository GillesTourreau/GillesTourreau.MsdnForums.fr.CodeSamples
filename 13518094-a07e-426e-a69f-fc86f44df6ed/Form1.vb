Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fille As Form1
        fille = New Form1()
        fille.MdiParent = Me
        fille.Show()
    End Sub
End Class
