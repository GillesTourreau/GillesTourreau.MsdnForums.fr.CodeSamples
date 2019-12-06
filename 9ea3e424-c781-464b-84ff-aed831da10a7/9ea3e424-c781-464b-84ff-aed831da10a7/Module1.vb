Imports System.Data.SqlClient

Module Module1

    Sub Main()
        Using connection As SqlConnection = New SqlConnection("< chaine de connexion >")
            Using cmd As SqlCommand = New SqlCommand()
                cmd.CommandText = "INSERT INTO MaTable (Colonne1, Colonne2) VALUES (@valeur1, @valeur2)"
                cmd.Parameters.AddWithValue("valeur1", "MaValeur")
                cmd.Parameters.AddWithValue("valeur1", 1664)
                cmd.Connection = connection

                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        Using connection As SqlConnection = New SqlConnection("< chaine de connexion >")
            Using cmd As SqlCommand = New SqlCommand()
                cmd.CommandText = "DELETE FROM MaTable WHERE Id = @id"
                cmd.Parameters.AddWithValue("id", 1664)
                cmd.Connection = connection

                connection.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Module
