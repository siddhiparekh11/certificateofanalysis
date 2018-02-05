Public Class cream_detail
    Public min_uniformity_weight() As Double
    Public max_uniformity_weight() As Double
    Public average_weight() As Double
    Public product_name() As String
    Public description() As String
    Public shelf_life() As Integer
    Dim record As Integer
    Private Sub cream_detail_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call CREAM_MODULE.cream_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub cmb_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_product_code.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txt_batch_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "-") And (e.KeyChar < "A" Or e.KeyChar > "Z") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Batch No")
        End If
    End Sub
    Private Sub txt_ar_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ar_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "/") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "A.R.No")
        End If
    End Sub
    Private Sub txt_sample_quantity_sale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sample_quantity1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND 'X' ONLY", MsgBoxStyle.Information, "Sample Quantity")
        End If
    End Sub
    Private Sub txt_sample_quantity_ps_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_sample_quantity2.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND 'X' ONLY", MsgBoxStyle.Information, "Sample Quantity")
        End If
    End Sub
    Private Sub txt_uniformity1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uniformity1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Weight")
        End If
    End Sub
    Private Sub txt_uniformity2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uniformity2.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Weight")
        End If
    End Sub
    Private Sub txt_average_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Average")
        End If
    End Sub
    Private Sub cream_detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CREAM_MODULE.cream_open_connection()
        Call CREAM_MODULE.cream_filldataset_master()
        Call initialize_arrays()
        Call CREAM_MODULE.cream_filldataset_detail()
        Me.conmenu_cream_detail.Hide()
        Call display_statusbar(-1)
        Me.txt_identification.Visible = False
    End Sub
    Private Sub cmb_product_code_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_product_code.SelectedIndexChanged
        Me.lbl_product_name.Text = product_name(Me.cmb_product_code.SelectedIndex)
        Me.txt_description.Text = description(Me.cmb_product_code.SelectedIndex)
        Me.txt_batch_no.Text = Me.cmb_product_code.Text & " "
    End Sub
    Private Sub initialize_arrays()
        Dim count As Integer, total As Integer
        total = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count
        ReDim min_uniformity_weight(total)
        ReDim max_uniformity_weight(total)
        ReDim average_weight(total)
        ReDim product_name(total)
        ReDim description(total)
        ReDim shelf_life(total)
        For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Code"))
            min_uniformity_weight(count) = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Min_Uniformity_Weight")
            max_uniformity_weight(count) = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Max_Uniformity_Weight")
            average_weight(count) = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Average_Weight")
            product_name(count) = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Name")
            description(count) = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Description")
            shelf_life(count) = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Shelf_Life")
        Next
    End Sub
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_record_number.Text = CStr(pointer)
        Me.status_lbl_total_record.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count)
    End Sub
    Private Sub cmb_product_code_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_product_code.TextChanged
        If Me.cmb_product_code.Text = "" Then
            Me.lbl_product_name.Text = ""
            Me.txt_description.Text = ""
            Me.txt_batch_no.Text = ""
            Me.dtp_manufacturing_date.Value = Me.dtp_manufacturing_date.MinDate
            Me.dtp_expiry_date.Value = Me.dtp_expiry_date.MinDate
        End If
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        add_row = add_detail()
                        CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Add(add_row)
                        record = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
                        Call CREAM_MODULE.cream_updatedatabase_detail()
                        Call display_statusbar(record)
                        MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                    End If
                Else
                    MsgBox("PLEASE ENTER BATCH NO", MsgBoxStyle.Information, "Enter Batch No")
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
    Private Function add_detail() As DataRow
        Dim add_row As DataRow
        add_row = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").NewRow()
        add_row.Item("Cream_Code") = Me.cmb_product_code.Text
        add_row.Item("Cream_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            add_row.Item("Cream_Sample_Quantity1") = "No Sample"
        Else
            add_row.Item("Cream_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If
        If Me.txt_sample_quantity2.Text = "" Then
            add_row.Item("Cream_Sample_Quantity2") = "No Sample"
        Else
            add_row.Item("Cream_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If
        If Me.txt_sample_quantity1_unit.Text = "" Then
            add_row.Item("Cream_Sample_Quantity1_Unit") = "No Unit"
        Else
            add_row.Item("Cream_Sample_Quantity1_Unit") = Me.txt_sample_quantity1_unit.Text
        End If
        If Me.txt_sample_quantity2_unit.Text = "" Then
            add_row.Item("Cream_Sample_Quantity2_Unit") = "No Unit"
        Else
            add_row.Item("Cream_Sample_Quantity2_Unit") = Me.txt_sample_quantity2_unit.Text
        End If
        If Me.txt_ar_no.Text = "" Then
            add_row.Item("Cream_A_R_No") = "No Number"
        Else
            add_row.Item("Cream_A_R_No") = Me.txt_ar_no.Text
        End If
        If Me.txt_description.Text = "" Then
            add_row.Item("Cream_Description") = "No Description"
        Else
            add_row.Item("Cream_Description") = Me.txt_description.Text
        End If
        If Me.txt_average.Text = "" Then
            add_row.Item("Cream_Average_Weight") = Val("0")
        Else
            add_row.Item("Cream_Average_Weight") = Val(Me.txt_average.Text)
        End If
        If Me.txt_uniformity1.Text = "" Then
            add_row.Item("Cream_Min_Uniformity_Weight") = Val("0")
        Else
            add_row.Item("Cream_Min_Uniformity_Weight") = Val(Me.txt_uniformity1.Text)
        End If
        If Me.txt_uniformity2.Text = "" Then
            add_row.Item("Cream_Max_Uniformity_Weight") = Val("0")
        Else
            add_row.Item("Cream_Max_Uniformity_Weight") = Val(Me.txt_uniformity2.Text)
        End If
        If Me.txt_identification.Text = "" Then
            add_row.Item("Cream_Identification") = "No Identification"
        Else
            add_row.Item("Cream_Identification") = Me.txt_identification.Text
        End If
        If Me.txt_specification_no.Text = "" Then
            add_row.Item("Cream_Specifcation_No") = "No Number"
        Else
            add_row.Item("Cream_Specification_No") = Me.txt_specification_no.Text
        End If
        add_row.Item("Cream_Received_Date") = Me.dtp_received_date.Value
        add_row.Item("Cream_Released_Date") = Me.dtp_released_date.Value
        add_row.Item("Cream_Manufacturing_Date") = Me.dtp_manufacturing_date.Value
        add_row.Item("Cream_Expiry_Date") = Me.dtp_expiry_date.Value
        Return add_row
    End Function
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD ?", MsgBoxStyle.YesNo, "Edit Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        Call edit_detail()
                        MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                    End If
                Else
                    MsgBox("BATCH NO IS BLANK", MsgBoxStyle.Information, "Enter Batch No.")
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
    Private Sub edit_detail()
        CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Code") = Me.cmb_product_code.Text
        CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity1") = "No Sample"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If

        If Me.txt_sample_quantity2.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity2") = "No Sample"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If

        If Me.txt_sample_quantity1_unit.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity1_Unit") = "No Unit"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity1_Unit") = Me.txt_sample_quantity1_unit.Text
        End If

        If Me.txt_sample_quantity2_unit.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity2_Unit") = "No Sample"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity2_Unit") = Me.txt_sample_quantity2_unit.Text
        End If

        If Me.txt_ar_no.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_A_R_No") = "No Number"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_A_R_No") = Me.txt_ar_no.Text
        End If

        If Me.txt_description.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Description") = "No Description"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Description") = Me.txt_description.Text
        End If

        If Me.txt_average.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Average_Weight") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Average_Weight") = Val(Me.txt_average.Text)
        End If

        If Me.txt_uniformity1.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Min_Uniformity_Weight") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Min_Uniformity_Weight") = Val(Me.txt_uniformity1.Text)
        End If

        If Me.txt_uniformity2.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Max_Uniformity_Weight") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Max_Uniformity_Weight") = Val(Me.txt_uniformity2.Text)
        End If
        If Me.txt_identification.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Identification") = "No Identification"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Identification") = Me.txt_identification.Text
        End If
        If Me.txt_specification_no.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Specification_No") = "No Number"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Specification_No") = Me.txt_specification_no.Text
        End If
        CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Received_Date") = Me.dtp_received_date.Value
        CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Released_Date") = Me.dtp_released_date.Value
        CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Manufacturing_Date") = Me.dtp_manufacturing_date.Value
        CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Expiry_Date") = Me.dtp_expiry_date.Value
        Call CREAM_MODULE.cream_updatedatabase_detail()
    End Sub
    Private Sub tlstr_btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_delete.Click
        Try
            Dim count As Integer, flag As Boolean, msg_box As Integer
            For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
                If Me.txt_batch_no.Text.ToUpper = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(count).Item("Cream_Batch_No") Then
                    flag = True
                    Exit For
                Else
                    flag = False
                End If
            Next
            If flag = False Then
                MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Enter Correct Batch No.")
            Else
                msg_box = MsgBox("DELETING THIS RECORD WOULD DELETE ALL THE RELEVANT ENTRIES IN TABLET INGREDIENT, ARE YOU SURE YOU WANT TO DELETE IT?", MsgBoxStyle.YesNo, "Delete Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Delete()
                    Call CREAM_MODULE.cream_updatedatabase_detail()
                    record = record - 1
                    Call display_statusbar(record)
                    Call display_records(record)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            If Me.btn_identification_show.Text = "Show" Then
                Me.txt_identification.Visible = True
                Me.btn_identification_show.Text = "Hide"
            End If
            Me.cmb_product_code.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Code")
            Me.txt_description.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Description")
            Me.txt_batch_no.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Batch_No")
            Me.txt_sample_quantity1.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity1")
            Me.txt_sample_quantity1_unit.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity1_Unit")
            Me.txt_sample_quantity2.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity2")
            Me.txt_sample_quantity2_unit.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Sample_Quantity2_Unit")
            Me.txt_ar_no.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_A_R_No")
            Me.txt_average.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Average_Weight"))
            Me.txt_uniformity1.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Min_Uniformity_Weight"))
            Me.txt_uniformity2.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Max_Uniformity_Weight"))
            Me.dtp_received_date.Value = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Received_Date")
            Me.dtp_released_date.Value = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Released_Date")
            Me.dtp_manufacturing_date.Value = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Manufacturing_Date")
            Me.dtp_expiry_date.Value = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Expiry_Date")
            Me.txt_identification.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Identification")
            Me.txt_specification_no.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(record).Item("Cream_Specification_No")
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub clear_all()
        Me.cmb_product_code.Text = ""
        Me.lbl_product_name.Text = ""
        Me.txt_batch_no.Text = ""
        Me.txt_description.Enabled = False
        Me.txt_description.Text = ""
        Me.txt_sample_quantity1.Text = ""
        Me.txt_sample_quantity1_unit.Text = ""
        Me.txt_sample_quantity2.Text = ""
        Me.txt_sample_quantity2_unit.Text = ""
        Me.txt_uniformity1.Text = ""
        Me.txt_uniformity2.Text = ""
        Me.txt_average.Text = ""
        Me.txt_ar_no.Text = ""
        Me.dtp_manufacturing_date.Value = Me.dtp_manufacturing_date.MinDate
        Me.dtp_expiry_date.Value = Me.dtp_expiry_date.MinDate
        Me.dtp_received_date.Value = Me.dtp_received_date.MinDate
        Me.dtp_released_date.Value = Me.dtp_released_date.MinDate
        If Me.btn_identification_show.Text = "Hide" Then
            Me.txt_identification.Text = ""
            Me.txt_identification.Visible = False
            Me.btn_identification_show.Text = "Show"
        End If
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Try
            Dim search_string As String, count As Integer, flag As Boolean
            search_string = InputBox("ENTER BATCH_NO", "SEARCH A RECORD", "NOSTRING")
            For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
                If search_string.ToUpper = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(count).Item("Cream_Batch_No") Then
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
                MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Enter Correct Batch No.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
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
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count > 0 Then
            record = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count > 0 Then
            record = record + 1
            If record > CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub tlstr_btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_clear.Click
        Call clear_all()
        Call display_statusbar(-1)
    End Sub
    Private Sub btn_description_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_description_edit.Click
        Me.txt_description.Enabled = True
        Me.txt_description.Focus()
    End Sub
    Private Sub txt_description_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_description.LostFocus
        Me.txt_description.Enabled = False
    End Sub
    Private Sub btn_validate_released_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_released.Click
        If Me.cmb_product_code.Text <> "" Then
            If Me.dtp_released_date.Value < Me.dtp_received_date.Value Then
                MsgBox("RELEASED DATE CANNOT BE LESS THAN RECEIVED DATE", MsgBoxStyle.Information, "Released Date Check")
                Me.dtp_released_date.Focus()
            Else
                MsgBox("RELEASED DATE IS OK", MsgBoxStyle.Information, "Released Date Check")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_expiry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_expiry.Click
        Dim expiry_date As Date
        If Me.cmb_product_code.Text <> "" Then
            If shelf_life(Me.cmb_product_code.SelectedIndex) <> 0 Then
                expiry_date = DateAdd(DateInterval.Month, shelf_life(Me.cmb_product_code.SelectedIndex), Me.dtp_manufacturing_date.Value)
                Me.dtp_expiry_date.Value = expiry_date
                MsgBox("EXPIRY DATE HAS BEEN CHANGED", MsgBoxStyle.Information, "Expiry Date Check")
            Else
                MsgBox("CHECK TABLET MASTER FOR SHELF LIFE VALUE", MsgBoxStyle.Information, "Expiry Date Check")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_average_range_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_average_range.Click
        If Me.cmb_product_code.Text <> "" Then
            If average_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                MsgBox("AVERAGE-WEIGHT" & CStr(average_weight(Me.cmb_product_code.SelectedIndex)), MsgBoxStyle.Information, "Average Weight")
            Else
                MsgBox("CHECK THE RELEVANT ENTRIES IN THE MASTER TABLE", MsgBoxStyle.Information, "Average Weight")
            End If
        Else
            MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_average_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_average.Click
        If Me.txt_average.Text <> "" Then
            If average_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                If Val(average_weight(Me.cmb_product_code.SelectedIndex)) < Val(Me.txt_average.Text) Then
                    MsgBox("AVERAGE WEIGHT IS CORRECT", MsgBoxStyle.Information, "Average Net Weight Of The Content")
                Else
                    MsgBox("AVERAGE WEIGHT IS INCORRECT", MsgBoxStyle.Information, "Average Net Weight Of The Content")
                End If
            Else
                MsgBox("CHECK POWDER MASTER FOR THE CORRESPONDING FIELD", MsgBoxStyle.Information, "Average Net Weight Of The Content")
            End If
        Else
            MsgBox("AVERAGE NET WEIGHT OF THE CONTENT IS BLANK", MsgBoxStyle.Information, "Enter Average Net Weight Of The Content")
            Me.txt_average.Focus()
        End If
    End Sub
    Private Sub btn_validate_uniformity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_uniformity.Click
        If Me.cmb_product_code.Text <> "" Then
            If min_uniformity_weight(Me.cmb_product_code.SelectedIndex) <> 0 And max_uniformity_weight(Me.cmb_product_code.SelectedIndex) <> 0 And Me.average_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                cream_calculation.Show()
                cream_calculation.lb_amax_tb1.Text = CStr(average_weight(Me.cmb_product_code.SelectedIndex))
                cream_calculation.lb_amin_tb2.Text = CStr(average_weight(Me.cmb_product_code.SelectedIndex))
                cream_calculation.lbl_max_average_weight.Text = CStr(min_uniformity_weight(Me.cmb_product_code.SelectedIndex))
                cream_calculation.lbl_max_averageweight_range.Text = CStr(max_uniformity_weight(Me.cmb_product_code.SelectedIndex))
                cream_calculation.lbl_min_average_weight.Text = CStr(min_uniformity_weight(Me.cmb_product_code.SelectedIndex))
                cream_calculation.lbl_min_averageweight_range.Text = CStr(max_uniformity_weight(Me.cmb_product_code.SelectedIndex))
            Else
                MsgBox("CHECK THE RELATED VALUES IN MASTER", MsgBoxStyle.Information, "Uniformity of Weight")
            End If
        Else
            MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        cream_detail_grid.Show()
        Me.Hide()
    End Sub
End Class