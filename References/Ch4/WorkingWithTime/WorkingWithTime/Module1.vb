Module Module1

    Sub Main()

        Dim zone As TimeZone = TimeZone.CurrentTimeZone

        Debug.WriteLine(zone.DaylightName)
        Debug.WriteLine(zone.StandardName)

        Debug.WriteLine(zone.IsDaylightSavingTime(Date.Now))

        Console.ReadLine()

        Dim tz As TimeZoneInfo = TimeZoneInfo.Local
        'Shows the current time zone Identifier
        Console.WriteLine(tz.Id)

        Dim customZone As TimeZoneInfo = TimeZoneInfo.
            CreateCustomTimeZone("CustomTimeZone",
            Date.UtcNow.Subtract(Date.Now),
            "Custom Zone", "Custom Zone")


        For Each timez As TimeZoneInfo In TimeZoneInfo.GetSystemTimeZones
            Debug.WriteLine(timez.Id)
        Next

        'Redmond time; requires specifying the Time Zone ID
        Dim RedmondTime As Date = TimeZoneInfo.
            ConvertTimeBySystemTimeZoneId(DateTime.Now, "Pacific Standard Time")

        Debug.WriteLine("In Italy now is {0} while in Redmond it is {1}", Date.Now.Hour,
                        RedmondTime.Hour)

        Console.ReadLine()

    End Sub

End Module
