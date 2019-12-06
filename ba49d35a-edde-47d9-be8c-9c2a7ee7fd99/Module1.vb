Imports System.IO

Module Module1

    Sub Main()
        Dim test1 As String
        Dim test2 As String
        Dim filePath As String
        test2 = "et moi non plus"
        test1 = "je ne peut pas repondre de tes acte"
        filePath = System.IO.Path.Combine(
                   My.Computer.FileSystem.SpecialDirectories.MyDocuments, "test.txt")

        Using writer As StreamWriter = New StreamWriter(filePath)
            writer.WriteLine(test1)
            writer.WriteLine(test2)
        End Using
    End Sub

End Module
