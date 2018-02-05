<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingredient_list
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
        Me.grd_ingredient = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_list_go = New System.Windows.Forms.Button
        Me.txt_ingredient_list_search = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_recno = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_totrec = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_table = New System.Windows.Forms.ToolStripStatusLabel
        Me.btn_close = New System.Windows.Forms.Button
        Me.tooltip_ingredient = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.grd_ingredient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_ingredient
        '
        Me.grd_ingredient.AllowUserToAddRows = False
        Me.grd_ingredient.AllowUserToDeleteRows = False
        Me.grd_ingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_ingredient.Location = New System.Drawing.Point(64, 130)
        Me.grd_ingredient.Name = "grd_ingredient"
        Me.grd_ingredient.ReadOnly = True
        Me.grd_ingredient.Size = New System.Drawing.Size(678, 407)
        Me.grd_ingredient.TabIndex = 0
        Me.grd_ingredient.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_list_go)
        Me.GroupBox1.Controls.Add(Me.txt_ingredient_list_search)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(184, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(35, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingredient No :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_list_go
        '
        Me.btn_list_go.Location = New System.Drawing.Point(351, 18)
        Me.btn_list_go.Name = "btn_list_go"
        Me.btn_list_go.Size = New System.Drawing.Size(60, 32)
        Me.btn_list_go.TabIndex = 2
        Me.btn_list_go.Text = "&Go"
        Me.btn_list_go.UseVisualStyleBackColor = True
        '
        'txt_ingredient_list_search
        '
        Me.txt_ingredient_list_search.Location = New System.Drawing.Point(175, 23)
        Me.txt_ingredient_list_search.Name = "txt_ingredient_list_search"
        Me.txt_ingredient_list_search.Size = New System.Drawing.Size(133, 21)
        Me.txt_ingredient_list_search.TabIndex = 1
        Me.tooltip_ingredient.SetToolTip(Me.txt_ingredient_list_search, "ingredient no")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(286, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(203, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "INGREDIENT LIST"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_recno, Me.ToolStripStatusLabel3, Me.status_lbl_totrec, Me.ToolStripStatusLabel2, Me.status_lbl_table})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 596)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(805, 22)
        Me.StatusStrip1.TabIndex = 0
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
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(632, 546)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(110, 38)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "CL&OSE"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'ingredient_list
        '
        Me.AcceptButton = Me.btn_list_go
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_close
        Me.ClientSize = New System.Drawing.Size(805, 618)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grd_ingredient)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ingredient_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredient List"
        CType(Me.grd_ingredient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_ingredient As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_list_go As System.Windows.Forms.Button
    Friend WithEvents txt_ingredient_list_search As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_recno As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_totrec As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_table As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents tooltip_ingredient As System.Windows.Forms.ToolTip
End Class
