Module Module1

    Sub Main()
        TimeSpanInstance()
        Console.ReadLine()
    End Sub

    Sub TimeSpanInstance()
        Dim currentDate As Date = Date.Now
        'Because the System namespace is imported at project
        'level, we do not need an Imports directive
        Dim intervalOfTime As TimeSpan = currentDate.TimeOfDay

        Console.WriteLine("My friend, in the current date " &
                          "there are {0} days; time is {1}:{2}:{3}",
                intervalOfTime.Days,
                intervalOfTime.Hours,
                intervalOfTime.Minutes,
                intervalOfTime.Seconds)
    End Sub

    Sub StopWatchDemo()
        Dim watch As New Stopwatch

        watch.Start()
        For i = 0 To 10000
            System.Threading.Thread.SpinWait(800000)
        Next
        watch.Stop()

        Debug.WriteLine(watch.Elapsed.Seconds)
        Debug.WriteLine(watch.Elapsed.Milliseconds)
        Debug.WriteLine(watch.Elapsed.Ticks)

        Console.WriteLine("Done")

    End Sub

End Module

