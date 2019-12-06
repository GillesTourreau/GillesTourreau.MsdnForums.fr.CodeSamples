Imports System.IO

Module Module1

    Sub Main()
        CopierDossier(New DirectoryInfo("C:\Temp\ConsoleApplication3\"), New DirectoryInfo("C:\Temp\Gilllllou4\"))
    End Sub

    Sub CopierDossier(source As DirectoryInfo, destination As DirectoryInfo)
        destination.Create()

        ' Copier tous les fichiers du répertoire
        For Each fichier In source.GetFiles()
            If (fichier.Attributes And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint Then
                ' Ignorer le fichier
                Continue For
            Else
                ' Copier le fichier
                fichier.CopyTo(destination.FullName + fichier.Name)
            End If
        Next

        ' Copier récursivement les fichiers du répertoire
        For Each répertoire In source.GetDirectories()
            CopierDossier(répertoire, New DirectoryInfo(destination.FullName + répertoire.Name + "\"))
        Next
    End Sub

End Module
