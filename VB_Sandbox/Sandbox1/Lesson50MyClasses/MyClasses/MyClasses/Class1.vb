Public Class Math
    Private Sub New()

    End Sub
    Public Shared Function Add(x As Double, y As Double) As Double
        Return x + y
    End Function
    Public Shared Function Subtract(x As Double, y As Double) As Double
        Return x - y
    End Function
    Public Shared Function Multiply(x As Double, y As Double) As Double
        Return x * y
    End Function
    'division by zero not allowed 
    Public Shared Function Divide(x As Double, y As Double) As Double
        If y <> 0 Then
            Return x / y
        Else
            Return Double.NaN
        End If
    End Function
End Class
