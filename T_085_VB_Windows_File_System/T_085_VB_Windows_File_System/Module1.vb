
'VB.Net -Windows File System
'VB.Net allows you To work With the directories And files Using various directory And file-related classes Like, the DirectoryInfo class And the FileInfo class.

'The DirectoryInfo Class
'The DirectoryInfo Class Is derived from the FileSystemInfo Class. It has various methods For creating, moving, And browsing through directories And subdirectories. This Class cannot be inherited.

'Following are some commonly used properties Of the DirectoryInfo Class

'S.N  Property Name & Description
'1   
'Attributes

'Gets the attributes For the current file Or directory.

'2   
'CreationTime

'Gets the creation time Of the current file Or directory.

'3   
'Exists

'Gets a Boolean value indicating whether the directory exists.

'4   
'Extension

'Gets the String representing the file extension.

'5   
'FullName

'Gets the full path Of the directory Or file.

'6   
'LastAccessTime

'Gets the time the current file Or directory was last accessed.

'7   
'Name

'Gets the name Of this DirectoryInfo instance.

'Following are some commonly used methods Of the DirectoryInfo Class

'S.N  Method Name & Purpose
'1   
'Public Sub Create()

'    Creates a directory.

'2   
'Public Function CreateSubdirectory(path As String) As DirectoryInfo

'    Creates a subdirectory Or subdirectories on the specified path. The specified path can be relative to this instance of the DirectoryInfo class.

'3   
'Public Overrides Sub Delete()

'    Deletes this DirectoryInfo if it Is empty.

'4   
'Public Function GetDirectories() As DirectoryInfo()

'    Returns the subdirectories of the current directory.

'5   
'Public Function GetFiles() As FileInfo()

'    Returns a file list from the current directory.

'For complete list of properties And methods please visit Microsoft's documentation.

'the FileInfo Class
'the FileInfo Class Is derived from the FileSystemInfo Class. It has properties And instance methods For creating, copying, deleting, moving, And opening Of files, And helps in the creation of FileStream objects. This class cannot be inherited.

'Following are some commonly used properties of the FileInfo class

'S.N  Property Name & Description
'1   
'Attributes

'        Gets the attributes for the current file.

'2   
'CreationTime

'        Gets the creation time of the current file.

'3   
'Directory

'        Gets an instance Of the directory, which the file belongs to.

'4   
'Exists

'        Gets a Boolean value indicating whether the file exists.

'5   
'Extension

'        Gets the string representing the file extension.

'6   
'FullName

'        Gets the full path of the file.

'7   
'LastAccessTime

'        Gets the time the current file was last accessed.

'8   
'LastWriteTime

'        Gets the time of the last written activity of the file.

'9   
'Length

'        Gets the size, in bytes, of the current file.

'10  
'Name

'        Gets the name of the file.

'Following are some commonly used methods of the FileInfo class

'S.N  Method Name & Purpose
'1   
'Public Function AppendText() As StreamWriter

'    Creates a StreamWriter that appends text to the file represented by this instance of the FileInfo.

'2   
'Public Function Create() As FileStream

'    Creates a file.

'3   
'Public Overrides Sub Delete()

'    Deletes a file permanently.

'4   
'Public Sub MoveTo(destFileName As String)

'    Moves a specified file To a New location, providing the option to specify a New file name.

'5   
'Public Function Open(mode As FileMode) As FileStream

'    Opens a file in the specified mode.

'6   
'Public Function Open(mode As FileMode, access As FileAccess) As FileStream

'    Opens a file In the specified mode With read, Write, Or read / Write() access.

'7   
'Public Function Open(mode As FileMode, access As FileAccess, share As FileShare) As FileStream

'    Opens a file In the specified mode With read, Write, Or read / Write() access And the specified sharing option.

'8   
'Public Function OpenRead() As FileStream

'    Creates a read-only FileStream

'9   
'Public Function OpenWrite() As FileStream

'    Creates a write-only FileStream.

'For complete list of properties And methods, please visit Microsoft's documentation
Imports System.IO
Module Module1

    Sub Main()
        'creating a DirectoryInfo object
        Dim mydir As DirectoryInfo = New DirectoryInfo("C:\Users\kagaya john\Desktop\Visual-Basic")
        ' getting the files in the directory, their names and size
        Dim f As FileInfo() = mydir.GetFiles()
        Dim file As FileInfo
        For Each file In f
            Console.WriteLine("File Name: {0} Size: {1}  ", file.Name, file.Length)
        Next file
        Console.ReadKey()
    End Sub

End Module
