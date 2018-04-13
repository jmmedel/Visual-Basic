Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class CreateDeepCopy

    Public Shared Function Clone(Of T)(ByVal objectToClone As T) As T

        'If the source object is null, simply returns the current
        'object (as a default)
        If Object.ReferenceEquals(objectToClone, Nothing) Then
            Return objectToClone
        End If

        'Creates a new formatter whose behavior is for cloning purposes
        Dim formatter As New BinaryFormatter(Nothing,
                                             New StreamingContext(
                                                 StreamingContextStates.Clone))
        'Serializes to a memory stream
        Dim ms As New MemoryStream
        Using ms
            formatter.Serialize(ms, objectToClone)

            'Gets back to the first stream byte
            ms.Seek(0, SeekOrigin.Begin)
            'Deserializes the object graph to a new T object
            Return CType(formatter.Deserialize(ms), T)
        End Using

    End Function
End Class
