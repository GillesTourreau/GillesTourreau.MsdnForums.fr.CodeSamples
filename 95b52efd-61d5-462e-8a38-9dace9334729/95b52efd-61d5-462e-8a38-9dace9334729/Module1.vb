Module Module1
    Private Oda As OleDbDataAdapter

    Private Données As DataTable

    Private PointBindingSource As BindingSource

    Private Sub FormMain_Load(ByVal sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim FileName As String = "Sorties.mdb"

        Using Connection As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.4.0;Dat SOurce=" + FileName + ";Persist Security Info=False;")

            Connection.Open()

            Oda=New OleDbDataAdapter("Select * From " & TableName,"Provider=Microsoft.Jet.4.0;Data Source=" & FileName & ";Persist Security Info=False;"

            Dim Dbc As OleDbCommandBuilder = New OleDbCommandBuilder(Oda)

            Dbc.QuotePrefix = "["

            Dbc.QuoteSuffix = "]"

            Données = New DataTable("Données")

            Oda.Fill(Données)

            PointBindingSource = New BindingSource

            PointBindingSource.DataTable = Données
    End Sub

    Sub Main()


        Dim Compteur As Integer = PointBindingSource.Count

        Dim Ligne As String

        For i = 1 To Compteur

            Ligne = txtChoix.Text

            cboChoix.Items.ADD(Ligne)

        Next

    End Sub

End Module
