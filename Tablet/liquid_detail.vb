Public Class liquid_detail
    Public min_uniformity() As Double
    Public max_uniformity() As Double
    Public average_volume() As Double
    Public product_name() As String
    Public min_ph() As Double
    Public max_ph() As Double
    Public min_weight() As Double
    Public max_weight() As Double
    Public description() As String
    Public shelf_life() As Integer
    Dim record As Integer
    Dim average As Double
    Private Sub txt_sample_quantity1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY AND 'X'", MsgBoxStyle.Information, "Sample Quantity")
        End If
    End Sub
    Private Sub txt_sample_quantity2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND 'X' ONLY", MsgBoxStyle.Information, "Sample Quantity")
        End If
    End Sub
    Private Sub liquid_detail_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call LIQUID_MODULE.liquid_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub liquid_detail__Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LIQUID_MODULE.liquid_open_connection()
        Call LIQUID_MODULE.liquid_filldataset_master()
        Call initialize_arrays()
        Call LIQUID_MODULE.liquid_filldataset_detail()
        conmenu_liquid_detail.Hide()
        Call display_statusbar(-1)
        Me.txt_identification.Visible = False
    End Sub
    Private Sub txt_ar_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ar_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "/") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND '/' ONLY", MsgBoxStyle.Information, "A.R.No")
        End If
    End Sub
    Private Sub txt_batch_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> " ") And (e.KeyChar < "A" Or e.KeyChar > "Z") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND UPPER CASE ALPHABETS ONLY", MsgBoxStyle.Information, "Batch No")
        End If
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
            Me.dtp_manufacturing_date.Value = Me.dtp_manufacturing_date.MinDate
            Me.dtp_expiry_date.Value = Me.dtp_expiry_date.MinDate
        End If
    End Sub
    Private Sub btn_description_edit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_description_edit.Click
        Me.txt_description.Enabled = True
        Me.txt_description.Focus()
    End Sub
    Private Sub txt_description_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_description.LostFocus
        Me.txt_description.Enabled = False
    End Sub
    Private Sub tlstr_btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_clear.Click
        Call clear_all()
        Call display_statusbar(-1)
    End Sub
    Private Sub btn_validate_released_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_released.Click
        If Me.cmb_product_code.Text <> "" Then
            If Me.dtp_released_date.Value < Me.dtp_received_date.Value Then
                MsgBox("RELEASE DATE CANNOT BE LESS THAN RECEIVED DATE", MsgBoxStyle.Information, "Released Date")
                Me.dtp_released_date.Focus()
            Else
                MsgBox("RELEASE DATE IS OK", MsgBoxStyle.Information, "Released Date")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_expiry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_expiry.Click
        Dim expiry_date As Date
        If Me.cmb_product_code.Text <> "" Then
            If shelf_life(Me.cmb_product_code.SelectedIndex) <> 0 Then
                expiry_date = DateAdd(DateInterval.Month, shelf_life(Me.cmb_product_code.SelectedIndex), Me.dtp_manufacturing_date.Value)
                Me.dtp_expiry_date.Value = expiry_date
                MsgBox("EXPIRY DATE HAS BEEN CHANGED", MsgBoxStyle.Information, "Expiry Date")
            Else
                MsgBox("CHECK TABLET MASTER FOR SHELF LIFE VALUE", MsgBoxStyle.Information, "Check Shelf Life")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        status_lbl_record_number.Text = CStr(pointer)
        status_lbl_total_record.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count)
    End Sub
    Private Sub txt_average_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Average")
        End If
    End Sub
    Private Sub txt_uniformity1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uniformity1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Volume")
        End If
    End Sub
    Private Sub txt_uniformity2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uniformity2.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Volume")
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count > 0 Then
            record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count > 0 Then
            record = record + 1
            If record > LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub clear_all()
        Me.cmb_product_code.Text = ""
        Me.lbl_product_name.Text = ""
        Me.txt_batch_no.Text = ""
        Me.txt_description.Enabled = False
        Me.txt_description.Text = ""
        Me.txt_weight.Text = ""
        Me.txt_sample_quantity1.Text = ""
        Me.txt_sample_quantity2.Text = ""
        Me.txt_uniformity1.Text = ""
        Me.txt_uniformity2.Text = ""
        Me.txt_average.Text = ""
        Me.txt_ph.Text = ""
        Me.txt_ar_no.Text = ""
        Me.dtp_manufacturing_date.Value = Me.dtp_manufacturing_date.MinDate
        Me.dtp_expiry_date.Value = Me.dtp_expiry_date.MinDate
        Me.dtp_received_date.Value = Me.dtp_received_date.MinDate
        Me.dtp_released_date.Value = Me.dtp_released_date.MinDate
        Me.txt_specification_no.Text = ""
        Me.txt_sample_quantity1_unit.Text = ""
        Me.txt_sample_quantity2_unit.Text = ""
        If Me.btn_identification_show.Text = "Hide" Then
            Me.txt_identification.Text = ""
            Me.txt_identification.Visible = False
            Me.btn_identification_show.Text = "Show"
        End If
    End Sub
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            If Me.btn_identification_show.Text = "Show" Then
                Me.txt_identification.Visible = True
                Me.btn_identification_show.Text = "Hide"
            End If
            Me.cmb_product_code.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Code")
            Me.txt_description.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Description")
            Me.txt_batch_no.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Batch_No")
            Me.txt_sample_quantity1.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity1")
            Me.txt_sample_quantity2.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity2")
            Me.txt_ar_no.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_A_R_No")
            Me.txt_average.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Average"))
            Me.txt_ph.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Ph"))
            Me.txt_weight.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Weight"))
            Me.txt_uniformity1.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Min_Uniformity"))
            Me.txt_uniformity2.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Max_Uniformity"))
            Me.dtp_received_date.Value = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Received_Date")
            Me.dtp_released_date.Value = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Released_Date")
            Me.dtp_manufacturing_date.Value = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Manufacturing_Date")
            Me.dtp_expiry_date.Value = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Expiry_Date")
            Me.txt_identification.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Identification")
            Me.txt_specification_no.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Specification_No")
            Me.txt_sample_quantity1_unit.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity1_Unit")
            Me.txt_sample_quantity2_unit.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity2_Unit")
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub initialize_arrays()
        Dim count As Integer, total As Integer
        total = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count
        ReDim min_uniformity(total)
        ReDim max_uniformity(total)
        ReDim average_volume(total)
        ReDim min_ph(total)
        ReDim max_ph(total)
        ReDim product_name(total)
        ReDim min_weight(total)
        ReDim max_weight(total)
        ReDim description(total)
        ReDim shelf_life(total)
        For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Code"))
            min_uniformity(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Min_Uniformity_Volume")
            max_uniformity(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Max_Uniformity_Volume")
            average_volume(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Average_Volume")
            min_ph(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Min_Ph")
            max_ph(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Max_Ph")
            product_name(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Name")
            description(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Description")
            shelf_life(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Shelf_Life")
            min_weight(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Min_Weight")
            max_weight(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Max_Weight")
        Next
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "ADD Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        add_row = add_detail()
                        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Add(add_row)
                        record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1
                        Call LIQUID_MODULE.liquid_updatedatabase_detail()
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
    Private Function add_detail() As DataRow
        Dim add_row As DataRow
        add_row = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").NewRow()
        add_row.Item("Liquid_Code") = Me.cmb_product_code.Text
        add_row.Item("Liquid_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            add_row.Item("Liquid_Sample_Quantity1") = "No Sample Quantity"
        Else
            add_row.Item("Liquid_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If
        If Me.txt_sample_quantity2.Text = "" Then
            add_row.Item("Liquid_Sample_Quantity2") = "No Sample Quantity"
        Else
            add_row.Item("Liquid_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If
        If Me.txt_sample_quantity1_unit.Text = "" Then
            add_row.Item("Liquid_Sample_Quantity1_Unit") = "No Sample Quantity"
        Else
            add_row.Item("Liquid_Sample_Quantity1_Unit") = Me.txt_sample_quantity1_unit.Text
        End If
        If Me.txt_sample_quantity2_unit.Text = "" Then
            add_row.Item("Liquid_Sample_Quantity2_Unit") = "No Sample Quantity"
        Else
            add_row.Item("Liquid_Sample_Quantity2_Unit") = Me.txt_sample_quantity2.Text
        End If
        If Me.txt_ar_no.Text = "" Then
            add_row.Item("Liquid_A_R_No") = "No Number"
        Else
            add_row.Item("Liquid_A_R_No") = Me.txt_ar_no.Text
        End If
        If Me.txt_description.Text = "" Then
            add_row.Item("Liquid_Description") = "No Description"
        Else
            add_row.Item("Liquid_Description") = Me.txt_description.Text
        End If
        If Me.txt_average.Text = "" Then
            add_row.Item("Liquid_Average") = Val("0")
        Else
            add_row.Item("Liquid_Average") = Val(Me.txt_average.Text)
        End If
        If Me.txt_uniformity1.Text = "" Then
            add_row.Item("Liquid_Min_Uniformity") = Val("0")
        Else
            add_row.Item("Liquid_Min_Uniformity") = Val(Me.txt_uniformity1.Text)
        End If
        If Me.txt_uniformity2.Text = "" Then
            add_row.Item("Liquid_Max_Uniformity") = Val("0")
        Else
            add_row.Item("Liquid_Max_Uniformity") = Val(Me.txt_uniformity2.Text)
        End If
        If Me.txt_ph.Text = "" Then
            add_row.Item("Liquid_Ph") = Val("0")
        Else
            add_row.Item("Liquid_Ph") = Val(Me.txt_ph.Text)
        End If
        If Me.txt_weight.Text = "" Then
            add_row.Item("Liquid_Weight") = Val("0")
        Else
            add_row.Item("Liquid_Weight") = Val(Me.txt_weight.Text)
        End If
        If Me.txt_identification.Text = "" Then
            add_row.Item("Liquid_Identification") = "No Number"
        Else
            add_row.Item("Liquid_Identification") = Val(Me.txt_identification.Text)
        End If
        If Me.txt_specification_no.Text = "" Then
            add_row.Item("Liquid_Specification_No") = "No Number"
        Else
            add_row.Item("Liquid_Specification_No") = Val(Me.txt_specification_no.Text)
        End If

        add_row.Item("Liquid_Received_Date") = Me.dtp_received_date.Value
        add_row.Item("Liquid_Released_Date") = Me.dtp_released_date.Value
        add_row.Item("Liquid_Manufacturing_Date") = Me.dtp_manufacturing_date.Value
        add_row.Item("Liquid_Expiry_Date") = Me.dtp_expiry_date.Value
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
    Private Sub edit_detail()
        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Code") = Me.cmb_product_code.Text
        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity1") = "No Sample Quantity"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If

        If Me.txt_sample_quantity2.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity2") = "No Sample Quantity"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If
        If Me.txt_sample_quantity1_unit.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity1_unit") = "No Sample Quantity"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity1_unit") = Me.txt_sample_quantity1_unit.Text
        End If

        If Me.txt_sample_quantity2_unit.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity2_unit") = "No Sample Quantity"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Sample_Quantity2_unit") = Me.txt_sample_quantity2_unit.Text
        End If
        If Me.txt_ar_no.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_A_R_No") = "No Number"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_A_R_No") = Me.txt_ar_no.Text
        End If

        If Me.txt_description.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Description") = "No Description"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Description") = Me.txt_description.Text
        End If
        If Me.txt_average.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Average") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Average") = Val(Me.txt_average.Text)
        End If

        If Me.txt_uniformity1.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Min_Uniformity") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Min_Uniformity") = Val(Me.txt_uniformity1.Text)
        End If

        If Me.txt_uniformity2.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Max_Uniformity") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Max_Uniformity") = Val(Me.txt_uniformity2.Text)
        End If

        If Me.txt_ph.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Ph") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Ph") = Val(Me.txt_ph.Text)
        End If

        If Me.txt_weight.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Weight") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Weight") = Val(Me.txt_weight.Text)
        End If
        If Me.txt_identification.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Identification") = "No Identification"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Identification") = Val(Me.txt_identification.Text)
        End If
        If Me.txt_specification_no.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Specification_No") = "No Number"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Specification_No") = Val(Me.txt_specification_no.Text)
        End If

        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Received_Date") = Me.dtp_received_date.Value
        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Released_Date") = Me.dtp_released_date.Value
        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Manufacturing_Date") = Me.dtp_manufacturing_date.Value
        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Item("Liquid_Expiry_Date") = Me.dtp_expiry_date.Value
        Call LIQUID_MODULE.liquid_updatedatabase_detail()
    End Sub
    Private Sub tlstr_btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_delete.Click
        Dim count As Integer, flag As Boolean, msg_box As Integer
        Try
            For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1
                If Me.txt_batch_no.Text.ToUpper = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(count).Item("Liquid_Batch_No") Then
                    flag = True
                    Exit For
                Else
                    flag = False
                End If
            Next
            If flag = False Then
                MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Incorrect Batch No")
            Else
                msg_box = MsgBox("DELETING THIS RECORD WOULD DELETE ALL THE RELEVANT ENTRIES IN TABLET INGREDIENT, ARE YOU SURE YOU WANT TO DELETE IT?", MsgBoxStyle.YesNo, "Delete Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(record).Delete()
                    Call LIQUID_MODULE.liquid_updatedatabase_detail()
                    record = record - 1
                    Call display_statusbar(record)
                    Call display_records(record)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Try
            Dim search_string As String, count As Integer, flag As Boolean
            search_string = InputBox("ENTER BATCH_NO", "SEARCH A RECORD", "NOSTRING")
            For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1
                If search_string.ToUpper = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(count).Item("Liquid_Batch_No") Then
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
                MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Incorrect Batch No")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        liquid_master_grid.Show()
    End Sub
    Private Sub btn_validate_average_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_average.Click
        If Me.txt_average.Text <> "" Then
            If average_volume(Me.cmb_product_code.SelectedIndex) <> 0 Then
                If Val(Me.txt_average.Text) >= Val(average_volume(Me.cmb_product_code.SelectedIndex)) Then
                    MsgBox("AVERAGE NET VOLUME IS CORRECT", MsgBoxStyle.Information, "Aerage Net Volume")
                    average = Val(Me.txt_average.Text)
                Else
                    MsgBox("AVERAGE NET VOLUME IS INCORRECT", MsgBoxStyle.Information, "Average Net Volume")
                    Me.txt_average.Focus()
                    average = Val("0")
                End If
            Else
                MsgBox("CHECK THE LIQUID MASTER FOR AVERAGE NET VOLUME", MsgBoxStyle.Information, "Average Net Volume")
                average = Val("0")
            End If
        Else
            MsgBox("AVERAGE NET VOLUME IS BLANK", MsgBoxStyle.Information, "Average Net Volume")
            Me.txt_average.Focus()
            average = Val("0")
        End If
    End Sub
    Private Sub btn_validate_ph_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_ph.Click
        If Me.txt_ph.Text <> "" Then
            If min_ph(Me.cmb_product_code.SelectedIndex) = 0 Or max_ph(Me.cmb_product_code.SelectedIndex) = 0 Then
                MsgBox("CHECK LIQUID MASTER FOR PH VALUES", MsgBoxStyle.Information, "PH")
            Else
                If Val(Me.txt_ph.Text) >= Val(min_ph(Me.cmb_product_code.SelectedIndex)) And Val(Me.txt_ph.Text) <= Val(max_ph(Me.cmb_product_code.SelectedIndex)) Then
                    MsgBox("PH IS CORRECT", MsgBoxStyle.Information, "PH")
                Else
                    MsgBox("PH IS INCORRECT", MsgBoxStyle.Information, "PH")
                    Me.txt_ph.Focus()
                End If
            End If
        Else
            MsgBox("PH IS BLANK", MsgBoxStyle.Information, "PH")
            Me.txt_ph.Focus()
        End If
    End Sub
    Private Sub btn_range_average_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_range_average.Click
        If Me.cmb_product_code.Text <> "" Then
            If average_volume(Me.cmb_product_code.SelectedIndex) <> 0 Then
                MsgBox("Average Volume=" & CStr(average_volume(Me.cmb_product_code.SelectedIndex)), MsgBoxStyle.Information, "Average Volume")
            Else
                MsgBox("CHECK THE MASTER FOR RELATED VALUES", MsgBoxStyle.Information, "Average Net Volume")
            End If
        Else
            MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_weight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_weight.Click
        If Me.cmb_product_code.Text <> "" Then
            If min_weight(Me.cmb_product_code.SelectedIndex) <> 0 And max_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                If Val(Me.txt_weight.Text) >= min_weight(Me.cmb_product_code.SelectedIndex) And Val(Me.txt_weight.Text) <= max_weight(Me.cmb_product_code.SelectedIndex) Then
                    MsgBox("Weight/ml IS CORRECT", MsgBoxStyle.Information, "Weight")
                Else
                    MsgBox("Weight/ml IS OUT OF RANGE", MsgBoxStyle.Information, "Weight")
                    Me.txt_weight.Focus()
                End If
            Else
                MsgBox("CHECK LIQUID MASTER FOR WEIGHT VALUES", MsgBoxStyle.Information, "Average Weight")
            End If
        Else
            MsgBox(" PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_range_pH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_range_pH.Click
        If Me.cmb_product_code.Text <> "" Then
            If min_ph(Me.cmb_product_code.SelectedIndex) = 0 Or max_ph(Me.cmb_product_code.SelectedIndex) = 0 Then
                MsgBox("CHECK LIQUID MASTER FOR PH VALUES", MsgBoxStyle.Information, "PH")
            Else
                MsgBox("PH RANGE IS" & CStr(min_ph(Me.cmb_product_code.SelectedIndex) & " TO " & CStr(max_ph(Me.cmb_product_code.SelectedIndex))), MsgBoxStyle.Information, "Range pH")
            End If
        Else
            MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_range_weight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_range_weight.Click
        If Me.cmb_product_code.Text <> "" Then
            If min_weight(Me.cmb_product_code.SelectedIndex) <> 0 And max_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                MsgBox("AVERAGE WEIGHT RANGE=" & CStr(min_weight(Me.cmb_product_code.SelectedIndex)) & "TO" & CStr(max_weight(Me.cmb_product_code.SelectedIndex)), MsgBoxStyle.Information, "Average Weight")
            Else
                MsgBox("CHECK LIQUID MASTER FOR AVERAGE WEIGHT VALUES", MsgBoxStyle.Information, "Average Weight")
            End If
        Else
            MsgBox(" PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_uniformity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_uniformity.Click
        If average <> 0 Then
            If Me.cmb_product_code.Text <> "" Then
                If min_uniformity(Me.cmb_product_code.SelectedIndex) <> 0 And max_uniformity(Me.cmb_product_code.SelectedIndex) <> 0 And Me.average_volume(Me.cmb_product_code.SelectedIndex) <> 0 Then
                    liquid_calculation.Show()
                    liquid_calculation.lb_amax_tb1.Text = CStr(average)
                    liquid_calculation.lb_amin_tb2.Text = CStr(average)
                    liquid_calculation.lbl_max_average_weight.Text = CStr(min_uniformity(Me.cmb_product_code.SelectedIndex))
                    liquid_calculation.lbl_max_averageweight_range.Text = CStr(max_uniformity(Me.cmb_product_code.SelectedIndex))
                    liquid_calculation.lbl_min_average_weight.Text = CStr(min_uniformity(Me.cmb_product_code.SelectedIndex))
                    liquid_calculation.lbl_min_averageweight_range.Text = CStr(max_uniformity(Me.cmb_product_code.SelectedIndex))
                Else
                    MsgBox("CHECK THE RELATED VALUES IN MASTER", MsgBoxStyle.Information, "Uniformity of Weight")
                End If
            Else
                MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
                Me.cmb_product_code.Focus()
            End If
        Else
            MsgBox("AVERAGE IS 0", MsgBoxStyle.Information, "Average")
        End If
    End Sub
End Class