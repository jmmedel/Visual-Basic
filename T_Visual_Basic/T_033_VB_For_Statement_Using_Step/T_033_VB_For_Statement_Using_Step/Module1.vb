
'If you want To use a Step size Of 2, For example, you need To display only even numbers, between 10 And 20


Module Module1

    Sub Main()
        Dim a As Byte
        ' for loop execution 
        For a = 10 To 20 Step 2
            Console.WriteLine("value of a: {0}", a)
        Next
        Console.ReadLine()
    End Sub


End Module

'When the above code Is compiled And executed, it produces the following result

'value of a: 10
'value of a: 12
'value of a: 14
'value of a: 16
'value of a: 18
'value of a: 20
