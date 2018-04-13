Module Covariance

    Sub Main()

        'Using collection initializers
        Dim stringsCollection As New List(Of String) _
                              From {"Understanding ", "covariance ", "in VB 2015"}

        'This code is now legal
        Dim variance As IEnumerable(Of Object) = stringsCollection

        For Each s In variance
            Debug.WriteLine(s)
        Next

        Console.ReadLine()
    End Sub

End Module