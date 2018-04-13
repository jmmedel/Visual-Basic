' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Protected Overrides Async Sub OnNavigatedTo(e As NavigationEventArgs)
        Me.Progress1.Visibility = Visibility.Visible
        Me.Progress1.IsIndeterminate = True
        Try
            DataContext = Await UniversalReader.GetFeedAsync()
            If DataContext Is Nothing Then
                Dim dlg As New Windows.UI.Popups.
                MessageDialog("Check your Internet connection")
                Await dlg.ShowAsync
            End If
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            Me.Progress1.IsIndeterminate = False
            Me.Progress1.Visibility = Visibility.Collapsed
        End Try
    End Sub

    Private Async Sub RefreshButton_Click(sender As Object, e As RoutedEventArgs)
        Me.Progress1.Visibility = Visibility.Visible
        Me.Progress1.IsIndeterminate = True

        Me.DataContext = Await UniversalReader.RefreshFeedAsync

        Me.Progress1.IsIndeterminate = False
        Me.Progress1.Visibility = Visibility.Collapsed

    End Sub

    Private Sub FeedView_ItemClick(sender As Object, e As ItemClickEventArgs)
        Dim item As FeedItem = CType(e.ClickedItem, FeedItem)
        Frame.Navigate(GetType(BrowserPage), item)

    End Sub
End Class
