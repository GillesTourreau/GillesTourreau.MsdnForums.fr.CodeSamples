Imports System.ComponentModel

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BindingSource1.DataSource = New Entreprise()
        Me.BindingSource2.DataSource = New BindingList(Of Entreprise)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using context As Database1Entities = New Database1Entities()
            context.Entreprises.AddRange(Me.BindingSource2.DataSource)
            context.SaveChanges()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BindingSource2.DataSource.Add(Me.BindingSource1.DataSource)
        Me.BindingSource1.DataSource = New Entreprise()
    End Sub
End Class
