Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.AutoScrollPosition = New Point(PictureBox1.Width / 2, PictureBox1.Height / 2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Panel1.AutoScrollPosition = New Point(Bureau_Pcb.Width / 2, Bureau_Pcb.Height / 2)
    End Sub
End Class
