Class MainWindow 

    Private Sub Button1_Click(ByVal sender As System.Object,
                              ByVal e As System.Windows.RoutedEventArgs)

        Dim Button1 As New Button
        With Button1
            .Width = 100
            .Height = 30
            .Content = "Button1"
        End With
        Me.Grid1.Children.Add(Button1)

        'Me is the current Window
        With Me
            .Title = "Chapter 28 demonstration"
            .WindowStartupLocation = WindowStartupLocation.CenterScreen
            .WindowState = WindowState.Maximized
            .WindowStyle = WindowStyle.ThreeDBorderWindow
            .Topmost = True
        End With

        Dim aWindow As New Window
        'Set your Window properties here...
        aWindow.ShowDialog()
        '....
        aWindow.Close()

    End Sub

    Private Sub GetApplicationInfo()
        Dim myApp As Application = CType(Application.Current, Application)

        'Gets the startup object under the form of a XAML file
        Dim startupObject As Uri = myApp.StartupUri

        'Gets (but also allows setting) the application main window
        Dim mainWindow As Window = myApp.MainWindow

        'Get assembly information
        With myApp.Info
            Dim companyName As String = .CompanyName
            Dim appName As String = .ProductName

            'get other info here...
        End With
        Application.Current.Shutdown()
    End Sub
End Class
