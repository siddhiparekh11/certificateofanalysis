<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class powder_report_viewer
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_go = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_batch_no = New System.Windows.Forms.ComboBox
        Me.cmb_product_code = New System.Windows.Forms.ComboBox
        Me.powder_report_view = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_go)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_batch_no)
        Me.GroupBox1.Controls.Add(Me.cmb_product_code)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 52)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_go.Location = New System.Drawing.Point(478, 21)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(33, 23)
        Me.btn_go.TabIndex = 5
        Me.btn_go.Text = "Go"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Batch No :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product No :"
        '
        'cmb_batch_no
        '
        Me.cmb_batch_no.FormattingEnabled = True
        Me.cmb_batch_no.Location = New System.Drawing.Point(335, 21)
        Me.cmb_batch_no.Name = "cmb_batch_no"
        Me.cmb_batch_no.Size = New System.Drawing.Size(121, 21)
        Me.cmb_batch_no.TabIndex = 2
        '
        'cmb_product_code
        '
        Me.cmb_product_code.FormattingEnabled = True
        Me.cmb_product_code.Location = New System.Drawing.Point(111, 21)
        Me.cmb_product_code.Name = "cmb_product_code"
        Me.cmb_product_code.Size = New System.Drawing.Size(121, 21)
        Me.cmb_product_code.TabIndex = 1
        '
        'powder_report_view
        '
        Me.powder_report_view.ActiveViewIndex = -1
        Me.powder_report_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.powder_report_view.DisplayGroupTree = False
        Me.powder_report_view.Location = New System.Drawing.Point(41, 105)
        Me.powder_report_view.Name = "powder_report_view"
        Me.powder_report_view.SelectionFormula = ""
        Me.powder_report_view.Size = New System.Drawing.Size(860, 577)
        Me.powder_report_view.TabIndex = 12
        Me.powder_report_view.ViewTimeSelectionFormula = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "POWDER REPORTS"
        '
        'powder_report_viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 704)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.powder_report_view)
        Me.Controls.Add(Me.Label3)
        Me.Name = "powder_report_viewer"
        Me.Text = "Powder Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_batch_no As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_product_code As System.Windows.Forms.ComboBox
    Friend WithEvents powder_report_view As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
