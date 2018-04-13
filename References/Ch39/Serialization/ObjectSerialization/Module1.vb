Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap

Module Module1

    Private Sub BinarySerialization()
        Dim stringSeries As New List(Of String) From
                    {"Serialization", "demo",
                     "with VB"}

        Dim targetFile As New FileStream("C:\temp\SerializedData.dat",
                                         FileMode.Create)
        Dim formatter As New BinaryFormatter

        formatter.Serialize(targetFile, stringSeries)
        targetFile.Close()
        formatter = Nothing

        Dim sourceFile As New FileStream("C:\temp\SerializedData.dat",
                                         FileMode.Open)

        formatter = New BinaryFormatter
        Dim data = CType(formatter.Deserialize(sourceFile), 
                         List(Of String))

        sourceFile.Close()
        formatter = Nothing

        'Iterates the result
        For Each item In data
            Console.WriteLine(item)
        Next
    End Sub

    Private Sub SoapSerialization()
        Dim stringToSerialize As String = "Serialization demo with VB"

        Dim targetFile As New FileStream("C:\temp\SerializedData.xml",
                                         FileMode.Create)

        Dim formatter As New SoapFormatter
        formatter.Serialize(targetFile, stringToSerialize)
        targetFile.Close()
        formatter = Nothing

        Dim sourceFile As New FileStream("C:\temp\SerializedData.xml",
                                 FileMode.Open)

        formatter = New SoapFormatter
        Dim data = CStr(formatter.Deserialize(sourceFile))

        sourceFile.Close()
        formatter = Nothing

        Console.WriteLine(data)
    End Sub

    Sub Main()

        Dim p As New Person With {.Address = "aaa", .Age = 37, .FirstName = "Ale", .LastName = "DelSo"}
        Dim targetFile As New FileStream("C:\temp\SerializedData.dat",
                                 FileMode.Create)
        Dim formatter As New BinaryFormatter

        formatter.Serialize(targetFile, p)
        targetFile.Close()
        formatter = Nothing
        Console.ReadLine()

    End Sub

End Module
