


'Accepting Values from User
'The Console Class In the System Namespace provides a Function ReadLine For accepting input from the user And store it into a variable. For example,

'Dim message As String
'message = Console.ReadLine
'The following example demonstrates it


Module Module1

    Sub Main()
        Dim message As String
        Console.Write("Enter message: ")
        message = Console.ReadLine
        Console.WriteLine()
        Console.WriteLine("Your Message: {0}", message)
        Console.ReadLine()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result (assume the user inputs Hello World):

'Enter message: Hello World   
'Your Message: Hello World

'Lvalues And Rvalues
'There are two kinds Of expressions

'lvalue: An expression that Is an lvalue may appear As either the left-hand Or right-hand side Of an assignment.

'rvalue: An expression that Is an rvalue may appear On the right- but Not left-hand side Of an assignment.

'Variables are lvalues And so may appear On the left-hand side Of an assignment. Numeric literals are rvalues And so may Not be assigned And can Not appear On the left-hand side. Following Is a valid statement

'Dim g As Integer = 20
'But following Is Not a valid statement And would generate compile-time Error

'20 = g
