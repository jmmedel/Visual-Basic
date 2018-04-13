Imports System.IO
Imports System.Xaml

Module Module1

    Sub Main()

        Dim oneFriend As New Person With {.LastName = "White",
                                          .FirstName = "Robert", .Age = 35}
        Dim anotherFriend As New Person With {.LastName = "Red",
                                              .FirstName = "Stephen", .Age = 42}

        Dim p As New Person With {.LastName = "Del Sole", .FirstName = "Alessandro",
                                  .Age = 32,
                                  .Friends = New List(Of Person) _
                                             From {oneFriend, anotherFriend}}

        Using target As New FileStream("C:\Temp\Person.xaml", FileMode.Create)
            XamlServices.Save(target, p)
        End Using

        Console.ReadLine()

        Using source As New FileStream("C:\temp\person.xaml", FileMode.Open)
            Dim result As Person = CType(XamlServices.Load(source), Person)

            'Shows:
            'White
            'Green
            For Each p In result.Friends
                Console.WriteLine(p.LastName)
            Next
            Console.ReadLine()
        End Using
    End Sub

End Module

