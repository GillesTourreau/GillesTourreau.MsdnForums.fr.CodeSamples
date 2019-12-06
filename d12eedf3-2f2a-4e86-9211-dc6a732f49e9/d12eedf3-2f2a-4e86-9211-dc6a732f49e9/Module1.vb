Module Module1

    Sub Main()

        Dim tousLesCodesAvalider As String() = {".....", "......", "......"}

        For Each codeAvalider In tousLesCodesAvalider
            If ValiderCode(codeAvalider) = False Then
                MsgBox("Code incorrect")
                Exit Sub
            End If

            Using connection As MySqlConnection = New MySqlConnection("< Chaîne de connexion >")
                Using command As MySqlCommand = New MySqlCommand()
                    command.Connection = connection
                    command.CommandText = "UPDATE MaTableLicences SET Valider = 1 WHERE code = @code"
                    command.Parameters.AddWithValue("@code", codeAvalider)

                    connection.Open()

                    If command.ExecuteNonQuery() = 0 Then
                        MsgBox("Code inexistant")
                    Else
                        MsgBox("Code OK !")
                    End If

                End Using
            End Using
        Next
    End Sub

    Public Function ValiderCode(code As String) As Boolean
        Dim caractèresPossibles As String = "abcdklmetGVISW012345678"

        For Each caractère As Char In code
            If caractèresPossibles.Contains(caractère) = False Then
                Return False
            End If
        Next

        Return True
    End Function

End Module
