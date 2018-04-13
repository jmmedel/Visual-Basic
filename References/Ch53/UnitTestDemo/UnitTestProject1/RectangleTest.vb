Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Class Rectangle

    Shared Function CalculatePerimeter(ByVal sideA As Double,
                                       ByVal sideB As Double) As Double
        Return (sideA * 2) + (sideB * 2)
    End Function

    Shared Function CalculateArea(ByVal sideA As Double,
                                  ByVal sideB As Double) As Double
        Return sideA * sideB
    End Function
End Class

<TestClass()> Public Class RectangleTest

    '''<summary>
    '''A test for CalculateArea
    '''</summary>
    <TestMethod()>
    Public Sub CalculateAreaTest()
        Dim sideA As Double = 10
        Dim sideB As Double = 20
        Dim expected As Double = 200
        Dim actual As Double
        actual = Rectangle.CalculateArea(sideA, sideB)
        Assert.AreEqual(expected, actual)

    End Sub

    '''<summary>
    '''A test for CalculatePerimeter
    '''</summary>
    <TestMethod()>
    Public Sub CalculatePerimeterTest()
        Dim sideA As Double = 10
        Dim sideB As Double = 20
        Dim expected As Double = 60
        Dim actual As Double
        actual = Rectangle.CalculatePerimeter(sideA, sideB)
        Assert.AreEqual(expected, actual)
    End Sub
End Class
