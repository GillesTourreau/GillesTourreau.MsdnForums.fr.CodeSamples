Module Module1

    Sub Main()

        Dim oldname As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "Test\123"
        Dim newName As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "Test\456"

        If Directory.Exists(oldname) And Not Directory.Exists(newName) Then
            Directory.Move(oldname, newName)
            MsgBox("Ficher renommer avec sucée", MsgBoxStyle.SystemModal, "Message")
        Else
            MsgBox("Ficher déjà renommer", MsgBoxStyle.SystemModal, "Message")
        End If
    End Sub

End Module
