Imports System.Xml.Serialization
Imports System.IO

Module Module1

    Sub Main()
        Dim stringSeries As New List(Of String) From
        {"Serialization", "demo",
        "with VB"}
        Dim targetFile As New FileStream("C:\temp\SerializedData.xml",
                                         FileMode.Create)
        Dim formatter As New XmlSerializer(GetType(List(Of String)))

        formatter.Serialize(targetFile, stringSeries)
        targetFile.Close()
        formatter = Nothing

        Dim sourceFile As New FileStream("C:\temp\SerializedData.xml",
                                         FileMode.Open)

        formatter = New XmlSerializer(GetType(List(Of String)))
        Dim data = CType(formatter.Deserialize(sourceFile), 
                         List(Of String))

        sourceFile.Close()
        formatter = Nothing

        'Iterates the result
        For Each item In data
            Console.WriteLine(item)
        Next
        Console.ReadLine()

    End Sub

End Module
