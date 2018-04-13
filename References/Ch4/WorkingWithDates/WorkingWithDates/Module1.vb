
Module Module1

    Sub Main()

        Dim currentDate As Date = Date.Now

        SubtractingAddingDemo()
        'Dim secondDate As New Date(1978, 6, 10)
        'Dim result As TimeSpan = firstDate.Subtract(secondDate)

        Console.ReadLine()
    End Sub

    Sub CreatingDates()

        'Creates a new date; May 10th 1977, 8.30 pm
        Dim myBirthDate As New Date(1977, 5, 10,
                                    20, 30, 0)

        'In 1977, May 10Th was Tuesday
        Debug.WriteLine(myBirthDate.DayOfWeek.
                          ToString)

        '8.30 pm
        Debug.WriteLine("Hour: {0}, Minutes: {1}",
                          myBirthDate.Hour,
                          myBirthDate.Minute)

        'Is the date included within the Day Light Saving Time period?
        Debug.WriteLine("Is Day light saving time: {0}",
                          myBirthDate.IsDaylightSavingTime.
                          ToString)

        'Is leap year
        Debug.WriteLine("Is leap: {0}",
                          Date.IsLeapYear(myBirthDate.Year).
                          ToString)
    End Sub

    Sub ParsingDates()
        Console.WriteLine("Please specify a date:")
        Dim inputDate As Date
        Dim result As Boolean = Date.TryParse(Console.ReadLine, inputDate)

        If result = False Then
            Console.WriteLine("You entered an invalid date")
        Else
            Console.WriteLine(inputDate.DayOfWeek.ToString)
        End If
    End Sub

    Sub FormattingDates()
        Debug.Print(Date.Now.ToString("D"))
        Debug.Print(Date.Now.ToString("d"))
        Debug.Print(Date.Now.ToString("T"))
        Debug.Print(Date.Now.ToString("t"))
        Debug.Print(Date.Now.ToString("F"))
        Debug.Print(Date.Now.ToString("f"))
        Debug.Print(Date.Now.ToString("G"))
        Debug.Print(Date.Now.ToString("g"))
        Debug.Print(Date.Now.ToString("M|M"))
        Debug.Print(Date.Now.ToString("r|R"))
        Debug.Print(Date.Now.ToString("s"))
        Debug.Print(Date.Now.ToString("U"))
        Debug.Print(Date.Now.ToString("u"))
        Debug.Print(Date.Now.ToString("Y|Y"))

        Console.WriteLine("Local time: {0}", Date.Now.ToLocalTime)
        Console.WriteLine("Long date: {0}", Date.Now.ToLongDateString)
        Console.WriteLine("Short date: {0}", Date.Now.ToShortDateString)
        Console.WriteLine("Long time: {0}", Date.Now.ToLongTimeString)
        Console.WriteLine("Short time: {0}", Date.Now.ToShortTimeString)
        Console.WriteLine("Universal time: {0}", Date.Now.
                          ToUniversalTime.ToString)
        Console.WriteLine("File time: {0}", Date.Now.
                          ToFileTime.ToString)
        Console.WriteLine("File time UTC: {0}", Date.Now.
                          ToFileTimeUtc.ToString)
        Console.WriteLine("OLE Automation date: {0}", Date.Now.
                          ToOADate.ToString)
    End Sub

    Sub SubtractingAddingDemo()

        Dim birthDate As Date = New Date(1977, 5, 10, 20, 30, 0)
        Dim secondDate As Date = New Date(1990, 5, 11, 20, 10, 0)

        'Dim result As System.TimeSpan = secondDate.Subtract(birthDate)

        ''In days
        'Debug.WriteLine(result.Days)
        ''In "ticks"
        'Debug.WriteLine(result.Ticks)

        Dim editedDate As Date = birthDate.AddDays(3)
        editedDate = editedDate.AddHours(2)
        editedDate = editedDate.AddYears(1)

        Debug.WriteLine(editedDate)

    End Sub

End Module
