Imports System.IO

Module Module1

    Sub Main()

    End Sub
    Private Sub OpenStreamAsync()
        Dim someBytes(1000) As Byte
        Dim randomGenerator As New Random()
        randomGenerator.NextBytes(someBytes)

        Using fs As New FileStream("Somedata.dat", FileMode.Create, FileAccess.Write)
            Dim result As IAsyncResult =
                fs.BeginWrite(someBytes, 0, someBytes.Length,
                              AddressOf fs_EndWrite, fs)
        End Using

    End Sub

    Private Sub fs_EndWrite(result As IAsyncResult)
        Dim stream As FileStream = CType(result.AsyncState, FileStream)
        stream.EndWrite(result)
        'Additional work goes here...
    End Sub
End Module
