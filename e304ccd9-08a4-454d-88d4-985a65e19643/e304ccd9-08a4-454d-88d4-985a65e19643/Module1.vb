Imports System.Data.SqlClient
Imports System.Windows.Forms

Module Module1

    Sub Main()

        Dim DataGridView1 As DataGridView

        Using connexion As SqlConnection = New SqlConnection("< Chaîne de connexion à la base de données >")

            connexion.Open()

            For i = 0 To DataGridView1.Rows.Count

                Using cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = connexion
                    cmd.CommandText = "INSERT INTO MaTable (dénomination, Adresse, Tel, numéro, Désignation, Quantité) VALUES (@dénomination, @adresse, @tel, @numéro, @désignation, @quantité)"
                    cmd.Parameters.AddWithValue("@dénomination", Combobox1.Text)
                    cmd.Parameters.AddWithValue("@adresse", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@tel", textBox2.Text)
                    cmd.Parameters.AddWithValue("@numéro", DataGridView1.Rows(0).Cells(0).Value)
                    cmd.Parameters.AddWithValue("@désignation", DataGridView1.Rows(0).Cells(1).Value)
                    cmd.Parameters.AddWithValue("@quantité", DataGridView1.Rows(0).Cells(2).Value)

                    cmd.ExecuteNonQuery()
                End Using
            Next
        End Using

    End Sub

End Module
