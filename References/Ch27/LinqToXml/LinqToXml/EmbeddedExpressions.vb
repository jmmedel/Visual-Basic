Module EmbeddedExpressions

    Sub LocalVariablesDemo()

        'All with type inference
        Dim FirstName = "Alessandro"
        Dim LastName = "Del Sole"
        Dim Age = 37

        Dim Contacts = <?xml version="1.0"?>
                       <Contacts>
                           <Contact LastName=<%= LastName %>
                               FirstName=<%= FirstName %>
                               Age=<%= Age %>
                               email="alessandro.delsole@visual-basic.it"/>
                           <!-- Fantasy name-->
                           <Contact LastName="White"
                               FirstName="Robert"
                               Age="45"
                               email="address1@something.com"/>
                       </Contacts>

        Console.WriteLine(Contacts.ToString)
        Console.ReadLine()
    End Sub

    Sub DynamicDocumentsDemo()
        Dim firstContact As New Contact With {.FirstName = "Alessandro",
                                              .LastName = "Del Sole",
                                              .EmailAddress = "alessandro.delsole@visual-basic.it",
                                              .Age = 37}

        'Now fantasy names
        Dim secondContact As New Contact With {.FirstName = "Stephen",
                                              .LastName = "Red",
                                              .EmailAddress = "address1@something.com",
                                              .Age = 40}
        Dim thirdContact As New Contact With {.FirstName = "Robert",
                                              .LastName = "White",
                                              .EmailAddress = "address2@something.com",
                                              .Age = 41}
        Dim fourthContact As New Contact With {.FirstName = "Luke",
                                              .LastName = "Green",
                                              .EmailAddress = "address3@something.com",
                                              .Age = 42}


        Dim people As New List(Of Contact) From {
                          firstContact,
                          secondContact,
                          thirdContact,
                          fourthContact}

        Dim newDocument = <?xml version="1.0"?>
                          <Contacts>
                              <%= From cont In people
                                  Select <Contact
                                             FirstName=<%= cont.FirstName %>
                                             LastName=<%= cont.LastName %>
                                             Age=<%= cont.Age %>
                                             Email=<%= cont.EmailAddress %>>
                                         </Contact>
                              %>
                          </Contacts>

        newDocument.Save("C:\Temp\Contacts.xml")
        Debug.WriteLine(newDocument.ToString)

        'Use anonymous iterators
        Dim doc = <?xml version="1.0"?>
                  <Contacts>
                      <%= (Iterator Function()
                               For Each person In people
                                   Yield person
                               Next
                           End Function)().
                          Select(Function(c) <Contact LastName=<%= c.LastName %>>
                                             </Contact>) %>
                  </Contacts>
    End Sub


    Sub QueryingDocumentsDemo()

        Dim doc = <?xml version="1.0" encoding="utf-8"?>
                  <Contacts>
                      <Contact FirstName="Alessandro"
                          LastName="Del Sole"
                          Age="37"
                          Email="alessandro.delsole@visual-basic.it">
                      </Contact>
                      <!--The following are fantasy names-->
                      <Contact FirstName="Stephen"
                          LastName="Red"
                          Age="40"
                          Email="address1@something.com">
                      </Contact>
                      <Contact FirstName="Robert"
                          LastName="White"
                          Age="41"
                          Email="address2@something.com">
                      </Contact>
                      <Contact FirstName="Luke"
                          LastName="Green"
                          Age="42"
                          Email="address3@something.com">
                      </Contact>
                      <Person FirstName="Alessandro"
                          LastName="Del Sole">
                      </Person>
                  </Contacts>

        Dim query = From cont In doc.<Contacts>.<Contact>
                    Where Integer.Parse(cont.@Age) >= 40
                    Select cont

        Dim doc2 = <?xml version="1.0" encoding="utf-8"?>
                   <Contacts>
                       <Contact>
                           <FirstName>Alessandro</FirstName>
                           <LastName>Del Sole</LastName>
                           <Age>32</Age>
                           <Email>alessandro.delsole@visual-basic.it</Email>
                       </Contact>
                       <Contact>
                           <FirstName>Stephen</FirstName>
                           <LastName>Red</LastName>
                           <Age>40</Age>
                           <Email>address1@something.com</Email>
                       </Contact>
                   </Contacts>


        'Returns a collection of all <LastName></LastName>
        'elements within the document
        Dim onlyLastNames = From cont In doc2...<LastName>
    End Sub

End Module

Class Contact
    Property FirstName As String
    Property LastName As String
    Property Age As Integer
    Property EmailAddress As String
End Class
