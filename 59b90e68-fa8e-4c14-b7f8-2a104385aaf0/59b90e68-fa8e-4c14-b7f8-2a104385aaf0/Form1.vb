Public Class Form1
    Private customFont As Font = New Drawing.Font("Lucida Console", 12, FontStyle.Regular)
    Private customColor As Color = Color.Black
    Private startingLocation As New Point(10, 50)
    Private Const SPACING As Integer = 30

    Private letters() As Label

    Public Sub ParseString(ByVal str As String)
        ReDim letters(str.ToCharArray.Length - 1)
        For i = 1 To str.ToCharArray.Length - 1
            letters(i) = New Label()
            letters(i).AutoSize = True
            letters(i).Font = customFont
            letters(i).ForeColor = customColor
            letters(i).BackColor = Me.BackColor
            letters(i).Text = str.ToCharArray(i, 1)
            letters(i).Location = New Point(startingLocation.X + i * SPACING, startingLocation.Y)
            Me.Controls.Add(letters(i))
        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ParseString("Toioio")
    End Sub
End Class
