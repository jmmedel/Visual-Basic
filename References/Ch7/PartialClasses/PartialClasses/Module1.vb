Module Module1

    Sub Main()

        Dim c As New Person("Alessandro", "Del Sole", 35)
    End Sub


End Module

Partial Public Class Person

    Implements ICloneable

    Public Function Clone() As Object Implements System.ICloneable.Clone
        Return Me.MemberwiseClone
    End Function
End Class