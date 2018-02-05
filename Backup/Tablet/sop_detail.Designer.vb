<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sop_detail
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_sop_supersedes = New System.Windows.Forms.TextBox
        Me.conmenu_sop_detail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txt_sop_count = New System.Windows.Forms.TextBox
        Me.lbl_sop_name = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp_review = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtp_effective = New System.Windows.Forms.DateTimePicker
        Me.dtp_issue = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_sop_no = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.grd_sop_detail = New System.Windows.Forms.DataGridView
        Me.sop_no = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sop_count = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sop_supersedes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.issue_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.effective_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.review_date = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.btn_clear = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_add = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        Me.tooltip_sop_detail = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_previous = New System.Windows.Forms.Button
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_last = New System.Windows.Forms.Button
        Me.btn_first = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_sop_detail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_sop_supersedes)
        Me.GroupBox1.Controls.Add(Me.txt_sop_count)
        Me.GroupBox1.Controls.Add(Me.lbl_sop_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp_review)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_effective)
        Me.GroupBox1.Controls.Add(Me.dtp_issue)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmb_sop_no)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(45, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SOP Alert Information"
        '
        'txt_sop_supersedes
        '
        Me.txt_sop_supersedes.ContextMenuStrip = Me.conmenu_sop_detail
        Me.txt_sop_supersedes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sop_supersedes.Location = New System.Drawing.Point(182, 94)
        Me.txt_sop_supersedes.Name = "txt_sop_supersedes"
        Me.txt_sop_supersedes.Size = New System.Drawing.Size(132, 21)
        Me.txt_sop_supersedes.TabIndex = 3
        Me.tooltip_sop_detail.SetToolTip(Me.txt_sop_supersedes, "enter sop supersede")
        '
        'conmenu_sop_detail
        '
        Me.conmenu_sop_detail.Name = "conmenu_sop_master"
        Me.conmenu_sop_detail.Size = New System.Drawing.Size(61, 4)
        '
        'txt_sop_count
        '
        Me.txt_sop_count.ContextMenuStrip = Me.conmenu_sop_detail
        Me.txt_sop_count.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sop_count.Location = New System.Drawing.Point(185, 61)
        Me.txt_sop_count.Name = "txt_sop_count"
        Me.txt_sop_count.Size = New System.Drawing.Size(132, 21)
        Me.txt_sop_count.TabIndex = 2
        Me.tooltip_sop_detail.SetToolTip(Me.txt_sop_count, "enter sop count")
        '
        'lbl_sop_name
        '
        Me.lbl_sop_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sop_name.Location = New System.Drawing.Point(182, 128)
        Me.lbl_sop_name.Name = "lbl_sop_name"
        Me.lbl_sop_name.Size = New System.Drawing.Size(409, 60)
        Me.lbl_sop_name.TabIndex = 0
        Me.lbl_sop_name.Text = "sop name"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "SOP Count   :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(386, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Issue Date       :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(386, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Review Date    :"
        '
        'dtp_review
        '
        Me.dtp_review.ContextMenuStrip = Me.conmenu_sop_detail
        Me.dtp_review.CustomFormat = "dd/MM/yyyy"
        Me.dtp_review.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_review.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_review.Location = New System.Drawing.Point(549, 95)
        Me.dtp_review.Name = "dtp_review"
        Me.dtp_review.Size = New System.Drawing.Size(167, 21)
        Me.dtp_review.TabIndex = 6
        Me.tooltip_sop_detail.SetToolTip(Me.dtp_review, "enter review date")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(386, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Effective Date :"
        '
        'dtp_effective
        '
        Me.dtp_effective.ContextMenuStrip = Me.conmenu_sop_detail
        Me.dtp_effective.CustomFormat = "dd/MM/yyyy"
        Me.dtp_effective.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_effective.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_effective.Location = New System.Drawing.Point(549, 59)
        Me.dtp_effective.Name = "dtp_effective"
        Me.dtp_effective.Size = New System.Drawing.Size(167, 21)
        Me.dtp_effective.TabIndex = 5
        Me.tooltip_sop_detail.SetToolTip(Me.dtp_effective, "enter effective date")
        '
        'dtp_issue
        '
        Me.dtp_issue.ContextMenuStrip = Me.conmenu_sop_detail
        Me.dtp_issue.CustomFormat = "dd/MM/yyyy"
        Me.dtp_issue.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_issue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_issue.Location = New System.Drawing.Point(549, 22)
        Me.dtp_issue.Name = "dtp_issue"
        Me.dtp_issue.Size = New System.Drawing.Size(167, 21)
        Me.dtp_issue.TabIndex = 4
        Me.tooltip_sop_detail.SetToolTip(Me.dtp_issue, "enter issue date")
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SOP Name   :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SOP No         :"
        '
        'cmb_sop_no
        '
        Me.cmb_sop_no.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_sop_no.ContextMenuStrip = Me.conmenu_sop_detail
        Me.cmb_sop_no.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_sop_no.FormattingEnabled = True
        Me.cmb_sop_no.Location = New System.Drawing.Point(182, 22)
        Me.cmb_sop_no.Name = "cmb_sop_no"
        Me.cmb_sop_no.Size = New System.Drawing.Size(159, 21)
        Me.cmb_sop_no.TabIndex = 1
        Me.tooltip_sop_detail.SetToolTip(Me.cmb_sop_no, "select sop number")
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Supersedes :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(314, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SOP DETAIL"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grd_sop_detail
        '
        Me.grd_sop_detail.AllowUserToAddRows = False
        Me.grd_sop_detail.AllowUserToDeleteRows = False
        Me.grd_sop_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_sop_detail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sop_no, Me.sop_count, Me.sop_supersedes, Me.issue_date, Me.effective_date, Me.review_date})
        Me.grd_sop_detail.Location = New System.Drawing.Point(45, 270)
        Me.grd_sop_detail.Name = "grd_sop_detail"
        Me.grd_sop_detail.ReadOnly = True
        Me.grd_sop_detail.Size = New System.Drawing.Size(730, 275)
        Me.grd_sop_detail.TabIndex = 0
        Me.grd_sop_detail.TabStop = False
        Me.tooltip_sop_detail.SetToolTip(Me.grd_sop_detail, "display records")
        '
        'sop_no
        '
        Me.sop_no.HeaderText = "SOP_No"
        Me.sop_no.Name = "sop_no"
        Me.sop_no.ReadOnly = True
        '
        'sop_count
        '
        Me.sop_count.HeaderText = "Sop_Count"
        Me.sop_count.Name = "sop_count"
        Me.sop_count.ReadOnly = True
        '
        'sop_supersedes
        '
        Me.sop_supersedes.HeaderText = "Sop_Supersedes"
        Me.sop_supersedes.Name = "sop_supersedes"
        Me.sop_supersedes.ReadOnly = True
        '
        'issue_date
        '
        DataGridViewCellStyle13.Format = "dd/MM/yy"
        Me.issue_date.DefaultCellStyle = DataGridViewCellStyle13
        Me.issue_date.HeaderText = "Issue_Date"
        Me.issue_date.Name = "issue_date"
        Me.issue_date.ReadOnly = True
        '
        'effective_date
        '
        DataGridViewCellStyle14.Format = "dd/MM/yy"
        Me.effective_date.DefaultCellStyle = DataGridViewCellStyle14
        Me.effective_date.HeaderText = "Effective_Date"
        Me.effective_date.Name = "effective_date"
        Me.effective_date.ReadOnly = True
        '
        'review_date
        '
        DataGridViewCellStyle15.Format = "dd/MM/yy"
        Me.review_date.DefaultCellStyle = DataGridViewCellStyle15
        Me.review_date.HeaderText = "Review_Date"
        Me.review_date.Name = "review_date"
        Me.review_date.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_close)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_delete)
        Me.GroupBox2.Controls.Add(Me.btn_edit)
        Me.GroupBox2.Controls.Add(Me.btn_add)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(45, 565)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 96)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transactions"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(312, 56)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(117, 31)
        Me.btn_close.TabIndex = 13
        Me.btn_close.Text = "Cl&ose"
        Me.tooltip_sop_detail.SetToolTip(Me.btn_close, "close the form")
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.Location = New System.Drawing.Point(31, 57)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(119, 31)
        Me.btn_search.TabIndex = 11
        Me.btn_search.Text = "&Search"
        Me.tooltip_sop_detail.SetToolTip(Me.btn_search, "search a record")
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Location = New System.Drawing.Point(169, 56)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(119, 31)
        Me.btn_clear.TabIndex = 12
        Me.btn_clear.Text = "&Clear"
        Me.tooltip_sop_detail.SetToolTip(Me.btn_clear, "clear the content of controls on the form")
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(310, 20)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(119, 31)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "&Delete"
        Me.tooltip_sop_detail.SetToolTip(Me.btn_delete, "delete a record")
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.Location = New System.Drawing.Point(169, 19)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(119, 31)
        Me.btn_edit.TabIndex = 9
        Me.btn_edit.Text = "&Edit"
        Me.tooltip_sop_detail.SetToolTip(Me.btn_edit, "edit a record")
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Location = New System.Drawing.Point(31, 20)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(119, 31)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "&Add"
        Me.tooltip_sop_detail.SetToolTip(Me.btn_add, "add a record")
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 676)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(823, 22)
        Me.StatusStrip1.TabIndex = 36
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_previous)
        Me.GroupBox3.Controls.Add(Me.btn_next)
        Me.GroupBox3.Controls.Add(Me.btn_last)
        Me.GroupBox3.Controls.Add(Me.btn_first)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(511, 566)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(261, 92)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'btn_previous
        '
        Me.btn_previous.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_previous.FlatAppearance.BorderSize = 0
        Me.btn_previous.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.ForeColor = System.Drawing.Color.Black
        Me.btn_previous.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_previous.Location = New System.Drawing.Point(10, 54)
        Me.btn_previous.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(110, 31)
        Me.btn_previous.TabIndex = 8
        Me.btn_previous.Text = "&Previous"
        Me.btn_previous.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.Black
        Me.btn_next.Location = New System.Drawing.Point(140, 52)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(110, 31)
        Me.btn_next.TabIndex = 9
        Me.btn_next.Text = "&Next"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_last.FlatAppearance.BorderSize = 0
        Me.btn_last.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.ForeColor = System.Drawing.Color.Black
        Me.btn_last.Location = New System.Drawing.Point(139, 17)
        Me.btn_last.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(110, 31)
        Me.btn_last.TabIndex = 6
        Me.btn_last.Text = "&Last"
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'btn_first
        '
        Me.btn_first.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_first.FlatAppearance.BorderSize = 0
        Me.btn_first.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.ForeColor = System.Drawing.Color.Black
        Me.btn_first.Location = New System.Drawing.Point(8, 19)
        Me.btn_first.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(110, 31)
        Me.btn_first.TabIndex = 5
        Me.btn_first.Text = "&First"
        Me.btn_first.UseVisualStyleBackColor = False
        '
        'sop_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 698)
        Me.ContextMenuStrip = Me.conmenu_sop_detail
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grd_sop_detail)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "sop_detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sop Detail"
        Me.tooltip_sop_detail.SetToolTip(Me, "sop detail")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_sop_detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sop_supersedes As System.Windows.Forms.TextBox
    Friend WithEvents txt_sop_count As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sop_name As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp_review As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_effective As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_issue As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_sop_no As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grd_sop_detail As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents conmenu_sop_detail As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip_sop_detail As System.Windows.Forms.ToolTip
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents sop_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sop_count As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sop_supersedes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents issue_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents effective_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents review_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_first As System.Windows.Forms.Button
End Class
