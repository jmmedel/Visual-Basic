
'Inheritance
'One of the most important concepts in object-oriented programming Is that of inheritance. Inheritance allows us to define a class in terms of another class which makes it easier to create And maintain an application. This also provides an opportunity to reuse the code functionality And fast implementation time.

'When creating a class, instead of writing completely New data members And member functions, the programmer can designate that the New class should inherit the members of an existing class. This existing class Is called the base class, And the New class Is referred to as the derived class.

'Base & Derived Classes:
'A Class can be derived from more than one Class Or Interface, which means that it can inherit data And functions from multiple base classes Or interfaces.

'The syntax used In VB.Net For creating derived classes Is As follows

'<access-specifier> Class <base_class>
'...
'End Class
'Class <derived_class>: Inherits <base_class>
'...
'End Class
'Consider a base Class Shape And its derived Class Rectangle

Module Module1

    ' Base class
    Class Shape
        Protected width As Integer
        Protected height As Integer
        Public Sub setWidth(ByVal w As Integer)
            width = w
        End Sub
        Public Sub setHeight(ByVal h As Integer)
            height = h
        End Sub
    End Class
    ' Derived class
    Class Rectangle : Inherits Shape
        Public Function getArea() As Integer
            Return (width * height)
        End Function
    End Class

    Sub Main()
        Dim rect As Rectangle = New Rectangle()
        rect.setWidth(5)
        rect.setHeight(7)
        ' Print the area of the object.
        Console.WriteLine("Total area: {0}", rect.getArea())
        Console.ReadKey()
    End Sub


End Module

'When the above code Is compiled And executed, it produces the following result:

'Total area :  35

