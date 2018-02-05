Public Class powder_detail
    Public min_uniformity() As Double
    Public max_uniformity() As Double
    Public average_weight() As Double
    Public product_name() As String
    Public fine_ness() As Double
    Public bulk_density() As Double
    Public bulk_density_range() As Double
    Public description() As String
    Public shelf_life() As Integer
    Dim record As Integer
    Private Sub txt_sample_quantity_ps_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND 'X' ONLY", MsgBoxStyle.Information, "SAMPLE_QUANTITY_PS")
        End If
    End Sub
    Private Sub txt_sample_quantity_sale_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "X") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND 'X' ONLY", MsgBoxStyle.Information, "SAMPLE_QUANTITY_SALE")
        End If
    End Sub
    Private Sub POWDER_detail__Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call POWDER_MODULE.POWDER_open_connection()
        Call POWDER_MODULE.POWDER_filldataset_master()
        Call initialize_arrays()
        Call POWDER_MODULE.POWDER_filldataset_detail()
        Me.conmenu_powder_detail.Hide()
        Call display_statusbar(-1)
        Me.txt_identification.Visible = False
    End Sub
    Private Sub txt_ar_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ar_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "/") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "CHECK A.R.NO")
        End If
    End Sub
    Private Sub txt_batch_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "-") And (e.KeyChar < "A" Or e.KeyChar > "Z") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "CHECK BATCH_NO")
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
    Private Sub btn_release_dt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_released.Click
        If Me.cmb_product_code.Text <> "" Then
            If Me.dtp_released_date.Value < Me.dtp_received_date.Value Then
                MsgBox("RELEASE DATE CANNOT BE LESS THAN RECEIVED DATE", MsgBoxStyle.Information, "RELEASE DATE CHECK")
                Me.dtp_released_date.Focus()
            Else
                MsgBox("RELEASE DATE IS OK", MsgBoxStyle.Information, "RELEASE DATE CHECK")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "RELEASED DATE CHECK")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub btn_validate_expiry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_expiry.Click
        Dim expiry_date As Date
        If Me.cmb_product_code.Text <> "" Then
            If shelf_life(Me.cmb_product_code.SelectedIndex) <> 0 Then
                expiry_date = DateAdd(DateInterval.Month, shelf_life(Me.cmb_product_code.SelectedIndex), Me.dtp_manufacturing_date.Value)
                Me.dtp_expiry_date.Value = expiry_date
                MsgBox("EXPIRY DATE HAS BEEN CHANGED", MsgBoxStyle.Information, "EXPIRY DATE CHECK")
            Else
                MsgBox("CHECK TABLET MASTER FOR SHELF LIFE VALUE", MsgBoxStyle.Information, "EXPIRY DATE CHECK")
            End If
        Else
            MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "EXPIRY DATE")
            Me.cmb_product_code.Focus()
        End If
    End Sub
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_record_number.Text = CStr(pointer)
        Me.status_lbl_total_record.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows.Count)
    End Sub
    Private Sub txt_average_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "AVERAGE")
        End If
    End Sub
    Private Sub txt_uniformity1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uniformity1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "UNIFORMITY1")
        End If
    End Sub
    Private Sub txt_uniformity2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uniformity2.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "UNIFORMITY2")
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count > 0 Then
            record = POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count > 0 Then
            record = record + 1
            If record > POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub clear_all()
        Me.cmb_product_code.Text = ""
        Me.lbl_product_name.Text = ""
        Me.txt_batch_no.Text = ""
        Me.txt_description.Enabled = False
        Me.txt_description.Text = ""
        Me.txt_bulk_density.Text = ""
        Me.txt_sample_quantity1.Text = ""
        Me.txt_sample_quantity1_unit.Text = ""
        Me.txt_sample_quantity2.Text = ""
        Me.txt_sample_quantity2_unit.Text = ""
        Me.txt_uniformity1.Text = ""
        Me.txt_uniformity2.Text = ""
        Me.txt_average.Text = ""
        Me.txt_fine_ness.Text = ""
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
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            If Me.btn_identification_show.Text = "Show" Then
                Me.txt_identification.Visible = True
                Me.btn_identification_show.Text = "Hide"
            End If
            Me.cmb_product_code.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Code")
            Me.txt_description.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Description")
            Me.txt_batch_no.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Batch_No")
            Me.txt_sample_quantity1.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity1")
            Me.txt_sample_quantity1_unit.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity1_Unit")
            Me.txt_sample_quantity2.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity2")
            Me.txt_sample_quantity2_unit.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity2_Unit")
            Me.txt_ar_no.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_A_R_No")
            Me.txt_average.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Average_Weight"))
            Me.txt_fine_ness.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Fine_ness"))
            Me.txt_bulk_density.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Bulk_density"))
            Me.txt_uniformity1.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Min_Uniformity_Weight"))
            Me.txt_uniformity2.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Max_Uniformity_Weight"))
            Me.dtp_received_date.Value = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Received_Date")
            Me.dtp_released_date.Value = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Released_Date")
            Me.dtp_manufacturing_date.Value = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Manufacturing_Date")
            Me.dtp_expiry_date.Value = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Expiry_Date")
            Me.txt_identification.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Identification")
            Me.txt_specification_no.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Specification_No")
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub initialize_arrays()
        Dim count As Integer, total As Integer
        total = POWDER_MODULE.POWDER_dataset.Tables("POWDER_MASTER").Rows.Count
        ReDim min_uniformity(total)
        ReDim max_uniformity(total)
        ReDim average_weight(total)
        ReDim fine_ness(total)
        ReDim bulk_density(total)
        ReDim bulk_density_range(total)
        ReDim product_name(total)
        ReDim description(total)
        ReDim shelf_life(total)
        For count = 0 To POWDER_MODULE.POWDER_dataset.Tables("POWDER_MASTER").Rows.Count - 1
            Me.cmb_product_code.Items.Add(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Code"))
            min_uniformity(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Min_Uniformity_Weight")
            max_uniformity(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Max_Uniformity_Weight")
            average_weight(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Average_Weight")
            fine_ness(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Fine_ness")
            product_name(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Name")
            description(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Description")
            shelf_life(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Shelf_Life")
            bulk_density(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Min_Bulk_density")
            bulk_density_range(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Max_Bulk_density")
        Next
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "ADD A RECORD")
                    If msg_box = MsgBoxResult.Yes Then
                        add_row = add_detail()
                        POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Add(add_row)
                        record = POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count - 1
                        Call POWDER_MODULE.POWDER_updatedatabase_detail()
                        Call display_statusbar(record)
                        MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "ADD A RECORD")
                    End If
                Else
                    MsgBox("PLEASE ENTER BATCH_NO", MsgBoxStyle.Information, "ADD A RECORD")
                    Me.txt_batch_no.Focus()
                End If
            Else
                MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "ADD A RECORD")
                Me.cmb_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Function add_detail() As DataRow
        Dim add_row As DataRow
        add_row = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").NewRow()
        add_row.Item("Powder_Code") = Me.cmb_product_code.Text
        add_row.Item("Powder_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            add_row.Item("Powder_Sample_Quantity1") = "No Sample"
        Else
            add_row.Item("Powder_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If
        If Me.txt_sample_quantity2.Text = "" Then
            add_row.Item("Powder_Sample_Quantity2") = "No Sample"
        Else
            add_row.Item("Powder_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If
        If Me.txt_sample_quantity1_unit.Text = "" Then
            add_row.Item("Powder_Sample_Quantity1_Unit") = "No Unit"
        Else
            add_row.Item("Powder_Sample_Quantity1_Unit") = Me.txt_sample_quantity1_unit.Text
        End If
        If Me.txt_sample_quantity2_unit.Text = "" Then
            add_row.Item("Powder_Sample_Quantity2_Unit") = "No Unit"
        Else
            add_row.Item("Powder_Sample_Quantity2_Unit") = Me.txt_sample_quantity2_unit.Text
        End If
        If Me.txt_ar_no.Text = "" Then
            add_row.Item("Powder_A_R_No") = "No Number"
        Else
            add_row.Item("Powder_A_R_No") = Me.txt_ar_no.Text
        End If
        If Me.txt_description.Text = "" Then
            add_row.Item("Powder_Description") = "No Description"
        Else
            add_row.Item("Powder_Description") = Me.txt_description.Text
        End If
        If Me.txt_average.Text = "" Then
            add_row.Item("Powder_Average_Weight") = Val("0")
        Else
            add_row.Item("Powder_Average_Weight") = Val(Me.txt_average.Text)
        End If
        If Me.txt_uniformity1.Text = "" Then
            add_row.Item("Powder_Min_Uniformity_Weight") = Val("0")
        Else
            add_row.Item("Powder_Min_Uniformity_Weight") = Val(Me.txt_uniformity1.Text)
        End If
        If Me.txt_uniformity2.Text = "" Then
            add_row.Item("Powder_Max_Uniformity_Weight") = Val("0")
        Else
            add_row.Item("Powder_Max_Uniformity_Weight") = Val(Me.txt_uniformity2.Text)
        End If
        If Me.txt_fine_ness.Text = "" Then
            add_row.Item("Powder_Fine_Ness") = Val("0")
        Else
            add_row.Item("Powder_Fine_Ness") = Val(Me.txt_fine_ness.Text)
        End If
        If Me.txt_bulk_density.Text = "" Then
            add_row.Item("Powder_Bulk_Density") = Val("0")
        Else
            add_row.Item("Powder_Bulk_Density") = Val(Me.txt_bulk_density.Text)
        End If
        If Me.txt_identification.Text = "" Then
            add_row.Item("Powder_Identification") = "No Identification"
        Else
            add_row.Item("Powder_Identification") = Me.txt_identification.Text
        End If
        If Me.txt_specification_no.Text = "" Then
            add_row.Item("Powder_Specifcation_No") = "No Number"
        Else
            add_row.Item("Powder_Specification_No") = Me.txt_specification_no.Text
        End If
        add_row.Item("Powder_Received_Date") = Me.dtp_received_date.Value
        add_row.Item("Powder_Released_Date") = Me.dtp_released_date.Value
        add_row.Item("Powder_Manufacturing_Date") = Me.dtp_manufacturing_date.Value
        add_row.Item("Powder_Expiry_Date") = Me.dtp_expiry_date.Value
        Return add_row
    End Function
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.cmb_product_code.Text <> "" Then
                If Me.txt_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD", MsgBoxStyle.YesNo, "EDIT A RECORD")
                    If msg_box = MsgBoxResult.Yes Then
                        Call edit_detail()
                        MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "EDIT A RECORD")
                    End If
                Else
                    MsgBox("BATCH NO IS BLANK", MsgBoxStyle.Information, "EDIT A RECORD")
                    Me.txt_batch_no.Focus()
                End If
            Else
                MsgBox("PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "EDIT A RECORD")
                Me.cmb_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub edit_detail()
        POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Code") = Me.cmb_product_code.Text
        POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Batch_No") = Me.txt_batch_no.Text
        If Me.txt_sample_quantity1.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity1") = "No Sample"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity1") = Me.txt_sample_quantity1.Text
        End If

        If Me.txt_sample_quantity2.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity2") = "No Sample"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity2") = Me.txt_sample_quantity2.Text
        End If

        If Me.txt_sample_quantity1_unit.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity1_Unit") = "No Unit"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity1_Unit") = Me.txt_sample_quantity1_unit.Text
        End If

        If Me.txt_sample_quantity2_unit.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity2_Unit") = "No Sample"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Sample_Quantity2_Unit") = Me.txt_sample_quantity2_unit.Text
        End If

        If Me.txt_ar_no.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_A_R_No") = "No Number"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_A_R_No") = Me.txt_ar_no.Text
        End If

        If Me.txt_description.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Description") = "No Description"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Description") = Me.txt_description.Text
        End If

        If Me.txt_average.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Average_Weight") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Average_Weight") = Val(Me.txt_average.Text)
        End If

        If Me.txt_uniformity1.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Min_Uniformity_Weight") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Min_Uniformity_Weight") = Val(Me.txt_uniformity1.Text)
        End If

        If Me.txt_uniformity2.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Max_Uniformity_Weight") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Max_Uniformity_Weight") = Val(Me.txt_uniformity2.Text)
        End If

        If Me.txt_fine_ness.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Fine_ness") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Fine_ness") = Val(Me.txt_fine_ness.Text)
        End If

        If Me.txt_bulk_density.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Bulk_density") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Bulk_density") = Val(Me.txt_bulk_density.Text)
        End If
        If Me.txt_identification.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Identification") = "No Identification"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Identification") = Me.txt_identification.Text
        End If
        If Me.txt_specification_no.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Specification_No") = "No Number"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Specification_No") = Me.txt_specification_no.Text
        End If
        POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Received_Date") = Me.dtp_received_date.Value
        POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Released_Date") = Me.dtp_released_date.Value
        POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Manufacturing_Date") = Me.dtp_manufacturing_date.Value
        POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Item("Powder_Expiry_Date") = Me.dtp_expiry_date.Value
        Call POWDER_MODULE.powder_updatedatabase_detail()
    End Sub
    Private Sub tlstr_btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_delete.Click
        Try
            Dim count As Integer, flag As Boolean, msg_box As Integer
            For count = 0 To POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows.Count - 1
                If Me.txt_batch_no.Text.ToUpper = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(count).Item("Powder_Batch_No") Then
                    flag = True
                    Exit For
                Else
                    flag = False
                End If
            Next
            If flag = False Then
                MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "SEARCH A RECORD")
            Else
                msg_box = MsgBox("DELETING THIS RECORD WOULD DELETE ALL THE RELEVANT ENTRIES IN TABLET INGREDIENT, ARE YOU SURE YOU WANT TO DELETE IT?", MsgBoxStyle.YesNo, "DELETE A RECORD")
                If msg_box = MsgBoxResult.Yes Then
                    POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(record).Delete()
                    Call POWDER_MODULE.powder_updatedatabase_detail()
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
            For count = 0 To POWDER_MODULE.POWDER_dataset.Tables("POWDER_DETAIL").Rows.Count - 1
                If search_string.ToUpper = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(count).Item("Powder_Batch_No") Then
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
                MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "SEARCH A RECORD")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
    End Sub

    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        powder_detail_grid.Show()
        Me.Hide()
    End Sub

    Private Sub btn_validate_uniformity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_uniformity.Click
        If Me.cmb_product_code.Text <> "" Then
            If min_uniformity(Me.cmb_product_code.SelectedIndex) <> 0 And max_uniformity(Me.cmb_product_code.SelectedIndex) <> 0 And Me.average_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                powder_calculation.Show()
                powder_calculation.lb_amax_tb1.Text = CStr(average_weight(Me.cmb_product_code.SelectedIndex))
                powder_calculation.lb_amin_tb2.Text = CStr(average_weight(Me.cmb_product_code.SelectedIndex))
                powder_calculation.lbl_max_average_weight.Text = CStr(min_uniformity(Me.cmb_product_code.SelectedIndex))
                powder_calculation.lbl_max_averageweight_range.Text = CStr(max_uniformity(Me.cmb_product_code.SelectedIndex))
                powder_calculation.lbl_min_average_weight.Text = CStr(min_uniformity(Me.cmb_product_code.SelectedIndex))
                powder_calculation.lbl_min_averageweight_range.Text = CStr(max_uniformity(Me.cmb_product_code.SelectedIndex))
            Else
                MsgBox("CHECK THE RELATED VALUES IN MASTER", MsgBoxStyle.Information, "Uniformity of Weight")
            End If
        Else
            MsgBox("Enter Product Code", MsgBoxStyle.Information, "Product Code")
            Me.cmb_product_code.Focus()
        End If
    End Sub

    Private Sub btn_validate_average_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_average.Click
        If Me.txt_average.Text <> "" Then
            If average_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                If Val(average_weight(Me.cmb_product_code.SelectedIndex)) < Val(Me.txt_average.Text) Then
                    MsgBox("AVERAGE WEIGHT IS CORRECT", MsgBoxStyle.Information, "AVERAGE NET WEIGHT OF CONTENT")
                Else
                    MsgBox("AVERAGE WEIGHT IS INCORRECT", MsgBoxStyle.Information, "AVERAGE NET WEIGHT OF CONTENT")
                End If
            Else
                MsgBox("CHECK POWDER MASTER FOR THE CORRESPONDING FIELD", MsgBoxStyle.Information, "AVERAGE NET WEIGHT OF CONTENT")
            End If

        Else
            MsgBox("AVERAGE NET WEIGHT OF THE CONTENT IS BLANK", MsgBoxStyle.Information, "AVERAGE NET WEIGHT OF CONTENT")
            Me.txt_average.Focus()
        End If
    End Sub

    Private Sub btn_validate_fine_ness_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_fine_ness.Click
        If Me.txt_fine_ness.Text <> "" Then
            If fine_ness(Me.cmb_product_code.SelectedIndex) <> 0 Then
                If Val(fine_ness(Me.cmb_product_code.SelectedIndex)) < Val(Me.txt_fine_ness.Text) Then
                    MsgBox("FINE-NESS IS CORRECT", MsgBoxStyle.Information, "FINE-NESS")
                Else
                    MsgBox("FINE-NESS IS INCORRECT", MsgBoxStyle.Information, "FINE-NESS")
                End If
            Else
                MsgBox("CHECK POWDER MASTER FOR THE CORRESPONDING FIELD", MsgBoxStyle.Information, "FINE_NESS")
            End If

        Else
            MsgBox("FINE-NESS OF THE POWDER IS BLANK", MsgBoxStyle.Information, "FINE_NESS")
            Me.txt_fine_ness.Focus()
        End If
    End Sub

   
   
    Private Sub btn_average_range_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_average_range.Click
        If Me.cmb_product_code.Text <> "" Then
            If average_weight(Me.cmb_product_code.SelectedIndex) <> 0 Then
                MsgBox("average-weight" & CStr(average_weight(Me.cmb_product_code.SelectedIndex)), MsgBoxStyle.Information, "Average Weight")
            Else
                MsgBox("check the relevant entries in the master table", MsgBoxStyle.Information, "Average Weight")

            End If
        Else
            MsgBox("Enter Product Code", MsgBoxStyle.Information, "PRODUCT CODE")
            Me.cmb_product_code.Focus()
        End If
    End Sub

    Private Sub txt_fineness_range_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_fineness_range.Click
        If Me.cmb_product_code.Text <> "" Then
            If fine_ness(Me.cmb_product_code.SelectedIndex) <> 0 Then
                MsgBox("fine_ness" & CStr(fine_ness(Me.cmb_product_code.SelectedIndex)), MsgBoxStyle.Information, "FINE-NESS")
            Else
                MsgBox("check the relevant entries in the master table", MsgBoxStyle.Information, "FINE-NESS")

            End If
        Else
            MsgBox("Enter Product Code", MsgBoxStyle.Information, "PRODUCT CODE")
            Me.cmb_product_code.Focus()
        End If
    End Sub

    Private Sub btn_validate_bulk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validate_bulk.Click
        Dim min, max, cal As Double
        If Me.cmb_product_code.Text <> "" Then
            If bulk_density(Me.cmb_product_code.SelectedIndex) <> 0 And bulk_density_range(Me.cmb_product_code.SelectedIndex) <> 0 Then
                cal = (bulk_density(Me.cmb_product_code.SelectedIndex) * (bulk_density_range(Me.cmb_product_code.SelectedIndex))) / 100
                min = bulk_density(Me.cmb_product_code.SelectedIndex) - cal
                max = bulk_density(Me.cmb_product_code.SelectedIndex) + cal
                If Val(Me.txt_bulk_density.Text) >= min And Val(Me.txt_bulk_density.Text) <= max Then
                    MsgBox("BULK DENSITY IS CORRECT", MsgBoxStyle.Information, "AVERAGE WEIGHT CHECK")
                Else
                    MsgBox("BULK DENSITY IS OUT OF RANGE", MsgBoxStyle.Information, "AVERAGE WEIGHT CHECK")
                    Me.txt_bulk_density.Focus()
                End If
            Else
                MsgBox("CHECK TABLET MASTER FOR RELATED VALUES", MsgBoxStyle.Information, "AVERAGE WEIGHT CHECK")
            End If
        Else
            MsgBox(" PLEASE ENTER PRODUCT CODE", MsgBoxStyle.Information, "AVERAGE WEIGHT CHECK")
            Me.cmb_product_code.Focus()
        End If
    End Sub

    Private Sub btn_range_bulk_density_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_range_bulk_density.Click
        Dim min, max, cal As Double
        If Me.cmb_product_code.Text <> "" Then
        If bulk_density(Me.cmb_product_code.SelectedIndex) <> 0 And bulk_density_range(Me.cmb_product_code.SelectedIndex) <> 0 Then
            cal = (bulk_density(Me.cmb_product_code.SelectedIndex) * (bulk_density_range(Me.cmb_product_code.SelectedIndex))) / 100
            min = bulk_density(Me.cmb_product_code.SelectedIndex) - cal
                max = bulk_density(Me.cmb_product_code.SelectedIndex) + cal
                MsgBox("range=" & CStr(min) & " to " & CStr(max), MsgBoxStyle.Information, "BULK DENSITY RANGE")
            Else
                MsgBox("CHECK POWDER MASTER FOR RELATED VALUES", MsgBoxStyle.Information, "Bulk density")
            End If
        Else
            MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "PRODUCT CODE")
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
End Class