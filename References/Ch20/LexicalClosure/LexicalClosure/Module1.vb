Module Module1

    Sub Main()

    End Sub

End Module

Class ClosureDemo

    Sub Divide(ByVal value As Double)
        Dim x = value
        Dim calculate = Function(y As Double) x / y
        Dim result = calculate(10)
    End Sub
End Class

'The following is how the compiler handles behind the
'scenes the above code:

'Class _Closure$__1
'    Public x As Double

'    Function _Lambda$__1(ByVal y As Double) As Double
'        Return x * y
'    End Function
'End Class

'Class ClosureDemo

'    Sub Divide(ByVal value As Double)
'       Dim closureVariable_A_8 As New _ 
'           _Closure$__1
'        _Closure$(__1.closureVariable_A_8 = value)

'       Dim calculate As Func(Of Double, Double) _ 
'       = AddressOf _Closure$__1._Lambda$__1
'        Dim result = calculate(10)

'    End Sub
'End Class