<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBinarySearch
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lblFirstTwo = New System.Windows.Forms.Label()
    Me.mtbInput = New System.Windows.Forms.MaskedTextBox()
    Me.btnSearch = New System.Windows.Forms.Button()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.lstStates = New System.Windows.Forms.ListBox()
    Me.SuspendLayout
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "States:"
    '
    'lblFirstTwo
    '
    Me.lblFirstTwo.Location = New System.Drawing.Point(131, 29)
    Me.lblFirstTwo.Name = "lblFirstTwo"
    Me.lblFirstTwo.Size = New System.Drawing.Size(77, 26)
    Me.lblFirstTwo.TabIndex = 10
    Me.lblFirstTwo.Text = "First two letters of state:"
    '
    'mtbInput
    '
    Me.mtbInput.Location = New System.Drawing.Point(216, 32)
    Me.mtbInput.Mask = "LL"
    Me.mtbInput.Name = "mtbInput"
    Me.mtbInput.Size = New System.Drawing.Size(21, 20)
    Me.mtbInput.TabIndex = 6
    '
    'btnSearch
    '
    Me.btnSearch.Location = New System.Drawing.Point(134, 89)
    Me.btnSearch.Name = "btnSearch"
    Me.btnSearch.Size = New System.Drawing.Size(112, 29)
    Me.btnSearch.TabIndex = 9
    Me.btnSearch.Text = "Search For State"
    Me.btnSearch.UseVisualStyleBackColor = true
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(60, 195)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(140, 20)
    Me.txtOutput.TabIndex = 8
    '
    'lstStates
    '
    Me.lstStates.FormattingEnabled = true
    Me.lstStates.Items.AddRange(New Object() {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Montana", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"})
    Me.lstStates.Location = New System.Drawing.Point(15, 29)
    Me.lstStates.Name = "lstStates"
    Me.lstStates.Size = New System.Drawing.Size(100, 160)
    Me.lstStates.Sorted = true
    Me.lstStates.TabIndex = 7
    '
    'frmBinarySearch
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(278, 234)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lblFirstTwo)
    Me.Controls.Add(Me.mtbInput)
    Me.Controls.Add(Me.btnSearch)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.lstStates)
    Me.Name = "frmBinarySearch"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Binary Search"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents lblFirstTwo As Label
  Friend WithEvents mtbInput As MaskedTextBox
  Friend WithEvents btnSearch As Button
  Friend WithEvents txtOutput As TextBox
  Friend WithEvents lstStates As ListBox
End Class
