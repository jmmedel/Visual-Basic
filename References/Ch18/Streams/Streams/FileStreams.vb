Imports System.IO
Imports System.IO.Compression
Imports System.Xml


Module FileStreams

    Sub Main()
        TestCompress()
        TestDecompress()


    End Sub

    Sub TextFiles()

        Dim ts As New StreamWriter("C:\Temporary\OneFile.txt",
                                   False, System.Text.Encoding.UTF8)

        ts.WriteLine("This is a text file")
        ts.WriteLine("with multi-line example")
        ts.Close()

        ts = Nothing

        Dim rf As New StreamReader("C:\Temporary\OneFile.txt",
                                   System.Text.Encoding.UTF8)
        Dim readALine As String = rf.ReadLine
        Dim allContent As String = rf.ReadToEnd

        rf.Close()
        rf = Nothing

        Dim fs As New FileStream("C:\Temporary\OneFile.txt", FileMode.Create)
        Dim ts2 As New StreamWriter(fs)

        'Work on your file here..
        ts2.Close()
        fs.Close()
    End Sub

    Sub BinaryFiles()

        Dim fs As New FileStream("C:\Temporary\OneFile.bin", FileMode.CreateNew)
        Dim bs As New BinaryWriter(fs)

        Dim bytesToWrite() As Byte = New Byte() {128, 64, 32, 16}

        bs.Write(bytesToWrite)
        bs.Close()
        fs.Close()

        fs = Nothing
        bs = Nothing

        fs = New FileStream("C:\Temporary\OneFile.bin", FileMode.Open)
        Using br As New BinaryReader(fs)
            If fs IsNot Nothing AndAlso fs.Length > 0 Then
                Dim buffer() As Byte = br.ReadBytes(CInt(fs.Length))

            End If
        End Using
        fs.Close()

    End Sub

    Sub MemoryStreams()

        Dim ms As New MemoryStream(2048)

        Dim bs As New BinaryWriter(ms)
        bs.Write("Some text written as binary")
        bs.Close()
        ms.Close()

        'The stream must be still open
        Using br As New BinaryReader(ms)
            If ms IsNot Nothing AndAlso ms.Length > 0 Then
                Dim data As String = br.ReadString

            End If
        End Using
        ms.Close()

    End Sub


    Sub StringsStreams()

        Dim sBuilder As New Text.StringBuilder
        Dim sWriter As New StringWriter(sBuilder)

        For Each name As String In Directory.GetFiles("C:\")
            sWriter.WriteLine(name)
        Next
        sWriter.Close()

        Console.WriteLine(sBuilder.ToString)

        Dim sReader As New StringReader(sBuilder.ToString)
        Do Until sReader.Peek = -1
            Console.WriteLine(sReader.ReadLine)
        Loop
    End Sub



End Module
