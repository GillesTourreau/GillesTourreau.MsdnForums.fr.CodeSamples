Imports System.Globalization

Module Module1

    Sub Main()
        Dim cultureFrançaise As CultureInfo
        cultureFrançaise = CultureInfo.GetCultureInfo("fr-FR")

        Dim samedi As String
        samedi = cultureFrançaise.DateTimeFormat.GetDayName(DayOfWeek.Saturday)
    End Sub

End Module
