

Public Structure ThreePoint

    Public Property X As Integer
    Public Property Y As Integer
    Public Property Z As Integer

    Public Sub New(ByVal valueX As Integer, ByVal valueY As Integer, ByVal valueZ As Integer)
        Me.X = valueX
        Me.Y = valueY
        Me.Z = valueZ
    End Sub

    Public Shared Operator +(ByVal firstValue As ThreePoint,
                             ByVal secondValue As ThreePoint) As ThreePoint
        Return New ThreePoint With {.X = firstValue.X + secondValue.X,
                                    .Y = firstValue.Y + secondValue.Y,
                                    .Z = firstValue.Z + secondValue.Z}
    End Operator

    Public Shared Operator -(ByVal firstValue As ThreePoint,
                             ByVal secondValue As ThreePoint) As ThreePoint
        Return New ThreePoint With {.X = firstValue.X - secondValue.X,
                                    .Y = firstValue.Y - secondValue.Y,
                                    .Z = firstValue.Z - secondValue.Z}
    End Operator

    Public Shared Operator =(ByVal firstValue As ThreePoint,
                             ByVal secondValue As ThreePoint) As Boolean
        Return (firstValue.X = secondValue.X) _
                AndAlso (firstValue.Y = secondValue.Y) _
                AndAlso (firstValue.Z = secondValue.Z)
    End Operator

    Public Shared Operator <>(ByVal firstValue As ThreePoint,
                              ByVal secondValue As ThreePoint) As Boolean
        Return (firstValue.X <> secondValue.X) _
                OrElse (firstValue.Y <> secondValue.Y) _
                OrElse (firstValue.Z <> secondValue.Z)
    End Operator

    'From ThreePoint to Array of Integer
    Public Shared Narrowing Operator CType(ByVal instance As ThreePoint) _
                                           As Integer()
        Return New Integer() {instance.X,
                              instance.Y,
                              instance.Z}
    End Operator

    'From Integer() to ThreePoint
    Public Shared Widening Operator CType(ByVal instance As Integer()) _
                                          As ThreePoint
        If instance.Count < 3 Then
            Throw New ArgumentException("Array is out of bounds",
                                        "instance")
        Else
            Return New ThreePoint With {.X = instance(0),
                                        .Y = instance(1),
                                        .Z = instance(2)}
        End If
    End Operator

End Structure
