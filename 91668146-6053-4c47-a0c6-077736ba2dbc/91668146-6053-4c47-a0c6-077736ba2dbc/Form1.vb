Public Class Form1

    Private _ListOfExample As List(Of Example)

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        _ListOfExample = New List(Of Example)
    End Sub

End Class
