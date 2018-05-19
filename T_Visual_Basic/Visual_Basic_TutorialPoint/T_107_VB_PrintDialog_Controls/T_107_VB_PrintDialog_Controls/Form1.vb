'VB.Net -PrintDialog Control
'The PrintDialog control lets the user To print documents by selecting a printer And choosing which sections Of the document To print from a Windows Forms application.

'There are various other controls related To printing Of documents. Let us have a brief look at these controls And their purpose. These other controls are:

'The PrintDocument control - it provides support For actual events And operations Of printing In Visual Basic And sets the properties For printing.

'The PrinterSettings control - it Is used To configure how a document Is printed by specifying the printer.

'The PageSetUpDialog control - it allows the user To specify page-related print settings including page orientation, paper size And margin size.

'The PrintPreviewControl control - it represents the raw preview part Of print previewing from a Windows Forms application, without any dialog boxes Or buttons.

'The PrintPreviewDialog control - it represents a dialog box form that contains a PrintPreviewControl For printing from a Windows Forms application.

'Following Is the Print dialog box

'Properties of the PrintDialog Control
'The following are some Of the commonly used properties Of the PrintDialog control

'S.N  Property	Description
'1   AllowCurrentPage	Gets Or sets a value indicating whether the Current Page option button Is displayed.
'2   AllowPrintToFile	Gets Or sets a value indicating whether the Print to file check box Is enabled.
'3   AllowSelection	Gets Or sets a value indicating whether the Selection option button Is enabled.
'4   AllowSomePages	Gets Or sets a value indicating whether the Pages option button Is enabled.
'5   Document	Gets Or sets a value indicating the PrintDocument used to obtain PrinterSettings.
'6   PrinterSettings	Gets Or sets the printer settings the dialog box modifies.
'7   PrintToFile	Gets Or sets a value indicating whether the Print to file check box Is selected.
'8   ShowHelp	Gets Or sets a value indicating whether the Help button Is displayed.
'9   ShowNetwork	Gets Or sets a value indicating whether the Network button Is displayed.
'Methods of the PrintDialog Control
'The following are some Of the commonly used methods Of the PrintDialog control

'S.N  Method Name & Description
'1   
'Reset

'Resets all options To their Default values.

'2   
'RunDialog

'When overridden in a derived class, specifies a common dialog box.

'3   
'ShowDialog

'Runs a common dialog box With a Default owner.

'Example
'In this example, let us see how to show a Print dialog box in a form. Take the following steps:

'Add a PrintDocument control, a PrintDialog control And a Button control On the form. The PrintDocument And the PrintDialog controls are found On the Print category Of the controls toolbox.

'Change the text Of the button To 'Print'.

'Double-click the Print button And modify the code of the Click event as shown

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub
End Class
