Imports System.Drawing

Public Class Form1

    Private numéroQuestion As Integer
    Private random As Random = New Random()

    Private nbTentatives As Integer

    Private questions As String() =
          {
       "Quelle est la capitale de la France ?",
       "Quelle est la couleur du cheval blanc d'Henri IV?",
       "Qui a peint la Joconde?",
       "Quelle est l'espérance de vie du lapin domestique ?",
       "À partir de combien de km/h peut-on entendre un <<Bang>> ?",
       "En quelle année la marque <<Skoda>> a-t-elle été créée?",
       "Sur les 2 mains, combien a-t-on de phalanges ?",
       "Les célèbres Beatles étaient...?",
       "Qui a écrit <<l'Avare>> ?",
       "Alea jacta est signifie ?",
       "Combien de temps Nicolas Sarkozy est-il resté président de la République française ?",
       "Qu`est ce qu`un gecko?",
       "Qui a tiré la fleche fatale dans le talon d'Achille?",
       "Quel est le dieu supreme du pantheon égyptien?",
       "Quels sont les deux départements qui forment la Corse?",
       "Qu`est ce qu`un chèche?",
       "Dans quel lac le Nil prend-il sa source?",
       "Combien une araignée a-t-elle de pattes",
       "Combien de lettres possède l`alphabet grec?",
       "Dans quelle ville se trouve le Golden Gate Bridge?",
       "Christophe Colomb a découvert l'Amérique en ...",
       "Où se trouve le Massif Armoricain ?",
       "ANUBIS, gardien des nécropoles est un dieu?",
       "L'intensité électrique s'exprime en ?",
       "Le TCHAD a une frontière commune avec quelle pays?",
       "Quels sont les pays frontaliers à la France",
       "Dans la superstition maritime, quel nom d'animal est tabou à bord d'un bateau?"
           }

    Private réponses As String() =
        {
       "Paris",
       "Blanc",
       "Léonard De Vinci",
       "7 ans",
       "1000",
       "1919",
       "28",
       "Anglais",
       "Molière",
       "Le sort en est jeté",
       "5 ans",
       "Un lezard ",
       "Paris",
       "Amon",
       "Haute Corse et Corse du Sud",
       "Une écharpe",
       "Victoria",
       "8",
       "24",
       "San Francisco ",
       "1492",
       "En Bretagne",
       "Egyptien",
       "Ampères",
       "Le soudan",
       "9",
       "Le Lapin"
     }
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitialiserNouvelleQuestion()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Verification()
    End Sub
    Sub Verification()

        If TextBox1.Text = Me.réponses(Me.numéroQuestion) Then
            Label2.Visible = True
            Label2.ForeColor = Color.Green
            Label2.Text = "OK"
            Timer1.Start()
            Timer1.Interval = 1500

        Else
            Label2.Visible = True
            Label2.ForeColor = Color.Red
            Label2.Text = " Réponse Incorrecte"
            MsgBox("Votre réponse est fausse, Veuillez réessayer", vbOKOnly, "test")
            TextBox1.Focus()
            TextBox1.Clear()
            Label2.Visible = False
            Me.nbTentatives = Me.nbTentatives + 1

            If Me.nbTentatives = 3 Then
                MsgBox("Zetes vraiment N-U-L !!")

                Timer1.Start()
                Timer1.Interval = 1500
            End If
        End If

    End Sub

    Private Sub InitialiserNouvelleQuestion()
        Me.numéroQuestion = random.Next(0, questions.Length - 1)
        Label1.Text = Me.questions(Me.numéroQuestion)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Verification()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        TextBox1.Clear()
        Label2.Visible = False
        InitialiserNouvelleQuestion()
    End Sub

End Class