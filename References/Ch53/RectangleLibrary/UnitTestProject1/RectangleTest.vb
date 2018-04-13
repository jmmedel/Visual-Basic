Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports RectangleLibrary

<TestClass()> Public Class RectangleTest

    <TestMethod()>
    Sub CalculatePerimeter()
        Dim rect As New Rectangle
        rect.Width = 150
        rect.Height = 100

        Dim expected As Double = 500
        Dim result = rect.CalculatePerimeter
        Assert.AreEqual(expected, result)

    End Sub

End Class