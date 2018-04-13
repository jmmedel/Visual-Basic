Module Module1

    Sub Main()

        'Employee inherits from BusinessPerson
        'which inherits from Person 
        Dim emp As New Employee With {.EmployeeID = 1,
            .Title = "Mr.",
            .LastName = "Del Sole",
            .FirstName = "Alessandro",
            .Email = "alessandro.delsole@visual-basic.it",
            .BusinessPhone = "000-000-000000",
            .HomePhone = "000-000-000000",
            .MobilePhone = "000-000-000000",
            .HireDate = New Date(6, 14, 2015)}

    End Sub

End Module
