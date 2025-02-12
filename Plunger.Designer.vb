﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plunger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plunger))
        Me.pbPlunger = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMinValue = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblMaxValue = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblRestingPoint = New System.Windows.Forms.Label()
        Me.btnSendCalibration = New System.Windows.Forms.Button()
        Me.cbPushOnMin = New System.Windows.Forms.CheckBox()
        Me.cbPushOnMax = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbLaunchButton = New System.Windows.Forms.ComboBox()
        Me.cbAverageReadings = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStartCalibration = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbPlunger
        '
        Me.pbPlunger.Location = New System.Drawing.Point(55, 32)
        Me.pbPlunger.Margin = New System.Windows.Forms.Padding(2)
        Me.pbPlunger.MarqueeAnimationSpeed = 1
        Me.pbPlunger.Maximum = 1024
        Me.pbPlunger.Name = "pbPlunger"
        Me.pbPlunger.Size = New System.Drawing.Size(530, 31)
        Me.pbPlunger.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbPlunger.TabIndex = 0
        Me.pbPlunger.Value = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblMinValue)
        Me.GroupBox1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(183, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(124, 47)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Minimum Value"
        '
        'lblMinValue
        '
        Me.lblMinValue.AutoSize = True
        Me.lblMinValue.Location = New System.Drawing.Point(79, 21)
        Me.lblMinValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMinValue.Name = "lblMinValue"
        Me.lblMinValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMinValue.Size = New System.Drawing.Size(42, 20)
        Me.lblMinValue.TabIndex = 0
        Me.lblMinValue.Text = "1000"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMaxValue)
        Me.GroupBox2.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(322, 80)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(124, 47)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Maximum Value"
        '
        'lblMaxValue
        '
        Me.lblMaxValue.AutoSize = True
        Me.lblMaxValue.Location = New System.Drawing.Point(79, 21)
        Me.lblMaxValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaxValue.Name = "lblMaxValue"
        Me.lblMaxValue.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMaxValue.Size = New System.Drawing.Size(42, 20)
        Me.lblMaxValue.TabIndex = 1
        Me.lblMaxValue.Text = "1000"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblRestingPoint)
        Me.GroupBox3.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(464, 80)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(124, 47)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resting Point"
        '
        'lblRestingPoint
        '
        Me.lblRestingPoint.AutoSize = True
        Me.lblRestingPoint.Location = New System.Drawing.Point(76, 21)
        Me.lblRestingPoint.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRestingPoint.Name = "lblRestingPoint"
        Me.lblRestingPoint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRestingPoint.Size = New System.Drawing.Size(42, 20)
        Me.lblRestingPoint.TabIndex = 2
        Me.lblRestingPoint.Text = "1000"
        '
        'btnSendCalibration
        '
        Me.btnSendCalibration.Enabled = False
        Me.btnSendCalibration.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendCalibration.Location = New System.Drawing.Point(465, 136)
        Me.btnSendCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSendCalibration.Name = "btnSendCalibration"
        Me.btnSendCalibration.Size = New System.Drawing.Size(123, 53)
        Me.btnSendCalibration.TabIndex = 4
        Me.btnSendCalibration.Text = "Send Calibration"
        Me.btnSendCalibration.UseVisualStyleBackColor = True
        '
        'cbPushOnMin
        '
        Me.cbPushOnMin.AutoSize = True
        Me.cbPushOnMin.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPushOnMin.Location = New System.Drawing.Point(193, 134)
        Me.cbPushOnMin.Margin = New System.Windows.Forms.Padding(2)
        Me.cbPushOnMin.Name = "cbPushOnMin"
        Me.cbPushOnMin.Size = New System.Drawing.Size(134, 22)
        Me.cbPushOnMin.TabIndex = 28
        Me.cbPushOnMin.Text = "Push Button On Min"
        Me.cbPushOnMin.UseVisualStyleBackColor = True
        '
        'cbPushOnMax
        '
        Me.cbPushOnMax.AutoSize = True
        Me.cbPushOnMax.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPushOnMax.Location = New System.Drawing.Point(193, 163)
        Me.cbPushOnMax.Margin = New System.Windows.Forms.Padding(2)
        Me.cbPushOnMax.Name = "cbPushOnMax"
        Me.cbPushOnMax.Size = New System.Drawing.Size(135, 22)
        Me.cbPushOnMax.TabIndex = 29
        Me.cbPushOnMax.Text = "Push Button On Max"
        Me.cbPushOnMax.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Launch Button"
        '
        'cbLaunchButton
        '
        Me.cbLaunchButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLaunchButton.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLaunchButton.FormattingEnabled = True
        Me.cbLaunchButton.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cbLaunchButton.Location = New System.Drawing.Point(124, 131)
        Me.cbLaunchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.cbLaunchButton.Name = "cbLaunchButton"
        Me.cbLaunchButton.Size = New System.Drawing.Size(52, 25)
        Me.cbLaunchButton.TabIndex = 42
        '
        'cbAverageReadings
        '
        Me.cbAverageReadings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAverageReadings.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAverageReadings.FormattingEnabled = True
        Me.cbAverageReadings.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255"})
        Me.cbAverageReadings.Location = New System.Drawing.Point(124, 160)
        Me.cbAverageReadings.Margin = New System.Windows.Forms.Padding(2)
        Me.cbAverageReadings.Name = "cbAverageReadings"
        Me.cbAverageReadings.Size = New System.Drawing.Size(52, 25)
        Me.cbAverageReadings.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 163)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Average Readings"
        '
        'btnStartCalibration
        '
        Me.btnStartCalibration.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartCalibration.Location = New System.Drawing.Point(338, 136)
        Me.btnStartCalibration.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartCalibration.Name = "btnStartCalibration"
        Me.btnStartCalibration.Size = New System.Drawing.Size(123, 53)
        Me.btnStartCalibration.TabIndex = 46
        Me.btnStartCalibration.Text = "Calibrate Plunger"
        Me.btnStartCalibration.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblCurrent)
        Me.GroupBox4.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(52, 80)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(124, 47)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Current Value"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(79, 21)
        Me.lblCurrent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurrent.Size = New System.Drawing.Size(42, 20)
        Me.lblCurrent.TabIndex = 0
        Me.lblCurrent.Text = "1000"
        '
        'Plunger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 206)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnStartCalibration)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbAverageReadings)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbLaunchButton)
        Me.Controls.Add(Me.cbPushOnMax)
        Me.Controls.Add(Me.cbPushOnMin)
        Me.Controls.Add(Me.btnSendCalibration)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbPlunger)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Plunger"
        Me.Text = "Plunger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbPlunger As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblMinValue As Label
    Friend WithEvents lblMaxValue As Label
    Friend WithEvents lblRestingPoint As Label
    Friend WithEvents btnSendCalibration As Button
    Friend WithEvents cbPushOnMin As CheckBox
    Friend WithEvents cbPushOnMax As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbLaunchButton As ComboBox
    Friend WithEvents cbAverageReadings As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStartCalibration As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblCurrent As Label
End Class
