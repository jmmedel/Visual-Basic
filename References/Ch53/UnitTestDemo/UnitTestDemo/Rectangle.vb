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
