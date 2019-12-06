Imports System.Data.SqlClient

Module Module1

    Sub Main()

        Dim dt As DataTable
        dt = New DataTable()

        Using adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Utilisateur WHERE ...", "< Chaine de connexion >")
            adapter.Fill(dt)
        End Using

        Dim nom As String = dt(0)("Nom")
        Dim prenom As String = dt(0)("Prénom")
    End Sub

End Module
