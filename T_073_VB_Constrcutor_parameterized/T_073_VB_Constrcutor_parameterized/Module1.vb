
'A Default constructor does Not have any parameter, but If you need, a constructor can have parameters. Such constructors are called parameterized constructors. This technique helps you To assign initial value To an Object at the time Of its 
'    as shown in the following example


Module Module1

    Class Line
        Private length As Double    ' Length of a line
        Public Sub New(ByVal len As Double)   'parameterised constructor
            Console.WriteLine("Object is being created, length = {0}", len)
            length = len
        End Sub
        Public Sub setLength(ByVal len As Double)
            length = len
        End Sub

        Public Function getLength() As Double
            Return length
        End Function


    End Class

    Sub Main()
        Dim line As Line = New Line(10.0)
        Console.WriteLine("Length of line set by constructor : {0}", line.getLength())
        'set line length
        line.setLength(6.0)
        Console.WriteLine("Length of line set by setLength : {0}", line.getLength())
        Console.ReadKey()
    End Sub

End Module
