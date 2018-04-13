Module Module1

    Sub Main()

        Dim t1 As New ThreePoint With {.X = 2, .Y = 24, .Z = 50}
        Dim t2 As New ThreePoint With {.X = 5, .Y = 10, .Z = 32}

        'Won't compile, throws an error
        Dim result As ThreePoint = t1 + t2

        Debug.Print("Sum result is: X {0}, Y {1}, Z {2}", result.X, result.Y, result.Z)


        Dim arr() As Integer = {10, 15, 20}
        Dim converted As ThreePoint = CType(arr, ThreePoint)

    End Sub

End Module