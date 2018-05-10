
'VB.Net -ScrollBar Control
'The ScrollBar controls display vertical And horizontal scroll bars On the form. This Is used For navigating through large amount Of information. There are two types Of scroll bar controls: HScrollBar for horizontal scroll bars And VScrollBar for vertical scroll bars. These are used independently from each other.

'Let's click on HScrollBar control and VScrollBar control from the Toolbox and place them on the form.

'Properties of the ScrollBar Control
'The following are some Of the commonly used properties Of the ScrollBar control

'S.N  Property	Description
'1   AutoSize	Gets Or sets a value indicating whether the ScrollBar Is automatically resized to fit its contents.
'2   BackColor	Gets Or sets the background color for the control.
'3   ForeColor	Gets Or sets the foreground color of the scroll bar control.
'4   ImeMode	Gets Or sets the Input Method Editor (IME) mode supported by this control.
'5   LargeChange	Gets Or sets a value to be added to Or subtracted from the Value property when the scroll box Is moved a large distance.
'6   Maximum	Gets Or sets the upper limit of values of the scrollable range.
'7   Minimum	Gets Or sets the lower limit of values of the scrollable range.
'8   SmallChange	Gets Or sets the value to be added to Or subtracted from the Value property when the scroll box Is moved a small distance.
'9   Value	Gets Or sets a numeric value that represents the current position of the scroll box on the scroll bar control.
'Methods of the ScrollBar Control
'The following are some Of the commonly used methods Of the ScrollBar control

'S.N  Method Name & Description
'1   
'OnClick

'Generates the Click Event.

'2   
'Select Case

'Activates the control.

'Events of the ScrollBar Control
'The following are some Of the commonly used events Of the ScrollBar control

'S.N  Event	Description
'1   Click	Occurs when the control Is clicked.
'2   DoubleClick	Occurs when the user double-clicks the control.
'3   Scroll	Occurs when the control Is moved.
'4   ValueChanged	Occurs when the Value property changes, either by handling the Scroll event Or programmatically.

'Example
'In this example, let us create two scroll bars at runtime. Let's double click on the Form and put the follow code in the opened window.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load
        'create two scroll bars
        Dim hs As HScrollBar
        Dim vs As VScrollBar
        hs = New HScrollBar()
        vs = New VScrollBar()
        'set properties
        hs.Location = New Point(10, 200)
        hs.Size = New Size(175, 15)
        hs.Value = 50
        vs.Location = New Point(200, 30)
        vs.Size = New Size(15, 175)
        hs.Value = 50
        'adding the scroll bars to the form
        Me.Controls.Add(hs)
        Me.Controls.Add(vs)
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
    End Sub
End Class