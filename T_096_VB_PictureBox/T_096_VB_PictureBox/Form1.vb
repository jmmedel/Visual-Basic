
'VB.Net -PictureBox Control
'The PictureBox control Is used For displaying images On the form. The Image Property Of the control allows you To Set an image both at design time Or at run time.

'Let's create a picture box by dragging a PictureBox control from the Toolbox and dropping it on the form.

'Properties of the PictureBox Control
'The following are some Of the commonly used properties Of the PictureBox control

'S.N  Property	Description
'1   AllowDrop	Specifies whether the picture box accepts data that a user drags on it.
'2   ErrorImage	Gets Or specifies an image to be displayed when an error occurs during the image-loading process Or if the image load Is cancelled.
'3   Image	Gets Or sets the image that Is displayed in the control.
'4   ImageLocation	Gets Or sets the path Or the URL for the image displayed in the control.
'5   InitialImage	Gets Or sets the image displayed in the control when the main image Is loaded
'6   SizeMode	Determines the size of the image to be displayed in the control. This property takes its value from the PictureBoxSizeMode enumeration, which has values:
'Normal -the upper left corner of the image Is placed at upper left part of the picture box
'StrechImage -allows stretching of the image
'AutoSize -allows resizing the picture box to the size of the image
'CenterImage -allows centering the image in the picture box
'Zoom -allows increasing Or decreasing the image size to maintain the size ratio.
'7   TabIndex	Gets Or sets the tab index value.
'8   TabStop	Specifies whether the user will be able to focus on the picture box by using the TAB key.
'9   Text	Gets Or sets the text for the picture box.
'10  WaitOnLoad	Specifies whether Or Not an image Is loaded synchronously.
'Methods of the PictureBox Control
'The following are some Of the commonly used methods Of the PictureBox control

'S.N  Method Name & Description
'1   
'CancelAsync

'Cancels an asynchronous image load.

'2   
'Load

'Displays an image In the picture box

'3   
'LoadAsync

'Loads image asynchronously.

'4   
'ToString

'Returns the String that represents the current picture box.

'Events of the PictureBox Control
'The following are some Of the commonly used events Of the PictureBox control

'S.N  Event	Description
'1   CausesValidationChanged	Overrides the Control.CausesValidationChanged property.
'2   Click	Occurs when the control Is clicked.
'3   Enter	Overrides the Control.Enter property.
'4   FontChanged	Occurs when the value of the Font property changes.
'5   ForeColorChanged	Occurs when the value of the ForeColor property changes.
'6   KeyDown	Occurs when a key Is pressed when the control has focus.
'7   KeyPress	Occurs when a key Is pressed when the control has focus.
'8   KeyUp	Occurs when a key Is released when the control has focus.
'9   Leave	Occurs when input focus leaves the PictureBox.
'10  LoadCompleted	Occurs when the asynchronous image-load operation Is completed, been canceled, Or raised an exception.
'11  LoadProgressChanged	Occurs when the progress of an asynchronous image-loading operation has changed.
'12  Resize	Occurs when the control Is resized.
'13  RightToLeftChanged	Occurs when the value of the RightToLeft property changes.
'14  SizeChanged	Occurs when the Size property value changes.
'15  SizeModeChanged	Occurs when SizeMode changes.
'16  TabIndexChanged	Occurs when the value of the TabIndex property changes.
'17  TabStopChanged	Occurs when the value of the TabStop property changes.
'18  TextChanged	Occurs when the value of the Text property changes.

'Example
'In this example, let us put a picture box And a button control on the form. We set the image property of the picture box to logo.png, as we used before. The Click event of the button named Button1 Is coded to stretch the image to a specified size

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.ClientSize = New Size(300, 300)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class
