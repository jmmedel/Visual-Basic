

'The program would behave In same way, If you use an Until statement, instead Of While

Module Module1

    Sub Main()
        ' local variable definition 
        Dim a As Integer = 10
        'do loop execution 
        Do
            Console.WriteLine("value of a: {0}", a)
            a = a + 1
        Loop Until (a = 20)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'value of a: 10
'value of a: 11
'value of a: 12
'value of a: 13
'value of a: 14
'value of a: 15
'value of a: 16
'value of a: 17
'value of a: 18
'value of a: 19
