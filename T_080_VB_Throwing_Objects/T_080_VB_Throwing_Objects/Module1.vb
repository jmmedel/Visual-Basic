
'Throwing Objects
'You can Throw an Object If it Is either directly Or indirectly derived from the System.Exception Class.

'You can use a Throw statement In the Catch block To Throw the present Object As

'Throw [ expression ]
'The following program demonstrates this

Module Module1

    Sub Main()
        Try
            Throw New ApplicationException("A custom exception _
		  is being thrown here...")
        Catch e As Exception
            Console.WriteLine(e.Message)
        Finally
            Console.WriteLine("Now inside the Finally Block")
        End Try
        Console.ReadKey()
    End Sub

End Module

'When the above code is compiled and executed, it produces the following result:

'A custom exception is being thrown here...
'Now inside the Finally Block
