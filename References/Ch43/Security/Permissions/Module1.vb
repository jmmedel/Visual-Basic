Imports System.Security.Permissions

Module Module1

    Sub Main()

        Dim fp As New FileIOPermission(PermissionState.Unrestricted)
        Try
            fp.Demand()

        Catch ex As Security.SecurityException

        End Try

        Dim doc As XDocument = XmlParse.String2Xml("MyTextDoc.txt")
    End Sub

End Module

'The caller code will need the FileIOPermission permission
'with unrestricted access otherwise it will fail
<FileIOPermission(Security.Permissions.SecurityAction.Demand,
                  Unrestricted:=True)>
Class XmlParse

    Shared Function String2Xml(ByVal fileName As String) As XDocument
        'Expects an Xml-formatted string
        If String.IsNullOrEmpty(fileName) Then
            Throw New ArgumentNullException("fileName")
        End If
        Return XDocument.Parse(fileName)
    End Function
End Class