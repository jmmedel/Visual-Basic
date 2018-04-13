Public Class Transforms

    Private Sub Transforms_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) _
                                  Handles Me.Loaded

        'Gets a list of names for running processes
        'and populates the Grid.DataContext so that children
        'elements will pick up data from it
        Me.Grid1.DataContext = From proc In Process.GetProcesses
                               Select proc.ProcessName
    End Sub
End Class
