Module ManagedObjects

    Sub WithObjectsDemo()
        Dim myDocument As New XDocument

        myDocument.Declaration = New XDeclaration("1.0", "utf-8", "no")

        myDocument.Add(New XComment("My first Xml document with LINQ"))

        Dim mainElement As New XElement("Contacts")

        'An Xml element with attributes
        Dim firstNestedElement As New XElement("Contact")
        Dim attribute1 As New XAttribute("LastName", "Del Sole")
        Dim attribute2 As New XAttribute("FirstName", "Alessandro")
        Dim attribute3 As New XAttribute("Age", "37")
        firstNestedElement.Add(attribute1)
        firstNestedElement.Add(attribute2)
        firstNestedElement.Add(attribute3)

        Dim secondNestedElement As New XElement("Contact")
        Dim attribute4 As New XAttribute("LastName", "White")
        Dim attribute5 As New XAttribute("FirstName", "Robert")
        Dim attribute6 As New XAttribute("Age", "40")
        secondNestedElement.Add(attribute4)
        secondNestedElement.Add(attribute5)
        secondNestedElement.Add(attribute6)

        'In-line initialization with array of XAttribute
        Dim thirdNestedElement As New XElement("Contact", New XAttribute() {
                                               New XAttribute("LastName", "Red"),
                                               New XAttribute("FirstName", "Stephen"),
                                               New XAttribute("Age", "41")})

        With mainElement
            .Add(firstNestedElement)
            .Add(secondNestedElement)
            .Add(thirdNestedElement)
        End With

        myDocument.Add(mainElement)
        'myDocument.Save("C:\Contacts.xml")

        Dim query = From element In myDocument.Descendants("Contact")
                    Let age = Integer.Parse(element.Attribute("Age").Value)
                    Where age >= 40
                    Select New With {.LastName = element.
                                                 Attribute("LastName").Value,
                                      .Age = age}


        'Returns a List(Of Contact)
        Dim contactCollection = (From element In myDocument.Descendants("Contact")
                                Let age = Integer.Parse(element.Attribute("Age").Value)
                                Select New Contact With {.FirstName = element.
                                                                      Attribute("FirstName").Value,
                                                         .LastName = element.
                                                                     Attribute("LastName").Value,
                                                         .Age = age}).ToList

        Debug.Print(myDocument.ToString)
    End Sub

End Module
