Public Class Rectangle
    Public Property Height As Double
    Public Property Width As Double

    Public Function CalculatePerimeter() As Double
        Return (Me.Height + Me.Width) * 2
    End Function
End Class
