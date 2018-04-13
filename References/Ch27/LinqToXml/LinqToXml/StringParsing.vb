Module StringParsing

    Sub Parse()

        Dim document As String = "<?xml version=""1.0""?>" & Environment.NewLine &
                                "    <Contacts>" & Environment.NewLine &
                                "       <Contact FirstName=""Alessandro"" LastName=""Del Sole"" Age=""37""/>" &
                                Environment.NewLine &
                                "       <Contact FirstName=""Robert"" LastName=""White"" Age=""40""/>" &
                                Environment.NewLine &
                                "   </Contacts>"

        Dim resultingDocument As XDocument = XDocument.Parse(document)
        resultingDocument.Save("C:\Contacts.xml")

        Console.WriteLine(resultingDocument.ToString)
    End Sub

End Module
