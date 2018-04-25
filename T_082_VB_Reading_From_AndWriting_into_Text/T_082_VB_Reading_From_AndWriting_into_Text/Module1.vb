
'VB.Net -Reading from And Writing to Text Files
'The StreamReader And StreamWriter classes are used For reading from And writing data To text files. These classes inherit from the abstract base Class Stream, which supports reading And writing bytes into a file stream.

'The StreamReader Class
'The StreamReader Class also Inherits from the abstract base Class TextReader that represents a reader For reading series Of characters. The following table describes some Of the commonly used methods Of the StreamReader Class

'S.N  Method Name & Purpose
'1   
'Public Overrides Sub Close()

'    It closes the StreamReader object And the underlying stream And releases any system resources associated with the reader.

'2   
'Public Overrides Function Peek() As Integer

'    Returns the next available character but does Not consume it.

'3   
'Public Overrides Function Read() As Integer

'    Reads the next character from the input stream And advances the character position by one character.

'Example:
'    The following example demonstrates reading a text file named Jamaica.txt. The file reads

'Down the way where the nights are gay
'And the sun shines daily on the mountain top
'I took a trip on a sailing ship
'And when I reached Jamaica
'I made a stop

Imports System.IO
Module Module1

    Sub Main()
        Try
            ' Create an instance of StreamReader to read from a file. 
            ' The using statement also closes the StreamReader. 
            Using sr As StreamReader = New StreamReader("C:\Users\kagaya john\Desktop\Visual-Basic\T_082_VB_Reading_From_AndWriting_into_Text\T_082_VB_Reading_From_AndWriting_into_Text\Jamaica.txt")
                Dim line As String
                ' Read and display lines from the file until the end of  
                ' the file is reached. 
                line = sr.ReadLine()
                While (line <> Nothing)
                    Console.WriteLine(line)
                    line = sr.ReadLine()
                End While
            End Using
        Catch e As Exception
            ' Let the user know what went wrong.
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try
        Console.ReadKey()
    End Sub

End Module
