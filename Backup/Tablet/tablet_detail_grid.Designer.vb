<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tablet_detail_grid
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_lst_go = New System.Windows.Forms.Button
        Me.txt_batch_no = New System.Windows.Forms.TextBox
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
        Me.Disintegration_Time = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Min_Dissolution = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Max_Dissolution = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Specification_Number = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Identification = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_close = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_record_number = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.status_lbl_total_record = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label2 = New System.Windows.Forms.Label
        Me.tooltip_tablet_detail_grid = New System.Windows.Forms.ToolTip(Me.components)
        Me.conmenu_tablet_detail_grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        'grd_tab_det
        '
        Me.grd_tab_det.AllowUserToAddRows = False
        Me.grd_tab_det.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_tab_det.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grd_tab_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_tab_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Code, Me.Batch_No, Me.A_R_No, Me.Sample_Quantity1, Me.Sample_Quantity1_Unit, Me.Sample_Quantity2_Unit, Me.Sample_Quantity2, Me.Mfg_Dt, Me.Exp_Dt, Me.Received_Dt, Me.Released_Dt, Me.Description, Me.Min_Uniformity, Me.Max_Uniformity, Me.AverageWeight, Me.Disintegration_Time, Me.Min_Dissolution, Me.Max_Dissolution, Me.Specification_Number, Me.Identification})
        Me.grd_tab_det.Location = New System.Drawing.Point(29, 157)
        Me.grd_tab_det.Name = "grd_tab_det"
        Me.grd_tab_det.ReadOnly = True
        Me.grd_tab_det.Size = New System.Drawing.Size(753, 440)
        Me.grd_tab_det.TabIndex = 0
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
        DataGridViewCellStyle7.Format = "MMM-yy"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Mfg_Dt.DefaultCellStyle = DataGridViewCellStyle7
        Me.Mfg_Dt.HeaderText = "Mfg_Dt"
        Me.Mfg_Dt.Name = "Mfg_Dt"
        Me.Mfg_Dt.ReadOnly = True
        '
        'Exp_Dt
        '
        DataGridViewCellStyle8.Format = "MMM-yy"
        Me.Exp_Dt.DefaultCellStyle = DataGridViewCellStyle8
        Me.Exp_Dt.HeaderText = "Exp_Dt"
        Me.Exp_Dt.Name = "Exp_Dt"
        Me.Exp_Dt.ReadOnly = True
        '
        'Received_Dt
        '
        DataGridViewCellStyle9.Format = "dd/MM/yy"
        Me.Received_Dt.DefaultCellStyle = DataGridViewCellStyle9
        Me.Received_Dt.HeaderText = "Received_Dt"
        Me.Received_Dt.Name = "Received_Dt"
        Me.Received_Dt.ReadOnly = True
        '
        'Released_Dt
        '
        DataGridViewCellStyle10.Format = "dd/MM/yy"
        Me.Released_Dt.DefaultCellStyle = DataGridViewCellStyle10
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
        'Disintegration_Time
        '
        Me.Disintegration_Time.HeaderText = "Disintegration_Time"
        Me.Disintegration_Time.Name = "Disintegration_Time"
        Me.Disintegration_Time.ReadOnly = True
        '
        'Min_Dissolution
        '
        Me.Min_Dissolution.HeaderText = "Min_Dissolution"
        Me.Min_Dissolution.Name = "Min_Dissolution"
        Me.Min_Dissolution.ReadOnly = True
        '
        'Max_Dissolution
        '
        Me.Max_Dissolution.HeaderText = "Max_Dissolution"
        Me.Max_Dissolution.Name = "Max_Dissolution"
        Me.Max_Dissolution.ReadOnly = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_batch_no)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_lst_go)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(226, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 54)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(650, 612)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(110, 38)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "CL&OSE"
        Me.tooltip_tablet_detail_grid.SetToolTip(Me.btn_close, "click it to close the form")
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.status_lbl_record_number, Me.ToolStripStatusLabel3, Me.status_lbl_total_record})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 663)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(813, 22)
        Me.StatusStrip1.TabIndex = 0
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
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel3.Text = "Out Of"
        '
        'status_lbl_total_record
        '
        Me.status_lbl_total_record.Name = "status_lbl_total_record"
        Me.status_lbl_total_record.Size = New System.Drawing.Size(154, 17)
        Me.status_lbl_total_record.Text = "ToolStripStatusLabel4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "TABLET DETAIL GRID"
        '
        'conmenu_tablet_detail_grid
        '
        Me.conmenu_tablet_detail_grid.Name = "conmenu_tablet_master_grid"
        Me.conmenu_tablet_detail_grid.Size = New System.Drawing.Size(61, 4)
        '
        'tablet_detail_grid
        '
        Me.AcceptButton = Me.btn_lst_go
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_close
        Me.ClientSize = New System.Drawing.Size(813, 685)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grd_tab_det)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "tablet_detail_grid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablet Detail Grid"
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_lst_go As System.Windows.Forms.Button
    Friend WithEvents txt_batch_no As System.Windows.Forms.TextBox
    Friend WithEvents grd_tab_det As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_record_number As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents status_lbl_total_record As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tooltip_tablet_detail_grid As System.Windows.Forms.ToolTip
    Friend WithEvents conmenu_tablet_detail_grid As System.Windows.Forms.ContextMenuStrip
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
    Friend WithEvents Disintegration_Time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Min_Dissolution As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Max_Dissolution As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Specification_Number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identification As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
