Imports System.IO

Module Module1

    Sub Main()
        Dim repMesDocuments As String
        repMesDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        File.Copy("C:\...\MonDoc.doc", repMesDocuments)
    End Sub

End Module
