Public Class Animations

    Private Sub Animations_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded

        Dim cust1 As New Customer With {.Address = "7Th street", .CompanyName = "Del Sole", .ContactName = "Alessandro Del Sole"}
        Dim cust2 As New Customer With {.Address = "5Th street", .CompanyName = "Fictitious Red & White", .ContactName = "Robert White"}

        Dim custList As New List(Of Customer) From {cust1, cust2}

        Me.CustomerDataGrid.ItemsSource = custList

        CreateRuntimeAnimation()
    End Sub

    Private Sub ImageStoryBoard_Completed(ByVal sender As Object,
                                          ByVal e As System.EventArgs) _
                                          Handles ImageStoryBoard.Completed
        'Write code for the animation completion

        With ImageStoryBoard
            .AutoReverse = True
            .RepeatBehavior = System.Windows.Media.Animation.
                              RepeatBehavior.Forever
            .Duration = New TimeSpan(0, 0, 5)
        End With
    End Sub

    Private myAnimation As Animation.DoubleAnimation
    Private WithEvents aButton As Button
    Private heightAnimationStoryboard As Animation.Storyboard

    Private Sub CreateRuntimeAnimation()

        'An instance of a new Button
        aButton = New Button With {.Width = 150, .Height = 50,
                                   .Content = "Runtime button",
                                   .Name = "RuntimeButton"}

        'Associates the button's name to the Window names collection
        '(required at runtime)
        Me.RegisterName(aButton.Name, aButton)

        'Adds the Button to the Grid at the given row/column
        Grid.SetColumn(aButton, 0)
        Grid.SetRow(aButton, 1)
        Grid1.Children.Add(aButton)

        'Creates a new DoubleAnimation, with properties
        myAnimation = New Animation.DoubleAnimation
        With myAnimation
            .AutoReverse = True
            'From and To are Nullable(Of Double)
            .From = 50
            .To = 15
            .RepeatBehavior = Animation.RepeatBehavior.Forever
            .Duration = New TimeSpan(0, 0, 3)
        End With

        'Sets the target control via its name
        Animation.Storyboard.SetTargetName(myAnimation, aButton.Name)
        'Sets the target property
        Animation.Storyboard.SetTargetProperty(myAnimation,
                                               New PropertyPath(Button.
                                                                HeightProperty))

        'Create a new storyboard instance and adds the animation
        'to the storyboard's collection of animations
        heightAnimationStoryboard = New Animation.Storyboard
        heightAnimationStoryboard.Children.Add(myAnimation)
    End Sub

    'Starts the animation when the button is loaded
    Private Sub aButton_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs) _
                               Handles aButton.Loaded
        heightAnimationStoryboard.Begin(aButton)
    End Sub
End Class

Public Class Customer
    Public Property CompanyName As String
    Public Property Address As String
    Public Property ContactName As String
End Class

