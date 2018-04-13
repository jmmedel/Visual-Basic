Class B_D

    Private Sub Calendar1_SelectedDatesChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs)
        Dim currentCalendar = CType(sender, Calendar)
        Me.TextBox1.Text = currentCalendar.SelectedDate.Value.ToString

    End Sub

    Private Sub Check1_Checked(ByVal sender As System.Object,
                           ByVal e As System.Windows.RoutedEventArgs)
        MessageBox.Show("Checked")
    End Sub

    Private Sub Check1_Unchecked(ByVal sender As Object,
                                 ByVal e As System.Windows.RoutedEventArgs)
        MessageBox.Show("Unchecked")
    End Sub
    Private Sub MainWindow_Loaded(ByVal sender As Object,
                              ByVal e As RoutedEventArgs) _
                              Handles Me.Loaded
        Dim procList = From proc In Process.GetProcesses.
                       AsEnumerable
                       Select proc.ProcessName

        'Assuming the Combo's name is now ProcessNamesCombo
        Me.ProcessNamesCombo.ItemsSource = procList
    End Sub

    Private Sub CustomerNamesCombo_SelectionChanged(ByVal sender As Object,
                               ByVal e As SelectionChangedEventArgs)

        Dim selectedProcess = CType(CType(sender, ComboBox).SelectedItem,
                              String)

        MessageBox.Show("You selected " & selectedProcess)
    End Sub

    Private Sub DatePicker1_SelectedDateChanged(ByVal sender As Object,
                                            ByVal e As  _
                                            SelectionChangedEventArgs)

        'Use the "e" object to access the DatePicker control 
        '(Source represents
        'the instance)
        MessageBox.Show("The new date is " & CType(e.Source, 
                        DatePicker).SelectedDate.
                        Value.ToLongDateString)
    End Sub

End Class
