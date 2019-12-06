Imports System.IO

Module Module1

    Sub Main()
        Console.WriteLine(FichierExiste("C:\", "Hosts.txt"))
        Console.WriteLine(FichierExiste("C:\", "ExistePas.txt"))
    End Sub

    Function FichierExiste(rep As String, fichierARchercher As String) As Boolean

        ' Regarder tous les fichiers dans le répertoire si le fichier a rechercher n'existe pas
        Try
            For Each fichier In Directory.GetFiles(rep)
                If Path.GetFileName(fichier) = fichierARchercher Then
                    Return True
                End If
            Next
        Catch ex As UnauthorizedAccessException
            ' Si on n'a pas le droit d'accéder aux fichiers du répertoire... Et bien ce que l'on pas le droit !
        End Try

        ' Regarder ensuite récursivement dans les sous répertoires
        Try
            For Each sousRepertoire In Directory.GetDirectories(rep)
                If FichierExiste(sousRepertoire, fichierARchercher) = True Then
                    Return True
                End If
            Next
        Catch ex As UnauthorizedAccessException
            ' Si on n'a pas le droit d'accéder aux sous-répertoires... Et bien ce que l'on pas le droit !
        End Try

        Return False

    End Function

End Module
