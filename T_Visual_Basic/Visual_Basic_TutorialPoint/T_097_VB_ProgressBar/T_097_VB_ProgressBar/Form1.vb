
'VB.Net -ProgressBar Control
'It represents a Windows progress bar control. It Is used To provide visual feedback To your users about the status Of some task. It shows a bar that fills In from left To right As the operation progresses.

'Let's click on a ProgressBar control from the Toolbox and place it on the form.
'The main properties Of a progress bar are Value, Maximum And Minimum. The Minimum And Maximum properties are used To Set the minimum And maximum values that the progress bar can display. The Value Property specifies the current position Of the progress bar.

'The ProgressBar control Is typically used When an application performs tasks such As copying files Or printing documents. To a user the application might look unresponsive If there Is no visual cue. In such cases, Using the ProgressBar allows the programmer To provide a visual status Of progress.

'Properties of the ProgressBar Control
'The following are some Of the commonly used properties Of the ProgressBar control

'S.N  Property	Description
'1   AllowDrop	Overrides Control.AllowDrop.
'2   BackgroundImage	Gets Or sets the background image for the ProgressBar control.
'3   BackgroundImageLayout	Gets Or sets the layout of the background image of the progress bar.
'4   CausesValidation	Gets Or sets a value indicating whether the control, when it receives focus, causes validation to be performed on any controls that require validation.
'5   Font	Gets Or sets the font of text in the ProgressBar.
'6   ImeMode	Gets Or sets the input method editor (IME) for the ProgressBar.
'7   ImeModeBase	Gets Or sets the IME mode of a control.
'8   MarqueeAnimationSpeed	Gets Or sets the time period, in milliseconds, that it takes the progress block to scroll across the progress bar.
'9   Maximum	Gets Or sets the maximum value of the range of the control.
'10  Minimum	Gets Or sets the minimum value of the range of the control.
'11  Padding	Gets Or sets the space between the edges of a ProgressBar control And its contents.
'12  RightToLeftLayout	Gets Or sets a value indicating whether the ProgressBar And any text it contains Is displayed from right to left.
'13  Step	Gets Or sets the amount by which a call to the PerformStep method increases the current position of the progress bar.
'14  Style	Gets Or sets the manner in which progress should be indicated on the progress bar.
'15  Value	Gets Or sets the current position of the progress bar.
'Methods of the ProgressBar Control
'The following are some Of the commonly used methods Of the ProgressBar control

'S.N  Method Name & Description
'1   
'Increment

'Increments the current position Of the ProgressBar control by specified amount.

'2   
'PerformStep

'Increments the value by the specified Step.

'3   
'ResetText

'Resets the Text Property To its Default value.

'4   
'ToString

'Returns a String that represents the progress bar control.

'Events of the ProgressBar Control
'The following are some Of the commonly used events Of the ProgressBar control

'S.N  Event	Description
'1   BackgroundImageChanged	Occurs when the value of the BackgroundImage property changes.
'2   BackgroundImageLayoutChanged	Occurs when the value of the BackgroundImageLayout property changes.
'3   CausesValidationChanged	Occurs when the value of the CausesValidation property changes.
'4   Click	Occurs when the control Is clicked.
'5   DoubleClick	Occurs when the user double-clicks the control.
'6   Enter	Occurs when focus enters the control.
'7   FontChanged	Occurs when the value of the Font property changes.
'8   ImeModeChanged	Occurs when the value of the ImeMode property changes.
'9   KeyDown	Occurs when the user presses a key while the control has focus.
'10  KeyPress	Occurs when the user presses a key while the control has focus.
'11  KeyUp	Occurs when the user releases a key while the control has focus.
'12  Leave	Occurs when focus leaves the ProgressBar control.
'13  MouseClick	Occurs when the control Is clicked by the mouse.
'14  MouseDoubleClick	Occurs when the user double-clicks the control.
'15  PaddingChanged	Occurs when the value of the Padding property changes.
'16  Paint	Occurs when the ProgressBar Is drawn.
'17  RightToLeftLayoutChanged	Occurs when the RightToLeftLayout property changes.
'18  TabStopChanged	Occurs when the TabStop property changes.
'18  TextChanged	Occurs when the Text property changes.
'Example
'In this example, let us create a progress bar at runtime. Let's double click on the Form and put the follow code in the opened window.


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
      Handles MyBase.Load
        'create two progress bars
        Dim ProgressBar1 As ProgressBar
        Dim ProgressBar2 As ProgressBar
        ProgressBar1 = New ProgressBar()
        ProgressBar2 = New ProgressBar()
        'set position
        ProgressBar1.Location = New Point(10, 10)
        ProgressBar2.Location = New Point(10, 50)
        'set values
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 200
        ProgressBar1.Value = 130
        ProgressBar2.Minimum = 0
        ProgressBar2.Maximum = 100
        ProgressBar2.Value = 40
        'add the progress bar to the form
        Me.Controls.Add(ProgressBar1)
        Me.Controls.Add(ProgressBar2)
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
    End Sub
End Class
