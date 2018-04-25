'The StreamWriter Class
'The StreamWriter Class Inherits from the abstract Class TextWriter that represents a writer, which can write a series Of character.

'The following table shows some Of the most commonly used methods Of this Class

'S.N  Method Name & Purpose
'1   Public Overrides Sub Close 
'Closes the current StreamWriter Object And the underlying stream.
'2   
'Public Overrides Sub Flush()

'    Clears all buffers for the current writer And causes any buffered data to be written to the underlying stream.

'3   
'Public Overridable Sub Write(value As Boolean)

'    Writes the text representation of a Boolean value to the text string Or stream. (Inherited from TextWriter.)

'4   
'Public Overrides Sub Write(value As Char)

'    Writes a character to the stream.

'5   
'Public Overridable Sub Write(value As Decimal)

'    Writes the text representation of a decimal value to the text string Or stream.

'6   
'Public Overridable Sub Write(value As Double)

'    Writes the text representation of an 8-byte floating-point value to the text string Or stream.

'7   
'Public Overridable Sub Write(value As Integer)

'    Writes the text representation of a 4-byte signed integer to the text string Or stream.

'8   
'Public Overrides Sub Write(value As String)

'    Writes a string to the stream.

'9   
'Public Overridable Sub WriteLine()

'    Writes a line terminator to the text string Or stream.

'the above list Is Not exhaustive. For complete list of methods please visit Microsoft's documentation

'Example:
'    the following example demonstrates writing text data into a file using the StreamWriter class:



Imports System.IO
Module Module1

    Sub Main()
        Dim names As String() = New String() {"Zara Ali",
         "Nuha Ali", "Amir Sohel", "M Amlan"}
        Dim s As String
        Using sw As StreamWriter = New StreamWriter("names.txt")
            For Each s In names
                sw.WriteLine(s)
            Next s
        End Using
        ' Read and show each line from the file. 
        Dim line As String
        Using sr As StreamReader = New StreamReader("names.txt")
            line = sr.ReadLine()
            While (line <> Nothing)
                Console.WriteLine(line)
                line = sr.ReadLine()
            End While
        End Using
        Console.ReadKey()
    End Sub

End Module

'When the above code Is compiled And executed, it produces the following result:

'Zara Ali
'Nuha Ali
'Amir Sohel
'M Amlan
