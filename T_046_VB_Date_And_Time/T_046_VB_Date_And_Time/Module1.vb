
'VB.Net -Date & Time
'    Most of the softwares you write need implementing some form of date functions returning current date And time. Dates are so much part of everyday life that it becomes easy to work with them without thinking. VB.Net also provides powerful tools for date arithmetic that makes manipulating dates easy.

'The Date data type contains Date values, time values, Or Date And time values. The default value of Date Is 0:00:00 (midnight) on January 1, 0001. The equivalent .NET data type Is System.DateTime.

'The DateTime Structure represents an instant In time, typically expressed As a Date And time Of day

'Declaration
'<SerializableAttribute>
'Public Structure DateTime _
'	Implements IComparable, IFormattable, IConvertible, ISerializable,  
'	IComparable(Of DateTime), IEquatable(Of DateTime)
'You can also Get the current Date And time from the DateAndTime Class.

'The DateAndTime Module contains the procedures And properties used In Date And time operations.

''Declaration
'<StandardModuleAttribute>
'    Public NotInheritable Class DateAndTime
'Note:

'Both the DateTime Structure And the DateAndTime Module contain properties Like Now And Today, so often beginners find it confusing. The DateAndTime Class belongs To the Microsoft.VisualBasic Namespace And the DateTime Structure belongs To the System Namespace.
'Therefore, using the later would help you in porting your code to another .Net language Like C#. However, the DateAndTime class/module contains all the legacy date functions available in Visual Basic.

'Properties And Methods of the DateTime Structure
'The following table lists some Of the commonly used properties Of the DateTime Structure:

'S.N	Property	Description
'1   Date	Gets the date component of this instance.
'2   Day	Gets the day of the month represented by this instance.
'3   DayOfWeek	Gets the day of the week represented by this instance.
'4   DayOfYear	Gets the day of the year represented by this instance.
'5   Hour	Gets the hour component of the date represented by this instance.
'6   Kind	Gets a value that indicates whether the time represented by this instance Is based on local time, Coordinated Universal Time (UTC), Or neither.
'7   Millisecond	Gets the milliseconds component of the date represented by this instance.
'8   Minute	Gets the minute component of the date represented by this instance.
'9   Month	Gets the month component of the date represented by this instance.
'10  Now	Gets a DateTime object that Is set to the current date And time on this computer, expressed as the local time.
'11  Second	Gets the seconds component of the date represented by this instance.
'12  Ticks	Gets the number of ticks that represent the date And time of this instance.
'13  TimeOfDay	Gets the time of day for this instance.
'14  Today	Gets the current date.
'15  UtcNow	Gets a DateTime object that Is set to the current date And time on this computer, expressed as the Coordinated Universal Time (UTC).
'16  Year	Gets the year component of the date represented by this instance.
'The following table lists some Of the commonly used methods Of the DateTime Structure:

'S.N	Method Name & Description
'1   
'Public Function Add(value As TimeSpan) As DateTime

'            Returns a New DateTime that adds the value of the specified TimeSpan to the value of this instance.

'2   
'Public Function AddDays(value As Double) As DateTime

'            Returns a New DateTime that adds the specified number of days to the value of this instance.

'3   
'Public Function AddHours(value As Double) As DateTime

'            Returns a New DateTime that adds the specified number of hours to the value of this instance.

'4   
'Public Function AddMinutes(value As Double) As DateTime

'            Returns a New DateTime that adds the specified number of minutes to the value of this instance.

'5   
'Public Function AddMonths(months As Integer) As DateTime

'            Returns a New DateTime that adds the specified number of months to the value of this instance.

'6   
'Public Function AddSeconds(value As Double) As DateTime

'            Returns a New DateTime that adds the specified number of seconds to the value of this instance.

'7   
'Public Function AddYears(value As Integer) As DateTime

'            Returns a New DateTime that adds the specified number of years to the value of this instance.

'8   
'Public Shared Function Compare(t1 As DateTime, t2 As DateTime) As Integer

'            Compares two instances Of DateTime And returns an Integer that indicates whether the first instance Is earlier than, the same As, Or later than the second instance.

'9   
'Public Function CompareTo(value As DateTime) As Integer

'            Compares the value Of this instance To a specified DateTime value And returns an Integer that indicates whether this instance Is earlier than, the same As, Or later than the specified DateTime value.

'10  
'Public Function Equals(value As DateTime) As Boolean

'            Returns a value indicating whether the value of this instance Is equal to the value of the specified DateTime instance.

'11  
'Public Shared Function Equals(t1 As DateTime, t2 As DateTime) As Boolean

'            Returns a value indicating whether two DateTime instances have the same date And time value.

'12  
'Public Overrides Function ToString() As String

'            Converts the value of the current DateTime object to its equivalent string representation.

'the above list Of methods Is Not exhaustive, please visit Microsoft documentation for the complete list of methods And properties of the DateTime structure.

'Creating a DateTime Object
'You can create a DateTime object in one of the following ways

'By calling a DateTime constructor from any of the overloaded DateTime constructors.

'By assigning the DateTime object a date And time value returned by a property Or method.

'By parsing the string representation of a date And time value.

'By calling the DateTime structure's implicit default constructor.

'            the following example demonstrates this:

Module Module1

    Sub Main()
        'DateTime constructor: parameters year, month, day, hour, min, sec
        Dim date1 As New Date(2012, 12, 16, 12, 0, 0)
        'initializes a new DateTime value
        Dim date2 As Date = #12/16/2012 12:00:52 AM#
        'using properties
        Dim date3 As Date = Date.Now
        Dim date4 As Date = Date.UtcNow
        Dim date5 As Date = Date.Today
        Console.WriteLine(date1)
        Console.WriteLine(date2)
        Console.WriteLine(date3)
        Console.WriteLine(date4)
        Console.WriteLine(date5)
        Console.ReadKey()
    End Sub

End Module

'When the above code was compiled And executed, it produces the following result

'12/16/2012 12:00:00 PM
'12/16/2012 12:00:52 PM
'12/12/2012 10:22:50 PM
'12/12/2012 12:00:00 PM
