Public Class AvoidingAmbiguities

    Private counter As Integer

    Public Sub DoSomething()

        'a local variable
        Dim counter As Integer

        counter = CInt(Console.ReadLine)
        Console.WriteLine(counter.ToString & " " & Me.counter.ToString)
        Console.ReadLine()
    End Sub
End Class