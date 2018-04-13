Public Class Contacts
    Private _contacts As ObservableCollection(Of Contact)

    Public Sub New()
        Me._contacts = New ObservableCollection(Of Contact)
        'Create some sample data
        Me._contacts.Add(New Contact With {.ContactID = 1, .FirstName =
"Alessandro",
                                           .LastName = "Del Sole",
                                           .EmailAddress =
                                           "alessandro.delsole@visual-basic.it",
                                           .Phone = "111-111-111",
                                           .PhysicalAddress = "Cremona"})

        Me._contacts.Add(New Contact With {.ContactID = 2, .FirstName = "Renato",
                                            .LastName = "Marzaro",
                                            .EmailAddress =
                                            "renato.marzaro@visual-basic.it",
                                            .Phone = "222-111-111",
                                            .PhysicalAddress = "Varese"})

        Me._contacts.Add(New Contact With {.ContactID = 3, .FirstName = "Diego",
                                            .LastName = "Cattaruzza",
                                            .EmailAddress =
                                            "dcattaruzza@visual-basic.it",
                                            .Phone = "222-222-111",
                                            .PhysicalAddress = "Trieste"})

        Me._contacts.Add(New Contact With {.ContactID = 4, .FirstName = "Antonio",
                                            .LastName = "Catucci",
                                            .EmailAddress =
                                            "antonio.catucci@visual-basic.it",
                                            .Phone = "222-111-222",
                                            .PhysicalAddress = "Milan"})

    End Sub

    Public Function GetContacts() As ObservableCollection(Of Contact)
        Return Me._contacts
    End Function
End Class
