<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class liquid_detail_grid
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
        Me.grd_tab_det = New System.Windows.Forms.DataGridView
        Me.Product_Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Batch_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_R_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sample_Quantitys = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sample_Quantityp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mfg_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Exp_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Received_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Released_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Uniformity1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Uniformity2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Average_Volume = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ph = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Weight_Per_ml = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.conmenu_liquid_detail_grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_batch_no = New System.Windows.Forms.TextBox
        Me.btn_go = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        Me.tooltip_liquid_detail_grid = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd_tab_det
        '
        Me.grd_tab_det.AllowUserToAddRows = False
        Me.grd_tab_det.AllowUserToDeleteRows = False
        Me.grd_tab_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_tab_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Code, Me.Batch_No, Me.A_R_No, Me.Sample_Quantitys, Me.Sample_Quantityp, Me.Mfg_Dt, Me.Exp_Dt, Me.Received_Dt, Me.Released_Dt, Me.Description, Me.Uniformity1, Me.Uniformity2, Me.Average_Volume, Me.Ph, Me.Weight_Per_ml})
        Me.grd_tab_det.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.grd_tab_det.Location = New System.Drawing.Point(62, 151)
        Me.grd_tab_det.Name = "grd_tab_det"
        Me.grd_tab_det.ReadOnly = True
        Me.grd_tab_det.Size = New System.Drawing.Size(753, 440)
        Me.grd_tab_det.TabIndex = 0
        Me.tooltip_liquid_detail_grid.SetToolTip(Me.grd_tab_det, "display records")
        '
        'Product_Code
        '
        Me.Product_Code.HeaderText = "Product_Code"
        Me.Product_Code.Name = "Product_Code"
        Me.Product_Code.ReadOnly = True
        '
        'Batch_No
        '
        Me.Batch_No.HeaderText = "Batch_No"
        Me.Batch_No.Name = "Batch_No"
        Me.Batch_No.ReadOnly = True
        '
        'A_R_No
        '
        Me.A_R_No.HeaderText = "A_R_NO"
        Me.A_R_No.Name = "A_R_No"
        Me.A_R_No.ReadOnly = True
        '
        'Sample_Quantitys
        '
        Me.Sample_Quantitys.HeaderText = "Sample_Quantity(s)"
        Me.Sample_Quantitys.Name = "Sample_Quantitys"
        Me.Sample_Quantitys.ReadOnly = True
        '
        'Sample_Quantityp
        '
        Me.Sample_Quantityp.HeaderText = "Sample_Quantity(p)"
        Me.Sample_Quantityp.Name = "Sample_Quantityp"
        Me.Sample_Quantityp.ReadOnly = True
        '
        'Mfg_Dt
        '
        Me.Mfg_Dt.HeaderText = "Mfg_Dt"
        Me.Mfg_Dt.Name = "Mfg_Dt"
        Me.Mfg_Dt.ReadOnly = True
        '
        'Exp_Dt
        '
        Me.Exp_Dt.HeaderText = "Exp_Dt"
        Me.Exp_Dt.Name = "Exp_Dt"
        Me.Exp_Dt.ReadOnly = True
        '
        'Received_Dt
        '
        Me.Received_Dt.HeaderText = "Received_Dt"
        Me.Received_Dt.Name = "Received_Dt"
        Me.Received_Dt.ReadOnly = True
        '
        'Released_Dt
        '
        Me.Released_Dt.HeaderText = "Released_Dt"
        Me.Released_Dt.Name = "Released_Dt"
        Me.Released_Dt.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Uniformity1
        '
        Me.Uniformity1.HeaderText = "Uniformity of Volume1"
        Me.Uniformity1.Name = "Uniformity1"
        Me.Uniformity1.ReadOnly = True
        '
        'Uniformity2
        '
        Me.Uniformity2.HeaderText = "Uniformity of Volume2"
        Me.Uniformity2.Name = "Uniformity2"
        Me.Uniformity2.ReadOnly = True
        '
        'Average_Volume
        '
        Me.Average_Volume.HeaderText = "Average Volume"
        Me.Average_Volume.Name = "Average_Volume"
        Me.Average_Volume.ReadOnly = True
        '
        'Ph
        '
        Me.Ph.HeaderText = "PH"
        Me.Ph.Name = "Ph"
        Me.Ph.ReadOnly = True
        '
        'Weight_Per_ml
        '
        Me.Weight_Per_ml.HeaderText = "Weight_Per_ml"
        Me.Weight_Per_ml.Name = "Weight_Per_ml"
        Me.Weight_Per_ml.ReadOnly = True
        '
        'conmenu_liquid_detail_grid
        '
        Me.conmenu_liquid_detail_grid.Name = "conmenu_liquid_detail_grid"
        Me.conmenu_liquid_detail_grid.Size = New System.Drawing.Size(61, 4)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(282, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "LIQUID DETAIL GRID"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(696, 615)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(72, 29)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "Cl&ose"
        Me.tooltip_liquid_detail_grid.SetToolTip(Me.btn_close, "click to close the form")
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.GroupBox1.Controls.Add(Me.txt_batch_no)
        Me.GroupBox1.Controls.Add(Me.btn_go)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(238, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 63)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'txt_batch_no
        '
        Me.txt_batch_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_batch_no.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.txt_batch_no.Location = New System.Drawing.Point(143, 25)
        Me.txt_batch_no.MaxLength = 4
        Me.txt_batch_no.Name = "txt_batch_no"
        Me.txt_batch_no.Size = New System.Drawing.Size(135, 21)
        Me.txt_batch_no.TabIndex = 1
        Me.tooltip_liquid_detail_grid.SetToolTip(Me.txt_batch_no, "enter batch number")
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_go.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.btn_go.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.Location = New System.Drawing.Point(309, 23)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(45, 23)
        Me.btn_go.TabIndex = 2
        Me.btn_go.Text = "&Go"
        Me.tooltip_liquid_detail_grid.SetToolTip(Me.btn_go, "click to search the records")
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Batch No :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 662)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(837, 22)
        Me.StatusStrip1.TabIndex = 85
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel1.Text = "Record"
        '
        'status_lbl_record_number
        '
        Me.status_lbl_record_number.Name = "status_lbl_record_number"
        Me.status_lbl_record_number.Size = New System.Drawing.Size(111, 17)
        Me.status_lbl_record_number.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel3.Text = "OutOf"
        '
        'status_lbl_total_record
        '
        Me.status_lbl_total_record.Name = "status_lbl_total_record"
        Me.status_lbl_total_record.Size = New System.Drawing.Size(111, 17)
        Me.status_lbl_total_record.Text = "ToolStripStatusLabel4"
        '
        'liquid_detail_grid
        '
        Me.AcceptButton = Me.btn_go
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_close
        Me.ClientSize = New System.Drawing.Size(837, 684)
        Me.ContextMenuStrip = Me.conmenu_liquid_detail_grid
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grd_tab_det)
        Me.Name = "liquid_detail_grid"
        Me.Text = "Liquid Detail Grid"
        Me.tooltip_liquid_detail_grid.SetToolTip(Me, "liquid detail grid")
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd_tab_det As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Product_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Batch_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_R_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sample_Quantitys As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sample_Quantityp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mfg_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exp_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Received_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Released_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uniformity1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Uniformity2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Average_Volume As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ph As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Weight_Per_ml As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_batch_no As System.Windows.Forms.TextBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents conmenu_liquid_detail_grid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tooltip_liquid_detail_grid As System.Windows.Forms.ToolTip
End Class
