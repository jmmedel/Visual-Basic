Imports ContactsLibrary

Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.DataContext = New ContactViewModel
    End Sub
End Class
