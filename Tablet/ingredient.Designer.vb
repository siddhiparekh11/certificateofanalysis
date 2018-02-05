<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingredient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingredient))
        Me.tab_ingredient = New System.Windows.Forms.TabControl
        Me.tab_non_descriptive = New System.Windows.Forms.TabPage
        Me.txt_non_unit = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_non_ingredient_no = New System.Windows.Forms.TextBox
        Me.conmenu_ingredient = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lbl_non_limit_unit = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.btn_non_per = New System.Windows.Forms.Button
        Me.txt_non_limit2 = New System.Windows.Forms.TextBox
        Me.txt_non_limit1 = New System.Windows.Forms.TextBox
        Me.lbl_non_limit2 = New System.Windows.Forms.Label
        Me.lbl_non_limit1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_non_ingredient_name = New System.Windows.Forms.TextBox
        Me.txt_non_label_claim = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tab_descriptive = New System.Windows.Forms.TabPage
        Me.txt_descriptive_unit = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_descriptive_ingredient_no = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_descriptive_unit = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.btn_descriptive_per = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_descriptive_limit = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txt_descriptive_limit = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_descriptive_ingredient_name = New System.Windows.Forms.TextBox
        Me.txt_descriptive_label_claim = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tlstr_btn_add = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_delete = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_edit = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_search = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_list = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_clear = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tlstr_btn_close = New System.Windows.Forms.ToolStripButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_first = New System.Windows.Forms.Button
        Me.btn_last = New System.Windows.Forms.Button
        Me.btn_previous = New System.Windows.Forms.Button
        Me.btn_next = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_recno = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_totrec = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_table = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label17 = New System.Windows.Forms.Label
        Me.tooltip_ingredient = New System.Windows.Forms.ToolTip(Me.components)
        Me.tab_ingredient.SuspendLayout()
        Me.tab_non_descriptive.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tab_descriptive.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_ingredient
        '
        Me.tab_ingredient.Controls.Add(Me.tab_non_descriptive)
        Me.tab_ingredient.Controls.Add(Me.tab_descriptive)
        Me.tab_ingredient.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_ingredient.Location = New System.Drawing.Point(26, 92)
        Me.tab_ingredient.Name = "tab_ingredient"
        Me.tab_ingredient.SelectedIndex = 0
        Me.tab_ingredient.Size = New System.Drawing.Size(652, 372)
        Me.tab_ingredient.TabIndex = 0
        Me.tooltip_ingredient.SetToolTip(Me.tab_ingredient, "ingredient")
        '
        'tab_non_descriptive
        '
        Me.tab_non_descriptive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tab_non_descriptive.Controls.Add(Me.txt_non_unit)
        Me.tab_non_descriptive.Controls.Add(Me.Label11)
        Me.tab_non_descriptive.Controls.Add(Me.txt_non_ingredient_no)
        Me.tab_non_descriptive.Controls.Add(Me.Label3)
        Me.tab_non_descriptive.Controls.Add(Me.GroupBox1)
        Me.tab_non_descriptive.Controls.Add(Me.txt_non_ingredient_name)
        Me.tab_non_descriptive.Controls.Add(Me.txt_non_label_claim)
        Me.tab_non_descriptive.Controls.Add(Me.Label5)
        Me.tab_non_descriptive.Controls.Add(Me.Label4)
        Me.tab_non_descriptive.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_non_descriptive.Location = New System.Drawing.Point(4, 22)
        Me.tab_non_descriptive.Name = "tab_non_descriptive"
        Me.tab_non_descriptive.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_non_descriptive.Size = New System.Drawing.Size(644, 346)
        Me.tab_non_descriptive.TabIndex = 0
        Me.tab_non_descriptive.Text = " NonDescriptive"
        '
        'txt_non_unit
        '
        Me.txt_non_unit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_non_unit.Location = New System.Drawing.Point(176, 195)
        Me.txt_non_unit.Name = "txt_non_unit"
        Me.txt_non_unit.Size = New System.Drawing.Size(88, 22)
        Me.txt_non_unit.TabIndex = 4
        Me.tooltip_ingredient.SetToolTip(Me.txt_non_unit, "unit")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(28, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = " Unit  :"
        '
        'txt_non_ingredient_no
        '
        Me.txt_non_ingredient_no.ContextMenuStrip = Me.conmenu_ingredient
        Me.txt_non_ingredient_no.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_non_ingredient_no.Location = New System.Drawing.Point(176, 36)
        Me.txt_non_ingredient_no.Name = "txt_non_ingredient_no"
        Me.txt_non_ingredient_no.Size = New System.Drawing.Size(100, 22)
        Me.txt_non_ingredient_no.TabIndex = 1
        Me.tooltip_ingredient.SetToolTip(Me.txt_non_ingredient_no, "ingredient no")
        '
        'conmenu_ingredient
        '
        Me.conmenu_ingredient.Name = "conmenu_ingredient"
        Me.conmenu_ingredient.Size = New System.Drawing.Size(61, 4)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ingredient No :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_non_limit_unit)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.btn_non_per)
        Me.GroupBox1.Controls.Add(Me.txt_non_limit2)
        Me.GroupBox1.Controls.Add(Me.txt_non_limit1)
        Me.GroupBox1.Controls.Add(Me.lbl_non_limit2)
        Me.GroupBox1.Controls.Add(Me.lbl_non_limit1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lbl_non_limit_unit
        '
        Me.lbl_non_limit_unit.AutoSize = True
        Me.lbl_non_limit_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit_unit.Location = New System.Drawing.Point(423, 32)
        Me.lbl_non_limit_unit.Name = "lbl_non_limit_unit"
        Me.lbl_non_limit_unit.Size = New System.Drawing.Size(0, 13)
        Me.lbl_non_limit_unit.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(364, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "%"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(214, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "%"
        '
        'btn_non_per
        '
        Me.btn_non_per.Location = New System.Drawing.Point(467, 72)
        Me.btn_non_per.Name = "btn_non_per"
        Me.btn_non_per.Size = New System.Drawing.Size(55, 20)
        Me.btn_non_per.TabIndex = 8
        Me.btn_non_per.Text = "%"
        Me.tooltip_ingredient.SetToolTip(Me.btn_non_per, "click to get % of label claim")
        Me.btn_non_per.UseVisualStyleBackColor = True
        '
        'txt_non_limit2
        '
        Me.txt_non_limit2.ContextMenuStrip = Me.conmenu_ingredient
        Me.txt_non_limit2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_non_limit2.Location = New System.Drawing.Point(315, 28)
        Me.txt_non_limit2.Name = "txt_non_limit2"
        Me.txt_non_limit2.Size = New System.Drawing.Size(66, 22)
        Me.txt_non_limit2.TabIndex = 7
        Me.tooltip_ingredient.SetToolTip(Me.txt_non_limit2, "max limit")
        '
        'txt_non_limit1
        '
        Me.txt_non_limit1.ContextMenuStrip = Me.conmenu_ingredient
        Me.txt_non_limit1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_non_limit1.Location = New System.Drawing.Point(161, 28)
        Me.txt_non_limit1.Name = "txt_non_limit1"
        Me.txt_non_limit1.Size = New System.Drawing.Size(66, 22)
        Me.txt_non_limit1.TabIndex = 6
        Me.tooltip_ingredient.SetToolTip(Me.txt_non_limit1, "min limit")
        '
        'lbl_non_limit2
        '
        Me.lbl_non_limit2.AutoSize = True
        Me.lbl_non_limit2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit2.Location = New System.Drawing.Point(309, 62)
        Me.lbl_non_limit2.Name = "lbl_non_limit2"
        Me.lbl_non_limit2.Size = New System.Drawing.Size(0, 13)
        Me.lbl_non_limit2.TabIndex = 50
        '
        'lbl_non_limit1
        '
        Me.lbl_non_limit1.AutoSize = True
        Me.lbl_non_limit1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_non_limit1.Location = New System.Drawing.Point(157, 61)
        Me.lbl_non_limit1.Name = "lbl_non_limit1"
        Me.lbl_non_limit1.Size = New System.Drawing.Size(0, 13)
        Me.lbl_non_limit1.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(256, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = " To"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = " Limit :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_non_ingredient_name
        '
        Me.txt_non_ingredient_name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_non_ingredient_name.Location = New System.Drawing.Point(176, 78)
        Me.txt_non_ingredient_name.Multiline = True
        Me.txt_non_ingredient_name.Name = "txt_non_ingredient_name"
        Me.txt_non_ingredient_name.Size = New System.Drawing.Size(260, 55)
        Me.txt_non_ingredient_name.TabIndex = 2
        Me.tooltip_ingredient.SetToolTip(Me.txt_non_ingredient_name, "ingredient name")
        '
        'txt_non_label_claim
        '
        Me.txt_non_label_claim.ContextMenuStrip = Me.conmenu_ingredient
        Me.txt_non_label_claim.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_non_label_claim.Location = New System.Drawing.Point(176, 155)
        Me.txt_non_label_claim.Name = "txt_non_label_claim"
        Me.txt_non_label_claim.Size = New System.Drawing.Size(100, 22)
        Me.txt_non_label_claim.TabIndex = 3
        Me.tooltip_ingredient.SetToolTip(Me.txt_non_label_claim, "label claim")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = " Label Claim :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingredient Name :"
        '
        'tab_descriptive
        '
        Me.tab_descriptive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tab_descriptive.ContextMenuStrip = Me.conmenu_ingredient
        Me.tab_descriptive.Controls.Add(Me.txt_descriptive_unit)
        Me.tab_descriptive.Controls.Add(Me.Label12)
        Me.tab_descriptive.Controls.Add(Me.txt_descriptive_ingredient_no)
        Me.tab_descriptive.Controls.Add(Me.Label6)
        Me.tab_descriptive.Controls.Add(Me.GroupBox2)
        Me.tab_descriptive.Controls.Add(Me.txt_descriptive_ingredient_name)
        Me.tab_descriptive.Controls.Add(Me.txt_descriptive_label_claim)
        Me.tab_descriptive.Controls.Add(Me.Label7)
        Me.tab_descriptive.Controls.Add(Me.Label8)
        Me.tab_descriptive.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_descriptive.Location = New System.Drawing.Point(4, 22)
        Me.tab_descriptive.Name = "tab_descriptive"
        Me.tab_descriptive.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_descriptive.Size = New System.Drawing.Size(644, 346)
        Me.tab_descriptive.TabIndex = 1
        Me.tab_descriptive.Text = "Descriptive"
        '
        'txt_descriptive_unit
        '
        Me.txt_descriptive_unit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descriptive_unit.Location = New System.Drawing.Point(165, 205)
        Me.txt_descriptive_unit.Name = "txt_descriptive_unit"
        Me.txt_descriptive_unit.Size = New System.Drawing.Size(88, 22)
        Me.txt_descriptive_unit.TabIndex = 4
        Me.tooltip_ingredient.SetToolTip(Me.txt_descriptive_unit, "unit")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 209)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = " Unit  :"
        '
        'txt_descriptive_ingredient_no
        '
        Me.txt_descriptive_ingredient_no.ContextMenuStrip = Me.conmenu_ingredient
        Me.txt_descriptive_ingredient_no.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descriptive_ingredient_no.Location = New System.Drawing.Point(165, 32)
        Me.txt_descriptive_ingredient_no.Name = "txt_descriptive_ingredient_no"
        Me.txt_descriptive_ingredient_no.Size = New System.Drawing.Size(100, 22)
        Me.txt_descriptive_ingredient_no.TabIndex = 1
        Me.tooltip_ingredient.SetToolTip(Me.txt_descriptive_ingredient_no, "ingredient no")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Ingredient No :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_descriptive_unit)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.btn_descriptive_per)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lbl_descriptive_limit)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_descriptive_limit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(621, 97)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'lbl_descriptive_unit
        '
        Me.lbl_descriptive_unit.AutoSize = True
        Me.lbl_descriptive_unit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_unit.Location = New System.Drawing.Point(369, 26)
        Me.lbl_descriptive_unit.Name = "lbl_descriptive_unit"
        Me.lbl_descriptive_unit.Size = New System.Drawing.Size(0, 13)
        Me.lbl_descriptive_unit.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(315, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 13)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "%"
        '
        'btn_descriptive_per
        '
        Me.btn_descriptive_per.Location = New System.Drawing.Point(432, 67)
        Me.btn_descriptive_per.Name = "btn_descriptive_per"
        Me.btn_descriptive_per.Size = New System.Drawing.Size(55, 20)
        Me.btn_descriptive_per.TabIndex = 7
        Me.btn_descriptive_per.Text = "%"
        Me.tooltip_ingredient.SetToolTip(Me.btn_descriptive_per, "click to get % of label claim")
        Me.btn_descriptive_per.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Not Less Then "
        '
        'lbl_descriptive_limit
        '
        Me.lbl_descriptive_limit.AutoSize = True
        Me.lbl_descriptive_limit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descriptive_limit.Location = New System.Drawing.Point(279, 53)
        Me.lbl_descriptive_limit.Name = "lbl_descriptive_limit"
        Me.lbl_descriptive_limit.Size = New System.Drawing.Size(0, 13)
        Me.lbl_descriptive_limit.TabIndex = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(153, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Not Less Then "
        '
        'txt_descriptive_limit
        '
        Me.txt_descriptive_limit.ContextMenuStrip = Me.conmenu_ingredient
        Me.txt_descriptive_limit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descriptive_limit.Location = New System.Drawing.Point(267, 18)
        Me.txt_descriptive_limit.Name = "txt_descriptive_limit"
        Me.txt_descriptive_limit.Size = New System.Drawing.Size(61, 22)
        Me.txt_descriptive_limit.TabIndex = 6
        Me.tooltip_ingredient.SetToolTip(Me.txt_descriptive_limit, "limit")
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = " Limit :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_descriptive_ingredient_name
        '
        Me.txt_descriptive_ingredient_name.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descriptive_ingredient_name.Location = New System.Drawing.Point(165, 82)
        Me.txt_descriptive_ingredient_name.Multiline = True
        Me.txt_descriptive_ingredient_name.Name = "txt_descriptive_ingredient_name"
        Me.txt_descriptive_ingredient_name.Size = New System.Drawing.Size(258, 48)
        Me.txt_descriptive_ingredient_name.TabIndex = 2
        Me.tooltip_ingredient.SetToolTip(Me.txt_descriptive_ingredient_name, "ingredient name")
        '
        'txt_descriptive_label_claim
        '
        Me.txt_descriptive_label_claim.ContextMenuStrip = Me.conmenu_ingredient
        Me.txt_descriptive_label_claim.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descriptive_label_claim.Location = New System.Drawing.Point(165, 161)
        Me.txt_descriptive_label_claim.Name = "txt_descriptive_label_claim"
        Me.txt_descriptive_label_claim.Size = New System.Drawing.Size(88, 22)
        Me.txt_descriptive_label_claim.TabIndex = 3
        Me.tooltip_ingredient.SetToolTip(Me.txt_descriptive_label_claim, "label claim")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = " Label Claim :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Ingredient Name :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstr_btn_add, Me.ToolStripSeparator1, Me.tlstr_btn_delete, Me.ToolStripSeparator2, Me.tlstr_btn_edit, Me.ToolStripSeparator3, Me.tlstr_btn_search, Me.ToolStripSeparator4, Me.tlstr_btn_list, Me.ToolStripSeparator5, Me.tlstr_btn_clear, Me.ToolStripSeparator6, Me.tlstr_btn_close})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(700, 25)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_first)
        Me.GroupBox3.Controls.Add(Me.btn_last)
        Me.GroupBox3.Controls.Add(Me.btn_previous)
        Me.GroupBox3.Controls.Add(Me.btn_next)
        Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(99, 487)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(492, 59)
        Me.GroupBox3.TabIndex = 80
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NAVIGATION"
        '
        'btn_first
        '
        Me.btn_first.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_first.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_first.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_first.Location = New System.Drawing.Point(19, 19)
        Me.btn_first.Name = "btn_first"
        Me.btn_first.Size = New System.Drawing.Size(103, 31)
        Me.btn_first.TabIndex = 58
        Me.btn_first.Text = "<< &First"
        Me.btn_first.UseVisualStyleBackColor = False
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_last.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_last.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.Location = New System.Drawing.Point(373, 20)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(98, 31)
        Me.btn_last.TabIndex = 61
        Me.btn_last.Text = ">> &Last"
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'btn_previous
        '
        Me.btn_previous.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_previous.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_previous.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_previous.Location = New System.Drawing.Point(149, 18)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(87, 31)
        Me.btn_previous.TabIndex = 59
        Me.btn_previous.Text = "< &Previous"
        Me.btn_previous.UseVisualStyleBackColor = False
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_next.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText
        Me.btn_next.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(262, 19)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(88, 31)
        Me.btn_next.TabIndex = 60
        Me.btn_next.Text = "> &Next"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_recno, Me.ToolStripStatusLabel3, Me.status_lbl_totrec, Me.ToolStripStatusLabel2, Me.status_lbl_table})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 569)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(700, 22)
        Me.StatusStrip1.TabIndex = 81
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(52, 17)
        Me.ToolStripStatusLabel1.Text = "Record"
        '
        'status_lbl_recno
        '
        Me.status_lbl_recno.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lbl_recno.Name = "status_lbl_recno"
        Me.status_lbl_recno.Size = New System.Drawing.Size(150, 17)
        Me.status_lbl_recno.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel3.Text = "OutOf"
        '
        'status_lbl_totrec
        '
        Me.status_lbl_totrec.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lbl_totrec.Name = "status_lbl_totrec"
        Me.status_lbl_totrec.Size = New System.Drawing.Size(150, 17)
        Me.status_lbl_totrec.Text = "ToolStripStatusLabel4"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(21, 17)
        Me.ToolStripStatusLabel2.Text = "Of"
        '
        'status_lbl_table
        '
        Me.status_lbl_table.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_lbl_table.Name = "status_lbl_table"
        Me.status_lbl_table.Size = New System.Drawing.Size(150, 17)
        Me.status_lbl_table.Text = "ToolStripStatusLabel4"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(259, 56)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(147, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "INGREDIENT"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ingredient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 591)
        Me.ContextMenuStrip = Me.conmenu_ingredient
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tab_ingredient)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ingredient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredient"
        Me.tooltip_ingredient.SetToolTip(Me, "ingredient")
        Me.tab_ingredient.ResumeLayout(False)
        Me.tab_non_descriptive.ResumeLayout(False)
        Me.tab_non_descriptive.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_descriptive.ResumeLayout(False)
        Me.tab_descriptive.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab_ingredient As System.Windows.Forms.TabControl
    Friend WithEvents tab_non_descriptive As System.Windows.Forms.TabPage
    Friend WithEvents txt_non_ingredient_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_non_label_claim As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tab_descriptive As System.Windows.Forms.TabPage
    Friend WithEvents txt_descriptive_ingredient_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_descriptive_label_claim As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tlstr_btn_add As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_delete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_edit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_search As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_list As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_clear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tlstr_btn_close As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_first As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_previous As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_non_per As System.Windows.Forms.Button
    Friend WithEvents txt_non_limit2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_non_limit1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_non_limit2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_descriptive_per As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_descriptive_limit As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_descriptive_limit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_recno As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_totrec As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_table As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txt_non_ingredient_no As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_descriptive_ingredient_no As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_limit1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_descriptive_unit As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_non_unit As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_non_limit_unit As System.Windows.Forms.Label
    Friend WithEvents lbl_descriptive_unit As System.Windows.Forms.Label
    Friend WithEvents conmenu_ingredient As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip_ingredient As System.Windows.Forms.ToolTip



End Class
