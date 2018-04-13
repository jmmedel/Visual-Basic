'Declared at namespace level
Public Delegate Function IsValidMailAddress(ByVal emailAddress _
                                            As String) As Boolean

Public Delegate Sub WriteTextMessage(ByVal textMessage As String)

Module MulticastDelegatesDemo
    Private textWriter As New WriteTextMessage(AddressOf WriteSomething)
    Private complexWriter As New WriteTextMessage(AddressOf _
                                                  WriteSomethingMoreComplex)


    Private Sub WriteSomething(ByVal text As String)
        Debug.Print("Simply report your text: {0}", text)
    End Sub

    Private Sub WriteSomethingMoreComplex(ByVal text As String)
        Debug.Print("Today is {0} and you wrote {1}",
                          Date.Today.ToShortDateString, text)
    End Sub

    'Because Combine returns System.Delegate, with Option Strict On
    'an explicit conversion is required.
    Friend CombinedDelegate As WriteTextMessage = CType(System.Delegate.
                                                   Combine(textWriter,
                                                   complexWriter), 
                                                   WriteTextMessage)
End Module

Module DelegatesDemo

    'The method's signature is the same of the delegate: correct
    Function CheckMailAddress(ByVal emailAddress As String) As Boolean

        'Validates emails via regular expressions, according to the
        'following pattern
        Dim validateMail As String = "^([\w-\.]+)@((\[[0-9]{1,3}\." & _
            "[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-z]{2,4}|[0-9]{1,3})(\]?)$"

        Return Text.RegularExpressions.Regex.IsMatch(emailAddress, validateMail)
    End Function

    Function CheckMailAddressBasic(ByVal emailAddress As String) As Boolean
        Return emailAddress.Contains("@")
    End Function


    Sub Main()

        MulticastDelegatesDemo.CombinedDelegate.Invoke("Test message")

        'Creates an instance of the delegate and points to
        'the specified method
        Dim mailCheck As IsValidMailAddress
        mailCheck = New IsValidMailAddress(AddressOf CheckMailAddress)

        'Alternative syntax: if you already declared
        'an instance, you can simply do this assignment
        mailCheck = AddressOf CheckMailAddressBasic

        'No changes here!
        'Dim result As Boolean = mailCheck.
        'Invoke("alessandro.delsole@visual-basic.it")
        Dim result As Boolean = mailCheck("alessandro.delsole@visual-basic.it")
        Console.WriteLine("Is valid: {0}", result)

        TestEvent()

    End Sub

    Sub TestEvent()
        Dim p As New Person2
        AddHandler p.LastNameChanged,
                   AddressOf personEventHandler
        p.LastName = "Del Sole"
        Console.ReadLine()
    End Sub

    Private Sub personEventHandler(ByVal sender As Object,
                                   ByVal e As LastNameChangedEventArgs)

        Dim raisingPerson As Person2 = DirectCast(sender, Person2)
        Console.WriteLine("LastName property was changed")
        Console.WriteLine("Last name contains blank spaces: " & e.ContainsBlank)
    End Sub
End Module