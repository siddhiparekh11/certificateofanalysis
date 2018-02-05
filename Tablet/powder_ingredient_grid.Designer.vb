<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class powder_ingredient_grid
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
        Me.btn_delete = New System.Windows.Forms.Button
        Me.txt_batch_no = New System.Windows.Forms.TextBox
        Me.conmenu_powder_ingredient_grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btn_lst_go = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_close = New System.Windows.Forms.Button
        Me.tooltip_powder_ingredient_grid = New System.Windows.Forms.ToolTip(Me.components)
        Me.grd_pow_ing = New System.Windows.Forms.DataGridView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_batch_no = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_pow_ing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(407, 34)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(67, 23)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.tooltip_powder_ingredient_grid.SetToolTip(Me.btn_delete, "click to delete the records")
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_batch_no
        '
        Me.txt_batch_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_batch_no.ContextMenuStrip = Me.conmenu_powder_ingredient_grid
        Me.txt_batch_no.Location = New System.Drawing.Point(132, 36)
        Me.txt_batch_no.MaxLength = 4
        Me.txt_batch_no.Name = "txt_batch_no"
        Me.txt_batch_no.Size = New System.Drawing.Size(135, 21)
        Me.txt_batch_no.TabIndex = 1
        Me.tooltip_powder_ingredient_grid.SetToolTip(Me.txt_batch_no, "enter batch number")
        '
        'conmenu_powder_ingredient_grid
        '
        Me.conmenu_powder_ingredient_grid.Name = "conmenu_tablet_ingredient_grid"
        Me.conmenu_powder_ingredient_grid.Size = New System.Drawing.Size(61, 4)
        '
        'btn_lst_go
        '
        Me.btn_lst_go.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_lst_go.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lst_go.Location = New System.Drawing.Point(320, 34)
        Me.btn_lst_go.Name = "btn_lst_go"
        Me.btn_lst_go.Size = New System.Drawing.Size(45, 23)
        Me.btn_lst_go.TabIndex = 2
        Me.btn_lst_go.Text = "Go"
        Me.tooltip_powder_ingredient_grid.SetToolTip(Me.btn_lst_go, "click to search the record")
        Me.btn_lst_go.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batch No :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.txt_batch_no)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_lst_go)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(191, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 80)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search & Delete"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(679, 620)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(110, 38)
        Me.btn_close.TabIndex = 9
        Me.btn_close.Text = "CL&OSE"
        Me.tooltip_powder_ingredient_grid.SetToolTip(Me.btn_close, "click to close the form")
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'grd_pow_ing
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_pow_ing.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_pow_ing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_pow_ing.Location = New System.Drawing.Point(69, 204)
        Me.grd_pow_ing.Name = "grd_pow_ing"
        Me.grd_pow_ing.Size = New System.Drawing.Size(742, 394)
        Me.grd_pow_ing.TabIndex = 5
        Me.tooltip_powder_ingredient_grid.SetToolTip(Me.grd_pow_ing, "display records")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_batch_no})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 672)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(903, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(81, 17)
        Me.ToolStripStatusLabel1.Text = "Batch Number :"
        '
        'status_lbl_batch_no
        '
        Me.status_lbl_batch_no.Name = "status_lbl_batch_no"
        Me.status_lbl_batch_no.Size = New System.Drawing.Size(111, 17)
        Me.status_lbl_batch_no.Text = "ToolStripStatusLabel2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(295, 45)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(319, 23)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "POWDER  INGREDIENT GRID"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'powder_ingredient_grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 694)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grd_pow_ing)
        Me.Name = "powder_ingredient_grid"
        Me.Text = "powder_ingredient_grid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_pow_ing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents tooltip_powder_ingredient_grid As System.Windows.Forms.ToolTip
    Friend WithEvents txt_batch_no As System.Windows.Forms.TextBox
    Friend WithEvents conmenu_powder_ingredient_grid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btn_lst_go As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents grd_pow_ing As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_batch_no As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
