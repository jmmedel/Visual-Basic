Public Structure ThreePoint
    Implements IConvertible

    Public Function GetTypeCode() As System.TypeCode Implements _
        System.IConvertible.GetTypeCode

        Return TypeCode.Object
    End Function

    'Just a custom return value
    Public Function ToBoolean(ByVal provider As System.IFormatProvider) _
        As Boolean Implements System.IConvertible.ToBoolean
        Return X > Y
    End Function

    Public Function ToByte(ByVal provider As System.IFormatProvider) _
        As Byte Implements System.IConvertible.ToByte
        Return Convert.ToByte(SumPoints)
    End Function

    Public Function ToChar(ByVal provider As System.IFormatProvider) _
        As Char Implements System.IConvertible.ToChar
        Return Convert.ToChar(SumPoints)
    End Function

    Public Function ToDateTime(ByVal provider As System.IFormatProvider) _
        As Date Implements System.IConvertible.ToDateTime
        Return Convert.ToDateTime(SumPoints)
    End Function

    Public Function ToDecimal(ByVal provider As System.IFormatProvider) _
        As Decimal Implements System.IConvertible.ToDecimal
        Return Convert.ToDecimal(SumPoints)
    End Function

    Public Function ToDouble(ByVal provider As System.IFormatProvider) _
        As Double Implements System.IConvertible.ToDouble
        Return Convert.ToDouble(SumPoints)
    End Function

    Public Function ToInt16(ByVal provider As System.IFormatProvider) _
        As Short Implements System.IConvertible.ToInt16
        Return Convert.ToInt16(SumPoints)
    End Function

    Public Function ToInt32(ByVal provider As System.IFormatProvider) _
        As Integer Implements System.IConvertible.ToInt32
        Return SumPoints()
    End Function

    Public Function ToInt64(ByVal provider As System.IFormatProvider) _
        As Long Implements System.IConvertible.ToInt64
        Return Convert.ToInt64(SumPoints)
    End Function

    Public Function ToSByte(ByVal provider As System.IFormatProvider) _
        As SByte Implements System.IConvertible.ToSByte
        Return Convert.ToSByte(SumPoints)
    End Function

    Public Function ToSingle(ByVal provider As System.IFormatProvider) _
        As Single Implements System.IConvertible.ToSingle
        Return Convert.ToSingle(SumPoints)
    End Function

    'Required "Overloads"
    Public Overloads Function ToString(ByVal provider As System.IFormatProvider) _
        As String Implements System.IConvertible.ToString
        Return String.Format("{0}, {1}, {2}", Me.X, Me.Y, Me.Z)
    End Function

    Public Function ToType(ByVal conversionType As System.Type,
                           ByVal provider As System.IFormatProvider) _
                           As Object Implements System.IConvertible.ToType
        Return Convert.ChangeType(SumPoints, conversionType)
    End Function

    Public Function ToUInt16(ByVal provider As System.IFormatProvider) _
        As UShort Implements System.IConvertible.ToUInt16

        Return Convert.ToUInt16(SumPoints)
    End Function

    Public Function ToUInt32(ByVal provider As System.IFormatProvider) _
        As UInteger Implements System.IConvertible.ToUInt32
        Return Convert.ToUInt32(SumPoints)
    End Function

    Public Function ToUInt64(ByVal provider As System.IFormatProvider) _
        As ULong Implements System.IConvertible.ToUInt64
        Return Convert.ToUInt64(SumPoints)
    End Function

    Public Property X As Integer
    Public Property Y As Integer
    Public Property Z As Integer

    Public Sub New(ByVal valueX As Integer,
                   ByVal valueY As Integer,
                   ByVal valueZ As Integer)
        Me.X = valueX
        Me.Y = valueY
        Me.Z = valueZ
    End Sub

    Public Function SumPoints() As Integer
        Return (Me.X + Me.Y + Me.Z)
    End Function
End Structure
