' Pour plus d'informations sur le modèle Application vide, consultez la page http://go.microsoft.com/fwlink/?LinkID=391641

''' <summary>
''' Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
    ''' </summary>
    ''' <param name="e">Données d’événement décrivant la manière dont l’utilisateur a accédé à cette page.
    ''' Ce paramètre est généralement utilisé pour configurer la page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)
        ' TODO: préparer la page pour affichage ici.

        ' TODO: si votre application comporte plusieurs pages, assurez-vous que vous
        ' gérez le bouton Retour physique en vous inscrivant à l’événement
        ' Événement Windows.Phone.UI.Input.HardwareButtons.BackPressed.
        ' Si vous utilisez le NavigationHelper fourni par certains modèles,
        ' cet événement est géré automatiquement.
    End Sub

End Class
