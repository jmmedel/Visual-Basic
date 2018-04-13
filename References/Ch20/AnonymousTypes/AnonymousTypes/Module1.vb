Module Module1

    Sub Main()

        Dim anonymous = New With {.FirstName = "Alessandro",
                                  .LastName = "Del Sole",
                                  .Email = "",
                                  .Age = 35}

        'The Age property is read-only and can
        'be assigned only when creating an instance
        Dim anonymousWithReadOnly = New With {.FirstName = "Alessandro",
                                              .LastName = "Del Sole",
                                              Key .Age = 35}


        'Property assignment
        anonymous.Email = "alessandro.delsole@visual-basic.it"
        'Property reading
        Console.WriteLine("{0} {1}, of age: {2}",
                          anonymous.FirstName,
                          anonymous.LastName,
                          anonymous.Age.ToString)

    End Sub

End Module
