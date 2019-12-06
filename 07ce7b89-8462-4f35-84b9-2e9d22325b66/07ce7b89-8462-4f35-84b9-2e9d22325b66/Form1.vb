Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView1.VirtualListSize = 100000
    End Sub

    Private Sub ListView1_RetrieveVirtualItem(sender As Object, e As RetrieveVirtualItemEventArgs) Handles ListView1.RetrieveVirtualItem

    End Sub

    Private Sub ChargementListeSitesInterdits()
        For Each lLigne As String In File.ReadAllLines("C:\Users\" & System.Environment.UserName & "\Documents\ListeDeSiteCaracteresSexuels.txt")
            ListeDeSiteCaracteresSexuels.Add(lLigne)
        Next

        ListView1.VirtualListSize = ListeDeSiteCaracteresSexuels.Count
    End Sub

    Private Sub ListView1_RetrieveVirtualItem(sender As Object, e As RetrieveVirtualItemEventArgs) Handles ListView1.RetrieveVirtualItem
        Dim it As New ListViewItem(ListeDeSiteCaracteresSexuels(e.ItemIndex))
        e.Item = it
    End Sub
End Class
