Imports System.IO
Imports System.Security.Permissions

Module Module1

    Sub Main()

        'PathDemo()
        'DirDemo()
        DriveInfoDemo()
        Console.ReadLine()
    End Sub

    Sub PathDemo()
        'Returns ".txt"
        Dim extension As String = Path.GetExtension("C:\TextFile.txt")
        'Returns "TextFile.txt"
        Dim fileName As String = Path.GetFileName("C:\TextFile.txt")
        'Returns "TextFile"
        Dim noExtension As String = Path.
                                    GetFileNameWithoutExtension("C:\TextFile.txt")
        'Returns "C:\Users\Alessandro\My Documents\"
        Dim dirName As String = Path.
                                GetDirectoryName("C:\Users\Alessandro\My Documents\Document.txt")

        'Returns "MyFile.Doc"
        Dim extReplaced As String = Path.ChangeExtension("MyFile.Txt", ".doc")

        Dim temporaryWinFolder As String = Path.GetTempPath
        Dim temporaryFile As String = Path.GetTempFileName
        Dim randomFile As String = Path.GetRandomFileName

    End Sub

    Sub FileDemo()


        File.WriteAllText("C:\Temp\OneFile.txt", "Test message")
        Dim lines2() As String = {"First", "Second", "Third"}
        File.WriteAllLines("C:\Temp\OneFile.txt", lines2)

        File.WriteAllBytes("C:\Temp\OneFile.bin", New Byte() {1, 2, 3, 4})

        Dim text As String = File.ReadAllText("C:\Temp\OneFile.txt")
        Dim fileLines() As String = File.ReadAllLines("C:\Temp\OneFile.txt")

        Dim bytes() As Byte = File.ReadAllBytes("C:\Temp\OneFile.bin")

        Dim lines As IEnumerable(Of String) = _
                     New String() {"First", "Second", "Third"}.AsEnumerable
        File.AppendAllLines("C:\Temporary\Test.txt", lines)
        File.AppendAllText("C:\Temporary\Text.txt",
                           "All text is stored within a string")

        File.Copy("Source.txt", "Target.txt")

        Dim myFile As FileStream = File.Create("C:\Temp\OneFile.bin", 1024, FileOptions.Asynchronous)
        myFile.Write(New Byte() {1, 2, 3, 4}, 0, 1024)
        myFile.Close()

        Dim myText As StreamWriter = File.CreateText("C:\Temp\OneFile.txt")
        myText.WriteLine("Test message")
        myText.Close()
        File.Delete("C:\Temp\OneFile.txt")
        File.Encrypt("C:\Temp\OneFile.txt")
        File.Decrypt("C:\Temp\OneFile.txt")

        File.Replace("C:\Temp\Source.Txt", "C:\Temp\Target.txt", "C:\Temp\Backup.txt")

    End Sub

    Sub DriveInfoDemo()
        Dim dr As New DriveInfo("C:\")

        Console.WriteLine("Drive type: {0}", dr.DriveType.ToString)
        Console.WriteLine("Volume label: {0}", dr.VolumeLabel)
        Console.WriteLine("Total disk space: {0}", dr.TotalSize.ToString)
        Console.WriteLine("Available space: {0}", dr.AvailableFreeSpace.ToString)
        dr = Nothing
    End Sub

    Sub FileInfoDemo()
        Dim fi As New FileInfo("C:\MyFile.txt")

        fi.Attributes = FileAttributes.System Or FileAttributes.Hidden
    End Sub

    Sub DirDemo()
        If Not Directory.Exists("C:\Test") Then
            Directory.CreateDirectory("C:\Test")
        End If

        Directory.Move("C:\Test", "C:\Demo")

        Dim createdDate As Date = Directory.GetCreationTime("C:\Demo")
        Directory.SetCreationTime("C:\Demo", New Date(2015, 3, 12))
        Directory.SetLastAccessTime("C:\Demo", Date.Now)

        'get files
        Dim filesEnumerable As IEnumerable(Of String) = _
                               Directory.EnumerateFiles("C:\", "*.exe")

        For Each item In filesEnumerable
            Console.WriteLine("File name: {0}", item)
        Next

        'Second argument is optional, specifies a pattern for search
        Dim filesArray() As String = Directory.GetFiles("C:\", "*.exe")
        'Must be empty
        'Directory.Delete("C:\Demo")
        Dim currentFolder As String = Directory.GetCurrentDirectory
        Dim drivesOnMyMachine() As String = Directory.
                                            GetLogicalDrives
        For Each drive In drivesOnMyMachine
            Debug.WriteLine(drive)
        Next
    End Sub

    Sub DirInfoDemo()

        Dim di As New DirectoryInfo("C:\Demo")

        di.Attributes = FileAttributes.Hidden Or FileAttributes.ReadOnly

        Dim directoryFullName As String = di.FullName
        Dim directoryName As String = di.Name


        di.Delete()
    End Sub

    Sub PermissionDemo()

        Dim fp As New FileIOPermission(PermissionState.None)
        fp.AllLocalFiles = FileIOPermissionAccess.Read
        Try
            fp.Demand()
        Catch ex As Security.SecurityException
            Console.WriteLine("You have no permission for local files")
        Catch ex As Exception

        End Try
    End Sub

End Module

Class MyFileList
    Inherits List(Of FileInfo)
End Class

Module FileInfoDemo

    Sub FileInfoDemo()

        'An instance of the collection
        Dim customList As New MyFileList

        'Create a FileInfo for each .exe file
        'in the specified directory
        For Each itemName As String In _
            Directory.EnumerateFiles("C:\", "*.exe")

            Dim fileReference As New FileInfo(itemName)
            customList.Add(fileReference)
        Next

        'Iterate the collection
        For Each item In customList
            Console.WriteLine("File: {0}, length: {1}, created on: {2}",
                              item.Name, item.Length, item.CreationTime)
        Next
    End Sub
End Module