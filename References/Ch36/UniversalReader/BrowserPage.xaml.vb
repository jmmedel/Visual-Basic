' The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

Imports Windows.ApplicationModel.DataTransfer
Imports Windows.Data.Xml.Dom
Imports Windows.Phone.UI.Input
Imports Windows.UI.Notifications
''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class BrowserPage
    Inherits Page

    Private Sub ShareButton_Click(sender As Object, e As RoutedEventArgs)
        DataTransferManager.ShowShareUI()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As RoutedEventArgs)
        If Frame.CanGoBack Then
            Frame.GoBack()
        End If

    End Sub

    Private Sub PlayButton_Click(sender As Object, e As RoutedEventArgs)
        If Me.currentFeed.Video IsNot Nothing Then
            Frame.Navigate(GetType(PlayerPage), currentFeed.Video)
        Else
            'Get a text template
            Dim toastXml = ToastNotificationManager.
                GetTemplateContent(ToastTemplateType.ToastText01)

            'Specify the text message
            Dim elements = toastXml.
                GetElementsByTagName("text")
            For Each node As IXmlNode In elements
                node.InnerText =
                    String.Format("No media available for this item")
            Next

            'Raise a new notification
            Dim notification As New ToastNotification(toastXml)
            ToastNotificationManager.
                CreateToastNotifier().Show(notification)
        End If

    End Sub

    Private currentFeed As FeedItem

    Protected Overrides Sub OnNavigatedTo(e As NavigationEventArgs)
        Me.currentFeed = CType(e.Parameter, FeedItem)
        Me.FeedWebView.Source = New Uri(Me.currentFeed.Url)
    End Sub
    Private Sub FeedWebView_ContentLoading(sender As WebView,
                                           args As WebViewContentLoadingEventArgs) _
                                           Handles FeedWebView.ContentLoading
        Me.Progress1.Visibility = Visibility.Visible
        Me.Progress1.IsIndeterminate = True
    End Sub

    Private Sub FeedWebView_LoadCompleted(sender As Object,
                                          e As NavigationEventArgs) _
                                          Handles FeedWebView.LoadCompleted
        Me.Progress1.IsIndeterminate = False
        Me.Progress1.Visibility = Visibility.Collapsed
    End Sub

    Private dataManager As DataTransferManager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        RegisterForShare()
    End Sub

    Private Sub RegisterForShare()
        Me.dataManager = DataTransferManager.GetForCurrentView
        AddHandler dataManager.DataRequested, AddressOf dataManager_DataRequested
    End Sub

    Private Sub dataManager_DataRequested(sender As DataTransferManager,
                                          args As DataRequestedEventArgs)
        Dim request As DataRequest = args.Request
        request.Data.Properties.Title = currentFeed.Title
        request.Data.Properties.Description = currentFeed.DateRecorded
        request.Data.SetWebLink(New Uri(currentFeed.Url))
    End Sub

End Class
