Module Module1

    Sub Main()

    End Sub

End Module

Public Class Etudiant
    Private codeEtudiant As String
    Private nomEtudiant As String
    Private matière As Matière

    ''' <summary>
    ''' Le constructeur par défaut
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        codeEtudiant = ""
        nomEtudiant = ""
    End Sub

    Public Sub New(ByVal pcodeEtudiant As String, ByVal pnomEtudiant As String, ByVal pcodeMatière As Matière)
        codeEtudiant = pcodeEtudiant
        nomEtudiant = pnomEtudiant
        matière = pcodeMatière
    End Sub
End Class

Public Class Matière
    Private codeMatière As String

    Public Sub New(ByVal pcodeMatière As String)
        codeMatière = pcodeMatière
    End Sub
End Class

