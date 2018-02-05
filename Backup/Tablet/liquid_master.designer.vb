<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liquid_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(liquid_master))
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_description = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.tlstr_btn_list = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_search = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_close = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_clear = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_add = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlstr_btn_delete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_edit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_first = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.btn_last = New System.Windows.Forms.Button
        Me.txt_shelf_life = New System.Windows.Forms.TextBox
        Me.conmenu_liquid_master = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_previous = New System.Windows.Forms.Button
        Me.btn_next = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_batch_size_unit = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txt_batch_size = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_product_name = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_product_code = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btn_identification_show = New System.Windows.Forms.Button
        Me.txt_identification = New System.Windows.Forms.TextBox
        Me.txt_assay = New System.Windows.Forms.TextBox
        Me.txt_max_weight = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txt_min_weight = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txt_max_ph = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txt_min_ph = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_average = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_max_uniformity = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_min_uniformity = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.tooltip_liquid_master = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel1.Text = "Record"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 652)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(928, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
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
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel3.Text = "OutOf"
        '
        'status_lbl_total_record
        '
        Me.status_lbl_total_record.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lbl_total_record.Name = "status_lbl_total_record"
        Me.status_lbl_total_record.Size = New System.Drawing.Size(15, 17)
        Me.status_lbl_total_record.Text = "0"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(16, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 40)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Average net volume of the content : "
        '
        'txt_description
        '
        Me.txt_description.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.Location = New System.Drawing.Point(164, 29)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_description.Size = New System.Drawing.Size(317, 49)
        Me.txt_description.TabIndex = 7
        Me.tooltip_liquid_master.SetToolTip(Me.txt_description, "enter description")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(16, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Description :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(16, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Uniformity of Volume :"
        '
        'tlstr_btn_list
        '
        Me.tlstr_btn_list.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_list.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_list.Image = CType(resources.GetObject("tlstr_btn_list.Image"), System.Drawing.Image)
        Me.tlstr_btn_list.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_list.Name = "tlstr_btn_list"
        Me.tlstr_btn_list.Size = New System.Drawing.Size(40, 22)
        Me.tlstr_btn_list.Text = "L&IST"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tlstr_btn_search
        '
        Me.tlstr_btn_search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_search.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_search.Image = CType(resources.GetObject("tlstr_btn_search.Image"), System.Drawing.Image)
        Me.tlstr_btn_search.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_search.Name = "tlstr_btn_search"
        Me.tlstr_btn_search.Size = New System.Drawing.Size(61, 22)
        Me.tlstr_btn_search.Text = "&SEARCH"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tlstr_btn_close
        '
        Me.tlstr_btn_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_close.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_close.Image = CType(resources.GetObject("tlstr_btn_close.Image"), System.Drawing.Image)
        Me.tlstr_btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_close.Name = "tlstr_btn_close"
        Me.tlstr_btn_close.Size = New System.Drawing.Size(51, 22)
        Me.tlstr_btn_close.Text = "CL&OSE"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tlstr_btn_clear
        '
        Me.tlstr_btn_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_clear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_clear.Image = CType(resources.GetObject("tlstr_btn_clear.Image"), System.Drawing.Image)
        Me.tlstr_btn_clear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_clear.Name = "tlstr_btn_clear"
        Me.tlstr_btn_clear.Size = New System.Drawing.Size(51, 22)
        Me.tlstr_btn_clear.Text = "&CLEAR"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tlstr_btn_add
        '
        Me.tlstr_btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_add.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_add.Image = CType(resources.GetObject("tlstr_btn_add.Image"), System.Drawing.Image)
        Me.tlstr_btn_add.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_add.Name = "tlstr_btn_add"
        Me.tlstr_btn_add.Size = New System.Drawing.Size(38, 22)
        Me.tlstr_btn_add.Text = "&ADD"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstr_btn_add, Me.ToolStripSeparator1, Me.tlstr_btn_delete, Me.ToolStripSeparator2, Me.tlstr_btn_edit, Me.ToolStripSeparator3, Me.tlstr_btn_search, Me.ToolStripSeparator4, Me.tlstr_btn_list, Me.ToolStripSeparator5, Me.tlstr_btn_clear, Me.ToolStripSeparator6, Me.tlstr_btn_close})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(928, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlstr_btn_delete
        '
        Me.tlstr_btn_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_delete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_delete.Image = CType(resources.GetObject("tlstr_btn_delete.Image"), System.Drawing.Image)
        Me.tlstr_btn_delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_delete.Name = "tlstr_btn_delete"
        Me.tlstr_btn_delete.Size = New System.Drawing.Size(59, 22)
        Me.tlstr_btn_delete.Text = "&DELETE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'tlstr_btn_edit
        '
        Me.tlstr_btn_edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_edit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_edit.Image = CType(resources.GetObject("tlstr_btn_edit.Image"), System.Drawing.Image)
        Me.tlstr_btn_edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_edit.Name = "tlstr_btn_edit"
        Me.tlstr_btn_edit.Size = New System.Drawing.Size(42, 22)
        Me.tlstr_btn_edit.Text = "&EDIT"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_first
        '
        Me.btn_first.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_first.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_first.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.Location = New System.Drawing.Point(15, 22)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(89, 31)
        Me.btn_first.TabIndex = 20
        Me.btn_first.Text = "<< &First"
        Me.tooltip_liquid_master.SetToolTip(Me.btn_first, "display first record")
        Me.btn_first.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(753, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Months"
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_last.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_last.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.Location = New System.Drawing.Point(327, 24)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(89, 31)
        Me.btn_last.TabIndex = 23
        Me.btn_last.Text = ">> &Last"
        Me.tooltip_liquid_master.SetToolTip(Me.btn_last, "display last record")
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'txt_shelf_life
        '
        Me.txt_shelf_life.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_shelf_life.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shelf_life.Location = New System.Drawing.Point(700, 25)
        Me.txt_shelf_life.MaxLength = 2
        Me.txt_shelf_life.Name = "txt_shelf_life"
        Me.txt_shelf_life.Size = New System.Drawing.Size(43, 22)
        Me.txt_shelf_life.TabIndex = 5
        Me.tooltip_liquid_master.SetToolTip(Me.txt_shelf_life, "enter shelf life")
        '
        'conmenu_liquid_master
        '
        Me.conmenu_liquid_master.Name = "conmenu_liquid_master"
        Me.conmenu_liquid_master.Size = New System.Drawing.Size(61, 4)
        '
        'btn_previous
        '
        Me.btn_previous.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_previous.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_previous.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.Location = New System.Drawing.Point(119, 23)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(89, 31)
        Me.btn_previous.TabIndex = 21
        Me.btn_previous.Text = "< &Previous"
        Me.tooltip_liquid_master.SetToolTip(Me.btn_previous, "display previous record of the existing record")
        Me.btn_previous.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_next.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_next.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(224, 24)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(89, 31)
        Me.btn_next.TabIndex = 22
        Me.btn_next.Text = "> &Next"
        Me.tooltip_liquid_master.SetToolTip(Me.btn_next, "display next record of the existing record")
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(324, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(184, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "LIQUID MASTER"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.ContextMenuStrip = Me.conmenu_liquid_master
        Me.GroupBox1.Controls.Add(Me.txt_batch_size_unit)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txt_shelf_life)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txt_batch_size)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_product_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_product_code)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(28, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(861, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Liquid General Information"
        '
        'txt_batch_size_unit
        '
        Me.txt_batch_size_unit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_batch_size_unit.Location = New System.Drawing.Point(454, 68)
        Me.txt_batch_size_unit.Name = "txt_batch_size_unit"
        Me.txt_batch_size_unit.Size = New System.Drawing.Size(95, 22)
        Me.txt_batch_size_unit.TabIndex = 4
        Me.tooltip_liquid_master.SetToolTip(Me.txt_batch_size_unit, "enter batch size unit")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(331, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(112, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Batch Size Unit :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(611, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Shelf Life :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(332, 29)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Batch Size :"
        '
        'txt_batch_size
        '
        Me.txt_batch_size.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_batch_size.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_batch_size.Location = New System.Drawing.Point(451, 23)
        Me.txt_batch_size.MaxLength = 7
        Me.txt_batch_size.Name = "txt_batch_size"
        Me.txt_batch_size.Size = New System.Drawing.Size(111, 22)
        Me.txt_batch_size.TabIndex = 3
        Me.tooltip_liquid_master.SetToolTip(Me.txt_batch_size, "enter batch size")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(336, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Batch Size :"
        '
        'txt_product_name
        '
        Me.txt_product_name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_name.Location = New System.Drawing.Point(127, 63)
        Me.txt_product_name.Name = "txt_product_name"
        Me.txt_product_name.Size = New System.Drawing.Size(147, 22)
        Me.txt_product_name.TabIndex = 2
        Me.tooltip_liquid_master.SetToolTip(Me.txt_product_name, "enter product name")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Product Name :"
        '
        'txt_product_code
        '
        Me.txt_product_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_product_code.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_product_code.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_code.Location = New System.Drawing.Point(128, 23)
        Me.txt_product_code.MaxLength = 4
        Me.txt_product_code.Name = "txt_product_code"
        Me.txt_product_code.Size = New System.Drawing.Size(132, 22)
        Me.txt_product_code.TabIndex = 1
        Me.tooltip_liquid_master.SetToolTip(Me.txt_product_code, "enter product code")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(14, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code :"
        '
        'GroupBox3
        '
        Me.GroupBox3.ContextMenuStrip = Me.conmenu_liquid_master
        Me.GroupBox3.Controls.Add(Me.btn_first)
        Me.GroupBox3.Controls.Add(Me.btn_last)
        Me.GroupBox3.Controls.Add(Me.btn_previous)
        Me.GroupBox3.Controls.Add(Me.btn_next)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(202, 576)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(431, 67)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(16, 333)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Assay:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(16, 291)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Weight Per ml:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.ContextMenuStrip = Me.conmenu_liquid_master
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.txt_assay)
        Me.GroupBox2.Controls.Add(Me.txt_max_weight)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txt_min_weight)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txt_max_ph)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_min_ph)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txt_average)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_description)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(28, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(861, 375)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liquid Specification"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_identification_show)
        Me.GroupBox5.Controls.Add(Me.txt_identification)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(623, 17)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(223, 346)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Identification"
        '
        'btn_identification_show
        '
        Me.btn_identification_show.BackColor = System.Drawing.SystemColors.Control
        Me.btn_identification_show.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_identification_show.Location = New System.Drawing.Point(70, 317)
        Me.btn_identification_show.Name = "btn_identification_show"
        Me.btn_identification_show.Size = New System.Drawing.Size(75, 23)
        Me.btn_identification_show.TabIndex = 18
        Me.btn_identification_show.Text = "Show"
        Me.tooltip_liquid_master.SetToolTip(Me.btn_identification_show, "click to view or hide identification")
        Me.btn_identification_show.UseVisualStyleBackColor = False
        '
        'txt_identification
        '
        Me.txt_identification.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_identification.Location = New System.Drawing.Point(6, 20)
        Me.txt_identification.Multiline = True
        Me.txt_identification.Name = "txt_identification"
        Me.txt_identification.Size = New System.Drawing.Size(211, 291)
        Me.txt_identification.TabIndex = 0
        Me.tooltip_liquid_master.SetToolTip(Me.txt_identification, "enter identification")
        '
        'txt_assay
        '
        Me.txt_assay.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_assay.Location = New System.Drawing.Point(164, 330)
        Me.txt_assay.Name = "txt_assay"
        Me.txt_assay.Size = New System.Drawing.Size(308, 22)
        Me.txt_assay.TabIndex = 16
        Me.tooltip_liquid_master.SetToolTip(Me.txt_assay, "enter assay")
        '
        'txt_max_weight
        '
        Me.txt_max_weight.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_max_weight.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_weight.Location = New System.Drawing.Point(294, 288)
        Me.txt_max_weight.Name = "txt_max_weight"
        Me.txt_max_weight.Size = New System.Drawing.Size(52, 22)
        Me.txt_max_weight.TabIndex = 15
        Me.tooltip_liquid_master.SetToolTip(Me.txt_max_weight, "enter weight/ml-upper")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(352, 291)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(51, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "gm/ml"
        '
        'txt_min_weight
        '
        Me.txt_min_weight.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_min_weight.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_min_weight.Location = New System.Drawing.Point(164, 288)
        Me.txt_min_weight.Name = "txt_min_weight"
        Me.txt_min_weight.Size = New System.Drawing.Size(52, 22)
        Me.txt_min_weight.TabIndex = 14
        Me.tooltip_liquid_master.SetToolTip(Me.txt_min_weight, "enter weight per/ml-lower")
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(218, 291)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "gm/ml to"
        '
        'txt_max_ph
        '
        Me.txt_max_ph.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_max_ph.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_ph.Location = New System.Drawing.Point(321, 250)
        Me.txt_max_ph.Name = "txt_max_ph"
        Me.txt_max_ph.Size = New System.Drawing.Size(52, 22)
        Me.txt_max_ph.TabIndex = 13
        Me.tooltip_liquid_master.SetToolTip(Me.txt_max_ph, "enter ph-upper")
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(284, 255)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "and"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(324, 206)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "ml"
        '
        'txt_min_ph
        '
        Me.txt_min_ph.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_min_ph.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_min_ph.Location = New System.Drawing.Point(228, 251)
        Me.txt_min_ph.Name = "txt_min_ph"
        Me.txt_min_ph.Size = New System.Drawing.Size(52, 22)
        Me.txt_min_ph.TabIndex = 12
        Me.tooltip_liquid_master.SetToolTip(Me.txt_min_ph, "enter ph-lower")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(164, 254)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Between"
        '
        'txt_average
        '
        Me.txt_average.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_average.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_average.Location = New System.Drawing.Point(260, 202)
        Me.txt_average.Name = "txt_average"
        Me.txt_average.Size = New System.Drawing.Size(52, 22)
        Me.txt_average.TabIndex = 11
        Me.tooltip_liquid_master.SetToolTip(Me.txt_average, "enter average net volume")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(164, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Not less than "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txt_max_uniformity)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txt_min_uniformity)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(174, 96)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(413, 90)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(66, 67)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(66, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(93, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "of label claim"
        '
        'txt_max_uniformity
        '
        Me.txt_max_uniformity.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_max_uniformity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_max_uniformity.Location = New System.Drawing.Point(7, 61)
        Me.txt_max_uniformity.Name = "txt_max_uniformity"
        Me.txt_max_uniformity.Size = New System.Drawing.Size(52, 22)
        Me.txt_max_uniformity.TabIndex = 10
        Me.tooltip_liquid_master.SetToolTip(Me.txt_max_uniformity, "enter uniformity of volume - upper")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(86, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "and Not more than "
        '
        'txt_min_uniformity
        '
        Me.txt_min_uniformity.ContextMenuStrip = Me.conmenu_liquid_master
        Me.txt_min_uniformity.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_min_uniformity.Location = New System.Drawing.Point(6, 36)
        Me.txt_min_uniformity.Name = "txt_min_uniformity"
        Me.txt_min_uniformity.Size = New System.Drawing.Size(53, 22)
        Me.txt_min_uniformity.TabIndex = 9
        Me.tooltip_liquid_master.SetToolTip(Me.txt_min_uniformity, "enter uniformity of volume - lower ")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(401, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Net volume of the content of any single unit is Not less than "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "PH:"
        '
        'liquid_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 674)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "liquid_master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquid Master"
        Me.tooltip_liquid_master.SetToolTip(Me, "liquid master")
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_description As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tlstr_btn_list As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_search As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_close As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_clear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlstr_btn_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents txt_shelf_life As System.Windows.Forms.TextBox
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_batch_size As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_product_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_product_code As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_max_uniformity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_min_uniformity As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_average As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_max_ph As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_min_ph As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_max_weight As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_min_weight As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_assay As System.Windows.Forms.TextBox
    Friend WithEvents conmenu_liquid_master As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip_liquid_master As System.Windows.Forms.ToolTip
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_batch_size_unit As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_identification_show As System.Windows.Forms.Button
    Friend WithEvents txt_identification As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
