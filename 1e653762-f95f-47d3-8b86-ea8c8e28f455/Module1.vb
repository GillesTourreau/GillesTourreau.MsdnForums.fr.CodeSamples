Imports System.Data.SqlClient

Module Module1

    Sub Main()
        Using connexion As SqlConnection = New SqlConnection("< Chaine de connexion >")
            Using commande As SqlCommand = New SqlCommand()
                commande.Connection = connexion
                commande.CommandText = "select * from entreprises where Redevance between '0 and '99000'"

                connexion.Open()

                monLabel.Text = Convert.ToString(commande.ExecuteScalar())
            End Using
        End Using
    End Sub

End Module
