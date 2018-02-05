<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tablet_master_grid
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_lst_go = New System.Windows.Forms.Button
        Me.txt_product_code = New System.Windows.Forms.TextBox
        Me.conmenu_tablet_master_grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.grd_tablet_master = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tooltip_tablet_master_grid = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_close = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.grd_tablet_master, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product_Code :"
        '
        'btn_lst_go
        '
        Me.btn_lst_go.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_lst_go.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lst_go.Location = New System.Drawing.Point(314, 30)
        Me.btn_lst_go.Name = "btn_lst_go"
        Me.btn_lst_go.Size = New System.Drawing.Size(45, 23)
        Me.btn_lst_go.TabIndex = 2
        Me.btn_lst_go.Text = "&Go"
        Me.tooltip_tablet_master_grid.SetToolTip(Me.btn_lst_go, "click go to search records")
        Me.btn_lst_go.UseVisualStyleBackColor = False
        '
        'txt_product_code
        '
        Me.txt_product_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_product_code.ContextMenuStrip = Me.conmenu_tablet_master_grid
        Me.txt_product_code.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_product_code.Location = New System.Drawing.Point(144, 32)
        Me.txt_product_code.MaxLength = 4
        Me.txt_product_code.Name = "txt_product_code"
        Me.txt_product_code.Size = New System.Drawing.Size(135, 21)
        Me.txt_product_code.TabIndex = 1
        Me.tooltip_tablet_master_grid.SetToolTip(Me.txt_product_code, "enter product code")
        '
        'conmenu_tablet_master_grid
        '
        Me.conmenu_tablet_master_grid.Name = "conmenu_tablet_master_grid"
        Me.conmenu_tablet_master_grid.Size = New System.Drawing.Size(61, 4)
        '
        'grd_tablet_master
        '
        Me.grd_tablet_master.AllowUserToAddRows = False
        Me.grd_tablet_master.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_tablet_master.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_tablet_master.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_tablet_master.Location = New System.Drawing.Point(19, 159)
        Me.grd_tablet_master.MultiSelect = False
        Me.grd_tablet_master.Name = "grd_tablet_master"
        Me.grd_tablet_master.ReadOnly = True
        Me.grd_tablet_master.Size = New System.Drawing.Size(708, 436)
        Me.grd_tablet_master.TabIndex = 0
        Me.grd_tablet_master.TabStop = False
        Me.tooltip_tablet_master_grid.SetToolTip(Me.grd_tablet_master, "display records ")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_product_code)
        Me.GroupBox1.Controls.Add(Me.btn_lst_go)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(171, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TABLET MASTER GRID"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(547, 615)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(110, 38)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "CL&OSE"
        Me.tooltip_tablet_master_grid.SetToolTip(Me.btn_close, "to close the form")
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 674)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(752, 22)
        Me.StatusStrip1.TabIndex = 11
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel1.Text = "Record"
        '
        'status_lbl_record_number
        '
        Me.status_lbl_record_number.Name = "status_lbl_record_number"
        Me.status_lbl_record_number.Size = New System.Drawing.Size(16, 17)
        Me.status_lbl_record_number.Text = "0"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel3.Text = "Out Of"
        '
        'status_lbl_total_record
        '
        Me.status_lbl_total_record.Name = "status_lbl_total_record"
        Me.status_lbl_total_record.Size = New System.Drawing.Size(16, 17)
        Me.status_lbl_total_record.Text = "0"
        '
        'tablet_master_grid
        '
        Me.AcceptButton = Me.btn_lst_go
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_close
        Me.ClientSize = New System.Drawing.Size(752, 696)
        Me.ContextMenuStrip = Me.conmenu_tablet_master_grid
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grd_tablet_master)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.Name = "tablet_master_grid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablet Master Grid"
        Me.tooltip_tablet_master_grid.SetToolTip(Me, "tablet master grid")
        CType(Me.grd_tablet_master, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_lst_go As System.Windows.Forms.Button
    Friend WithEvents txt_product_code As System.Windows.Forms.TextBox
    Friend WithEvents grd_tablet_master As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tooltip_tablet_master_grid As System.Windows.Forms.ToolTip
    Friend WithEvents conmenu_tablet_master_grid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_close As System.Windows.Forms.Button
End Class
