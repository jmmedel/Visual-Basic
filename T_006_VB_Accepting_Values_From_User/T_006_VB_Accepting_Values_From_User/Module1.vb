


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



