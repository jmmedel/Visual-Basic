
'A destructor Is a special member Sub Of a Class that Is executed whenever an Object Of its Class goes out Of scope.

'A destructor has the name Finalize And it can neither Return a value nor can it take any parameters. Destructor can be very useful For releasing resources before coming out Of the program Like closing files, releasing memories, etc.

'Destructors cannot be inherited Or overloaded.

'Following example explains the concept Of destructor

Module Module1

    Class Line
        Private length As Double    ' Length of a line
        Public Sub New()   'parameterised constructor
            Console.WriteLine("Object is being created")
        End Sub
        Protected Overrides Sub Finalize()  ' destructor
            Console.WriteLine("Object is being deleted")
        End Sub
        Public Sub setLength(ByVal len As Double)
            length = len
        End Sub
        Public Function getLength() As Double
            Return length
        End Function

    End Class

    Sub Main()
        Dim line As Line = New Line()
        'set line length
        line.setLength(6.0)
        Console.WriteLine("Length of line : {0}", line.getLength())
        Console.ReadKey()
    End Sub


End Module

'When the above code Is compiled And executed, it produces the following result

'Object Is being created
'Length of line : 6
'Object Is being deleted
