
'Shared Members Of a VB.Net Class
'We can define Class members As Static Using the Shared keyword. When we Declare a member Of a Class As Shared, it means no matter how many objects Of the Class are created, there Is only one copy Of the member.

'The keyword Shared implies that only one instance Of the member exists For a Class. Shared variables are used For defining constants because their values can be retrieved by invoking the Class without creating an instance Of it.

'Shared variables can be initialized outside the member Function Or Class definition. You can also initialize Shared variables inside the Class definition.

'You can also Declare a member Function As Shared. Such functions can access only Shared variables. The Shared functions exist even before the Object Is created.

'The following example demonstrates the use Of Shared members


Module Module1

    Class StaticVar
        Public Shared num As Integer
        Public Sub count()
            num = num + 1
        End Sub
        Public Shared Function getNum() As Integer
            Return num
        End Function

    End Class

    Sub Main()
        Dim s As StaticVar = New StaticVar()
        s.count()
        s.count()
        s.count()
        Console.WriteLine("Value of variable num: {0}", StaticVar.getNum())
        Console.ReadKey()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result

'Value of variable num: 3

