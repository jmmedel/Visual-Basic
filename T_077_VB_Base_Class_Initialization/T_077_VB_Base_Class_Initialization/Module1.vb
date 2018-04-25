
'Base Class Initialization
'The derived Class Inherits the base Class member variables And member methods. Therefore, the super Class Object should be created before the subclass Is created. The super Class Or the base Class Is implicitly known As MyBase In VB.Net

'The following program demonstrates this


Module Module1

    ' Base class
    Class Rectangle
        Protected width As Double
        Protected length As Double
        Public Sub New(ByVal l As Double, ByVal w As Double)
            length = l
            width = w
        End Sub
        Public Function GetArea() As Double
            Return (width * length)
        End Function
        Public Overridable Sub Display()
            Console.WriteLine("Length: {0}", length)
            Console.WriteLine("Width: {0}", width)
            Console.WriteLine("Area: {0}", GetArea())
        End Sub
        'end class Rectangle  
    End Class
    'Derived class
    Class Tabletop : Inherits Rectangle
        Private cost As Double
        Public Sub New(ByVal l As Double, ByVal w As Double)
            MyBase.New(l, w)
        End Sub
        Public Function GetCost() As Double
            Dim cost As Double
            cost = GetArea() * 70
            Return cost
        End Function
        Public Overrides Sub Display()
            MyBase.Display()
            Console.WriteLine("Cost: {0}", GetCost())
        End Sub
        'end class Tabletop
    End Class

    Sub Main()
        Dim t As Tabletop = New Tabletop(4.5, 7.5)
        t.Display()
        Console.ReadKey()
    End Sub


End Module


'When the above code Is compiled And executed, it produces the following result

'Length: 4.5
'Width: 7.5
'Area: 33.75
'Cost: 2362.5