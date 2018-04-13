Imports TestWcfSerialization.PersonServiceReference
Imports System.IO
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.Runtime.Serialization.Json

Module Module1

    Sub Main()

        Dim client As New PersonServiceClient
        Dim p As New Person With {.FirstName = "Alessandro", .LastName = "Del Sole"}

        Dim target As New FileStream("C:\Temp\WcfSerialized.xml", FileMode.Create)
        Dim serializer As New DataContractSerializer(GetType(Person))
        Dim jsonSerializer As New DataContractJsonSerializer(GetType(Person))
        jsonSerializer.WriteObject(target, p)

        Try
            serializer.WriteObject(target, p)
        Catch ex As InvalidDataContractException
            'Data contract on the service side is wrong
        Catch ex As QuotaExceededException
            'Maximum number of serializable object exceeded
        Finally
            target.Close()
            serializer = Nothing
        End Try


        Console.ReadLine()
        Dim source As New FileStream("C:\Temp\WcfSerialized.xml", FileMode.Open)
        serializer = New DataContractSerializer(GetType(Person))

        Dim result As Person = CType(serializer.ReadObject(source), Person)

        Console.WriteLine(result.LastName)
        Console.ReadLine()
    End Sub
End Module
