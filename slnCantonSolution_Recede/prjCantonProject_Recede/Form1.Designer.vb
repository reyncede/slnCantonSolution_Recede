<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.txtAssetCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalvageValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstSumOfYears = New System.Windows.Forms.ListBox()
        Me.lstDoubleDeclining = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstUsefulLife = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Asset cost:"
        '
        'txtAssetCost
        '
        Me.txtAssetCost.Location = New System.Drawing.Point(70, 45)
        Me.txtAssetCost.Name = "txtAssetCost"
        Me.txtAssetCost.Size = New System.Drawing.Size(82, 20)
        Me.txtAssetCost.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Salvage value:"
        '
        'txtSalvageValue
        '
        Me.txtSalvageValue.Location = New System.Drawing.Point(171, 45)
        Me.txtSalvageValue.Name = "txtSalvageValue"
        Me.txtSalvageValue.Size = New System.Drawing.Size(82, 20)
        Me.txtSalvageValue.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Useful life:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(70, 142)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(215, 37)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "&Display Deprecitation Schedules"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(291, 142)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstSumOfYears)
        Me.GroupBox1.Controls.Add(Me.lstDoubleDeclining)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 190)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depreciation schedules"
        '
        'lstSumOfYears
        '
        Me.lstSumOfYears.FormattingEnabled = True
        Me.lstSumOfYears.Location = New System.Drawing.Point(188, 48)
        Me.lstSumOfYears.Name = "lstSumOfYears"
        Me.lstSumOfYears.Size = New System.Drawing.Size(146, 121)
        Me.lstSumOfYears.TabIndex = 3
        '
        'lstDoubleDeclining
        '
        Me.lstDoubleDeclining.FormattingEnabled = True
        Me.lstDoubleDeclining.Location = New System.Drawing.Point(16, 48)
        Me.lstDoubleDeclining.Name = "lstDoubleDeclining"
        Me.lstDoubleDeclining.Size = New System.Drawing.Size(146, 121)
        Me.lstDoubleDeclining.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sum-of-the-years' digits:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Double-declining balance:"
        '
        'lstUsefulLife
        '
        Me.lstUsefulLife.FormattingEnabled = True
        Me.lstUsefulLife.Location = New System.Drawing.Point(273, 45)
        Me.lstUsefulLife.Name = "lstUsefulLife"
        Me.lstUsefulLife.Size = New System.Drawing.Size(80, 69)
        Me.lstUsefulLife.TabIndex = 5
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 408)
        Me.Controls.Add(Me.lstUsefulLife)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSalvageValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAssetCost)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                    Canton Manufacturing Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAssetCost As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSalvageValue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lstUsefulLife As ListBox
    Friend WithEvents lstSumOfYears As ListBox
    Friend WithEvents lstDoubleDeclining As ListBox
End Class
