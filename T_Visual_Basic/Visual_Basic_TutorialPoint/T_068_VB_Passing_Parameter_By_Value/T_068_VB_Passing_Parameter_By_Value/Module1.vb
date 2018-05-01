
'Passing Parameters by Value
'This Is the Default mechanism For passing parameters To a method. In this mechanism, when a method Is called, a New storage location Is created For Each value parameter. The values Of the actual parameters are copied into them. So, the changes made to the parameter inside the method have no effect on the argument.

'In VB.Net, you declare the reference parameters using the ByVal keyword. The following example demonstrates the concept

Module Module1

    Sub swap(ByVal x As Integer, ByVal y As Integer)
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

'Before swap, value Of a :100
'Before swap, value Of b :200
'After swap, value Of a :100
'After swap, value Of b :200
'It shows that there Is no change In the values though they had been changed inside the Function.

