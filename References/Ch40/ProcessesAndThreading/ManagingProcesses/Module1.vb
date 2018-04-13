Module Module1

    Sub Main()

        Process.Start("Notepad.exe")
        Process.Start("Notepad.exe", "C:\aFile.txt")

        Dim procInfo As New ProcessStartInfo
        With procInfo
            .FileName = "Notepad.exe"
            .Arguments = "aFile.txt"
            .WorkingDirectory = "C:\"
            .WindowStyle = ProcessWindowStyle.Maximized
            .ErrorDialog = True           
        End With

        Dim proc As New Process
        proc.StartInfo = procInfo
        proc.Start()

        'Waits for two seconds
        proc.WaitForExit(2000)

        'Kills the process
        proc.Kill()

        Dim processesList = From p In Process.GetProcesses
                            Select p.ProcessName

        For Each procName In processesList
            Console.WriteLine(procName)
        Next
    End Sub

End Module
