Public Class RoutedEvents

    Private Sub OnClick(ByVal sender As Object, ByVal e As RoutedEventArgs)

        Dim element As FrameworkElement = CType(e.Source, 
                                                FrameworkElement)

        Select Case element.Name
            Case Is = "Button1"
                MessageBox.Show("You clicked Button1")
            Case Is = "Button2"
                MessageBox.Show("You clicked Button2")
            Case Is = "Button3"
                MessageBox.Show("You clicked Button3")
        End Select
    End Sub

End Class
