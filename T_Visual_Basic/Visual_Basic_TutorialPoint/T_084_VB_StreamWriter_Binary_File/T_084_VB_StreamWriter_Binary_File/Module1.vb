

'VB.Net -Binary Files
'The BinaryReader And BinaryWriter classes are used For reading from And writing To a binary file.

'The BinaryReader Class
'The BinaryReader Class Is used To read binary data from a file. A BinaryReader Object Is created by passing a FileStream Object To its constructor.

'The following table shows some Of the commonly used methods Of the BinaryReader Class.

'S.N  Method Name & Purpose
'1   
'Public Overridable Sub Close()

'    It closes the BinaryReader object And the underlying stream.

'2   
'Public Overridable Function Read() As Integer

'    Reads the characters from the underlying stream And advances the current position of the stream.

'3   
'Public Overridable Function ReadBoolean() As Boolean

'    Reads a Boolean value from the current stream And advances the current position of the stream by one byte.

'4   
'Public Overridable Function ReadByte() As Byte

'    Reads the next byte from the current stream And advances the current position of the stream by one byte.

'5   
'Public Overridable Function ReadBytes(count As Integer) As Byte()

'    Reads the specified number of bytes from the current stream into a byte array And advances the current position by that number of bytes.

'6   
'Public Overridable Function ReadChar() As Char

'    Reads the next character from the current stream And advances the current position of the stream in accordance with the Encoding used And the specific character being read from the stream.

'7   
'Public Overridable Function ReadChars(count As Integer) As Char()

'    Reads the specified number Of characters from the current stream, returns the data In a character array, And advances the current position in accordance with the Encoding used And the specific character being read from the stream.

'8   
'Public Overridable Function ReadDouble() As Double

'    Reads an 8-byte floating point value from the current stream And advances the current position of the stream by eight bytes.

'9   
'Public Overridable Function ReadInt32() As Integer

'    Reads a 4-byte signed integer from the current stream And advances the current position of the stream by four bytes.

'10  
'Public Overridable Function ReadString() As String

'    Reads a String from the current stream. The String Is prefixed With the length, encoded as an integer seven bits at a time.

'The BinaryWriter Class
'The BinaryWriter class Is used to write binary data to a stream. A BinaryWriter object Is created by passing a FileStream object to its constructor.

'The following table shows some of the commonly used methods of the BinaryWriter class.

'S.N  Function() Name & Description
'1   
'Public Overridable Sub Close()

'    It closes the BinaryWriter object And the underlying stream.

'2   
'Public Overridable Sub Flush()

'    Clears all buffers for the current writer And causes any buffered data to be written to the underlying device.

'3   
'Public Overridable Function Seek(offset As Integer, origin As SeekOrigin) As Long

'    Sets the position within the current stream.

'4   
'Public Overridable Sub Write(value As Boolean)

'    Writes a one-Byte Boolean value To the current stream, with 0 representing false And 1 representing true.

'5   
'Public Overridable Sub Write(value As Byte)

'    Writes an unsigned byte to the current stream And advances the stream position by one byte.

'6   
'Public Overridable Sub Write(buffer As Byte())

'    Writes a byte array to the underlying stream.

'7   
'Public Overridable Sub Write(ch As Char)

'    Writes a Unicode character to the current stream And advances the current position of the stream in accordance with the Encoding used And the specific characters being written to the stream.

'8   
'Public Overridable Sub Write(chars As Char())

'    Writes a character array to the current stream And advances the current position of the stream in accordance with the Encoding used And the specific characters being written to the stream.

'9   
'Public Overridable Sub Write(value As Double)

'    Writes an eight-byte floating-point value to the current stream And advances the stream position by eight bytes.

'10  
'Public Overridable Sub Write(value As Integer)

'    Writes a four-byte signed integer to the current stream And advances the stream position by four bytes.

'11  
'Public Overridable Sub Write(value As String)

'    Writes a length-prefixed string to this stream in the current encoding of the BinaryWriter And advances the current position of the stream in accordance with the encoding used And the specific characters being written to the stream.

'For complete list of methods, please visit Microsoft's documentation.
Imports System.IO

Module Module1

    Sub Main()
        Dim bw As BinaryWriter
        Dim br As BinaryReader
        Dim i As Integer = 25
        Dim d As Double = 3.14157
        Dim b As Boolean = True
        Dim s As String = "I am happy"
        'create the file
        Try
            bw = New BinaryWriter(New FileStream("mydata", FileMode.Create))
        Catch e As IOException
            Console.WriteLine(e.Message + "\n Cannot create file.")
            Return
        End Try
        'writing into the file
        Try
            bw.Write(i)
            bw.Write(d)
            bw.Write(b)
            bw.Write(s)
        Catch e As IOException
            Console.WriteLine(e.Message + "\n Cannot write to file.")
            Return
        End Try
        bw.Close()
        'reading from the file
        Try
            br = New BinaryReader(New FileStream("mydata", FileMode.Open))
        Catch e As IOException
            Console.WriteLine(e.Message + "\n Cannot open file.")
            Return
        End Try
        Try
            i = br.ReadInt32()
            Console.WriteLine("Integer data: {0}", i)
            d = br.ReadDouble()
            Console.WriteLine("Double data: {0}", d)
            b = br.ReadBoolean()
            Console.WriteLine("Boolean data: {0}", b)
            s = br.ReadString()
            Console.WriteLine("String data: {0}", s)
        Catch e As IOException
            Console.WriteLine(e.Message + "\n Cannot read from file.")
            Return
        End Try
        br.Close()
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'Integer data:  25
'Double data:  3.14157
'Boolean data:  True
'String data: I am happy