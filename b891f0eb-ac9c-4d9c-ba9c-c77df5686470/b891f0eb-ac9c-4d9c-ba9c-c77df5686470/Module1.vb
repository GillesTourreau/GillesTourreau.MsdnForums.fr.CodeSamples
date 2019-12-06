Module Module1

    Sub Main()
        Dim dir As New IO.DirectoryInfo("C:\Program Files\Adobe")
        If dir.Exists Then
            Dim proc As System.Diagnostics.Process = New System.Diagnostics.Process()
            Try
                proc.EnableRaisingEvents = False
                proc.StartInfo.FileName = "test32.exe"
                proc.Start()
            Catch ex As Exception
            End Try
        Else
            dir = New IO.DirectoryInfo("C:\Program Files (x86)\ABC")
            If dir.Exists Then
                Dim proc As System.Diagnostics.Process = New System.Diagnostics.Process()
                Try
                    proc.EnableRaisingEvents = False
                    proc.StartInfo.FileName = "test64.exe"
                    proc.Start()
                Catch ex As Exception
                End Try
            Else
                MsgBox("Message d'erreur", MsgBoxStyle.SystemModal, "Error")
            End If
        End If
    End Sub

End Module
