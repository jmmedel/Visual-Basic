Module Module1

    Sub Main()
        ' Delegate relaxation can drop the return type of the lambda
        Dim lambdaReturnType As Action = Function() 1

        ' Delegate relaxation can drop the parameters of the delegate
        Dim delegateParameters As Action(Of Integer) = Sub() Console.WriteLine()

        ' Delegate relaxation can do widening conversions from lambda return type to delegate return type
        Dim lambdaToDelegate As Func(Of Integer?) = Function() 1

        ' Delegate relaxation can do widening conversions from delegate parameter type to lambda parameter type
        Dim delegateParamType As Action(Of Integer) = Sub(i As Integer?) Console.WriteLine(i)

    End Sub

End Module
