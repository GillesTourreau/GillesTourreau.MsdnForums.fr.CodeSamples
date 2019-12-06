Public Class Form1

    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.WebBrowser1.Url = New Uri("file:///C:/Projets/Forums MSDN/c3a61051-a702-481f-9ea5-08c31b891806/c3a61051-a702-481f-9ea5-08c31b891806/TextFile1.htm")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim monBouton As HtmlElement
        monBouton = Me.GetButtonQueJeRecherche(Me.WebBrowser1.Document.GetElementsByTagName("input"))

        ' Utiliser mon bouton
    End Sub

    Private Function GetButtonQueJeRecherche(elements As HtmlElementCollection) As HtmlElement
        For Each element As HtmlElement In elements
            If element.GetAttribute("value") = "login now" Then
                Return element
            End If
        Next

        Return Nothing
    End Function
End Class
