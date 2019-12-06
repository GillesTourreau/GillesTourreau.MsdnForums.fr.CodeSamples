Imports System.IO

Module Module1

    Sub Main()
        ' Sauvegarder l'exécutable dans le répertoire temporaire
        File.WriteAllBytes(Path.GetTempPath() + "Test32.exe", My.Resources.Test32)

        ' Executer l'exécutable
        Dim p As Process
        p = Process.Start(Path.GetTempPath() + "Test32.exe")

        ' Et attendre l'exécutable
        p.WaitForExit()

        ' Supprimer l'executable du répertoire temporaire
        File.Delete(Path.GetTempPath() + "Test32.exe")
    End Sub

End Module
