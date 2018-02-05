Public Class tablet_detail_grid

    Private Sub tablet_detail_grid_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        tablet_detail.Show()
    End Sub
    Private Sub frm_grd_det_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grd_tab_det.AutoGenerateColumns = False
        Me.grd_tab_det.DataSource = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL")
        Me.Product_Code.DataPropertyName = "Tablet_Code"
        Me.Batch_No.DataPropertyName = "Tablet_Batch_No"
        Me.Sample_Quantity1.DataPropertyName = "Tablet_Sample_Quantity1"
        Me.Sample_Quantity2.DataPropertyName = "Tablet_Sample_Quantity2"
        Me.A_R_No.DataPropertyName = "Tablet_A_R_No"
        Me.Received_Dt.DataPropertyName = "Tablet_Received_Dt"
        Me.Released_Dt.DataPropertyName = "Tablet_Released_Dt"
        Me.Mfg_Dt.DataPropertyName = "Tablet_Manufacturing_Date"
        Me.Exp_Dt.DataPropertyName = "Tablet_Expiry_Date"
        Me.Description.DataPropertyName = "Tablet_Description"
        Me.Min_Uniformity.DataPropertyName = "Tablet_Min_Uniformity"
        Me.Max_Uniformity.DataPropertyName = "Tablet_Max_Uniformity"
        Me.AverageWeight.DataPropertyName = "Tablet_Average"
        Me.Min_Dissolution.DataPropertyName = "Tablet_Min_Dissolution"
        Me.Max_Dissolution.DataPropertyName = "Tablet_Max_Dissolution"
        Me.Disintegration_Time.DataPropertyName = "Tablet_Disintegration_Time"
        Me.Identification.DataPropertyName = "Tablet_Identification"
        Me.Specification_Number.DataPropertyName = "Tablet_Specification_No"
        Me.Sample_Quantity1_Unit.DataPropertyName = "Tablet_Sample_Quantity1_Unit"
        Me.Sample_Quantity2_Unit.DataPropertyName = "ablet_Sample_Quantity2_Unit"
        Call display_statusbar(-1)
        Me.conmenu_tablet_detail_grid.Hide()
    End Sub
    'this procedure displays the record in the status bar
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_record_number.Text = CStr(pointer)
        Me.status_lbl_total_record.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count)
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub btn_lst_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lst_go.Click
        Dim count As Integer
        Dim flag As Boolean
        Try
            For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
                If Me.txt_batch_no.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(count).Item("Tablet_Batch_No") Then
                    Me.grd_tab_det.Rows(count).Selected = True
                    Me.grd_tab_det.CurrentCell = Me.grd_tab_det.SelectedCells(1)
                    flag = True
                    Call display_statusbar(count)
                    Exit For
                End If
            Next
            If flag = False Then
                MsgBox("NO RECORD FOUND", MsgBoxStyle.Information, "No Records")
                If Me.grd_tab_det.RowCount >= 0 Then
                    Me.grd_tab_det.Rows(0).Selected = True
                    Me.grd_tab_det.CurrentCell = Me.grd_tab_det.SelectedCells(1)
                End If
                Call display_statusbar(-1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub txt_batch_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> " ") And (e.KeyChar < "A" Or e.KeyChar > "Z") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND ALPHABETS AND '-' ONLY", MsgBoxStyle.Information, "Batch No")
        End If
    End Sub
    Private Sub grd_tab_det_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_tab_det.SelectionChanged
        Call display_statusbar(Me.grd_tab_det.CurrentRow.Index)
    End Sub
End Class