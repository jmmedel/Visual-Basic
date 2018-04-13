Module Module1

    Sub Main()

        Dim p As New Person

        p.LastName = "Del Sole"
        p.FirstName = "Alessandro"

        Dim fullName As String = p.FullName

        Person.ReturnInstanceCount()

        Dim threeDim As New ThreePoint

    End Sub
End Module