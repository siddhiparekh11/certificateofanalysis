Public Class liquid_detail_grid
    Private Sub liquid_detail_grid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grd_tab_det.AutoGenerateColumns = False
        Me.grd_tab_det.DataSource = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL")
        Me.Product_Code.DataPropertyName = "Product_Code"
        Me.Batch_No.DataPropertyName = "Batch_No"
        Me.A_R_No.DataPropertyName = "A_R_No"
        Me.Sample_Quantitys.DataPropertyName = "Sample_Quantity1"
        Me.Sample_Quantityp.DataPropertyName = "Sample_Quantity2"
        Me.Received_Dt.DataPropertyName = "Received_Date"
        Me.Released_Dt.DataPropertyName = "Released_Date"
        Me.Mfg_Dt.DataPropertyName = "Manufacturing_Date"
        Me.Exp_Dt.DataPropertyName = "Expiry_Date"
        Me.Description.DataPropertyName = "Description"
        Me.Uniformity1.DataPropertyName = "Uniformity1"
        Me.Uniformity2.DataPropertyName = "Uniformity2"
        Me.Ph.DataPropertyName = "Ph"
        Me.Weight_Per_ml.DataPropertyName = "Weight"
        Me.Average_Volume.DataPropertyName = "Average"
        Call display_statusbar(-1)
        Me.conmenu_liquid_detail_grid.Hide()
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Dim count As Integer
        Dim flag As Boolean
        For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1
            If Me.txt_batch_no.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Batch_No") Then
                Me.grd_tab_det.Rows(count).Selected = True
                Me.grd_tab_det.CurrentCell = Me.grd_tab_det.SelectedCells(1)
                Call display_statusbar(count)
                flag = True
            End If
        Next
        If flag = False Then
            MsgBox("NO RECORD FOUND", MsgBoxStyle.Information, "Incorrect Batch No")
            Me.grd_tab_det.Rows(0).Selected = True
            Me.grd_tab_det.CurrentCell = Me.grd_tab_det.SelectedCells(1)
            Call display_statusbar(-1)
        End If
    End Sub
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_record_number.Text = CStr(pointer)
        Me.status_lbl_total_record.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count)
    End Sub
End Class