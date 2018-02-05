<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sop_master
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmb_dept = New System.Windows.Forms.ComboBox
        Me.conmenu_sop_master = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_sop_no = New System.Windows.Forms.TextBox
        Me.txt_sop_name = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btn_clear = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.grd_sop_master = New System.Windows.Forms.DataGridView
        Me.btn_edit = New System.Windows.Forms.Button
        Me.btn_add = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_close = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.toolstripstatuslabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_total_records = New System.Windows.Forms.ToolStripStatusLabel
        Me.tooltip_sop_master = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_previous = New System.Windows.Forms.Button
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_last = New System.Windows.Forms.Button
        Me.btn_first = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_sop_master, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Department :"
        '
        'cmb_dept
        '
        Me.cmb_dept.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmb_dept.ContextMenuStrip = Me.conmenu_sop_master
        Me.cmb_dept.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_dept.FormattingEnabled = True
        Me.cmb_dept.Items.AddRange(New Object() {"QC/GEN", "QC/OPN", "QC/CLN", "QC/CAL", "QA/GEN", "QA/OPN", "QA/CLN", "QA/CAL", "PDN/GEN", "PDN/OPN", "PDN/CAL", "PDN/CLN", "ADN/GEN", "ADN/OPN", "ADN/CAL", "ADN/CLN", "WHD/CLN", "WHD/CAL", "WHD/OPN", "WHD/GEN", "ENG/CAL", "ENG/OPN", "ENG/CLN", "ENG/GEN", "ACC"})
        Me.cmb_dept.Location = New System.Drawing.Point(158, 25)
        Me.cmb_dept.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmb_dept.Name = "cmb_dept"
        Me.cmb_dept.Size = New System.Drawing.Size(116, 22)
        Me.cmb_dept.TabIndex = 1
        Me.tooltip_sop_master.SetToolTip(Me.cmb_dept, "select department code")
        '
        'conmenu_sop_master
        '
        Me.conmenu_sop_master.Name = "conmenu_sop_master"
        Me.conmenu_sop_master.Size = New System.Drawing.Size(61, 4)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SOP No          :"
        '
        'txt_sop_no
        '
        Me.txt_sop_no.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_sop_no.ContextMenuStrip = Me.conmenu_sop_master
        Me.txt_sop_no.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sop_no.Location = New System.Drawing.Point(158, 62)
        Me.txt_sop_no.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_sop_no.MaxLength = 0
        Me.txt_sop_no.Name = "txt_sop_no"
        Me.txt_sop_no.Size = New System.Drawing.Size(116, 22)
        Me.txt_sop_no.TabIndex = 2
        Me.tooltip_sop_master.SetToolTip(Me.txt_sop_no, "enter sop number")
        '
        'txt_sop_name
        '
        Me.txt_sop_name.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_sop_name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sop_name.Location = New System.Drawing.Point(158, 103)
        Me.txt_sop_name.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_sop_name.Multiline = True
        Me.txt_sop_name.Name = "txt_sop_name"
        Me.txt_sop_name.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_sop_name.Size = New System.Drawing.Size(215, 56)
        Me.txt_sop_name.TabIndex = 3
        Me.tooltip_sop_master.SetToolTip(Me.txt_sop_name, "enter sop name")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmb_dept)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_sop_no)
        Me.GroupBox1.Controls.Add(Me.txt_sop_name)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(42, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(480, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sop Details"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SOP Name       :"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Black
        Me.btn_clear.Location = New System.Drawing.Point(85, 55)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(53, 31)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "&Clear"
        Me.tooltip_sop_master.SetToolTip(Me.btn_clear, "clear a data form the controls")
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.Black
        Me.btn_search.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_search.Location = New System.Drawing.Point(18, 55)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(53, 31)
        Me.btn_search.TabIndex = 8
        Me.btn_search.Text = "&Search"
        Me.tooltip_sop_master.SetToolTip(Me.btn_search, "search a record")
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Location = New System.Drawing.Point(153, 18)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(53, 31)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "&Delete"
        Me.tooltip_sop_master.SetToolTip(Me.btn_delete, "delete a record")
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'grd_sop_master
        '
        Me.grd_sop_master.AllowUserToAddRows = False
        Me.grd_sop_master.AllowUserToDeleteRows = False
        Me.grd_sop_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_sop_master.Location = New System.Drawing.Point(45, 286)
        Me.grd_sop_master.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grd_sop_master.Name = "grd_sop_master"
        Me.grd_sop_master.ReadOnly = True
        Me.grd_sop_master.Size = New System.Drawing.Size(480, 278)
        Me.grd_sop_master.TabIndex = 0
        Me.grd_sop_master.TabStop = False
        Me.tooltip_sop_master.SetToolTip(Me.grd_sop_master, "displays records")
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Black
        Me.btn_edit.Location = New System.Drawing.Point(85, 18)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(53, 31)
        Me.btn_edit.TabIndex = 6
        Me.btn_edit.Text = "&Edit"
        Me.tooltip_sop_master.SetToolTip(Me.btn_edit, "edit a record")
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Black
        Me.btn_add.Location = New System.Drawing.Point(18, 19)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(53, 31)
        Me.btn_add.TabIndex = 5
        Me.btn_add.Text = "&Add"
        Me.tooltip_sop_master.SetToolTip(Me.btn_add, "add a record")
        Me.btn_add.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Location = New System.Drawing.Point(51, 570)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(224, 92)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operations"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_close.ContextMenuStrip = Me.conmenu_sop_master
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(155, 55)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(53, 31)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Cl&ose"
        Me.tooltip_sop_master.SetToolTip(Me.btn_close, "close the form")
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_record_number, Me.toolstripstatuslabel2, Me.status_total_records})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 675)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(582, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel1.Text = "Record"
        '
        'status_record_number
        '
        Me.status_record_number.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_record_number.Name = "status_record_number"
        Me.status_record_number.Size = New System.Drawing.Size(15, 17)
        Me.status_record_number.Text = "0"
        '
        'toolstripstatuslabel2
        '
        Me.toolstripstatuslabel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolstripstatuslabel2.Name = "toolstripstatuslabel2"
        Me.toolstripstatuslabel2.Size = New System.Drawing.Size(45, 17)
        Me.toolstripstatuslabel2.Text = "out of"
        '
        'status_total_records
        '
        Me.status_total_records.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_total_records.Name = "status_total_records"
        Me.status_total_records.Size = New System.Drawing.Size(15, 17)
        Me.status_total_records.Text = "0"
        '
        'btn_previous
        '
        Me.btn_previous.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_previous.ContextMenuStrip = Me.conmenu_sop_master
        Me.btn_previous.FlatAppearance.BorderSize = 0
        Me.btn_previous.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.ForeColor = System.Drawing.Color.Black
        Me.btn_previous.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_previous.Location = New System.Drawing.Point(15, 55)
        Me.btn_previous.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(84, 31)
        Me.btn_previous.TabIndex = 8
        Me.btn_previous.Text = "&Previous"
        Me.tooltip_sop_master.SetToolTip(Me.btn_previous, "display previous record")
        Me.btn_previous.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.Black
        Me.btn_next.Location = New System.Drawing.Point(113, 55)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(84, 31)
        Me.btn_next.TabIndex = 9
        Me.btn_next.Text = "&Next"
        Me.tooltip_sop_master.SetToolTip(Me.btn_next, "dispaly next record")
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_last.FlatAppearance.BorderSize = 0
        Me.btn_last.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.ForeColor = System.Drawing.Color.Black
        Me.btn_last.Location = New System.Drawing.Point(112, 18)
        Me.btn_last.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(84, 31)
        Me.btn_last.TabIndex = 6
        Me.btn_last.Text = "&Last"
        Me.tooltip_sop_master.SetToolTip(Me.btn_last, "display last record")
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'btn_first
        '
        Me.btn_first.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_first.FlatAppearance.BorderSize = 0
        Me.btn_first.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.ForeColor = System.Drawing.Color.Black
        Me.btn_first.Location = New System.Drawing.Point(15, 19)
        Me.btn_first.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(84, 31)
        Me.btn_first.TabIndex = 5
        Me.btn_first.Text = "&First"
        Me.tooltip_sop_master.SetToolTip(Me.btn_first, "display first record")
        Me.btn_first.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(196, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "SOP MASTER"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_previous)
        Me.GroupBox3.Controls.Add(Me.btn_next)
        Me.GroupBox3.Controls.Add(Me.btn_last)
        Me.GroupBox3.Controls.Add(Me.btn_first)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(304, 573)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox3.Size = New System.Drawing.Size(221, 92)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'sop_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 697)
        Me.ContextMenuStrip = Me.conmenu_sop_master
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grd_sop_master)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "sop_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sop Master"
        Me.tooltip_sop_master.SetToolTip(Me, "Sop Master")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_sop_master, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_dept As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_sop_no As System.Windows.Forms.TextBox
    Friend WithEvents txt_sop_name As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents grd_sop_master As System.Windows.Forms.DataGridView
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolstripstatuslabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_total_records As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents conmenu_sop_master As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip_sop_master As System.Windows.Forms.ToolTip
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_first As System.Windows.Forms.Button

End Class
