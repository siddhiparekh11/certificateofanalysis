'this form contains details about Tablet Detail for details see TABLET_MODULE
Public Class tablet_detail
    Public uniformity() As Double
    Public average_weight_range() As Double
    Public average_weight() As Double
    Public product_name() As String
    Public description() As String
    Public shelf_life() As Integer
    Public disintegration_time() As String
    Dim average As Double
    Dim record As Integer
    Private Sub txt_ar_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ar_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "/") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "A.R.No")
        End If
    End Sub
    Private Sub txt_batch_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> " ") And (e.KeyChar < "A" Or e.KeyChar > "Z") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND ALPHABETS AND '-' ONLY", MsgBoxStyle.Information, "Batch No")
        End If
    End Sub

    Private Sub tablet_detail_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        TABLET_MODULE.tablet_close_connection()
        frm_mdi.Show()
    End Sub
    
    Private Sub tablet_detail__Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call TABLET_MODULE.tablet_open_connection()
        Call TABLET_MODULE.tablet_filldataset_master()
        Call initialize_master_arrays()
        Call TABLET_MODULE.tablet_filldataset_detail()
        conmenu_tablet_detail.Hide()
        Call display_statusbar(-1)
        Me.txt_identification.Visible = False
    End Sub
    Private Sub cmb_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_product_code.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmb_product_code_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_product_code.SelectedValueChanged
        Me.lbl_product_name.Text = product_name(Me.cmb_product_code.SelectedIndex)
        Me.txt_description.Text = description(Me.cmb_product_code.SelectedIndex)
        Me.txt_batch_no.Text = Me.cmb_product_code.Text & " "
    End Sub
    Private Sub cmb_product_code_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_product_code.TextChanged
        If Me.cmb_product_code.Text = "" Then
            Me.lbl_product_name.Text = ""
            Me.txt_description.Text = ""
            Me.txt_batch_no.Text = ""
            Me.dtp_mfg_date.Value = Me.dtp_mfg_date.MinDate
            Me.dtp_exp_date.Value = Me.dtp_exp_date.MinDate
        End If
    End Sub
    Private Sub txt_description_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.txt_description.Enabled = False
    End Sub
    Private Sub tlstr_btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_clear.Click
        Call clear_all()
        Call display_statusbar(-1)
    End Sub
    Private Sub btn_validate_average_weight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_validate_average_weight.Click
        Dim min, max, cal As Double
        If Me.cmb_product_code.Text <> "" Then
            If average_weight(Me.cmb_product_code.SelectedIndex) <> 0 And average_weight_range(Me.cmb_product_code.SelectedIndex) <> 0 Then
                cal = ((average_weight(Me.cmb_product_code.SelectedIndex) * (average_weight_range(Me.cmb_product_code.SelectedIndex))) / 100)
                min = average_weight(Me.cmb_product_code.SelectedIndex) - cal
                max = average_weight(Me.cmb_product_code.SelectedIndex) + cal
                If Val(Me.txt_average.Text) >= min And Val(Me.txt_average.Text) <= max Then
                    average = Val(Me.txt_average.Text)
                    MsgBox("AVERAGE WEIGHT IS CORRECT", MsgBoxStyle.Information, "Average Weight")
                Else
                    average = Val("0")
                    MsgBox("AVERAGE WEIGHT IS OUT OF RANGE", MsgBoxStyle.Information, "Average Weight")
                    Me.txt_average.Focus()
                End If
            Else
                MsgBox("CHECK TABLET MASTER FOR AVERAGE WEIGHT VALUES", MsgBoxStyle.Information, "Average Weight")
                average = Val("0")
            End If
        Else
            MsgBox(" PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
            average = Val("0")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_released_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_released.Click
        If Me.cmb_product_code.Text <> "" Then
            If Me.dtp_released_date.Value < Me.dtp_received_date.Value Then
                MsgBox("RELEASE DATE CANNOT BE LESS THAN RECEIVED DATE", MsgBoxStyle.Information, "Released Date Check")
                Me.dtp_released_date.Focus()
            Else
                MsgBox("RELEASE DATE IS CORRECT", MsgBoxStyle.Information, "Released Date Check")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validat_expiry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validat_expiry.Click
        Dim expiry_date As Date
        If Me.cmb_product_code.Text <> "" Then
            If shelf_life(Me.cmb_product_code.SelectedIndex) <> 0 Then
                expiry_date = DateAdd(DateInterval.Month, shelf_life(Me.cmb_product_code.SelectedIndex), Me.dtp_mfg_date.Value)
                Me.dtp_exp_date.Value = expiry_date
                MsgBox("EXPIRY DATE HAS BEEN CHANGED", MsgBoxStyle.Information, "Expiry Date Check")
            Else
                MsgBox("CHECK TABLET MASTER FOR SHELF LIFE VALUE", MsgBoxStyle.Information, "Expiry Date Check")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_uniformity_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_uniformity.Click
        Dim average_range As Double
        If average <> 0 Then
            average_range = average_weight_range(Me.cmb_product_code.SelectedIndex)
            frm_uniform_validate.Show()
            frm_uniform_validate.lb_amax_tb1.Text = CStr(average / 1000)
            frm_uniform_validate.lb_amin_tb2.Text = CStr(average / 1000)
            frm_uniform_validate.lbl_max_average_weight.Text = CStr(average)
            frm_uniform_validate.lbl_max_averageweight_range.Text = CStr(average_range)
            frm_uniform_validate.lbl_min_average_weight.Text = CStr(average)
            frm_uniform_validate.lbl_min_averageweight_range.Text = CStr(average_range)
        Else
            MsgBox("CHECK THE AVERAGE WEIGHT", MsgBoxStyle.Information, "Average Weight")
            Me.txt_average.Focus()
        End If
    End Sub
    'This procedure initialize the arrays from Tablet Master
    Private Sub initialize_master_arrays()
        Dim count As Integer, total As Integer
        total = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count
        ReDim uniformity(total)
        ReDim average_weight(total)
        ReDim average_weight_range(total)
        ReDim product_name(total)
        ReDim description(total)
        ReDim shelf_life(total)
        ReDim disintegration_time(total)
        For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Code"))
            uniformity(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Uniformity")
            average_weight(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Average_Weight")
            average_weight_range(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Average_Weight_Range")
            product_name(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Name")
            description(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Description")
            shelf_life(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Shelf_Life")
            disintegration_time(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Disintegration_Time")
        Next
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add a Record")
                    If msg_box = MsgBoxResult.Yes Then
                        add_row = add_detail()
                        TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Add(add_row)
                        record = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
                        Call TABLET_MODULE.tablet_updatedatabase_detail()
                        Call display_statusbar(record)
                        MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                    End If
                Else
                    MsgBox("PLEASE ENTER BATCH_NO", MsgBoxStyle.Information, "Enter Batch No")
                    Me.txt_batch_no.Focus()
                End If
            Else
                MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
                Me.cmb_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Add Procedure of Tablet Detail
    Private Function add_detail() As DataRow
        Dim add_row As DataRow
        add_row = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").NewRow()
        add_row.Item("Tablet_Code") = Me.cmb_product_code.Text
        add_row.Item("Tablet_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            add_row.Item("Tablet_Sample_Quantity1") = "No Sample Quantity"
        Else
            add_row.Item("Tablet_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If
        If Me.txt_sample_quantity2.Text = "" Then
            add_row.Item("Tablet_Sample_Quantity2") = "No Sample Quantity"
        Else
            add_row.Item("Tablet_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If
        If Me.txt_ar_no.Text = "" Then
            add_row.Item("Tablet_A_R_No") = "No Number"
        Else
            add_row.Item("Tablet_A_R_No") = Me.txt_ar_no.Text
        End If
        If Me.txt_description.Text = "" Then
            add_row.Item("Tablet_Description") = "No Description"
        Else
            add_row.Item("Tablet_Description") = Me.txt_description.Text
        End If
        If Me.txt_average.Text = "" Then
            add_row.Item("Tablet_Average") = Val("0")
        Else
            add_row.Item("Tablet_Average") = Val(Me.txt_average.Text)
        End If
        If Me.txt_min_uniformity.Text = "" Then
            add_row.Item("Tablet_Min_Uniformity") = Val("0")
        Else
            add_row.Item("Tablet_Min_Uniformity") = Val(Me.txt_min_uniformity.Text)
        End If
        If Me.txt_max_uniformity.Text = "" Then
            add_row.Item("Tablet_Max_Uniformity") = Val("0")
        Else
            add_row.Item("Tablet_Max_Uniformity") = Val(Me.txt_max_uniformity.Text)
        End If
        If Me.txt_disintegration_time.Text = "" Then
            add_row.Item("Tablet_Disintegration_Time") = "No Time"
        Else
            add_row.Item("Tablet_Disintegration_Time") = Me.txt_disintegration_time.Text
        End If
        If Me.txt_min_dissolution.Text = "" Then
            add_row.Item("Tablet_Min_Dissolution") = Val("0")
        Else
            add_row.Item("Tablet_Min_Dissolution") = Val(Me.txt_min_dissolution.Text)
        End If
        If Me.txt_max_dissolution.Text = "" Then
            add_row.Item("Tablet_Max_Dissolution") = Val("0")
        Else
            add_row.Item("Tablet_Max_Dissolution") = Val(Me.txt_max_dissolution.Text)
        End If
        If Me.txt_sample_quantity1_unit.Text = "" Then
            add_row.Item("Tablet_Sample_Quantity1_Unit") = "No Unit"
        Else
            add_row.Item("Tablet_Sample_Quantity1_Unit") = Me.txt_sample_quantity1_unit.Text
        End If
        If Me.txt_sample_quantity2_unit.Text = "" Then
            add_row.Item("Tablet_Sample_Quantity2_Unit") = "No Unit"
        Else
            add_row.Item("Tablet_Sample_Quantity2_Unit") = Me.txt_sample_quantity2_unit.Text
        End If
        If Me.txt_specification_no.Text = "" Then
            add_row.Item("Tablet_Specification_No") = "No Number"
        Else
            add_row.Item("Tablet_Specification_No") = Me.txt_specification_no.Text
        End If
        If Me.txt_identification.Text = "" Then
            add_row.Item("Tablet_Identification") = "No Identification"
        Else
            add_row.Item("Tablet_Identification") = Me.txt_identification.Text
        End If
        add_row.Item("Tablet_Received_Date") = Me.dtp_received_date.Value
        add_row.Item("Tablet_Released_Date") = Me.dtp_released_date.Value
        add_row.Item("Tablet_Manufacturing_Date") = Me.dtp_mfg_date.Value
        add_row.Item("Tablet_Expiry_Date") = Me.dtp_exp_date.Value
        Return add_row
    End Function
    'This procedure displays the recordnumber and total record in the status bar
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        status_lbl_record_number.Text = CStr(pointer)
        status_lbl_total_record.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count)
    End Sub
    Private Sub txt_average_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Average")
        End If
    End Sub
    Private Sub txt_min_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity")
        End If
    End Sub
    Private Sub txt_max_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity")
        End If
    End Sub
    Private Sub txt_min_dissolution_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_dissolution.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Dissolution")
        End If
    End Sub
    Private Sub txt_max_dissolution_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_dissolution.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Dissoluton")
        End If
    End Sub
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD ?", MsgBoxStyle.YesNo, "Edit a Record")
                    If msg_box = MsgBoxResult.Yes Then
                        Call edit_detail()
                        MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                    End If
                Else
                    MsgBox("BATCH NO IS BLANK", MsgBoxStyle.Information, "Enter Batch No")
                    Me.txt_batch_no.Focus()
                End If
            Else
                MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
                Me.cmb_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Edit Procedure of Tablet Detail
    Private Sub edit_detail()
        TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Code") = Me.cmb_product_code.Text
        TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity1") = "No Sample Quantity"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If

        If Me.txt_sample_quantity2.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity2") = "No Sample Quantity"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If

        If Me.txt_ar_no.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_A_R_No") = "No Number"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_A_R_No") = Me.txt_ar_no.Text
        End If

        If Me.txt_description.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Description") = "No Description"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Description") = Me.txt_description.Text
        End If

        If Me.txt_average.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Average") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Average") = Val(Me.txt_average.Text)
        End If

        If Me.txt_min_uniformity.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Min_Uniformity") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Min_Uniformity") = Val(Me.txt_min_uniformity.Text)
        End If

        If Me.txt_max_uniformity.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Max_Uniformity") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Max_Uniformity") = Val(Me.txt_max_uniformity.Text)
        End If

        If Me.txt_disintegration_time.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Disintegration_Time") = "No Time"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Disintegration_Time") = Me.txt_disintegration_time.Text
        End If

        If Me.txt_min_dissolution.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Min_Dissolution") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Min_Dissolution") = Val(Me.txt_min_dissolution.Text)
        End If
        If Me.txt_max_dissolution.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Max_Dissolution") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Max_Dissolution") = Val(Me.txt_max_dissolution.Text)
        End If
        If Me.txt_identification.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Identification") = "No Identification"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Identification") = Me.txt_identification.Text
        End If
        If Me.txt_specification_no.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Specification_No") = "No Number"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Specification_No") = Me.txt_specification_no.Text
        End If
        If Me.txt_sample_quantity2_unit.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity2_Unit") = "No Unit"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity2_Unit") = Me.txt_sample_quantity2_unit.Text
        End If
        If Me.txt_sample_quantity1_unit.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity1_Unit") = "No Unit"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity1_Unit") = Me.txt_sample_quantity1_unit.Text
        End If
        TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Received_Date") = Me.dtp_received_date.Value
        TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Released_Date") = Me.dtp_released_date.Value
        TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Manufacturing_Date") = Me.dtp_mfg_date.Value
        TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Expiry_Date") = Me.dtp_exp_date.Value
        Call TABLET_MODULE.tablet_updatedatabase_detail()
    End Sub
    'This procedure displays the records
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            If Me.btn_identification_show.Text = "Show" Then
                Me.txt_identification.Visible = True
                Me.btn_identification_show.Text = "Hide"
            End If
            Me.cmb_product_code.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Code")
            Me.txt_description.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Description")
            Me.txt_batch_no.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Batch_No")
            Me.txt_sample_quantity1.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity1")
            Me.txt_sample_quantity2.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity2")
            Me.txt_ar_no.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_A_R_No")
            Me.txt_average.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Average"))
            Me.txt_disintegration_time.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Disintegration_Time")
            Me.txt_min_dissolution.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Min_Dissolution"))
            Me.txt_max_dissolution.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Max_Dissolution"))
            Me.txt_min_uniformity.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Min_Uniformity"))
            Me.txt_max_uniformity.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Max_Uniformity"))
            Me.txt_specification_no.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Specification_No")
            Me.txt_identification.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Identification")
            Me.txt_sample_quantity1_unit.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity1_Unit")
            Me.txt_sample_quantity2_unit.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Item("Tablet_Sample_Quantity1_Unit")
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count > 0 Then
            record = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count > 0 Then
            record = record + 1
            If record > TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Try
            Dim search_string As String, count As Integer, flag As Boolean
            search_string = InputBox("ENTER BATCH_NO", "SEARCH A RECORD", "NOSTRING")
            For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
                If search_string.ToUpper = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(count).Item("Tablet_Batch_No") Then
                    flag = True
                    record = count
                    Call display_records(record)
                    Call display_statusbar(record)
                    Exit For
                Else
                    flag = False
                End If
            Next
            If flag = False Then
                MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "No Records")

            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_delete.Click
        Dim count As Integer, flag As Boolean, msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
                        If Me.txt_batch_no.Text.ToUpper = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(count).Item("Tablet_Batch_No") Then
                            flag = True
                            Exit For
                        Else
                            flag = False
                        End If
                    Next
                    If flag = False Then
                        MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "No Records")
                    Else
                        msg_box = MsgBox("DELETING THIS RECORD WOULD DELETE ALL THE RELEVANT ENTRIES IN TABLET INGREDIENT, ARE YOU SURE YOU WANT TO DELETE IT ?", MsgBoxStyle.YesNo, "Delete a Record")
                        If msg_box = MsgBoxResult.Yes Then
                            TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(record).Delete()
                            Call TABLET_MODULE.tablet_updatedatabase_detail()
                            record = record - 1
                            Call display_statusbar(record)
                            Call display_records(record)
                        End If
                    End If
                Else
                    MsgBox("BATCH NO IS BLANK", MsgBoxStyle.Information, "Enter Batch No")
                    Me.txt_batch_no.Focus()
                End If
            Else
                MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
                Me.cmb_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'clear all the records in the form
    Private Sub clear_all()
        Me.cmb_product_code.Text = ""
        Me.lbl_product_name.Text = ""
        Me.txt_batch_no.Text = ""
        Me.txt_description.Enabled = False
        Me.txt_description.Text = ""
        Me.txt_min_dissolution.Text = ""
        Me.txt_max_dissolution.Text = ""
        Me.txt_sample_quantity2.Text = ""
        Me.txt_sample_quantity1.Text = ""
        Me.txt_min_uniformity.Text = ""
        Me.txt_max_uniformity.Text = ""
        Me.txt_average.Text = ""
        Me.txt_disintegration_time.Text = " "
        Me.txt_ar_no.Text = ""
        Me.txt_identification.Text = ""
        Me.txt_specification_no.Text = ""
        Me.txt_sample_quantity1_unit.Text = ""
        Me.txt_sample_quantity2_unit.Text = ""
        Me.dtp_mfg_date.Value = Me.dtp_mfg_date.MinDate
        Me.dtp_exp_date.Value = Me.dtp_exp_date.MinDate
        Me.dtp_received_date.Value = Me.dtp_received_date.MinDate
        Me.dtp_released_date.Value = Me.dtp_released_date.MinDate
        If Me.btn_identification_show.Text = "Hide" Then
            Me.txt_identification.Text = ""
            Me.txt_identification.Visible = False
            Me.btn_identification_show.Text = "Show"
        End If
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        tablet_detail_grid.Show()
        Me.Hide()
    End Sub
    Private Sub btn_description_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_description_edit.Click
        Me.txt_description.Enabled = True
        Me.txt_description.Focus()
    End Sub
    Private Sub txt_description_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_description.LostFocus
        Me.txt_description.Enabled = False
    End Sub
    Private Sub txt_sample_quantity1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sample_quantity1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND X ONLY", MsgBoxStyle.Information, "Sample Quantity")
        End If
    End Sub
    Private Sub txt_sample_quantity2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sample_quantity2.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND X ONLY", MsgBoxStyle.Information, "Sample Quantity")
        End If
    End Sub
    Private Sub btn_range_average_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_range_average.Click
        Dim cal, min, max As Double
        If Me.cmb_product_code.Text <> "" Then
            If average_weight(Me.cmb_product_code.SelectedIndex) <> 0 And average_weight_range(Me.cmb_product_code.SelectedIndex) <> 0 Then
                cal = (average_weight(Me.cmb_product_code.SelectedIndex) * (average_weight_range(Me.cmb_product_code.SelectedIndex))) / 100
                min = average_weight(Me.cmb_product_code.SelectedIndex) - cal
                max = average_weight(Me.cmb_product_code.SelectedIndex) + cal
                MsgBox("RANGE = " & CStr(min) & "to" & CStr(max), MsgBoxStyle.Information, "Average Weight Range")
            Else
                MsgBox("CHECK TABLET MASTER FOR THE ASSOCIATED VALUES", MsgBoxStyle.Information, "Average Weight")
            End If
        Else
            MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_identification_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_identification_show.Click
        If Me.btn_identification_show.Text = "Show" Then
            Me.txt_identification.Visible = True
            Me.btn_identification_show.Text = "Hide"
        Else
            Me.txt_identification.Visible = False
            Me.btn_identification_show.Text = "Show"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox(CStr(disintegration_time(Me.cmb_product_code.SelectedIndex)), MsgBoxStyle.Information, "Disintegration_Time")
    End Sub
    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
        frm_mdi.Show()
    End Sub
End Class
