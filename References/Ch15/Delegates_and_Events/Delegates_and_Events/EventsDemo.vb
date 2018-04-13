Public Class EventsDemo

    'Declares a Timer
    Private myTimer As Timers.Timer

    'A simple counter
    Private counter As Integer

    'Interval is the amount of time in ticks
    Public Sub New(ByVal interval As Double)
        'Register for notifications about the Elapsed event
        AddHandler myTimer.Elapsed, AddressOf increaseCounter
        'Assigns the Timer.Interval property
        Me.myTimer.Interval = interval
        Me.myTimer.Enabled = True

        RemoveHandler myTimer.Elapsed, AddressOf increaseCounter
        Me.myTimer.Enabled = False
    End Sub

    'Method that adheres to the delegate signature and that is
    'executed each time our class get notifications about
    'the Elapsed event occurring
    Private Sub increaseCounter(ByVal sender As Object,
                                ByVal e As Timers.ElapsedEventArgs)
        counter += 1

    End Sub
End Class

Public Class WithEventsDemo

    Private WithEvents myTimer As Timers.Timer

    Private counter As Integer

    Public Sub New(ByVal interval As Double)
        Me.myTimer.Interval = interval
        Me.myTimer.Enabled = True
    End Sub

    Private Sub increaseCounter(ByVal sender As Object,
                                ByVal e As Timers.ElapsedEventArgs) _
                                Handles myTimer.Elapsed
        counter += 1
    End Sub


End Class