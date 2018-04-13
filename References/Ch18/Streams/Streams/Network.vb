Imports System.Net.Sockets
Imports System.Text

Module Network

    Sub NetStreamDemo()
        'Instantiating TcpClient and NetworkStream
        Dim customTcpClient As New TcpClient()
        Dim customNetworkStream As NetworkStream

        Try
            'Attempt to connect to socket
            '127.0.0.1 is the local machine address
            customTcpClient.Connect("127.0.0.1", 587) 'Port
            'Gets the instance of the stream for
            'data exchange
            customNetworkStream = customTcpClient.GetStream()

            'The port is not available
        Catch ex As ArgumentOutOfRangeException
            Console.WriteLine(ex.Message)
            'Connection problem
        Catch ex As SocketException
            Console.WriteLine(ex.Message)
        End Try

        'Gets an array of byte from a value, which is
        'encoded via System.Text.Encoding.Ascii.GetBytes
        Dim bytesToWrite() As Byte = _
            Encoding.ASCII.GetBytes("Something to exchange via TCP")

        'Gets the stream instance
        customNetworkStream = customTcpClient.GetStream()
        'Writes the bytes to the stream; this
        'means sending data to the network
        customNetworkStream.Write(bytesToWrite, 0,
                                  bytesToWrite.Length)

        'Establishes the buffer size for receiving data
        Dim bufferSize As Integer = customTcpClient.
                                    ReceiveBufferSize
        Dim bufferForReceivedBytes(bufferSize) As Byte

        'Gets data from the stream, meaning by the network
        customNetworkStream.Read(bufferForReceivedBytes, 0,
                                 bufferSize)

        Dim result As String = Encoding.ASCII.GetString(bufferForReceivedBytes,
                               0, bufferSize)
    End Sub
End Module

