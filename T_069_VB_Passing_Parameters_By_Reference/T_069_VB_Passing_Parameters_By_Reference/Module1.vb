
'Passing Parameters by Reference
'A reference parameter Is a reference To a memory location Of a variable. When you pass parameters by reference, unlike value parameters, a New storage location Is Not created For these parameters. The reference parameters represent the same memory location As the actual parameters that are supplied To the method.

'In VB.Net, you declare the reference parameters using the ByRef keyword. The following example demonstrates this


Module Module1

    Sub swap(ByRef x As Integer, ByRef y As Integer)
        Dim temp As Integer
        temp = x ' save the value of x 
        x = y    ' put y into x 
        y = temp 'put temp into y 
    End Sub
    Sub Main()
        ' local variable definition 
        Dim a As Integer = 100
        Dim b As Integer = 200
        Console.WriteLine("Before swap, value of a : {0}", a)
        Console.WriteLine("Before swap, value of b : {0}", b)
        ' calling a function to swap the values '
        swap(a, b)
        Console.WriteLine("After swap, value of a : {0}", a)
        Console.WriteLine("After swap, value of b : {0}", b)
        Console.ReadLine()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result:

'Before swap, value Of a : 100
'Before swap, value Of b : 200
'After swap, value Of a : 200
'After swap, value Of b : 100
