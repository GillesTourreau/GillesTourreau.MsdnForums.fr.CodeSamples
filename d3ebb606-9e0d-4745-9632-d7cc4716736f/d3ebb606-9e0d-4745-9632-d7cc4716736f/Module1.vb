Imports System.Net.Mail

Module Module1

    Sub Main()

        Dim SMTP As New SmtpClient()
        SMTP.Credentials = New System.Net.NetworkCredential(Me.TextBox2.Text, Me.TextBox2.Text)
        ' Ici, continuer à paramétrer le SmtpClient

        Dim message As MailMessage
        ' Ici paramétrer le message

        Try
            SMTP.Send(message)
            Form2.Show()
        Catch ex As SmtpException
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
