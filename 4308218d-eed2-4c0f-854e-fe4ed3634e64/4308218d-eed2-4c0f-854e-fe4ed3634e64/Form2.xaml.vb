Public Class Form2
    Public Sub Action()
        Dim Mafenetre As New Form1

        ' Exemple pour mettre une valeur à ma_variable de l'instance MaFenetre
        Mafenetre.ma_variable = "La valeur à mettre dans la variable ma_variable de l'instance MaFenetre"

        ' Exemple pour récupérer la variable ma_variable de l'instance MaFenetre
        Dim valeur As String
        valeur = Mafenetre.ma_variable
    End Sub
End Class
