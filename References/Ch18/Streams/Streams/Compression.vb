Imports System.IO
Imports System.IO.Compression

Module Compression

    Sub TestCompress()
        Try
            Compress("C:\Temp\Source.Txt",
                     "C:\Temp\Compressed.gzp")
        Catch ex As FileNotFoundException
            Console.WriteLine("File not found!")
        Catch ex As IOException
            Console.WriteLine("An input/output error has occurred:")
            Console.WriteLine(ex.Message)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub TestDecompress()
        Try
            Decompress("C:\Temp\Compressed.gzp",
                       "C:\Temp\Original.txt")

        Catch ex As FileNotFoundException
            Console.WriteLine("File not found!")
        Catch ex As IOException
            Console.WriteLine("An input/output error has occurred:")
            Console.WriteLine(ex.Message)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub Compress(ByVal inputName As String, ByVal outputName As String)

        'Instantiates a new FileStream
        Dim infile As FileStream

        Try
            'The Stream points to the specified input file
            infile = New FileStream(inputName, FileMode.Open, FileAccess.Read,
                                    FileShare.Read)

            'Stores the file length in a buffer
            Dim buffer(CInt(infile.Length - 1)) As Byte

            'Checks if the file can be read and assigns to the "count"
            'variable the result of reading the file
            Dim count As Integer = infile.Read(buffer, 0, buffer.Length)

            'If the number of read byte is different from the file length
            'throws an exception
            If count <> buffer.Length Then
                infile.Close()
                Throw New IOException
            End If
            'closes the stream
            infile.Close()
            infile = Nothing

            'Creates a new stream pointing to the output file
            Dim ms As New FileStream(outputName, FileMode.CreateNew,
                                     FileAccess.Write)

            'Creates a new GZipStream for compressing, pointing to
            'the output stream above leaving it open
            Dim compressedzipStream As New GZipStream(ms,
                                                      CompressionMode.Compress,
                                                      True)
            'Puts the buffer into the new stream, which is
            'automatically compressed
            compressedzipStream.Write(buffer, 0, buffer.Length)

            compressedzipStream.Close()
            ms.Close()
            Exit Sub
        Catch ex As IO.FileNotFoundException
            Throw
        Catch ex As IOException
            Throw
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Sub Decompress(ByVal fileName As String, ByVal originalName As String)

        Dim inputFile As FileStream

        'Defining the stream for decompression
        Dim compressedZipStream As GZipStream

        'Defining a variable for storing compressed file size
        Dim compressedFileSize As Integer

        Try

            'Reads the input file
            inputFile = New FileStream(fileName,
                                       FileMode.Open,
                                       FileAccess.Read,
                                       FileShare.Read)

            'Reads input file's size
            compressedFileSize = CInt(inputFile.Length)

            'Creates a new GZipStream in Decompress mode
            compressedZipStream = New GZipStream(inputFile,
                                                 CompressionMode.Decompress)

            'In compressed data the first 100 bytes store the original
            'data size, so let's get it
            Dim offset As Integer = 0
            Dim totalBytes As Integer = 0

            Dim SmallBuffer(100) As Byte

            'Reads until there are available bytes in the first 100
            'and increments variables that we'll need for sizing
            'the buffer that will store the decompressed file
            Do While True

                Dim bytesRead As Integer = compressedZipStream.
                                           Read(SmallBuffer, 0, 100)
                If bytesRead = 0 Then
                    Exit Do
                End If

                offset += bytesRead
                totalBytes += bytesRead
            Loop

            compressedZipStream.Close()
            compressedZipStream = Nothing

            'Creates a new FileStream for reading the input file
            inputFile = New FileStream(fileName,
                                       FileMode.Open,
                                       FileAccess.Read,
                                       FileShare.Read)

            'and decompress its content
            compressedZipStream = New GZipStream(inputFile,
                                                 CompressionMode.Decompress)

            'Declares the buffer that will store uncompressed data
            Dim buffer(totalBytes) As Byte

            'Reads from the source file the number of bytes
            'representing the buffer length, taking advantage
            'of the original size
            compressedZipStream.Read(buffer, 0, totalBytes)

            compressedZipStream.Close()
            compressedZipStream = Nothing

            'Creates a new file for putting uncompressed
            'data
            Dim ms As New FileStream(originalName,
                                     FileMode.Create,
                                     FileAccess.Write)

            'Writes uncompressed data to file
            ms.Write(buffer, 0, buffer.Length)
            ms.Close()
            ms = Nothing
            Exit Sub

            'General IO error 
        Catch ex As IOException
            Throw
        Catch ex As Exception
            Throw
            Exit Try
        End Try
    End Sub
End Module
