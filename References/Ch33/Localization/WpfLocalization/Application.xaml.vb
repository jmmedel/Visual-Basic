Class Application
    Public Sub New()
        Threading.Thread.CurrentThread.
          CurrentCulture = New Globalization.CultureInfo("it")
        Threading.Thread.CurrentThread.
                  CurrentUICulture = New Globalization.CultureInfo("it")
    End Sub

    ' Application-level events, such as Startup, Exit, and DispatcherUnhandledException
    ' can be handled in this file.

End Class
