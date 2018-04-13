Imports System.Runtime.InteropServices

Public Class ProperCleanup
    Implements IDisposable

    Protected disposedValue As Boolean ' To detect redundant calls

    'A managed resource
    Private managedStream As IO.MemoryStream

    'Unmanaged resources
    <DllImport("winspool.drv")>
    Shared Function OpenPrinter(ByVal deviceName As String,
                                ByVal deviceHandle As Integer,
                                ByVal printerDefault As Object) _
                                As Integer
    End Function
    <DllImport("winspool.drv")>
    Shared Function _
    ClosePrinter(ByVal deviceHandle As Integer) _
                 As Integer
    End Function

    Private printerHandle As Integer

    'Initializes managed and unmanaged resources
    Public Sub New()
        managedStream = New IO.MemoryStream
        OpenPrinter("MyDevice", printerHandle, &H0)
    End Sub

    'Just a sample method that does nothing
    'particular except for checking if the object
    'has been already disposed
    Public Function FormatString(ByVal myString As String) As String
        If disposedValue = True Then
            Throw New ObjectDisposedException("ProperCleanup")
        Else
            Return "You entered: " & myString
        End If
    End Function

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                managedStream.Dispose()
            End If

            ' TODO: free unmanaged resources (unmanaged objects) 
            ' and override Finalize() below.
            ' TODO: set large fields to null.
            ClosePrinter(printerHandle)
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) 
    'above has code to free unmanaged resources.
    Protected Overrides Sub Finalize()
        ' Do not change this code.  Put cleanup code in 
        ' Dispose(ByVal disposing As Boolean) above.
        Dispose(False)
        MyBase.Finalize()
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code 
        ' in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
End Class
