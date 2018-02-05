<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liquid_ingredient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(liquid_ingredient))
        Me.tab_liquid_ingredient = New System.Windows.Forms.TabControl
        Me.descriptive = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_descriptive_validate_claim = New System.Windows.Forms.Button
        Me.lbl_descriptive_percentage_claim = New System.Windows.Forms.Label
        Me.lbl_descriptive_ingredient_type = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lbl_descriptive_limit_per = New System.Windows.Forms.Label
        Me.lbl_descriptive_limit = New System.Windows.Forms.Label
        Me.lbl_descriptive_found_unit = New System.Windows.Forms.Label
        Me.lbl_descriptive_label_unit = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbl_descriptive_limit_unit = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_descriptive_found = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_descriptive_batch_no = New System.Windows.Forms.ComboBox
        Me.lbl_descriptive_label_claim = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmb_descriptive_ingredient_name = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.non_descriptive = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_non_validate_claim = New System.Windows.Forms.Button
        Me.lbl_non_percentage_claim = New System.Windows.Forms.Label
        Me.lbl_non_ingredient_type = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.lbl_non_label_unit = New System.Windows.Forms.Label
        Me.lbl_non_found_unit = New System.Windows.Forms.Label
        Me.lbl_non_limit_unit = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbl_non_limit2 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lbl_non_limit1 = New System.Windows.Forms.Label
        Me.lbl_non_limit2_per = New System.Windows.Forms.Label
        Me.lbl_non_limit1_per = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_non_found = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmb_non_batch_no = New System.Windows.Forms.ComboBox
        Me.lbl_non_label_claim = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.cmb_non_ingredient_name = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
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
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_table = New System.Windows.Forms.ToolStripStatusLabel
        Me.conmenu_liquid_ingredient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tooltip_liquid_ingredient = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.tab_liquid_ingredient.SuspendLayout()
        Me.descriptive.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.non_descriptive.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_liquid_ingredient
        '
        Me.tab_liquid_ingredient.Controls.Add(Me.descriptive)
        Me.tab_liquid_ingredient.Controls.Add(Me.non_descriptive)
        Me.tab_liquid_ingredient.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_liquid_ingredient.Location = New System.Drawing.Point(38, 112)
        Me.tab_liquid_ingredient.Name = "tab_liquid_ingredient"
        Me.tab_liquid_ingredient.SelectedIndex = 0
        Me.tab_liquid_ingredient.Size = New System.Drawing.Size(473, 449)
        Me.tab_liquid_ingredient.TabIndex = 0
        '
        'descriptive
        '
        Me.descriptive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.descriptive.Controls.Add(Me.GroupBox1)
        Me.descriptive.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptive.Location = New System.Drawing.Point(4, 22)
        Me.descriptive.Name = "descriptive"
        Me.descriptive.Padding = New System.Windows.Forms.Padding(3)
        Me.descriptive.Size = New System.Drawing.Size(465, 423)
        Me.descriptive.TabIndex = 0
        Me.descriptive.Text = "Descriptive"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_descriptive_validate_claim)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_percentage_claim)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_ingredient_type)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_limit_per)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_limit)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_found_unit)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_label_unit)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_limit_unit)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_descriptive_found)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmb_descriptive_batch_no)
        Me.GroupBox1.Controls.Add(Me.lbl_descriptive_label_claim)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmb_descriptive_ingredient_name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(18, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 383)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LIQUID ASSAY TEST BATCH WISE"
        '
        'btn_descriptive_validate_claim
        '
        Me.btn_descriptive_validate_claim.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_descriptive_validate_claim.Location = New System.Drawing.Point(303, 339)
        Me.btn_descriptive_validate_claim.Name = "btn_descriptive_validate_claim"
        Me.btn_descriptive_validate_claim.Size = New System.Drawing.Size(75, 23)
        Me.btn_descriptive_validate_claim.TabIndex = 41
        Me.btn_descriptive_validate_claim.Text = "Validate"
        Me.btn_descriptive_validate_claim.UseVisualStyleBackColor = True
        '
        'lbl_descriptive_percentage_claim
        '
        Me.lbl_descriptive_percentage_claim.AutoSize = True
        Me.lbl_descriptive_percentage_claim.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_percentage_claim.Location = New System.Drawing.Point(170, 339)
        Me.lbl_descriptive_percentage_claim.Name = "lbl_descriptive_percentage_claim"
        Me.lbl_descriptive_percentage_claim.Size = New System.Drawing.Size(15, 13)
        Me.lbl_descriptive_percentage_claim.TabIndex = 40
        Me.lbl_descriptive_percentage_claim.Text = "0"
        Me.lbl_descriptive_percentage_claim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_descriptive_ingredient_type
        '
        Me.lbl_descriptive_ingredient_type.AutoSize = True
        Me.lbl_descriptive_ingredient_type.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_ingredient_type.Location = New System.Drawing.Point(170, 132)
        Me.lbl_descriptive_ingredient_type.Name = "lbl_descriptive_ingredient_type"
        Me.lbl_descriptive_ingredient_type.Size = New System.Drawing.Size(60, 13)
        Me.lbl_descriptive_ingredient_type.TabIndex = 39
        Me.lbl_descriptive_ingredient_type.Text = "No Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Ingredient Type :"
        '
        'lbl_descriptive_limit_per
        '
        Me.lbl_descriptive_limit_per.AutoSize = True
        Me.lbl_descriptive_limit_per.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_limit_per.Location = New System.Drawing.Point(283, 238)
        Me.lbl_descriptive_limit_per.Name = "lbl_descriptive_limit_per"
        Me.lbl_descriptive_limit_per.Size = New System.Drawing.Size(15, 13)
        Me.lbl_descriptive_limit_per.TabIndex = 34
        Me.lbl_descriptive_limit_per.Text = "0"
        '
        'lbl_descriptive_limit
        '
        Me.lbl_descriptive_limit.AutoSize = True
        Me.lbl_descriptive_limit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_limit.Location = New System.Drawing.Point(282, 206)
        Me.lbl_descriptive_limit.Name = "lbl_descriptive_limit"
        Me.lbl_descriptive_limit.Size = New System.Drawing.Size(15, 13)
        Me.lbl_descriptive_limit.TabIndex = 33
        Me.lbl_descriptive_limit.Text = "0"
        '
        'lbl_descriptive_found_unit
        '
        Me.lbl_descriptive_found_unit.AutoSize = True
        Me.lbl_descriptive_found_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_found_unit.Location = New System.Drawing.Point(253, 291)
        Me.lbl_descriptive_found_unit.Name = "lbl_descriptive_found_unit"
        Me.lbl_descriptive_found_unit.Size = New System.Drawing.Size(15, 13)
        Me.lbl_descriptive_found_unit.TabIndex = 32
        Me.lbl_descriptive_found_unit.Text = "u"
        Me.lbl_descriptive_found_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_descriptive_label_unit
        '
        Me.lbl_descriptive_label_unit.AutoSize = True
        Me.lbl_descriptive_label_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_label_unit.Location = New System.Drawing.Point(208, 171)
        Me.lbl_descriptive_label_unit.Name = "lbl_descriptive_label_unit"
        Me.lbl_descriptive_label_unit.Size = New System.Drawing.Size(15, 13)
        Me.lbl_descriptive_label_unit.TabIndex = 31
        Me.lbl_descriptive_label_unit.Text = "u"
        Me.lbl_descriptive_label_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(327, 239)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "%)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(253, 339)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(170, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "(Not less than"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_descriptive_limit_unit
        '
        Me.lbl_descriptive_limit_unit.AutoSize = True
        Me.lbl_descriptive_limit_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_limit_unit.Location = New System.Drawing.Point(329, 207)
        Me.lbl_descriptive_limit_unit.Name = "lbl_descriptive_limit_unit"
        Me.lbl_descriptive_limit_unit.Size = New System.Drawing.Size(15, 13)
        Me.lbl_descriptive_limit_unit.TabIndex = 25
        Me.lbl_descriptive_limit_unit.Text = "u"
        Me.lbl_descriptive_limit_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 18)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = " % of Label Claim :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Not less than"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_descriptive_found
        '
        Me.txt_descriptive_found.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descriptive_found.Location = New System.Drawing.Point(170, 290)
        Me.txt_descriptive_found.Name = "txt_descriptive_found"
        Me.txt_descriptive_found.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_descriptive_found.Size = New System.Drawing.Size(60, 21)
        Me.txt_descriptive_found.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = " Found :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_descriptive_batch_no
        '
        Me.cmb_descriptive_batch_no.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_descriptive_batch_no.FormattingEnabled = True
        Me.cmb_descriptive_batch_no.Location = New System.Drawing.Point(170, 45)
        Me.cmb_descriptive_batch_no.Name = "cmb_descriptive_batch_no"
        Me.cmb_descriptive_batch_no.Size = New System.Drawing.Size(112, 21)
        Me.cmb_descriptive_batch_no.TabIndex = 17
        '
        'lbl_descriptive_label_claim
        '
        Me.lbl_descriptive_label_claim.AutoSize = True
        Me.lbl_descriptive_label_claim.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_label_claim.Location = New System.Drawing.Point(170, 171)
        Me.lbl_descriptive_label_claim.Name = "lbl_descriptive_label_claim"
        Me.lbl_descriptive_label_claim.Size = New System.Drawing.Size(15, 13)
        Me.lbl_descriptive_label_claim.TabIndex = 16
        Me.lbl_descriptive_label_claim.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Batch_No :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 22)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = " Limit :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = " Label Claim :"
        '
        'cmb_descriptive_ingredient_name
        '
        Me.cmb_descriptive_ingredient_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_descriptive_ingredient_name.FormattingEnabled = True
        Me.cmb_descriptive_ingredient_name.Location = New System.Drawing.Point(170, 86)
        Me.cmb_descriptive_ingredient_name.Name = "cmb_descriptive_ingredient_name"
        Me.cmb_descriptive_ingredient_name.Size = New System.Drawing.Size(244, 21)
        Me.cmb_descriptive_ingredient_name.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ingredient Name :"
        '
        'non_descriptive
        '
        Me.non_descriptive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.non_descriptive.Controls.Add(Me.GroupBox2)
        Me.non_descriptive.Location = New System.Drawing.Point(4, 22)
        Me.non_descriptive.Name = "non_descriptive"
        Me.non_descriptive.Padding = New System.Windows.Forms.Padding(3)
        Me.non_descriptive.Size = New System.Drawing.Size(465, 423)
        Me.non_descriptive.TabIndex = 1
        Me.non_descriptive.Text = "Non Descriptive"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_non_validate_claim)
        Me.GroupBox2.Controls.Add(Me.lbl_non_percentage_claim)
        Me.GroupBox2.Controls.Add(Me.lbl_non_ingredient_type)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.lbl_non_label_unit)
        Me.GroupBox2.Controls.Add(Me.lbl_non_found_unit)
        Me.GroupBox2.Controls.Add(Me.lbl_non_limit_unit)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lbl_non_limit2)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lbl_non_limit1)
        Me.GroupBox2.Controls.Add(Me.lbl_non_limit2_per)
        Me.GroupBox2.Controls.Add(Me.lbl_non_limit1_per)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_non_found)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.cmb_non_batch_no)
        Me.GroupBox2.Controls.Add(Me.lbl_non_label_claim)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.cmb_non_ingredient_name)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(19, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 383)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LIQUID ASSAY TEST BATCH WISE"
        '
        'btn_non_validate_claim
        '
        Me.btn_non_validate_claim.Location = New System.Drawing.Point(321, 342)
        Me.btn_non_validate_claim.Name = "btn_non_validate_claim"
        Me.btn_non_validate_claim.Size = New System.Drawing.Size(75, 23)
        Me.btn_non_validate_claim.TabIndex = 39
        Me.btn_non_validate_claim.Text = "Validate"
        Me.btn_non_validate_claim.UseVisualStyleBackColor = True
        '
        'lbl_non_percentage_claim
        '
        Me.lbl_non_percentage_claim.AutoSize = True
        Me.lbl_non_percentage_claim.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_percentage_claim.Location = New System.Drawing.Point(168, 348)
        Me.lbl_non_percentage_claim.Name = "lbl_non_percentage_claim"
        Me.lbl_non_percentage_claim.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_percentage_claim.TabIndex = 38
        Me.lbl_non_percentage_claim.Text = "0"
        '
        'lbl_non_ingredient_type
        '
        Me.lbl_non_ingredient_type.AutoSize = True
        Me.lbl_non_ingredient_type.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_ingredient_type.Location = New System.Drawing.Point(166, 130)
        Me.lbl_non_ingredient_type.Name = "lbl_non_ingredient_type"
        Me.lbl_non_ingredient_type.Size = New System.Drawing.Size(60, 13)
        Me.lbl_non_ingredient_type.TabIndex = 37
        Me.lbl_non_ingredient_type.Text = "No Type"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(19, 129)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(120, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "Ingredient Type :"
        '
        'lbl_non_label_unit
        '
        Me.lbl_non_label_unit.AutoSize = True
        Me.lbl_non_label_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_label_unit.Location = New System.Drawing.Point(206, 171)
        Me.lbl_non_label_unit.Name = "lbl_non_label_unit"
        Me.lbl_non_label_unit.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_label_unit.TabIndex = 35
        Me.lbl_non_label_unit.Text = "u"
        '
        'lbl_non_found_unit
        '
        Me.lbl_non_found_unit.AutoSize = True
        Me.lbl_non_found_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_found_unit.Location = New System.Drawing.Point(242, 298)
        Me.lbl_non_found_unit.Name = "lbl_non_found_unit"
        Me.lbl_non_found_unit.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_found_unit.TabIndex = 34
        Me.lbl_non_found_unit.Text = "u"
        '
        'lbl_non_limit_unit
        '
        Me.lbl_non_limit_unit.AutoSize = True
        Me.lbl_non_limit_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit_unit.Location = New System.Drawing.Point(296, 213)
        Me.lbl_non_limit_unit.Name = "lbl_non_limit_unit"
        Me.lbl_non_limit_unit.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_limit_unit.TabIndex = 33
        Me.lbl_non_limit_unit.Text = "u"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(296, 250)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "%"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(206, 249)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "To"
        '
        'lbl_non_limit2
        '
        Me.lbl_non_limit2.AutoSize = True
        Me.lbl_non_limit2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit2.Location = New System.Drawing.Point(254, 213)
        Me.lbl_non_limit2.Name = "lbl_non_limit2"
        Me.lbl_non_limit2.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_limit2.TabIndex = 29
        Me.lbl_non_limit2.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(241, 346)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "%"
        '
        'lbl_non_limit1
        '
        Me.lbl_non_limit1.AutoSize = True
        Me.lbl_non_limit1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit1.Location = New System.Drawing.Point(166, 212)
        Me.lbl_non_limit1.Name = "lbl_non_limit1"
        Me.lbl_non_limit1.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_limit1.TabIndex = 28
        Me.lbl_non_limit1.Text = "0"
        '
        'lbl_non_limit2_per
        '
        Me.lbl_non_limit2_per.AutoSize = True
        Me.lbl_non_limit2_per.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit2_per.Location = New System.Drawing.Point(254, 249)
        Me.lbl_non_limit2_per.Name = "lbl_non_limit2_per"
        Me.lbl_non_limit2_per.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_limit2_per.TabIndex = 27
        Me.lbl_non_limit2_per.Text = "0"
        '
        'lbl_non_limit1_per
        '
        Me.lbl_non_limit1_per.AutoSize = True
        Me.lbl_non_limit1_per.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit1_per.Location = New System.Drawing.Point(166, 249)
        Me.lbl_non_limit1_per.Name = "lbl_non_limit1_per"
        Me.lbl_non_limit1_per.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_limit1_per.TabIndex = 26
        Me.lbl_non_limit1_per.Text = "0"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(19, 343)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 18)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = " % of Label Claim :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(204, 212)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 13)
        Me.Label17.TabIndex = 25
        Me.Label17.Text = " To"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_non_found
        '
        Me.txt_non_found.Location = New System.Drawing.Point(166, 295)
        Me.txt_non_found.Name = "txt_non_found"
        Me.txt_non_found.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_non_found.Size = New System.Drawing.Size(60, 21)
        Me.txt_non_found.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(19, 293)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 18)
        Me.Label24.TabIndex = 20
        Me.Label24.Text = " Found :"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_non_batch_no
        '
        Me.cmb_non_batch_no.FormattingEnabled = True
        Me.cmb_non_batch_no.Location = New System.Drawing.Point(166, 44)
        Me.cmb_non_batch_no.Name = "cmb_non_batch_no"
        Me.cmb_non_batch_no.Size = New System.Drawing.Size(112, 21)
        Me.cmb_non_batch_no.TabIndex = 17
        '
        'lbl_non_label_claim
        '
        Me.lbl_non_label_claim.AutoSize = True
        Me.lbl_non_label_claim.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_label_claim.Location = New System.Drawing.Point(166, 171)
        Me.lbl_non_label_claim.Name = "lbl_non_label_claim"
        Me.lbl_non_label_claim.Size = New System.Drawing.Size(15, 13)
        Me.lbl_non_label_claim.TabIndex = 16
        Me.lbl_non_label_claim.Text = "0"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(19, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 13)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "Batch_No :"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(20, 227)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 21)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = " Limit :"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(19, 168)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(94, 13)
        Me.Label28.TabIndex = 9
        Me.Label28.Text = " Label Claim :"
        '
        'cmb_non_ingredient_name
        '
        Me.cmb_non_ingredient_name.FormattingEnabled = True
        Me.cmb_non_ingredient_name.Location = New System.Drawing.Point(166, 86)
        Me.cmb_non_ingredient_name.Name = "cmb_non_ingredient_name"
        Me.cmb_non_ingredient_name.Size = New System.Drawing.Size(244, 21)
        Me.cmb_non_ingredient_name.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(19, 89)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(125, 13)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Ingredient Name :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstr_btn_add, Me.ToolStripSeparator1, Me.tlstr_btn_edit, Me.ToolStripSeparator3, Me.tlstr_btn_list, Me.ToolStripSeparator5, Me.tlstr_btn_clear, Me.ToolStripSeparator6, Me.tlstr_btn_close})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(551, 25)
        Me.ToolStrip1.TabIndex = 85
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tlstr_btn_add
        '
        Me.tlstr_btn_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
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
        Me.tlstr_btn_close.Image = CType(resources.GetObject("tlstr_btn_close.Image"), System.Drawing.Image)
        Me.tlstr_btn_close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tlstr_btn_close.Name = "tlstr_btn_close"
        Me.tlstr_btn_close.Size = New System.Drawing.Size(51, 22)
        Me.tlstr_btn_close.Text = "CL&OSE"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record, Me.ToolStripStatusLabel2, Me.status_lbl_table})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 579)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(551, 22)
        Me.StatusStrip1.TabIndex = 87
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel1.Text = "Record"
        '
        'status_lbl_record_number
        '
        Me.status_lbl_record_number.Name = "status_lbl_record_number"
        Me.status_lbl_record_number.Size = New System.Drawing.Size(150, 17)
        Me.status_lbl_record_number.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel3.Text = "OutOf"
        '
        'status_lbl_total_record
        '
        Me.status_lbl_total_record.Name = "status_lbl_total_record"
        Me.status_lbl_total_record.Size = New System.Drawing.Size(150, 17)
        Me.status_lbl_total_record.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(21, 17)
        Me.ToolStripStatusLabel2.Text = "Of"
        '
        'status_lbl_table
        '
        Me.status_lbl_table.Name = "status_lbl_table"
        Me.status_lbl_table.Size = New System.Drawing.Size(150, 17)
        Me.status_lbl_table.Text = "ToolStripStatusLabel4"
        '
        'conmenu_liquid_ingredient
        '
        Me.conmenu_liquid_ingredient.Name = "tooltip_liquid_ingredient"
        Me.conmenu_liquid_ingredient.Size = New System.Drawing.Size(61, 4)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 23)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "LIQUID INGREDIENT"
        '
        'liquid_ingredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 601)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tab_liquid_ingredient)
        Me.Name = "liquid_ingredient"
        Me.Text = "Liquid Ingredient"
        Me.tab_liquid_ingredient.ResumeLayout(False)
        Me.descriptive.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.non_descriptive.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab_liquid_ingredient As System.Windows.Forms.TabControl
    Friend WithEvents descriptive As System.Windows.Forms.TabPage
    Friend WithEvents non_descriptive As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_limit2 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_limit1 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_limit2_per As System.Windows.Forms.Label
    Friend WithEvents lbl_non_limit1_per As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_descriptive_limit_unit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_descriptive_found As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_descriptive_batch_no As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_descriptive_label_claim As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_descriptive_ingredient_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_non_found As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmb_non_batch_no As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_non_label_claim As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cmb_non_ingredient_name As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_found_unit As System.Windows.Forms.Label
    Friend WithEvents lbl_non_limit_unit As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_label_unit As System.Windows.Forms.Label
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
    Friend WithEvents lbl_descriptive_found_unit As System.Windows.Forms.Label
    Friend WithEvents lbl_descriptive_label_unit As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_ingredient_type As System.Windows.Forms.Label
    Friend WithEvents lbl_descriptive_limit_per As System.Windows.Forms.Label
    Friend WithEvents lbl_descriptive_limit As System.Windows.Forms.Label
    Friend WithEvents lbl_descriptive_ingredient_type As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents conmenu_liquid_ingredient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip_liquid_ingredient As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_table As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_descriptive_percentage_claim As System.Windows.Forms.Label
    Friend WithEvents lbl_non_percentage_claim As System.Windows.Forms.Label
    Friend WithEvents btn_non_validate_claim As System.Windows.Forms.Button
    Friend WithEvents btn_descriptive_validate_claim As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
