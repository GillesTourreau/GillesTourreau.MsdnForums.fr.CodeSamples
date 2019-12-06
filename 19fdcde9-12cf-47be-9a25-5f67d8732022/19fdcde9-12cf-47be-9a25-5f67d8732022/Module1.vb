Module Module1

    Sub Main()
        Dim m As MaClass
        m = New MaClass()
        AddHandler m.Activated, AddressOf MaClasse_Activated
        m.Activate(10)
    End Sub
    Private Sub MaClasse_Activated(ByVal Index As Integer)
        'Développement des actions'
    End Sub
End Module

Class MaClass
    Public Event Activated(ByVal Index As Integer)

    Public Function Activate(ByVal Index As Integer) As Integer
        'Développement de ma fonction avec mon return'
        RaiseEvent Activated(Index)
        Return 0
    End Function
End Class
