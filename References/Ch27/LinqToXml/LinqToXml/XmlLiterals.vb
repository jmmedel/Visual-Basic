Module XmlLiterals

    Sub LiteralsDemo()
        'The Compiler infers XDocument
        Dim Contacts = <?xml version="1.0"?>
                       <Contacts>
                           <Contact LastName="Del Sole"
                               FirstName="Alessandro"
                               Age="37"
                               email="alessandro.delsole@visual-basic.it"/>
                           <!-- Fantasy name-->
                           <Contact LastName="White"
                               FirstName="Robert"
                               Age="45"
                               email="address1@something.com"/>
                           <Contact LastName="Red"
                               Age="44"
                               email="address1@something.com"/>
                       </Contacts>

        Dim x = Contacts?...<Contact> ?.First?.@email
        Console.ReadLine()
    End Sub
End Module
