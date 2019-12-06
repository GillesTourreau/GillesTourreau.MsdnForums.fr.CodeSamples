Imports System.Data.OleDb

Module Module1

    Sub Main()

    End Sub

    Sub AddParcours(parcours As String)
        Using connexion As OleDbConnection = New OleDbConnection()
            connexion.ConnectionString = "< Chaine de connexion >"
            connexion.Open()

            Using commande As OleDbCommand = New OleDbCommand()
                commande.Connection = connexion
                commande.CommandText = "INSERT INTO MaTable (Parcours) VALUES (?)"
                commande.Parameters.AddWithValue("parcours", parcours)

                commande.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
