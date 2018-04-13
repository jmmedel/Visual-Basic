Public Class E_L

    Private Sub E_L_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Dim procList = From proc In Process.GetProcesses.
               AsEnumerable
               Select proc.ProcessName

        Me.ListBox1.ItemsSource = procList
        Me.ListView1.ItemsSource = Process.GetProcesses.AsEnumerable
    End Sub
End Class
