<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liquid_calculation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.minimum_sample = New System.Windows.Forms.TabPage
        Me.lb_amax_tb1 = New System.Windows.Forms.Label
        Me.btn_max_clear = New System.Windows.Forms.Button
        Me.btn_max_result = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lbl_max_averageweight_range = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lbl_max_average_weight = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_max_result = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txt_max = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.maximium_sample = New System.Windows.Forms.TabPage
        Me.lb_amin_tb2 = New System.Windows.Forms.Label
        Me.btn_min_clear = New System.Windows.Forms.Button
        Me.btn_min_result = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_min_averageweight_range = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_min_average_weight = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_min_result = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_min = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.minimum_sample.SuspendLayout()
        Me.maximium_sample.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.minimum_sample)
        Me.TabControl1.Controls.Add(Me.maximium_sample)
        Me.TabControl1.ItemSize = New System.Drawing.Size(94, 21)
        Me.TabControl1.Location = New System.Drawing.Point(3, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(425, 247)
        Me.TabControl1.TabIndex = 3
        '
        'minimum_sample
        '
        Me.minimum_sample.Controls.Add(Me.lb_amax_tb1)
        Me.minimum_sample.Controls.Add(Me.btn_max_clear)
        Me.minimum_sample.Controls.Add(Me.btn_max_result)
        Me.minimum_sample.Controls.Add(Me.Label28)
        Me.minimum_sample.Controls.Add(Me.Label27)
        Me.minimum_sample.Controls.Add(Me.Label26)
        Me.minimum_sample.Controls.Add(Me.lbl_max_averageweight_range)
        Me.minimum_sample.Controls.Add(Me.Label17)
        Me.minimum_sample.Controls.Add(Me.lbl_max_average_weight)
        Me.minimum_sample.Controls.Add(Me.Label19)
        Me.minimum_sample.Controls.Add(Me.txt_max_result)
        Me.minimum_sample.Controls.Add(Me.Label20)
        Me.minimum_sample.Controls.Add(Me.txt_max)
        Me.minimum_sample.Controls.Add(Me.Label21)
        Me.minimum_sample.Controls.Add(Me.Label22)
        Me.minimum_sample.Location = New System.Drawing.Point(4, 25)
        Me.minimum_sample.Name = "minimum_sample"
        Me.minimum_sample.Padding = New System.Windows.Forms.Padding(3)
        Me.minimum_sample.Size = New System.Drawing.Size(417, 218)
        Me.minimum_sample.TabIndex = 1
        Me.minimum_sample.Text = "Maximum Sample"
        Me.minimum_sample.UseVisualStyleBackColor = True
        '
        'lb_amax_tb1
        '
        Me.lb_amax_tb1.AutoSize = True
        Me.lb_amax_tb1.Location = New System.Drawing.Point(155, 35)
        Me.lb_amax_tb1.Name = "lb_amax_tb1"
        Me.lb_amax_tb1.Size = New System.Drawing.Size(13, 13)
        Me.lb_amax_tb1.TabIndex = 0
        Me.lb_amax_tb1.Text = "0"
        '
        'btn_max_clear
        '
        Me.btn_max_clear.Location = New System.Drawing.Point(198, 194)
        Me.btn_max_clear.Name = "btn_max_clear"
        Me.btn_max_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_max_clear.TabIndex = 4
        Me.btn_max_clear.Text = "Clear"
        Me.btn_max_clear.UseVisualStyleBackColor = True
        '
        'btn_max_result
        '
        Me.btn_max_result.Location = New System.Drawing.Point(66, 194)
        Me.btn_max_result.Name = "btn_max_result"
        Me.btn_max_result.Size = New System.Drawing.Size(75, 23)
        Me.btn_max_result.TabIndex = 3
        Me.btn_max_result.Text = "Result"
        Me.btn_max_result.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(263, 124)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(15, 13)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "%"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(214, 75)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(21, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "gm"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(214, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(21, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "gm"
        '
        'lbl_max_averageweight_range
        '
        Me.lbl_max_averageweight_range.AutoSize = True
        Me.lbl_max_averageweight_range.Location = New System.Drawing.Point(269, 166)
        Me.lbl_max_averageweight_range.Name = "lbl_max_averageweight_range"
        Me.lbl_max_averageweight_range.Size = New System.Drawing.Size(84, 13)
        Me.lbl_max_averageweight_range.TabIndex = 0
        Me.lbl_max_averageweight_range.Text = "Average Weight"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(244, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "+"
        '
        'lbl_max_average_weight
        '
        Me.lbl_max_average_weight.AutoSize = True
        Me.lbl_max_average_weight.Location = New System.Drawing.Point(155, 166)
        Me.lbl_max_average_weight.Name = "lbl_max_average_weight"
        Me.lbl_max_average_weight.Size = New System.Drawing.Size(84, 13)
        Me.lbl_max_average_weight.TabIndex = 0
        Me.lbl_max_average_weight.Text = "Average Weight"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(28, 165)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Range"
        '
        'txt_max_result
        '
        Me.txt_max_result.Location = New System.Drawing.Point(155, 119)
        Me.txt_max_result.Name = "txt_max_result"
        Me.txt_max_result.Size = New System.Drawing.Size(100, 20)
        Me.txt_max_result.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(28, 122)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Result"
        '
        'txt_max
        '
        Me.txt_max.Location = New System.Drawing.Point(155, 71)
        Me.txt_max.Name = "txt_max"
        Me.txt_max.Size = New System.Drawing.Size(55, 20)
        Me.txt_max.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(28, 78)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Maximum Weight"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(28, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Average Weight"
        '
        'maximium_sample
        '
        Me.maximium_sample.Controls.Add(Me.lb_amin_tb2)
        Me.maximium_sample.Controls.Add(Me.btn_min_clear)
        Me.maximium_sample.Controls.Add(Me.btn_min_result)
        Me.maximium_sample.Controls.Add(Me.Label1)
        Me.maximium_sample.Controls.Add(Me.Label2)
        Me.maximium_sample.Controls.Add(Me.Label3)
        Me.maximium_sample.Controls.Add(Me.lbl_min_averageweight_range)
        Me.maximium_sample.Controls.Add(Me.Label5)
        Me.maximium_sample.Controls.Add(Me.lbl_min_average_weight)
        Me.maximium_sample.Controls.Add(Me.Label7)
        Me.maximium_sample.Controls.Add(Me.txt_min_result)
        Me.maximium_sample.Controls.Add(Me.Label8)
        Me.maximium_sample.Controls.Add(Me.txt_min)
        Me.maximium_sample.Controls.Add(Me.Label23)
        Me.maximium_sample.Controls.Add(Me.Label24)
        Me.maximium_sample.Location = New System.Drawing.Point(4, 25)
        Me.maximium_sample.Name = "maximium_sample"
        Me.maximium_sample.Padding = New System.Windows.Forms.Padding(3)
        Me.maximium_sample.Size = New System.Drawing.Size(417, 218)
        Me.maximium_sample.TabIndex = 2
        Me.maximium_sample.Text = "Minimum Sample"
        Me.maximium_sample.UseVisualStyleBackColor = True
        '
        'lb_amin_tb2
        '
        Me.lb_amin_tb2.AutoSize = True
        Me.lb_amin_tb2.Location = New System.Drawing.Point(171, 29)
        Me.lb_amin_tb2.Name = "lb_amin_tb2"
        Me.lb_amin_tb2.Size = New System.Drawing.Size(13, 13)
        Me.lb_amin_tb2.TabIndex = 0
        Me.lb_amin_tb2.Text = "0"
        '
        'btn_min_clear
        '
        Me.btn_min_clear.Location = New System.Drawing.Point(242, 191)
        Me.btn_min_clear.Name = "btn_min_clear"
        Me.btn_min_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_min_clear.TabIndex = 4
        Me.btn_min_clear.Text = "Clear"
        Me.btn_min_clear.UseVisualStyleBackColor = True
        '
        'btn_min_result
        '
        Me.btn_min_result.Location = New System.Drawing.Point(101, 191)
        Me.btn_min_result.Name = "btn_min_result"
        Me.btn_min_result.Size = New System.Drawing.Size(75, 23)
        Me.btn_min_result.TabIndex = 3
        Me.btn_min_result.Text = "Result"
        Me.btn_min_result.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "gm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "gm"
        '
        'lbl_min_averageweight_range
        '
        Me.lbl_min_averageweight_range.AutoSize = True
        Me.lbl_min_averageweight_range.Location = New System.Drawing.Point(287, 163)
        Me.lbl_min_averageweight_range.Name = "lbl_min_averageweight_range"
        Me.lbl_min_averageweight_range.Size = New System.Drawing.Size(84, 13)
        Me.lbl_min_averageweight_range.TabIndex = 0
        Me.lbl_min_averageweight_range.Text = "Average Weight"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(255, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "+"
        '
        'lbl_min_average_weight
        '
        Me.lbl_min_average_weight.AutoSize = True
        Me.lbl_min_average_weight.Location = New System.Drawing.Point(162, 163)
        Me.lbl_min_average_weight.Name = "lbl_min_average_weight"
        Me.lbl_min_average_weight.Size = New System.Drawing.Size(84, 13)
        Me.lbl_min_average_weight.TabIndex = 0
        Me.lbl_min_average_weight.Text = "Average Weight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Range"
        '
        'txt_min_result
        '
        Me.txt_min_result.Location = New System.Drawing.Point(164, 116)
        Me.txt_min_result.Name = "txt_min_result"
        Me.txt_min_result.Size = New System.Drawing.Size(100, 20)
        Me.txt_min_result.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Result"
        '
        'txt_min
        '
        Me.txt_min.Location = New System.Drawing.Point(164, 68)
        Me.txt_min.Name = "txt_min"
        Me.txt_min.Size = New System.Drawing.Size(55, 20)
        Me.txt_min.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(46, 75)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(85, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Minimum Weight"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(46, 29)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Average Weight"
        '
        'liquid_calculation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 251)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "liquid_calculation"
        Me.Text = "liquid_calculation"
        Me.TabControl1.ResumeLayout(False)
        Me.minimum_sample.ResumeLayout(False)
        Me.minimum_sample.PerformLayout()
        Me.maximium_sample.ResumeLayout(False)
        Me.maximium_sample.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents minimum_sample As System.Windows.Forms.TabPage
    Friend WithEvents lb_amax_tb1 As System.Windows.Forms.Label
    Friend WithEvents btn_max_clear As System.Windows.Forms.Button
    Friend WithEvents btn_max_result As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbl_max_averageweight_range As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lbl_max_average_weight As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_max_result As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_max As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents maximium_sample As System.Windows.Forms.TabPage
    Friend WithEvents lb_amin_tb2 As System.Windows.Forms.Label
    Friend WithEvents btn_min_clear As System.Windows.Forms.Button
    Friend WithEvents btn_min_result As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_min_averageweight_range As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_min_average_weight As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_min_result As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_min As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
