Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim labelASupprimer As Label = Nothing

        For Each l In Controls.OfType(Of Label)()
            If l.Text = "3" Then
                labelASupprimer = l
                Exit For
            End If
        Next

        If Not labelASupprimer Is Nothing Then
            Controls.Remove(labelASupprimer)
        Else
            MsgBox("Pas trouvé...")
        End If
    End Sub
End Class
