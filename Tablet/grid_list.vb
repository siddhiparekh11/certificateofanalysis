Public Class frm_grd_det
    Dim range() As String

    Private Sub frm_grd_det_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.grd_tab_det.AutoGenerateColumns = False
        Me.grd_tab_det.DataSource = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL")
        Me.Product_Code.DataPropertyName = "Product_Code"
        Me.Batch_No.DataPropertyName = "Batch_No"
        Me.Sample_Quantityp.DataPropertyName = "Sample_1"
        Me.Sample_Quantitys.DataPropertyName = "Sample_2"
        Me.A_R_No.DataPropertyName = "A_R_No"
        Me.Received_Dt.DataPropertyName = "Received_Dt"
        Me.Released_Dt.DataPropertyName = "Released_Dt"
        Me.Mfg_Dt.DataPropertyName = "Mfg_Dt"
        Me.Exp_Dt.DataPropertyName = "Exp_Dt"
        Me.Description.DataPropertyName = "Description"
        Me.Uniformity1.DataPropertyName = "Uniformity1"
        Me.Uniformity2.DataPropertyName = "Uniformity2"
        Me.AverageWeight.DataPropertyName = "Average1"
        Me.Dissolution1.DataPropertyName = "Dissolution1"
        Me.Dissolution2.DataPropertyName = "Dissolution2"
        Me.Disintegration_Time.DataPropertyName = "Disintegration_Time"

    End Sub

    Private Sub txt_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_product_code.KeyPress
        If (e.KeyChar < "A" Or e.KeyChar > "Z") And (e.KeyChar < "a" Or e.KeyChar > "z") And e.KeyChar <> vbBack Then
            e.KeyChar = ""
            MsgBox("ENTER ALPHABETS ONLY")
        End If
    End Sub
    Private Sub pre_range()
        Dim min, max, cal As Double, i As Integer
        For i = 0 To tablet_detail.average1.Length - 1
            cal = (tablet_detail.average1(i)) * ((tablet_detail.average2(i)) / 100)
            min = tablet_detail.average1(i) - cal
            max = tablet_detail.average1(i) - cal
            range(i) = CStr(min) & "to" & CStr(max)
        Next
    End Sub
End Class