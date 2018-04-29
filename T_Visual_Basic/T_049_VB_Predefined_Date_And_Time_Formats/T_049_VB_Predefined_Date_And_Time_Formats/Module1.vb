
'Predefined Date / Time Formats
'The following table identifies the predefined Date And time format names. These may be used by name As the style argument For the Format Function:

'Format	Description
'General Date, Or G	Displays a Date And/Or time. For example, 1 / 12 / 2012 07: 07:30 AM.
'Long Date, Medium Date, Or D Displays a date according to your current culture's long date format. For example, Sunday, December 16, 2012.
'Short Date, Or d    Displays a date using your current culture's short date format. For example, 12/12/2012.
'Long Time, Medium Time, orT	Displays a time using your current culture's long time format; typically includes hours, minutes, seconds. For example, 01:07:30 AM.
'Short Time Or t	Displays a time using your current culture's short time format. For example, 11:07 AM.
'f	Displays the Long Date And Short time according To your current culture's format. For example, Sunday, December 16, 2012 12:15 AM.
'F	Displays the Long Date And Long time according To your current culture's format. For example, Sunday, December 16, 2012 12:15:31 AM.
'g	Displays the Short Date And Short time according To your current culture's format. For example, 12/16/2012 12:15 AM.
'M, m	Displays the month And the day Of a Date. For example, December 16.
'R, r	Formats the date according to the RFC1123Pattern property.
's	Formats the Date And time As a sortable index. For example, 2012-12-16T12:07:31.
'u	Formats the Date And time As a GMT sortable index. For example, 2012-12-16 12:15:31Z.
'U	Formats the Date And time With the Long Date And Long time As GMT. For example, Sunday, December 16, 2012 6:07:31 PM.
'Y, y	Formats the Date As the year And month. For example, December, 2012.
'For other formats Like user-defined formats, please consult Microsoft Documentation.

'Properties And Methods of the DateAndTime Class
'The following table lists some Of the commonly used properties Of the DateAndTime Class

'S.N  Property	Description
'1   Date	Returns Or sets a String value representing the current date according to your system.
'2   Now	Returns a Date value containing the current date And time according to your system.
'3   TimeOfDay	Returns Or sets a Date value containing the current time of day according to your system.
'4   Timer	Returns a Double value representing the number of seconds elapsed since midnight.
'5   TimeString	Returns Or sets a String value representing the current time of day according to your system.
'6   Today	Gets the current date.
'The following table lists some Of the commonly used methods Of the DateAndTime Class

'S.N  Method Name & Description
'1   
'Public Shared Function DateAdd(Interval As DateInterval, Number As Double, DateValue As DateTime) As DateTime

'    Returns a Date value containing a date And time value to which a specified time interval has been added.

'2   
'Public Shared Function DateAdd(Interval As String, Number As Double, DateValue As Object) As DateTime

'    Returns a Date value containing a date And time value to which a specified time interval has been added.

'3   
'Public Shared Function DateDiff(Interval As DateInterval, Date1 As DateTime, Date2 As DateTime, DayOfWeek As FirstDayOfWeek, WeekOfYear As FirstWeekOfYear) As Long

'    Returns a Long value specifying the number of time intervals between two Date values.

'4   
'Public Shared Function DatePart(Interval As DateInterval, DateValue As DateTime, FirstDayOfWeekValue As FirstDayOfWeek, FirstWeekOfYearValue As FirstWeekOfYear) As Integer

'    Returns an Integer value containing the specified component of a given Date value.

'5   
'Public Shared Function Day(DateValue As DateTime) As Integer

'    Returns an Integer value from 1 through 31 representing the day of the month.

'6   Public Shared Function Hour (TimeValue As DateTime) As Integer
'Returns an Integer value from 0 through 23 representing the hour of the day.

'7   
'Public Shared Function Minute(TimeValue As DateTime) As Integer

'    Returns an Integer value from 0 through 59 representing the minute of the hour.

'8   
'Public Shared Function Month(DateValue As DateTime) As Integer

'    Returns an Integer value from 1 through 12 representing the month of the year.

'9   
'Public Shared Function MonthName(Month As Integer, Abbreviate As Boolean) As String

'    Returns a String value containing the name of the specified month.

'10  
'Public Shared Function Second(TimeValue As DateTime) As Integer

'    Returns an Integer value from 0 through 59 representing the second of the minute.

'11  
'Public Overridable Function ToString() As String

'    Returns a string that represents the current object.

'12  
'Public Shared Function Weekday(DateValue As DateTime, DayOfWeek As FirstDayOfWeek) As Integer

'    Returns an Integer value containing a number representing the day of the week.

'13  
'Public Shared Function WeekdayName(Weekday As Integer, Abbreviate As Boolean, FirstDayOfWeekValue As FirstDayOfWeek) As String

'    Returns a String value containing the name of the specified weekday.

'14  
'Public Shared Function Year(DateValue As DateTime) As Integer

'    Returns an Integer value from 1 through 9999 representing the year.

'The above list Is Not exhaustive. For complete list Of properties And methods Of the DateAndTime Class, please consult Microsoft Documentation.

'The following program demonstrates some of these And methods:


Module Module1

    Sub Main()
        Dim birthday As Date
        Dim bday As Integer
        Dim month As Integer
        Dim monthname As String
        ' Assign a date using standard short format.
        birthday = #7/27/1998#
        bday = Microsoft.VisualBasic.DateAndTime.Day(birthday)
        month = Microsoft.VisualBasic.DateAndTime.Month(birthday)
        monthname = Microsoft.VisualBasic.DateAndTime.MonthName(month)
        Console.WriteLine(birthday)
        Console.WriteLine(bday)
        Console.WriteLine(month)
        Console.WriteLine(monthname)
        Console.ReadKey()
    End Sub

End Module



'When the above code Is compiled And executed, it produces the following result

'7/27/1998 12:00:00 AM
'27
'7
'July