Public Class ContactViewModel
    Inherits ViewModelBase

    Private _currentContact As Contact
    Private _contactList As Contacts

    Public Sub New()
        Me._contactList = New Contacts
        Me.Contacts = Me._contactList.GetContacts

        SetupCommands()
    End Sub

    'Set up commands by creating instances of RelayCommand
    'and passing the appropriate delegate
    Private Sub SetupCommands()
        AddContactCommand = New RelayCommand(AddressOf AddContact)
        AddContactCommand.IsEnabled = True
    End Sub

    'Expose the command
    Public Property AddContactCommand As RelayCommand
    'Expose the list of contact
    Public Property Contacts() As ObservableCollection(Of Contact)


    'Represents the currently selected contact
    'Raise a property change notification
    'Enable the command
    Public Property CurrentContact() As Contact
        Get
            Return _currentContact
        End Get
        Set(value As Contact)
            _currentContact = value
            OnPropertyChanged("CurrentContact")
        End Set
    End Property


    'Add a new contact. In the real world, accept values
    'from the user input
    Public Sub AddContact()
        Me.Contacts.Add(New Contact With {.FirstName = "Robert", .LastName = "White",
                         .EmailAddress = "robert.white@something.com", .PhysicalAddress = "Rome",
                         .Phone = "123-456-789", .ContactID = 10})
    End Sub

End Class