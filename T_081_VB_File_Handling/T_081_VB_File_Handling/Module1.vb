'VB.Net -File Handling
'A file Is a collection Of data stored In a disk With a specific name And a directory path. When a file Is opened For reading Or writing, it becomes a stream.

'The stream Is basically the sequence Of bytes passing through the communication path. There are two main streams: the input stream And the output stream. The input stream Is used For reading data from file (read operation) And the output stream Is used For writing into the file (write operation).

'VB.Net I / O Classes
'The System.IO Namespace has various classes that are used For performing various operations With files, Like creating And deleting files, reading from Or writing To a file, closing a file, etc.

'The following table shows some commonly used non-abstract classes In the System.IO Namespace

'I/ O Class	Description
'BinaryReader	Reads primitive data from a binary stream.
'BinaryWriter	Writes primitive data In binary format.
'BufferedStream	A temporary storage For a stream Of bytes.
'Directory	Helps In manipulating a directory Structure.
'DirectoryInfo	Used For performing operations On directories.
'DriveInfo	Provides information For the drives.
'File	Helps In manipulating files.
'FileInfo	Used For performing operations On files.
'FileStream	Used To read from And write To any location In a file.
'MemoryStream	Used For random access Of streamed data stored In memory.
'Path	Performs operations On path information.
'StreamReader	Used For reading characters from a Byte stream.
'StreamWriter    Is used for writing characters to a stream.
'StringReader    Is used for reading from a string buffer.
'StringWriter    Is used for writing into a string buffer.
'The FileStream Class
'The FileStream Class In the System.IO Namespace helps In reading from, writing To And closing files. This Class derives from the abstract Class Stream.

'You need To create a FileStream Object To create a New file Or open an existing file. The syntax For creating a FileStream Object Is As follows

'Dim <object_name> As FileStream = New FileStream(<file_name>, <FileMode Enumerator>, <FileAccess Enumerator>, <FileShare Enumerator>)
'For example, for creating a FileStream object F for reading a file named sample.txt

'Dim f1 As FileStream = New FileStream("sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)

'Parameter	Description
'FileMode	
'The FileMode enumerator defines various methods For opening files. The members Of the FileMode enumerator are

'Append: It opens an existing file And puts cursor at the End Of file, Or creates the file, If the file does Not exist.

'Create: It creates a New file.

'CreateNew: It specifies To the operating system that it should create a New file.

'Open: It opens an existing file.

'OpenOrCreate: It specifies To the operating system that it should open a file If it exists, otherwise it should create a New file.

'Truncate: It opens an existing file And truncates its size To zero bytes.

'FileAccess	
'FileAccess enumerators have members: Read, ReadWrite And Write.

'FileShare	
'FileShare enumerators have the following members

'Inheritable: It allows a file handle To pass inheritance To the child processes

'None: It declines sharing Of the current file

'Read: It allows opening the file For reading

'ReadWrite: It allows opening the file For reading And writing

'Write: It allows opening the file For writing

'Example:
'The following program demonstrates use Of the FileStream Class

Imports System.IO
Module Module1

    Sub Main()
        Dim f1 As FileStream = New FileStream("sample.txt",
              FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim i As Integer
        For i = 0 To 20
            f1.WriteByte(CByte(i))
        Next i
        f1.Position = 0
        For i = 0 To 20
            Console.Write("{0} ", f1.ReadByte())
        Next i
        f1.Close()
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 -1


Advanced File Operations In VB.Net
The preceding example provides simple file operations In VB.Net. However, To utilize the immense powers Of System.IO classes, you need To know the commonly used properties And methods Of these classes.

We will discuss these classes And the operations they perform In the following sections. Please click the links provided To Get To the individual sections

Topic And Description
Reading from And Writing into Text files

It involves reading from And writing into text files. The StreamReader And StreamWriter classes help To accomplish it.

Reading from And Writing into Binary files

It involves reading from And writing into binary files. The BinaryReader And BinaryWriter classes help To accomplish this.

Manipulating the Windows file system

It gives a VB.Net programmer the ability To browse And locate Windows files And directories.

