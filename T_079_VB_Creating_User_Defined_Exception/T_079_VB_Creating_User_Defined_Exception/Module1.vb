
'Creating User-Defined Exceptions
'You can also define your own exception. User-defined exception classes are derived from the ApplicationException Class. The following example demonstrates this

Module Module1

    Public Class TempIsZeroException : Inherits ApplicationException
        Public Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class

    Public Class Temperature
        Dim temperature As Integer = 0
        Sub showTemp()
            If (temperature = 0) Then
                Throw (New TempIsZeroException("Zero Temperature found"))
            Else
                Console.WriteLine("Temperature: {0}", temperature)
            End If
        End Sub
    End Class
    Sub Main()
        Dim temp As Temperature = New Temperature()
        Try
            temp.showTemp()
        Catch e As TempIsZeroException
            Console.WriteLine("TempIsZeroException: {0}", e.Message)
        End Try
        Console.ReadKey()
    End Sub

End Module


'When the above code Is compiled And executed, it produces the following result

'TempIsZeroException: Zero Temperature found
