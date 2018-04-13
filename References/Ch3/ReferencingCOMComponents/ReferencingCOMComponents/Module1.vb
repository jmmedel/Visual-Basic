Module Module1
    Sub Main()

        Console.WriteLine("Type the name of a media file:")
        Dim fileName As String = Console.ReadLine

        Dim wmp As New WMPLib.WindowsMediaPlayer
        wmp.openPlayer(fileName)
    End Sub
End Module
