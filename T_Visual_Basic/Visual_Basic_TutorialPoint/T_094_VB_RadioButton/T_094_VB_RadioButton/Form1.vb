

'VB.Net -RadioButton Control
'The RadioButton control Is used To provide a Set Of mutually exclusive options. The user can Select one radio button In a group. If you need To place more than one group Of radio buttons In the same form, you should place them In different container controls Like a GroupBox control.

'Let's create three radio buttons by dragging RadioButton controls from the Toolbox and dropping on the form.

'The Checked Property Of the radio button Is used To Set the state Of a radio button. You can display text, image Or both On radio button control. You can also change the appearance Of the radio button control by Using the Appearance Property.

'Properties of the RadioButton Control
'The following are some Of the commonly used properties Of the RadioButton control

'S.N  Property	Description
'1   Appearance	Gets Or sets a value determining the appearance of the radio button.
'2   AutoCheck	Gets Or sets a value indicating whether the Checked value And the appearance of the control automatically change when the control Is clicked.
'3   CheckAlign	Gets Or sets the location of the check box portion of the radio button.
'4   Checked	Gets Or sets a value indicating whether the control Is checked.
'5   Text	Gets Or sets the caption for a radio button.
'6   TabStop	Gets Or sets a value indicating whether a user can give focus to the RadioButton control using the TAB key.
'Methods of the RadioButton Control
'The following are some Of the commonly used methods Of the RadioButton control

'S.N  Method Name & Description
'1   
'PerformClick

'Generates a Click Event For the control, simulating a click by a user.

'Events of the RadioButton Control
'The following are some Of the commonly used events Of the RadioButton control

'S.N  Event	Description
'1   AppearanceChanged	Occurs when the value of the Appearance property of the RadioButton control Is changed.
'2   CheckedChanged	Occurs when the value of the Checked property of the RadioButton control Is changed.
'Consult Microsoft documentation For detailed list Of properties, methods And events Of the RadioButton control.

'Example
'In the following example, let us create two groups of radio buttons And use their CheckedChanged events for changing the BackColor And ForeColor property of the form.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspont.com"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object,
       e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.BackColor = Color.Red
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object,
      e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.BackColor = Color.Green
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object,
      e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object,
      e As EventArgs) Handles RadioButton4.CheckedChanged
        Me.ForeColor = Color.Black
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object,
       e As EventArgs) Handles RadioButton5.CheckedChanged
        Me.ForeColor = Color.White
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object,
      e As EventArgs) Handles RadioButton6.CheckedChanged
        Me.ForeColor = Color.Red
    End Sub
End Class