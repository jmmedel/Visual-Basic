
'VB.Net -Nested Select Case Statement
'It Is possible To have a Select statement As part Of the statement sequence Of an outer Select statement. Even If the Case constants Of the inner And outer Select contain common values, no conflicts will arise.

Module Module1

    Sub Main()
        'local variable definition
        Dim a As Integer = 100
        Dim b As Integer = 200
        Select Case a
            Case 100
                Console.WriteLine("This is part of outer case ")
                Select Case b
                    Case 200
                        Console.WriteLine("This is part of inner case ")
                End Select
        End Select
        Console.WriteLine("Exact value of a is : {0}", a)
        Console.WriteLine("Exact value of b is : {0}", b)
        Console.ReadLine()
    End Sub
End Module

'When the above code Is compiled And executed, it produces the following result

'This Is part of outer case
'This Is part of inner case
'Exact value Of a Is : 100
'Exact value Of b Is : 200
