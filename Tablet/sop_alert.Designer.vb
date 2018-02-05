<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sop_alert
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grd_sop_alert = New System.Windows.Forms.DataGridView
        Me.Sop_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sop_Count = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sop_Supersedes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Issue_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Effective_Date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Review_Date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Review_Status = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.txt_sop_count = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        Me.conmenu_sop_alert = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tooltip_sop_alert = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.grd_sop_alert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_sop_alert
        '
        Me.grd_sop_alert.AllowUserToAddRows = False
        Me.grd_sop_alert.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_sop_alert.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_sop_alert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_sop_alert.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sop_No, Me.Sop_Count, Me.Sop_Supersedes, Me.Issue_date, Me.Effective_Date, Me.Review_Date, Me.Review_Status})
        Me.grd_sop_alert.Location = New System.Drawing.Point(46, 237)
        Me.grd_sop_alert.Name = "grd_sop_alert"
        Me.grd_sop_alert.Size = New System.Drawing.Size(740, 374)
        Me.grd_sop_alert.TabIndex = 1
        Me.grd_sop_alert.TabStop = False
        '
        'Sop_No
        '
        Me.Sop_No.HeaderText = "Sop No"
        Me.Sop_No.Name = "Sop_No"
        '
        'Sop_Count
        '
        Me.Sop_Count.HeaderText = "Sop Count"
        Me.Sop_Count.Name = "Sop_Count"
        '
        'Sop_Supersedes
        '
        Me.Sop_Supersedes.HeaderText = "Sop Supersedes"
        Me.Sop_Supersedes.Name = "Sop_Supersedes"
        '
        'Issue_date
        '
        Me.Issue_date.HeaderText = "Issue Date"
        Me.Issue_date.Name = "Issue_date"
        '
        'Effective_Date
        '
        Me.Effective_Date.HeaderText = "Effective Date"
        Me.Effective_Date.Name = "Effective_Date"
        '
        'Review_Date
        '
        Me.Review_Date.HeaderText = "Review Date"
        Me.Review_Date.Name = "Review_Date"
        '
        'Review_Status
        '
        Me.Review_Status.HeaderText = "Review Status"
        Me.Review_Status.Name = "Review_Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.txt_sop_count)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(139, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search & Update"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Location = New System.Drawing.Point(446, 33)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(60, 31)
        Me.btn_update.TabIndex = 15
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Location = New System.Drawing.Point(347, 32)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(60, 31)
        Me.btn_search.TabIndex = 14
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_sop_count
        '
        Me.txt_sop_count.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sop_count.Location = New System.Drawing.Point(175, 38)
        Me.txt_sop_count.Name = "txt_sop_count"
        Me.txt_sop_count.Size = New System.Drawing.Size(116, 22)
        Me.txt_sop_count.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "SOP Count   :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 698)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(915, 22)
        Me.StatusStrip1.TabIndex = 37
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel1.Text = "Record"
        '
        'status_lbl_record_number
        '
        Me.status_lbl_record_number.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lbl_record_number.Name = "status_lbl_record_number"
        Me.status_lbl_record_number.Size = New System.Drawing.Size(15, 17)
        Me.status_lbl_record_number.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(47, 17)
        Me.ToolStripStatusLabel3.Text = "Out Of"
        '
        'status_lbl_total_record
        '
        Me.status_lbl_total_record.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lbl_total_record.Name = "status_lbl_total_record"
        Me.status_lbl_total_record.Size = New System.Drawing.Size(15, 17)
        Me.status_lbl_total_record.Text = "0"
        '
        'conmenu_sop_alert
        '
        Me.conmenu_sop_alert.Name = "conmenu_sop_master"
        Me.conmenu_sop_alert.Size = New System.Drawing.Size(61, 4)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 23)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "SOP ALERT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sop_alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 720)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grd_sop_alert)
        Me.Name = "sop_alert"
        Me.Text = "Sop Alert"
        CType(Me.grd_sop_alert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_sop_alert As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_sop_count As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents conmenu_sop_alert As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip_sop_alert As System.Windows.Forms.ToolTip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Sop_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sop_Count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sop_Supersedes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Issue_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Effective_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Review_Date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Review_Status As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
