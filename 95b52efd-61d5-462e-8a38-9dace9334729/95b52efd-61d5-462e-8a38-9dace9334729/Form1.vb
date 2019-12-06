Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BindingSource1(0).ToString()

        Dim Données As DataTable

        For i = 1 To Données.Rows.Count
            cboChoix.Items.ADD(Données.Rows(i)("Colonne"))
        Next
    End Sub
End Class