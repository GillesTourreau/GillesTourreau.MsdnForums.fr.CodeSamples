Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Récupérer les noms des images d'un répertoire
        Dim fichiers As String()
        fichiers = Directory.GetFiles("C:\.....\")

        ' Tirer un nombre compris entre 0 et fichiers.Length - 1
        Dim random As Random
        random = New Random()

        Dim numéro As Integer
        numéro = random.Next(0, fichiers.Length)

        ' Afficher l'image fichiers(indice)
    End Sub
End Class
