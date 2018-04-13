Module Module1

    Sub Main()

        Dim p As New Person With {.FirstName = "Alessandro", .LastName = "Del Sole",
                                  .Age = 35}

        Dim fullName As String = p.GetFullName

    End Sub

End Module
