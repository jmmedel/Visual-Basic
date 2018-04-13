' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class PlayerPage
    Inherits Page

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        Me.Player1.Source = New Uri(CStr(e.Parameter))
    End Sub

    Private Sub BackButton_Click(sender As Object, e As RoutedEventArgs)
        If Frame.CanGoBack Then
            Frame.GoBack()
        End If
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Player1.Play()
    End Sub

    Private Sub StopButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Player1.Stop()
    End Sub

    Private Sub PauseButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Player1.Pause()
    End Sub

End Class
