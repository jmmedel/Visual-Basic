
'VB.Net -DateTimePicker Control
'The DateTimePicker control allows selecting a Date And time by editing the displayed values In the control. If you click the arrow In the DateTimePicker control, it displays a month calendar, Like a combo box control. The user can make selection by clicking the required Date. The New selected value appears In the text box part Of the control.

'The MinDate And the MaxDate properties allow you To put limits On the Date range.

'Properties of the DateTimePicker Control
'The following are some Of the commonly used properties Of the DateTimePicker control

'S.N  Property	Description
'1   BackColor	Gets Or sets a value indicating the background color of the DateTimePicker control.
'2   BackgroundImage	Gets Or sets the background image for the control.
'3   BackgroundImageLayout	Gets Or sets the layout of the background image of the DateTimePicker control.
'4   CalendarFont	Gets Or sets the font style applied to the calendar.
'5   CalendarForeColor	Gets Or sets the foreground color of the calendar.
'6   CalendarMonthBackground	Gets Or sets the background color of the calendar month.
'7   CalendarTitleBackColor	Gets Or sets the background color of the calendar title.
'8   CalendarTitleForeColor	Gets Or sets the foreground color of the calendar title.
'9   CalendarTrailingForeColor	Gets Or sets the foreground color of the calendar trailing dates.
'10  Checked	Gets Or sets a value indicating whether the Value property has been set with a valid date/time value And the displayed value Is able to be updated.
'11  CustomFormat	Gets Or sets the custom date/time format string.
'12  DropDownAlign	Gets Or sets the alignment of the drop-down calendar on the DateTimePicker control.
'13  ForeColor	Gets Or sets the foreground color of the DateTimePicker control.
'14  Format	Gets Or sets the format of the date And time displayed in the control.
'15  MaxDate	Gets Or sets the maximum date And time that can be selected in the control.
'16  MaximumDateTime	Gets the maximum date value allowed for the DateTimePicker control.
'17  MinDate	Gets Or sets the minimum date And time that can be selected in the control.
'18  MinimumDateTime	Gets the minimum date value allowed for the DateTimePicker control.
'19  PreferredHeight	Gets the preferred height of the DateTimePicker control.
'20  RightToLeftLayout	Gets Or sets whether the contents of the DateTimePicker are laid out from right to left.
'21  ShowCheckBox	Gets Or sets a value indicating whether a check box Is displayed to the left of the selected date.
'22  ShowUpDown	Gets Or sets a value indicating whether a spin button control (also known as an up-down control) Is used to adjust the date/time value.
'23  Text	Gets Or sets the text associated with this control.
'24  Value	Gets Or sets the date/time value assigned to the control.
'Methods of the DateTimePicker Control
'The following are some Of the commonly used methods Of the DateTimePicker control

'S.N  Method Name & Description
'1   
'ToString

'Returns the String representing the control.

'Events of the DateTimePicker Control
'The following are some Of the commonly used events Of the DateTimePicker control

'S.N  Event	Description
'1   BackColorChanged	Occurs when the value of the BackColor property changes.
'2   BackgroundImageChanged	Occurs when the value of the BackgroundImage property changes.
'3   BackgroundImageLayoutChanged	Occurs when the value of the BackgroundImageLayout property changes.
'4   Click	Occurs when the control Is clicked.
'5   CloseUp	Occurs when the drop-down calendar Is dismissed And disappears.
'6   DoubleClick	Occurs when the control Is double-clicked.
'7   DragDrop	Occurs when a drag-And-drop operation Is completed.
'8   ForeColorChanged	Occurs when the value of the ForeColor property changes.
'9   FormatChanged	Occurs when the Format property value has changed.
'10  MouseClick	Occurs when the control Is clicked with the mouse.
'11  MouseDoubleClick	Occurs when the control Is double-clicked with the mouse.
'12  PaddingChanged	Occurs when the value of the Padding property changes.
'13  Paint	Occurs when the control Is redrawn.
'14  RightToLeftLayoutChanged	Occurs when the RightToLeftLayout property changes.
'15  TextChanged	Occurs when the value of the Text property changes.
'16  ValueChanged	Occurs when the Value property changes.
'Example
'In this example, let us create a small application for calculating days of leave. Let us add two DateTimePicker controls on the form, where the user will enter the date of going on leave And the date of joining. Let us keep a button control for performing the calculation And appropriate label controls for displaying information.

'The form In design view

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "Date_Time_Picker"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1 As DateTime = DateTimePicker1.Value
        Dim d2 As DateTime = DateTimePicker2.Value
        Dim result As TimeSpan = d1.Subtract(d2)
        Dim days As Integer = result.TotalDays
        Label3.Text = days
    End Sub
End Class