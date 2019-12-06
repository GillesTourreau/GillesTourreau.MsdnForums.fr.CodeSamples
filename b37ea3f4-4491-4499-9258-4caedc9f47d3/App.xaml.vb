' Pour plus d'informations sur le modèle Application vide, consultez la page http://go.microsoft.com/fwlink/?LinkID=391641

''' <summary>
''' Fournit un comportement spécifique à l'application afin de compléter la classe Application par défaut.
''' </summary>
NotInheritable Class App
    Inherits Application

    Private _transitions As TransitionCollection

    ''' <summary>
    ''' Initialise l'objet d'application de singleton. Il s'agit de la première ligne du code créé
    ''' à être exécutée. Elle correspond donc à l'équivalent logique de main() ou WinMain().
    ''' </summary>
    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Appelé lorsque l'application est lancée normalement par l'utilisateur final. Les autres points d'entrée
    ''' sont utilisés lorsque l'application est lancée pour ouvrir un fichier spécifique, pour afficher
    ''' des résultats de recherche, etc.
    ''' </summary>
    ''' <param name="e">Détails concernant la requête et le processus de lancement.</param>
    Protected Overrides Sub OnLaunched(e As LaunchActivatedEventArgs)
#If DEBUG Then
        If System.Diagnostics.Debugger.IsAttached Then
            DebugSettings.EnableFrameRateCounter = True
        End If
#End If

        Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)

        ' Ne répétez pas l'initialisation de l'application lorsque la fenêtre comporte déjà du contenu,
        ' assurez-vous juste que la fenêtre est active
        If rootFrame Is Nothing Then
            ' Créez un Frame utilisable comme contexte de navigation et naviguez jusqu'à la première page
            rootFrame = New Frame()

            ' TODO: modifier cette valeur à une taille de cache qui contient à votre application
            rootFrame.CacheSize = 1

            If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
                ' TODO: chargez l'état de l'application précédemment suspendue
            End If

            ' Placez le frame dans la fenêtre active
            Window.Current.Content = rootFrame
        End If

        If rootFrame.Content Is Nothing Then
            ' Supprime la navigation tourniquet pour le démarrage.
            If rootFrame.ContentTransitions IsNot Nothing Then
                _transitions = New TransitionCollection()
                For Each transition As Transition In rootFrame.ContentTransitions
                    _transitions.Add(transition)
                Next
            End If

            rootFrame.ContentTransitions = Nothing
            AddHandler rootFrame.Navigated, AddressOf RootFrame_FirstNavigated

            ' Quand la pile de navigation n'est pas restaurée, accédez à la première page,
            ' puis configurez la nouvelle page en transmettant les informations requises en tant que
            ' paramètre
            If Not rootFrame.Navigate(GetType(MainPage), e.Arguments) Then
                Throw New Exception("Failed to create initial page")
            End If
        End If

        ' Vérifiez que la fenêtre actuelle est active
        Window.Current.Activate()
    End Sub

    ''' <summary>
    ''' Restaure les transitions de contenu une fois l'application lancée.
    ''' </summary>
    Private Sub RootFrame_FirstNavigated(sender As Object, e As NavigationEventArgs)
        Dim newTransitions As TransitionCollection
        If _transitions Is Nothing Then
            newTransitions = New TransitionCollection()
            newTransitions.Add(New NavigationThemeTransition())
        Else
            newTransitions = _transitions
        End If

        Dim rootFrame As Frame = DirectCast(sender, Frame)
        rootFrame.ContentTransitions = newTransitions
        RemoveHandler rootFrame.Navigated, AddressOf RootFrame_FirstNavigated
    End Sub

    ''' <summary>
    ''' Appelé lorsque l'exécution de l'application est suspendue. L'état de l'application est enregistré.
    ''' sans savoir si l'application pourra se fermer ou reprendre sans endommager
    ''' le contenu de la mémoire.
    ''' </summary>
    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()

        ' TODO: enregistrez l'état de l'application et arrêtez toute activité en arrière-plan
        deferral.Complete()
    End Sub

End Class
