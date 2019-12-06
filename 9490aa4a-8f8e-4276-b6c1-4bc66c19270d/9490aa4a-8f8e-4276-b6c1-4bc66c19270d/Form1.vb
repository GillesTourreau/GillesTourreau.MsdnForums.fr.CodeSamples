Public Class Form1

    Private img As Bitmap = Image.FromFile("C:\Projets\Forums MSDN\9490aa4a-8f8e-4276-b6c1-4bc66c19270d\9490aa4a-8f8e-4276-b6c1-4bc66c19270d\Sans Titre.png")

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        ' Rendre le blanc transparent
        img.MakeTransparent(Color.White)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.PictureBox1.Image = Nothing
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim pos As Point
        pos = Me.PictureBox1.PointToClient(Cursor.Position)

        Dim c As Color
        c = img.GetPixel(pos.X, pos.Y)
        If c.R = 0 And c.G = 0 And c.B = 0 And c.A = 0 Then
            Me.PictureBox1.Image = Nothing
        Else
            Me.PictureBox1.Image = img
        End If
    End Sub
End Class
