Imports System.IO
Imports System.Text


Module Module1

    Sub Main()
        ConcatenatingStringsWithStringBuilder()
    End Sub

#Region "Comparing strings"

    Sub CompareStrings()

        Dim firstString As String = "Test string"
        Dim secondString As String = "Comparison Test"

        Dim areEqual As Boolean = String.Equals(firstString, secondString)
        Dim areCaseEqual As Boolean =
            String.Equals(firstString, secondString,
            StringComparison.CurrentCultureIgnoreCase)

        Dim result As Integer = String.Compare(firstString, secondString)

        Dim caseComparisonResult As Integer = String.Compare(firstString, secondString, True)
        Console.WriteLine(result)

        'Using the equality operator
        Dim stringOne As String = "Hi guys"
        Dim stringTwo As String = "How are you?"
        Dim stringThree As String = "Hi guys"
        'Returns False
        Dim result1 As Boolean = (stringOne = stringTwo)
        'Returns True
        Dim result2 As Boolean = (stringOne = stringThree)

        If stringOne = stringTwo Then
            'Do something if the two strings are equal
        End If
    End Sub

#End Region

#Region "Concatenating Strings"
    Sub ConcatenatingStrings()

        Dim firstString As String = "Hello! My name is "
        Dim secondString As String = "Alessandro Del Sole"

        Dim result As String = firstString + secondString

        Dim concatResult As String = String.Concat(firstString, secondString)
    End Sub
#End Region

#Region "Checking for empty strings"

    Sub CheckForEmptyStrings(ByVal stringToCheck As String)

        If String.IsNullOrEmpty(stringToCheck) = False Then
            'The string is neither null nor empty
        Else
            'The string is either null or empty
        End If

        'If you need to just check if it is null
        If stringToCheck Is Nothing Then
            'String is null
        End If
    End Sub

#End Region

#Region "Copying strings"

    Sub CopyDemo()
        Dim sourceString As String = "Alessandro Del Sole"
        Dim targetString As String = String.Copy(sourceString)
    End Sub

    Sub CopyToDemo()
        Dim sourceString As String = "Alessandro Del Sole"
        Dim charArray(sourceString.Length) As Char
        sourceString.CopyTo(11, charArray, 0, 3)
        Console.WriteLine(charArray)
    End Sub


#End Region

#Region "Formatting strings"

    Sub FormattingDemo()

        Console.WriteLine(String.Format("The cost for traveling to Europe is {0:C} dollars", 1000))
        Console.WriteLine(String.Format("You are eligible for a {0:P} discount", 15.55F))
        Console.WriteLine(String.Format("Hex counterpart for 10 is {0:X}", 10))

        Console.WriteLine(String.Format("The traveling cost is {0:C}. Hex for {1} is '{1,5:X}'", 1000, 10))

        Console.WriteLine(String.Format("Custom currency {0:£#,###.00} ", 987654))

        Dim number As Decimal = 1000
        Console.WriteLine(String.
                        Format("Custom currency formatting: {0:£#,##0.00;*£#,##0.00*;Zero}",
                        number))

    End Sub

#End Region

#Region "Editing strings"

    Sub EditingStrings()

        Dim testString As String = "This is a test string"
        'Returns
        '"This is a test,for demo purposes only,string"
        Dim addedString As String = testString.Insert(14, ",for demo purposes only,")

        'Returns "This is a test string"
        Dim removedString As String = testString.Remove(14)

        'Returns
        '"This is a demo string"
        Dim replacedString As String = testString.Replace("test", "demo")

        Dim stringToSplit As String = "Name,Last Name,Age"
        Dim result() As String = stringToSplit.Split(","c)

        'Dim r() As String = stringToSplit.Split(New Char() {","c}, 2, StringSplitOptions.RemoveEmptyEntries)

        For Each item As String In result
            Debug.WriteLine(item)
        Next

        'Returns "Name, Last Name, Age"
        Dim result2 As String = String.Join(",", New String() {"Name", "Last Name", "Age"})
        Debug.WriteLine(result2)

        Dim stringWithSpaces As String = "    Test with spaces    "
        'Returns "Test with spaces"
        Dim result3 As String = stringWithSpaces.Trim
        'Returns "Test with spaces   "
        Dim result4 As String = stringWithSpaces.TrimStart
        'Returns "   Test with spaces"
        Dim result5 As String = stringWithSpaces.TrimEnd

        Dim padResult As String = testString.PadLeft(30, "*"c)
        Dim padResult1 As String = testString.PadRight(30, "*"c)

        Debug.WriteLine(padResult)
        Debug.WriteLine(padResult1)
    End Sub
#End Region

#Region "Inspecting strings"

    Sub InspectingStrings()

        Dim testString As String = "This is a string to inspect"
        'Returns 27
        Dim length As Integer = testString.Length

        'Returns True
        Dim contains As Boolean = testString.Contains("inspect")
        'Returns False
        Dim contains1 As Boolean = testString.Contains("Inspect")

        'Returns False, the string starts with "T"
        Dim startsWith As Boolean = testString.StartsWith("Uh")
        'Returns True
        Dim endsWith As Boolean = testString.EndsWith("pect")

        'Returns 2
        Dim index As Integer = testString.IndexOf("is")
        'Returns 5
        Dim index1 As Integer = testString.IndexOf("is", 3, StringComparison.InvariantCultureIgnoreCase)
        'Returns 1
        Dim index2 As Integer = testString.IndexOfAny(New Char() {"h"c, "s"c, "i"c})

        'Returns 5
        Dim lastIndex As Integer = testString.LastIndexOf("is")
        'Returns 22
        Dim lastIndex1 As Integer = testString.LastIndexOfAny(New Char() {"h"c, "s"c, "i"c})

        'Returns "is a string"
        Dim subString As String = testString.Substring(5, 11)

    End Sub

#End Region

#Region "StringBuilder"
    Sub ConcatenatingStringsWithoutStringBuilder()
        Dim start As Date = Date.Now
        Dim x As String = ""
        For i As Integer = 0 To 500000
            x = x & "!"
        Next
        Dim finish = Date.Now
        Console.WriteLine($"Time taken {finish - start})")
        Console.ReadLine()
    End Sub

    'Requires an Imports System.Text directive
    Sub ConcatenatingStringsWithStringBuilder()
        Dim start As Date = Date.Now
        Dim x As New StringBuilder
        For i As Integer = 0 To 500000
            x.Append("!")
        Next
        Debug.WriteLine(x.ToString)
        Dim finish = Date.Now
        Console.WriteLine($"Time taken {finish - start})")
        Console.ReadLine()
    End Sub

#End Region
End Module
