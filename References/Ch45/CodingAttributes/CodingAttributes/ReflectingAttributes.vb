Imports System.Reflection

Module ReflectingAttributes

    Public Sub GetMyAttributes()
        'About members in the Document class
        Dim info As System.Reflection.MemberInfo = GetType(Document)
        'Retrieves an array of attributes
        Dim attributesList() As Object = info.GetCustomAttributes(True)

        'Enumerates applied attributes
        For i As Integer = 0 To attributesList.Length - 1
            Console.WriteLine(attributesList(i))
        Next (i)
    End Sub

    Public Sub GetMyAttributesComplex()
        Dim typeToInvestigate As Type = GetType(Document)

        ' Get the type information for the DocumentName property.
        Dim member_Info As PropertyInfo = typeToInvestigate.GetProperty("DocumentName")
        If Not (member_Info Is Nothing) Then

            'Iterate through all the attributes of the property.
            Dim attr As Attribute
            For Each attr In Attribute.GetCustomAttributes(member_Info)
                ' Check for the DocumentPropertiesAttribute attribute.
                If attr.GetType().Equals(GetType(DocumentPropertiesAttribute)) Then
                    Console.WriteLine("Author: {0}", CType(attr, 
                                      DocumentPropertiesAttribute).Author)

                    'Additional ElseIf conditions here for other attributes..
                End If
            Next attr
        End If
    End Sub

End Module
