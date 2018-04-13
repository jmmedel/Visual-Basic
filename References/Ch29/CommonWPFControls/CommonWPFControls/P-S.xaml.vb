Public Class P_S

    Private Sub PasswordButton_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Dim myPassword = "TestPassword"
        If PasswordBox1.Password = myPassword Then
            MessageBox.Show("Password matches")
        Else
            MessageBox.Show("Password does not match")
        End If

    End Sub

    Private Delegate Sub updateDelegate(ByVal depProperty As  _
                 System.Windows.DependencyProperty, _
                 ByVal value As Object)


    Private Sub HandleProgressBar()
        Dim value As Double = ProgressBar1.Value

        Dim updateProgressBar As New  _
            updateDelegate(AddressOf _
                                      ProgressBar1.SetValue)

        Do Until ProgressBar1.Value = ProgressBar1.Maximum
            value += 1

            Dispatcher.Invoke(updateProgressBar, _
                System.Windows.Threading.DispatcherPriority.Background, _
                New Object() {ProgressBar.ValueProperty, value})
        Loop
    End Sub

    Private Sub Scroll1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Controls.Primitives.ScrollEventArgs)

    End Sub
End Class
