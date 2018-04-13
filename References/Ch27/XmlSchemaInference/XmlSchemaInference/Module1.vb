Imports <xmlns:ds="DelSole.Customers">

Module Module1

    Sub Main()

        Dim custDoc = XDocument.Load("Customers.xml")

        Dim customers = From cust In custDoc...<ds:Customer>
                      Select cust.@CompanyName

    End Sub

End Module
