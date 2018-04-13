Class MainWindow 

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim pdfViewer As New PDFControl
        Me.FormsHost1.Child = pdfViewer
    End Sub
End Class
