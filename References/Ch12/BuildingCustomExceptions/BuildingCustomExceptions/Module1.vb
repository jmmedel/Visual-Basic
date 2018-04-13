Module Module1

    Sub Main()

        Try
            Dim p As New Person
            'Will cause an error, because
            'the LastName was not specified
            Console.WriteLine(p.FullName)
        Catch ex As MissingLastNameException
            Console.WriteLine("ERROR: please specify at least the last name")
        Catch ex As Exception
            Console.WriteLine("Generic error")
            Console.WriteLine(ex.ToString)
        Finally
            Console.ReadLine()
        End Try

    End Sub

End Module