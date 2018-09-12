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
        Dim str As String = "make a maze and manage to measure it"
        Console.WriteLine("Matching words that start with 'm' and ends with 'e': ")
        showMatch(str, "\bm\S*e\b")
        Console.ReadKey()
    End Sub

    '    Matching words start With 'm' and ends with 'e':
    'The Expression :  \bm\S*e\b
    'make
    'maze
    'manage
    'measure

End Module