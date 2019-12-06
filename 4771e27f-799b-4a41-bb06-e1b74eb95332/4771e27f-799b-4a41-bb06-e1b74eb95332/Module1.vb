Module Module1

    Sub Main()
        Dim s As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Shell("C:\Windows\System32\cmd.exe /Cc:""" & s & "\OutilMW\Shoot.bat""")
    End Sub

End Module
