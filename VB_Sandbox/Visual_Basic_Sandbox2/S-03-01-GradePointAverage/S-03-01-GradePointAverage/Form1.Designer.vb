<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPA
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
    Me.txtGPA = New System.Windows.Forms.TextBox()
    Me.cmbGrades = New System.Windows.Forms.ComboBox()
    Me.txtHours = New System.Windows.Forms.TextBox()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.btnRecord = New System.Windows.Forms.Button()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'txtGPA
    '
    Me.txtGPA.Enabled = false
    Me.txtGPA.Location = New System.Drawing.Point(82, 191)
    Me.txtGPA.Name = "txtGPA"
    Me.txtGPA.Size = New System.Drawing.Size(85, 20)
    Me.txtGPA.TabIndex = 16
    '
    'cmbGrades
    '
    Me.cmbGrades.FormattingEnabled = true
    Me.cmbGrades.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
    Me.cmbGrades.Location = New System.Drawing.Point(82, 15)
    Me.cmbGrades.Name = "cmbGrades"
    Me.cmbGrades.Size = New System.Drawing.Size(85, 21)
    Me.cmbGrades.TabIndex = 10
    Me.cmbGrades.Text = "Select Grade"
    '
    'txtHours
    '
    Me.txtHours.Location = New System.Drawing.Point(82, 52)
    Me.txtHours.Name = "txtHours"
    Me.txtHours.Size = New System.Drawing.Size(85, 20)
    Me.txtHours.TabIndex = 12
    '
    'btnCalculate
    '
    Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlDark
    Me.btnCalculate.Location = New System.Drawing.Point(14, 139)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(153, 35)
    Me.btnCalculate.TabIndex = 15
    Me.btnCalculate.Text = "Calculate GPA"
    Me.btnCalculate.UseVisualStyleBackColor = false
    '
    'btnRecord
    '
    Me.btnRecord.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.btnRecord.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnRecord.ForeColor = System.Drawing.SystemColors.ControlDark
    Me.btnRecord.Location = New System.Drawing.Point(14, 87)
    Me.btnRecord.Name = "btnRecord"
    Me.btnRecord.Size = New System.Drawing.Size(153, 36)
    Me.btnRecord.TabIndex = 14
    Me.btnRecord.Text = "Record This Course"
    Me.btnRecord.UseVisualStyleBackColor = false
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(47, 194)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(29, 13)
    Me.Label3.TabIndex = 13
    Me.Label3.Text = "GPA"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(11, 59)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 11
    Me.Label2.Text = "Credit Hours"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(40, 18)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(36, 13)
    Me.Label1.TabIndex = 9
    Me.Label1.Text = "Grade"
    '
    'frmGPA
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(191, 223)
    Me.Controls.Add(Me.txtGPA)
    Me.Controls.Add(Me.cmbGrades)
    Me.Controls.Add(Me.txtHours)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.btnRecord)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmGPA"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "GPA"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtGPA As TextBox
  Friend WithEvents cmbGrades As ComboBox
  Friend WithEvents txtHours As TextBox
  Friend WithEvents btnCalculate As Button
  Friend WithEvents btnRecord As Button
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
