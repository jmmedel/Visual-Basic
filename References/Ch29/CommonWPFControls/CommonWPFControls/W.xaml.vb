Public Class W

    Private Sub W_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        'This is Windows Forms code inside a WPF application
        Me.Picture1.Image = System.Drawing.Image.
                            FromFile("OpenFolder.png")

    End Sub
End Class
