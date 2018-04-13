Imports System.Text.RegularExpressions
Public Class BookService
    Implements IBookService

    Private Const isbnPattern As String =
    "ISBN(?:-13)?:?\x20*(?=.{17}$)97(?:8|9)([ -])\d{1,5}\1\d{1,7}\1\d{1,6}\1\d$"

    Public Function ValidateBook(ByVal bookToValidate As Book) As _
                    String Implements IBookService.ValidateBook

        Dim isValidIsbn As Boolean = Regex.IsMatch(String.Concat("ISBN-13: ",
                                                   bookToValidate.ISBN),
                                                   isbnPattern)

        If isValidIsbn = False Then
            Return "Invalid ISBN"
        End If

        Dim isValidAuthor As Boolean = String.IsNullOrEmpty(bookToValidate.Author)
        If isValidAuthor = True Then
            Return "Author not specified"
        End If

        Dim isValidTitle As Boolean = String.IsNullOrEmpty(bookToValidate.Title)
        If isValidTitle = True Then
            Return "Title not specified"
        End If

        If bookToValidate.DatePublished Is Nothing Then
            Return "Book data is valid but date published was not specified"
        End If

        Return "Valid book"
    End Function
End Class

