Imports System.IO.Compression
Imports System.IO

Module Module1

    Sub Main()

        '* Uncomment the following block to use the shortened syntax *'
        'ZipFile.CreateFromDirectory("C:\temp", "C:\ZippedTemp.zip", CompressionLevel.Optimal, True)
        'Console.ReadLine()
        'ZipFile.ExtractToDirectory("C:\ZippedDemo.zip", "C:\temp")

        Using zipArc As ZipArchive = ZipFile.Open("C:\temp\Northwind.zip", ZipArchiveMode.Read)
            For Each item As ZipArchiveEntry In zipArc.Entries
                Console.WriteLine("{0}, Compressed size: {1}, ",
                                  item.FullName,
                                  item.CompressedLength.ToString)
            Next
        End Using
        Console.ReadLine()

        Using zipArc As ZipArchive = ZipFile.Open("C:\Temp\NewZipped.zip", ZipArchiveMode.Create)
            zipArc.CreateEntry("C:\Temp\Northwind.sdf", CompressionLevel.NoCompression)
        End Using

        Using zipArc As ZipArchive = ZipFile.Open("C:\Temp\NewZipped.zip", ZipArchiveMode.Update)
            zipArc.CreateEntry("C:\Temp\AnotherFile.txt", CompressionLevel.Fastest)
            'Get the specified entry
            Dim entry As ZipArchiveEntry = zipArc.GetEntry("Northwind.sdf")
            'Delete the entry from the archive
            entry.Delete()
        End Using
        Console.ReadLine()
    End Sub

End Module
