<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_grd_det
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_lst_go = New System.Windows.Forms.Button
        Me.txt_product_code = New System.Windows.Forms.TextBox
        Me.grd_tab_det = New System.Windows.Forms.DataGridView
        Me.Product_Code = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.AverageWeight = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Disintegration_Time = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dissolution1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dissolution2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Product_Code :"
        '
        'btn_lst_go
        '
        Me.btn_lst_go.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_lst_go.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_lst_go.Location = New System.Drawing.Point(471, 43)
        Me.btn_lst_go.Name = "btn_lst_go"
        Me.btn_lst_go.Size = New System.Drawing.Size(45, 23)
        Me.btn_lst_go.TabIndex = 10
        Me.btn_lst_go.Text = "Go"
        Me.btn_lst_go.UseVisualStyleBackColor = False
        '
        'txt_product_code
        '
        Me.txt_product_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_product_code.Location = New System.Drawing.Point(301, 45)
        Me.txt_product_code.MaxLength = 4
        Me.txt_product_code.Name = "txt_product_code"
        Me.txt_product_code.Size = New System.Drawing.Size(135, 20)
        Me.txt_product_code.TabIndex = 9
        '
        'grd_tab_det
        '
        Me.grd_tab_det.AllowUserToAddRows = False
        Me.grd_tab_det.AllowUserToDeleteRows = False
        Me.grd_tab_det.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_tab_det.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product_Code, Me.Product_Name, Me.Batch_No, Me.A_R_No, Me.Sample_Quantitys, Me.Sample_Quantityp, Me.Mfg_Dt, Me.Exp_Dt, Me.Received_Dt, Me.Released_Dt, Me.Description, Me.Uniformity1, Me.Uniformity2, Me.AverageWeight, Me.Disintegration_Time, Me.Dissolution1, Me.Dissolution2})
        Me.grd_tab_det.Location = New System.Drawing.Point(29, 105)
        Me.grd_tab_det.Name = "grd_tab_det"
        Me.grd_tab_det.ReadOnly = True
        Me.grd_tab_det.Size = New System.Drawing.Size(753, 440)
        Me.grd_tab_det.TabIndex = 8
        '
        'Product_Code
        '
        Me.Product_Code.HeaderText = "Product_Code"
        Me.Product_Code.Name = "Product_Code"
        Me.Product_Code.ReadOnly = True
        '
        'Product_Name
        '
        Me.Product_Name.HeaderText = "Product_Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
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
        Me.Uniformity1.HeaderText = "Uniformity1"
        Me.Uniformity1.Name = "Uniformity1"
        Me.Uniformity1.ReadOnly = True
        '
        'Uniformity2
        '
        Me.Uniformity2.HeaderText = "Uniformity2"
        Me.Uniformity2.Name = "Uniformity2"
        Me.Uniformity2.ReadOnly = True
        '
        'AverageWeight
        '
        Me.AverageWeight.HeaderText = "AverageWeight"
        Me.AverageWeight.Name = "AverageWeight"
        Me.AverageWeight.ReadOnly = True
        '
        'Disintegration_Time
        '
        Me.Disintegration_Time.HeaderText = "Disintegration_Time"
        Me.Disintegration_Time.Name = "Disintegration_Time"
        Me.Disintegration_Time.ReadOnly = True
        '
        'Dissolution1
        '
        Me.Dissolution1.HeaderText = "Dissolution1"
        Me.Dissolution1.Name = "Dissolution1"
        Me.Dissolution1.ReadOnly = True
        '
        'Dissolution2
        '
        Me.Dissolution2.HeaderText = "Dissolution2"
        Me.Dissolution2.Name = "Dissolution2"
        Me.Dissolution2.ReadOnly = True
        '
        'frm_grd_det
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_lst_go)
        Me.Controls.Add(Me.txt_product_code)
        Me.Controls.Add(Me.grd_tab_det)
        Me.Name = "frm_grd_det"
        Me.Text = "Grid List"
        CType(Me.grd_tab_det, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_lst_go As System.Windows.Forms.Button
    Friend WithEvents txt_product_code As System.Windows.Forms.TextBox
    Friend WithEvents grd_tab_det As System.Windows.Forms.DataGridView
    Friend WithEvents Product_Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents AverageWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Disintegration_Time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dissolution1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dissolution2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
