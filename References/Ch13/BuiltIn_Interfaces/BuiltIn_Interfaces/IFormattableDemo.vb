Imports System.Globalization

Public Class Person
    Implements IFormattable

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String

    Public Overloads Function ToString(ByVal format As String,
                                       ByVal formatProvider As System.IFormatProvider) _
                                       As String Implements System.IFormattable.ToString

        If String.IsNullOrEmpty(format) Then format = "G"
        If formatProvider Is Nothing Then formatProvider = CultureInfo.CurrentCulture

        Select Case format
            'General specifier. Must be implemented
            Case Is = "G"
                Return String.Format("{0} {1}, {2}", Me.FirstName, Me.LastName, Me.Email)
            Case Is = "F"
                Return FirstName
            Case Is = "L"
                Return LastName
            Case Is = "LF"
                Return String.Format("{0} {1}", Me.LastName, Me.FirstName)
            Case Else
                Throw New FormatException
        End Select
    End Function
End Class
