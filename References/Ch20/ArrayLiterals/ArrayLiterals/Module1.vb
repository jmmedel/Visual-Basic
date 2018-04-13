Module Module1

    Sub Main()

        'The compiler infers String()
        Dim anArrayOfStrings = {"One", "Two", "Three"}

        'The compiler infers Double
        Dim anArrayOfDouble = {1.23, 2.34, 3.45}
        'The compiler infers Integer
        Dim anArrayOfInteger = {4, 3, 2, 1}

        'Does not work with Option Strict On
        'Dim mixedArray = {1.23, "One point Twentythree"}

        Dim multiIntArray = {{4, 3}, {2, 1}}

        Dim jaggedStringArray = {({"One", "Two"}),
                                ({"Three", "Four"})}

    End Sub

End Module