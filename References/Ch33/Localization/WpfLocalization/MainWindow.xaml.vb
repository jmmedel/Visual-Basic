Class MainWindow
    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Threading.Thread.CurrentThread.
                  CurrentCulture = New Globalization.CultureInfo("it")
        Threading.Thread.CurrentThread.
                  CurrentUICulture = New Globalization.CultureInfo("it")
        Me.Button1.Content = My.Resources.LocalizedButton
        Me.TextBlock1.Text = My.Resources.LocalizedText
    End Sub
End Class
