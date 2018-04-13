Module SimpleIterators

    'Simplest iterator, with demonstration of how to exit
    'You use it like this:
    'For Each item As String in StringSeries
    '   Console.Writeline(item)
    'Next
    Iterator Function StringSeries() As IEnumerable(Of String)
        Yield "First string"
        Yield "Second string"
        Exit Function 'Return is also accepted
        Yield "Third string"
        '...
    End Function

    'In VB, iterators can be inside a Try..Catch block
    Iterator Function OddNumbers(first As Integer, last As Integer) As IEnumerable(Of Integer)
        Try
            For number As Integer = first To last
                If number Mod 2 <> 0 Then
                    'is odd
                    Yield number
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            Console.WriteLine("Loop completed.")
        End Try
    End Function


    'Demonstrating anonymous iterators
    Sub Main()
        'Type of oddSequence is inferred by the compiler
        'Iterator definition is in-line, with no name
        Dim oddSequence = Iterator Function(first As Integer,
                                            last As Integer) As IEnumerable(Of Integer)
                              Try
                                  For number As Integer = first To last
                                      If number Mod 2 <> 0 Then
                                          'is odd
                                          Yield number
                                      End If
                                  Next
                              Catch ex As Exception
                                  Console.WriteLine(ex.Message)
                              Finally
                                  Console.WriteLine("Loop completed.")
                              End Try
                          End Function

        For Each number As Integer In oddSequence(1, 10)
            Console.WriteLine(number)
        Next
    End Sub




End Module
