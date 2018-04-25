
'Constructors And Destructors
'A Class constructor Is a special member Sub Of a Class that Is executed whenever we create New objects Of that Class. A constructor has the name New And it does Not have any Return type.

'Following program explains the concept Of constructor


Module Module1
    Class Line
        Private length As Double    ' Length of a line
        Public Sub New()   'constructor
            Console.WriteLine("Object is being created")
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