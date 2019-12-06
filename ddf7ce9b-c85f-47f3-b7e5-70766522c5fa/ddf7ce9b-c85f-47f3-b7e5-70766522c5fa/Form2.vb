Public Class Form2

    Private _form2 As Form1

    Sub New(form2 As Form1)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me._form2 = form2
    End Sub

    Private Sub annuler_Click(sender As Object, e As EventArgs) Handles annuler.Click
        Me._form2.Close()
    End Sub
End Class