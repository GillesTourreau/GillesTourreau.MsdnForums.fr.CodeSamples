Module Module1

    Sub Main()
        Dim random As Random
        random = New Random()

        Dim prénoms As String() = {"PAUL", "EMILE", "VICTOR", "LUC", "PIERRE", "MARCEL", "FRANCIS", "GILBERT", "JACQUES", "FABRICE"}

        For i = 0 To prénoms.Length - 1
            Permuter(prénoms, i, random.Next(0, prénoms.Length - 1))
        Next

    End Sub

    Sub Permuter(prénoms As String(), i As Integer, j As Integer)
        Dim temp
        temp = prénoms(i)
        prénoms(i) = prénoms(j)
        prénoms(j) = temp
    End Sub

End Module
