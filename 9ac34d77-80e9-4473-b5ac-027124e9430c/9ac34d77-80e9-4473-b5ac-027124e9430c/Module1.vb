Imports System.IO

Module Module1

    Sub Main()

    End Sub

    Public Async Function MonCode() As Task
        Await CopyDirectoryAsync()
        Console.WriteLine("Pendant ce temps... Ca copie...")
    End Function

    Public Function CopyDirectoryAsync() As Task
        Return Task.Run(AddressOf RecursiveCopy)
    End Function

    Private Sub RecursiveCopy()
        ' Copie récursive
    End Sub

End Module
