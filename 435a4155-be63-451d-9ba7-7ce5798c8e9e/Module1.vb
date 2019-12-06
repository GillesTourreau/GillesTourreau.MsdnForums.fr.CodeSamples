Imports Microsoft.Office.Interop.Outlook

Module Module1

    Sub Main()
        Dim app As Application = New Application()
        Dim mail As Microsoft.Office.Interop.Outlook.MailItem
        mail = app.CreateItem(OlItemType.olMailItem)
        mail.To = "expediteur@email.com"
        mail.Subject = "Sujet"
        mail.Body = "Body"

        Dim accounts As Accounts = app.Session.Accounts
        For Each account As Account In accounts
            If account.SmtpAddress = "mon@email.com" Then
                mail.SendUsingAccount = account
                mail.Send()
                Return
            End If
        Next

    End Sub

End Module
