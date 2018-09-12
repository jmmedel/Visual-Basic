Imports System.Text.RegularExpressions
Module Module1
    Sub showMatch(ByVal text As String, ByVal expr As String)
        Console.WriteLine("The Expression: " + expr)
        Dim mc As MatchCollection = Regex.Matches(text, expr)
        Dim m As Match

        For Each m In mc
            Console.WriteLine(m)
        Next m
    End Sub

    Sub Main()
        Dim str As String = "A Thousand Splendid Suns"
        Console.WriteLine("Matching words that start with 'S': ")
        showMatch(str, "\bS\S*")
        Console.ReadKey()
    End Sub
End Module