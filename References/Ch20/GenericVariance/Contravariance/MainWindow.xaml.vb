Class MainWindow 

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Explicitly specify handlers for events
        AddHandler Button1.KeyUp, AddressOf CommonHandler
        AddHandler Button1.MouseDoubleClick, AddressOf CommonHandler

    End Sub

    Private Sub CommonHandler(ByVal sender As Object,
                          ByVal e As EventArgs)
        MessageBox.Show("You did it!")
    End Sub
End Class
