



'Getting the Current Date And Time:
'The following programs demonstrate how To Get the current Date And time In VB.Net

Module Module1

    Sub Main()

        Console.Write("Current Time: ")
        Console.WriteLine(Now.ToLongTimeString)
        Console.WriteLine("Current Date: ")
        Dim dt As Date = Today
        Console.WriteLine("Today is: {0}", dt)

        Console.ReadKey()

    End Sub

End Module
