
'Passing Arrays As Function Arguments
'You can pass an array As a Function argument In VB.Net. The following example demonstrates this

Module Module1

    Function getAverage(ByVal arr As Integer(), ByVal size As Integer) As Double
        'local variables
        Dim i As Integer
        Dim avg As Double
        Dim sum As Integer = 0
        For i = 0 To size - 1
            sum += arr(i)
        Next i
        avg = sum / size
        Return avg
    End Function
    Sub Main()
        ' an int array with 5 elements '
        Dim balance As Integer() = {1000, 2, 3, 17, 50}
        Dim avg As Double
        'pass pointer to the array as an argument 
        avg = getAverage(balance, 5)
        ' output the returned value '
        Console.WriteLine("Average value is: {0} ", avg)
        Console.ReadLine()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result:

'Average value Is: 214.4
