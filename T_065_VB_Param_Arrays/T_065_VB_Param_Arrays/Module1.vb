
'Param Arrays
'At times, while declaring a Function Or Sub procedure, you are Not sure Of the number Of arguments passed As a parameter. VB.Net param arrays (Or parameter arrays) come into help at these times.

'The following example demonstrates this


Module Module1

    Function AddElements(ParamArray arr As Integer()) As Integer
        Dim sum As Integer = 0
        Dim i As Integer = 0
        For Each i In arr
            sum += i
        Next i
        Return sum
    End Function
    Sub Main()
        Dim sum As Integer
        sum = AddElements(512, 720, 250, 567, 889)
        Console.WriteLine("The sum is: {0}", sum)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result:

'The sum Is: 2938
