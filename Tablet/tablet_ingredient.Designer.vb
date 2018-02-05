<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tablet_ingredient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tablet_ingredient))
        Me.btn_first = New System.Windows.Forms.Button
        Me.lbl_label_claim = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.btn_last = New System.Windows.Forms.Button
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_previous = New System.Windows.Forms.Button
        Me.lbl_limit2 = New System.Windows.Forms.Label
        Me.lbl_limit1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_found = New System.Windows.Forms.TextBox
        Me.conmenu_tablet_ingredient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lbl_limit2_percentage = New System.Windows.Forms.Label
        Me.lbl_limit1_percentage = New System.Windows.Forms.Label
        Me.cmb_batch_no = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_ingredient_name = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_label_claim_percentage = New System.Windows.Forms.Label
        Me.lbl_label_claim_unit = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lbl_limit_unit = New System.Windows.Forms.Label
        Me.btn_label_claim = New System.Windows.Forms.Button
        Me.btn_found = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.lbl_found_unit = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlstr_btn_add = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_edit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_list = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_clear = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_close = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        Me.tooltip_tablet_ingredient = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_first
        '
        Me.btn_first.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_first.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_first.FlatAppearance.BorderSize = 4
        Me.btn_first.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.ForeColor = System.Drawing.Color.Black
        Me.btn_first.Location = New System.Drawing.Point(15, 26)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(73, 29)
        Me.btn_first.TabIndex = 6
        Me.btn_first.Text = "<< &First"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.btn_first, "display first record")
        Me.btn_first.UseVisualStyleBackColor = False
        '
        'lbl_label_claim
        '
        Me.lbl_label_claim.AutoSize = True
        Me.lbl_label_claim.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_label_claim.Location = New System.Drawing.Point(162, 121)
        Me.lbl_label_claim.Name = "lbl_label_claim"
        Me.lbl_label_claim.Size = New System.Drawing.Size(15, 14)
        Me.lbl_label_claim.TabIndex = 0
        Me.lbl_label_claim.Text = "0"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_label_claim, "label claim")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batch_No :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(235, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 12)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = " To"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = " Limit :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_last.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_last.FlatAppearance.BorderSize = 4
        Me.btn_last.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.ForeColor = System.Drawing.Color.Black
        Me.btn_last.Location = New System.Drawing.Point(308, 26)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(80, 29)
        Me.btn_last.TabIndex = 9
        Me.btn_last.Text = ">> &Last"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.btn_last, "display last record")
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_next.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_next.FlatAppearance.BorderSize = 4
        Me.btn_next.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.ForeColor = System.Drawing.Color.Black
        Me.btn_next.Location = New System.Drawing.Point(203, 26)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(86, 29)
        Me.btn_next.TabIndex = 8
        Me.btn_next.Text = "> &Next"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.btn_next, "display next record of the existing record")
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'btn_previous
        '
        Me.btn_previous.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_previous.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_previous.FlatAppearance.BorderSize = 4
        Me.btn_previous.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.ForeColor = System.Drawing.Color.Black
        Me.btn_previous.Location = New System.Drawing.Point(104, 26)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(89, 29)
        Me.btn_previous.TabIndex = 7
        Me.btn_previous.Text = "< &Previous"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.btn_previous, "display previous record of the existing record")
        Me.btn_previous.UseVisualStyleBackColor = False
        '
        'lbl_limit2
        '
        Me.lbl_limit2.AutoSize = True
        Me.lbl_limit2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limit2.Location = New System.Drawing.Point(319, 158)
        Me.lbl_limit2.Name = "lbl_limit2"
        Me.lbl_limit2.Size = New System.Drawing.Size(19, 14)
        Me.lbl_limit2.TabIndex = 0
        Me.lbl_limit2.Text = " 0"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_limit2, "upper limit")
        '
        'lbl_limit1
        '
        Me.lbl_limit1.AutoSize = True
        Me.lbl_limit1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limit1.Location = New System.Drawing.Point(163, 158)
        Me.lbl_limit1.Name = "lbl_limit1"
        Me.lbl_limit1.Size = New System.Drawing.Size(15, 14)
        Me.lbl_limit1.TabIndex = 0
        Me.lbl_limit1.Text = "0"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_limit1, "lower limit ")
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = " % of Label Claim :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_found
        '
        Me.txt_found.ContextMenuStrip = Me.conmenu_tablet_ingredient
        Me.txt_found.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_found.Location = New System.Drawing.Point(172, 236)
        Me.txt_found.Name = "txt_found"
        Me.txt_found.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_found.Size = New System.Drawing.Size(60, 22)
        Me.txt_found.TabIndex = 3
        Me.tooltip_tablet_ingredient.SetToolTip(Me.txt_found, "found")
        '
        'conmenu_tablet_ingredient
        '
        Me.conmenu_tablet_ingredient.Name = "conmenu_tablet_ingredient"
        Me.conmenu_tablet_ingredient.Size = New System.Drawing.Size(61, 4)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(157, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(234, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "TABLET INGREDIENT"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = " Found :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_limit2_percentage
        '
        Me.lbl_limit2_percentage.AutoSize = True
        Me.lbl_limit2_percentage.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limit2_percentage.Location = New System.Drawing.Point(323, 188)
        Me.lbl_limit2_percentage.Name = "lbl_limit2_percentage"
        Me.lbl_limit2_percentage.Size = New System.Drawing.Size(15, 14)
        Me.lbl_limit2_percentage.TabIndex = 0
        Me.lbl_limit2_percentage.Text = "0"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_limit2_percentage, "upper unit percentage")
        '
        'lbl_limit1_percentage
        '
        Me.lbl_limit1_percentage.AutoSize = True
        Me.lbl_limit1_percentage.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limit1_percentage.Location = New System.Drawing.Point(163, 188)
        Me.lbl_limit1_percentage.Name = "lbl_limit1_percentage"
        Me.lbl_limit1_percentage.Size = New System.Drawing.Size(15, 14)
        Me.lbl_limit1_percentage.TabIndex = 0
        Me.lbl_limit1_percentage.Text = "0"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_limit1_percentage, "lower unit percentage")
        '
        'cmb_batch_no
        '
        Me.cmb_batch_no.ContextMenuStrip = Me.conmenu_tablet_ingredient
        Me.cmb_batch_no.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_batch_no.FormattingEnabled = True
        Me.cmb_batch_no.Location = New System.Drawing.Point(168, 41)
        Me.cmb_batch_no.Name = "cmb_batch_no"
        Me.cmb_batch_no.Size = New System.Drawing.Size(112, 22)
        Me.cmb_batch_no.TabIndex = 1
        Me.tooltip_tablet_ingredient.SetToolTip(Me.cmb_batch_no, "shows batch number for a product")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_next)
        Me.GroupBox2.Controls.Add(Me.btn_last)
        Me.GroupBox2.Controls.Add(Me.btn_first)
        Me.GroupBox2.Controls.Add(Me.btn_previous)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(77, 503)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 71)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NAVIGATION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = " Label Claim :"
        '
        'cmb_ingredient_name
        '
        Me.cmb_ingredient_name.ContextMenuStrip = Me.conmenu_tablet_ingredient
        Me.cmb_ingredient_name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ingredient_name.FormattingEnabled = True
        Me.cmb_ingredient_name.Location = New System.Drawing.Point(167, 76)
        Me.cmb_ingredient_name.Name = "cmb_ingredient_name"
        Me.cmb_ingredient_name.Size = New System.Drawing.Size(313, 22)
        Me.cmb_ingredient_name.TabIndex = 2
        Me.tooltip_tablet_ingredient.SetToolTip(Me.cmb_ingredient_name, "displays ingredient name")
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.conmenu_tablet_ingredient
        Me.GroupBox1.Controls.Add(Me.lbl_label_claim_percentage)
        Me.GroupBox1.Controls.Add(Me.lbl_label_claim_unit)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_limit_unit)
        Me.GroupBox1.Controls.Add(Me.btn_label_claim)
        Me.GroupBox1.Controls.Add(Me.btn_found)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lbl_found_unit)
        Me.GroupBox1.Controls.Add(Me.lbl_limit2)
        Me.GroupBox1.Controls.Add(Me.lbl_limit1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_found)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_limit2_percentage)
        Me.GroupBox1.Controls.Add(Me.lbl_limit1_percentage)
        Me.GroupBox1.Controls.Add(Me.cmb_batch_no)
        Me.GroupBox1.Controls.Add(Me.lbl_label_claim)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmb_ingredient_name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(26, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TABLET ASSAY TEST BATCH WISE"
        '
        'lbl_label_claim_percentage
        '
        Me.lbl_label_claim_percentage.AutoSize = True
        Me.lbl_label_claim_percentage.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_label_claim_percentage.Location = New System.Drawing.Point(190, 296)
        Me.lbl_label_claim_percentage.Name = "lbl_label_claim_percentage"
        Me.lbl_label_claim_percentage.Size = New System.Drawing.Size(15, 14)
        Me.lbl_label_claim_percentage.TabIndex = 0
        Me.lbl_label_claim_percentage.Text = "0"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_label_claim_percentage, "percentage of label claim")
        '
        'lbl_label_claim_unit
        '
        Me.lbl_label_claim_unit.AutoSize = True
        Me.lbl_label_claim_unit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_label_claim_unit.Location = New System.Drawing.Point(217, 121)
        Me.lbl_label_claim_unit.Name = "lbl_label_claim_unit"
        Me.lbl_label_claim_unit.Size = New System.Drawing.Size(15, 14)
        Me.lbl_label_claim_unit.TabIndex = 0
        Me.lbl_label_claim_unit.Text = "u"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_label_claim_unit, "label claim unit")
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(236, 180)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 29)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = " To"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(384, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 14)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "%"
        '
        'lbl_limit_unit
        '
        Me.lbl_limit_unit.AutoSize = True
        Me.lbl_limit_unit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limit_unit.Location = New System.Drawing.Point(384, 158)
        Me.lbl_limit_unit.Name = "lbl_limit_unit"
        Me.lbl_limit_unit.Size = New System.Drawing.Size(15, 14)
        Me.lbl_limit_unit.TabIndex = 0
        Me.lbl_limit_unit.Text = "u"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_limit_unit, "limit unit")
        '
        'btn_label_claim
        '
        Me.btn_label_claim.Location = New System.Drawing.Point(313, 296)
        Me.btn_label_claim.Name = "btn_label_claim"
        Me.btn_label_claim.Size = New System.Drawing.Size(86, 19)
        Me.btn_label_claim.TabIndex = 5
        Me.btn_label_claim.Text = "Check"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.btn_label_claim, "click to get percentage of label claim")
        Me.btn_label_claim.UseVisualStyleBackColor = True
        '
        'btn_found
        '
        Me.btn_found.Location = New System.Drawing.Point(313, 238)
        Me.btn_found.Name = "btn_found"
        Me.btn_found.Size = New System.Drawing.Size(86, 19)
        Me.btn_found.TabIndex = 4
        Me.btn_found.Text = "Check"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.btn_found, "click to validate found")
        Me.btn_found.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(251, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = " %"
        '
        'lbl_found_unit
        '
        Me.lbl_found_unit.AutoSize = True
        Me.lbl_found_unit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_found_unit.Location = New System.Drawing.Point(251, 240)
        Me.lbl_found_unit.Name = "lbl_found_unit"
        Me.lbl_found_unit.Size = New System.Drawing.Size(19, 14)
        Me.lbl_found_unit.TabIndex = 0
        Me.lbl_found_unit.Text = " u"
        Me.tooltip_tablet_ingredient.SetToolTip(Me.lbl_found_unit, "found unit")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingredient Name :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstr_btn_add, Me.ToolStripSeparator1, Me.tlstr_btn_edit, Me.ToolStripSeparator3, Me.tlstr_btn_list, Me.ToolStripSeparator5, Me.tlstr_btn_clear, Me.ToolStripSeparator6, Me.tlstr_btn_close})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(547, 25)
        Me.ToolStrip1.TabIndex = 79
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'tlstr_btn_list
        '
        Me.tlstr_btn_list.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tlstr_btn_list.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlstr_btn_list.Image = CType(resources.GetObject("tlstr_btn_list.Image"), System.Drawing.Image)
        Me.tlstr_btn_list.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_list.Name = "tlstr_btn_list"
        Me.tlstr_btn_list.Size = New System.Drawing.Size(40, 22)
        Me.tlstr_btn_list.Text = "&LIST"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
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
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 590)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(547, 22)
        Me.StatusStrip1.TabIndex = 80
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
        'tablet_ingredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 612)
        Me.ContextMenuStrip = Me.conmenu_tablet_ingredient
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "tablet_ingredient"
        Me.Text = "TABLET INGREDIENT"
        Me.tooltip_tablet_ingredient.SetToolTip(Me, "tablet ingredient")
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents lbl_label_claim As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents lbl_limit2 As System.Windows.Forms.Label
    Friend WithEvents lbl_limit1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_found As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_limit2_percentage As System.Windows.Forms.Label
    Friend WithEvents lbl_limit1_percentage As System.Windows.Forms.Label
    Friend WithEvents cmb_batch_no As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_ingredient_name As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlstr_btn_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_list As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_clear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_close As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lbl_found_unit As System.Windows.Forms.Label
    Friend WithEvents btn_label_claim As System.Windows.Forms.Button
    Friend WithEvents btn_found As System.Windows.Forms.Button
    Friend WithEvents lbl_limit_unit As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_label_claim_unit As System.Windows.Forms.Label
    Friend WithEvents lbl_label_claim_percentage As System.Windows.Forms.Label
    Friend WithEvents tooltip_tablet_ingredient As System.Windows.Forms.ToolTip
    Friend WithEvents conmenu_tablet_ingredient As System.Windows.Forms.ContextMenuStrip
End Class
