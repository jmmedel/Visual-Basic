Class Application

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.
    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

    Private Sub Application_Startup(ByVal sender As Object,
                                    ByVal e As System.Windows.StartupEventArgs) _
                                    Handles Me.Startup
        MessageBox.Show("Application is starting up")
    End Sub

    Private Sub Application_Exit(ByVal sender As Object,
                                 ByVal e As System.Windows.ExitEventArgs) _
                                 Handles Me.Exit
        MessageBox.Show("Application is closing")
    End Sub
End Class
