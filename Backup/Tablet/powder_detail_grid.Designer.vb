<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class powder_detail_grid
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_batch_no = New System.Windows.Forms.TextBox
        Me.btn_lst_go = New System.Windows.Forms.Button
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.tooltip_tablet_detail_grid = New System.Windows.Forms.ToolTip(Me.components)
        Me.grd_tab_det = New System.Windows.Forms.DataGridView
        Me.Product_Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Batch_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.A_R_No = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sample_Quantity1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sample_Quantity1_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sample_Quantity2_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sample_Quantity2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Mfg_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Exp_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Received_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Released_Dt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Min_Uniformity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Max_Uniformity = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AverageWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Bulk_Density = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fine_Ness = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Specification_Number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Identification = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.conmenu_tablet_detail_grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Batch No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(300, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "POWDER DETAIL GRID"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(712, 593)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(110, 38)
        Me.btn_close.TabIndex = 8
        Me.btn_close.Text = "CL&OSE"
        Me.tooltip_tablet_detail_grid.SetToolTip(Me.btn_close, "click it to close the form")
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'status_lbl_total_record
        '
        Me.status_lbl_total_record.Name = "status_lbl_total_record"
        Me.status_lbl_total_record.Size = New System.Drawing.Size(154, 17)
        Me.status_lbl_total_record.Text = "ToolStripStatusLabel4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_batch_no)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_lst_go)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(248, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 54)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'txt_batch_no
        '
        Me.txt_batch_no.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_batch_no.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_batch_no.Location = New System.Drawing.Point(136, 19)
        Me.txt_batch_no.MaxLength = 0
        Me.txt_batch_no.Name = "txt_batch_no"
        Me.txt_batch_no.Size = New System.Drawing.Size(135, 21)
        Me.txt_batch_no.TabIndex = 1
        Me.tooltip_tablet_detail_grid.SetToolTip(Me.txt_batch_no, "enter product code")
        '
        'btn_lst_go
        '
        Me.btn_lst_go.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_lst_go.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lst_go.Location = New System.Drawing.Point(305, 17)
        Me.btn_lst_go.Name = "btn_lst_go"
        Me.btn_lst_go.Size = New System.Drawing.Size(45, 23)
        Me.btn_lst_go.TabIndex = 2
        Me.btn_lst_go.Text = "Go"
        Me.tooltip_tablet_detail_grid.SetToolTip(Me.btn_lst_go, "click it to search the records")
        Me.btn_lst_go.UseVisualStyleBackColor = False
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel3.Text = "Out Of"
        '
        'grd_tab_det
        '
        Me.grd_tab_det.AllowUserToAddRows = False
        Me.grd_tab_det.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_tab_det.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_tab_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_tab_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Code, Me.Batch_No, Me.A_R_No, Me.Sample_Quantity1, Me.Sample_Quantity1_Unit, Me.Sample_Quantity2_Unit, Me.Sample_Quantity2, Me.Mfg_Dt, Me.Exp_Dt, Me.Received_Dt, Me.Released_Dt, Me.Description, Me.Min_Uniformity, Me.Max_Uniformity, Me.AverageWeight, Me.Bulk_Density, Me.Fine_Ness, Me.Specification_Number, Me.Identification})
        Me.grd_tab_det.Location = New System.Drawing.Point(81, 142)
        Me.grd_tab_det.Name = "grd_tab_det"
        Me.grd_tab_det.ReadOnly = True
        Me.grd_tab_det.Size = New System.Drawing.Size(753, 440)
        Me.grd_tab_det.TabIndex = 5
        Me.grd_tab_det.TabStop = False
        Me.tooltip_tablet_detail_grid.SetToolTip(Me.grd_tab_det, "display records")
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
        'Sample_Quantity1
        '
        Me.Sample_Quantity1.HeaderText = "Sample_Quantity1"
        Me.Sample_Quantity1.Name = "Sample_Quantity1"
        Me.Sample_Quantity1.ReadOnly = True
        '
        'Sample_Quantity1_Unit
        '
        Me.Sample_Quantity1_Unit.HeaderText = "Sample_Quantity1_Unit"
        Me.Sample_Quantity1_Unit.Name = "Sample_Quantity1_Unit"
        Me.Sample_Quantity1_Unit.ReadOnly = True
        '
        'Sample_Quantity2_Unit
        '
        Me.Sample_Quantity2_Unit.HeaderText = "Sample_Quantity2_Unit"
        Me.Sample_Quantity2_Unit.Name = "Sample_Quantity2_Unit"
        Me.Sample_Quantity2_Unit.ReadOnly = True
        '
        'Sample_Quantity2
        '
        Me.Sample_Quantity2.HeaderText = "Sample_Quantity2"
        Me.Sample_Quantity2.Name = "Sample_Quantity2"
        Me.Sample_Quantity2.ReadOnly = True
        '
        'Mfg_Dt
        '
        DataGridViewCellStyle2.Format = "MMM-yy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Mfg_Dt.DefaultCellStyle = DataGridViewCellStyle2
        Me.Mfg_Dt.HeaderText = "Mfg_Dt"
        Me.Mfg_Dt.Name = "Mfg_Dt"
        Me.Mfg_Dt.ReadOnly = True
        '
        'Exp_Dt
        '
        DataGridViewCellStyle3.Format = "MMM-yy"
        Me.Exp_Dt.DefaultCellStyle = DataGridViewCellStyle3
        Me.Exp_Dt.HeaderText = "Exp_Dt"
        Me.Exp_Dt.Name = "Exp_Dt"
        Me.Exp_Dt.ReadOnly = True
        '
        'Received_Dt
        '
        DataGridViewCellStyle4.Format = "dd/MM/yy"
        Me.Received_Dt.DefaultCellStyle = DataGridViewCellStyle4
        Me.Received_Dt.HeaderText = "Received_Dt"
        Me.Received_Dt.Name = "Received_Dt"
        Me.Received_Dt.ReadOnly = True
        '
        'Released_Dt
        '
        DataGridViewCellStyle5.Format = "dd/MM/yy"
        Me.Released_Dt.DefaultCellStyle = DataGridViewCellStyle5
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
        'Min_Uniformity
        '
        Me.Min_Uniformity.HeaderText = "Min_Uniformity"
        Me.Min_Uniformity.Name = "Min_Uniformity"
        Me.Min_Uniformity.ReadOnly = True
        '
        'Max_Uniformity
        '
        Me.Max_Uniformity.HeaderText = "Max_Uniformity"
        Me.Max_Uniformity.Name = "Max_Uniformity"
        Me.Max_Uniformity.ReadOnly = True
        '
        'AverageWeight
        '
        Me.AverageWeight.HeaderText = "Average Weight"
        Me.AverageWeight.Name = "AverageWeight"
        Me.AverageWeight.ReadOnly = True
        '
        'Bulk_Density
        '
        Me.Bulk_Density.HeaderText = "Bulk_Density"
        Me.Bulk_Density.Name = "Bulk_Density"
        Me.Bulk_Density.ReadOnly = True
        '
        'Fine_Ness
        '
        Me.Fine_Ness.HeaderText = "Fine_Ness"
        Me.Fine_Ness.Name = "Fine_Ness"
        Me.Fine_Ness.ReadOnly = True
        '
        'Specification_Number
        '
        Me.Specification_Number.HeaderText = "Specification_Number"
        Me.Specification_Number.Name = "Specification_Number"
        Me.Specification_Number.ReadOnly = True
        '
        'Identification
        '
        Me.Identification.HeaderText = "Identification"
        Me.Identification.Name = "Identification"
        Me.Identification.ReadOnly = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(918, 22)
        Me.StatusStrip1.TabIndex = 4
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
        Me.status_lbl_record_number.Size = New System.Drawing.Size(154, 17)
        Me.status_lbl_record_number.Text = "ToolStripStatusLabel2"
        '
        'conmenu_tablet_detail_grid
        '
        Me.conmenu_tablet_detail_grid.Name = "conmenu_tablet_master_grid"
        Me.conmenu_tablet_detail_grid.Size = New System.Drawing.Size(61, 4)
        '
        'powder_detail_grid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 661)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grd_tab_det)
        Me.Name = "powder_detail_grid"
        Me.Text = "powder_detail_grid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents tooltip_tablet_detail_grid As System.Windows.Forms.ToolTip
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_batch_no As System.Windows.Forms.TextBox
    Friend WithEvents btn_lst_go As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents grd_tab_det As System.Windows.Forms.DataGridView
    Friend WithEvents Product_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Batch_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents A_R_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sample_Quantity1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sample_Quantity1_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sample_Quantity2_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sample_Quantity2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mfg_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Exp_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Received_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Released_Dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Min_Uniformity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Max_Uniformity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AverageWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bulk_Density As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fine_Ness As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Specification_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identification As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents conmenu_tablet_detail_grid As System.Windows.Forms.ContextMenuStrip
End Class
