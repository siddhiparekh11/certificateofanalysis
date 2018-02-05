'This form is concerned with Powder Master ,for more details see POWDER_MODULE
Public Class powder_master
    Dim record As Integer

    Private Sub powder_master_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call POWDER_MODULE.powder_close_connection()
        frm_mdi.Show()
    End Sub

  
    Private Sub powder_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call POWDER_MODULE.powder_open_connection()
        Call POWDER_MODULE.powder_filldataset_master()
        Call display_statusbar(-1)
        Me.txt_identification.Visible = False
        Me.conmenu_powder_master.Hide()
        Me.txt_product_code.Focus()
    End Sub
    'This Procedure display currebt record nummber and total number of records in status bar of Powder Master   
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        status_lbl_record_number.Text = CStr(pointer)
        status_lbl_total_record.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count)
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.txt_product_code.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "ADD A RECORD")
                If msg_box = MsgBoxResult.Yes Then
                    add_row = add_master()
                    POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Add(add_row)
                    record = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count - 1
                    Call POWDER_MODULE.powder_updatedatabase_master()
                    Call display_statusbar(record)
                    MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "ADD A RECORD")
                End If
            Else
                MsgBox("ENTER PRODUCT_CODE", MsgBoxStyle.Information, "PRODUCT_CODE")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Add Procedure of Powder Master
    Private Function add_master() As DataRow
        Dim powder_row As DataRow
        powder_row = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").NewRow()
        powder_row.Item("Powder_Code") = Me.txt_product_code.Text
        If Me.txt_product_name.Text = "" Then
            powder_row.Item("Powder_Name") = "No Name"
        Else
            powder_row.Item("Powder_Name") = Me.txt_product_name.Text
        End If

        If Me.txt_batch_size.Text = "" Then
            powder_row.Item("Powder_Batch_Size") = CInt("0")
        Else
            powder_row.Item("Powder_Batch_Size") = CInt(Me.txt_batch_size.Text)
        End If

        If Me.txt_shelf_life.Text = "" Then
            powder_row.Item("Powder_Shelf_Life") = CInt("0")
        Else
            powder_row.Item("Powder_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If

        If Me.txt_description.Text = "" Then
            powder_row.Item("Powder_Description") = "No Description"
        Else
            powder_row.Item("Powder_Description") = Me.txt_description.Text
        End If

        If Me.txt_min_uniformity.Text = "" Then
            powder_row.Item("Powder_Min_Uniformity_Weight") = Val("0")
        Else
            powder_row.Item("Powder_Min_Uniformity_Weight") = Val(Me.txt_min_uniformity.Text)
        End If

        If Me.txt_max_uniformity.Text = "" Then
            powder_row.Item("Powder_Max_Uniformity_Weight") = Val("0")
        Else
            powder_row.Item("Powder_Max_Uniformity_Weight") = Val(Me.txt_max_uniformity.Text)
        End If

        If Me.txt_average.Text = "" Then
            powder_row.Item("Powder_Average_Weight") = Val("0")
        Else
            powder_row.Item("Powder_Average_Weight") = Val(Me.txt_average.Text)
        End If

        If Me.txt_fine_ness.Text = "" Then
            powder_row.Item("Powder_Fine_ness") = Val("0")
        Else
            powder_row.Item("Powder_Fine_ness") = Val(Me.txt_fine_ness.Text)
        End If

        If Me.txt_min_bulk_density.Text = "" Then
            powder_row.Item("Powder_Min_Bulk_density") = Val("0")
        Else
            powder_row.Item("Powder_Min_Bulk_density") = Val(Me.txt_min_bulk_density.Text)
        End If

        If Me.txt_max_bulk_density.Text = "" Then
            powder_row.Item("Powder_Max_Bulk_density") = Val("0")
        Else
            powder_row.Item("Powder_Max_Bulk_density") = Val(Me.txt_max_bulk_density.Text)
        End If

        If Me.txt_assay.Text = "" Then
            powder_row.Item("Powder_Assay") = "No Assay"
        Else
            powder_row.Item("Powder_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            powder_row.Item("Powder_Batch_Size_Unit") = "No Unit"
        Else
            powder_row.Item("Powder_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        If Me.txt_identification.Text = "" Then
            powder_row.Item("Powder_Identification") = "No Identification"
        Else
            powder_row.Item("Powder_Identification") = Me.txt_identification.Text
        End If
        Return powder_row
    End Function
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.txt_product_code.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO EDIT THIS RECORD ?", MsgBoxStyle.YesNo, "EDIT A RECORD")
                If msg_box = MsgBoxResult.Yes Then
                    Call edit_master(record)
                    MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "EDIT A RECORD")
                End If
            Else
                MsgBox("ENTER PRODUCT_CODE", MsgBoxStyle.Information, "EDIT A RECORD")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Edit Procedure of Powder Master  
    Private Sub edit_master(ByVal record As Integer)
        POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Code") = Me.txt_product_code.Text
        If Me.txt_product_name.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Name") = "No Name"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Name") = Me.txt_product_name.Text
        End If

        If Me.txt_batch_size.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Batch_Size") = CInt("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Batch_Size") = CInt(Me.txt_batch_size.Text)
        End If

        If Me.txt_shelf_life.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Shelf_Life") = CInt("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If

        If Me.txt_description.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Description") = "No Description"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Description") = Me.txt_description.Text
        End If

        If Me.txt_min_uniformity.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Min_Uniformity_Weight") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Min_Uniformity_Weight") = Val(Me.txt_min_uniformity.Text)
        End If

        If Me.txt_max_uniformity.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Max_Uniformity_Weight") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Max_Uniformity_Weight") = Val(Me.txt_max_uniformity.Text)
        End If

        If Me.txt_average.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Average_Weight") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Average_Weight") = Val(Me.txt_average.Text)
        End If

        If Me.txt_fine_ness.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Fine_ness") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Fine_ness") = Val(Me.txt_fine_ness.Text)
        End If

        If Me.txt_min_bulk_density.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Min_Bulk_density") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Min_Bulk_density") = Val(Me.txt_min_bulk_density.Text)
        End If

        If Me.txt_max_bulk_density.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Max_Bulk_density") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Max_Bulk_density") = Val(Me.txt_max_bulk_density.Text)
        End If

        If Me.txt_assay.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Assay") = "No Assay"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Batch_Size_Unit") = "No Unit"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        If Me.txt_identification.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Identification") = "No Identification"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Identification") = Me.txt_identification.Text
        End If
        Call POWDER_MODULE.powder_updatedatabase_master()
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Dim search_row As DataRow
        Dim search_string As String, record_count As Integer
        search_string = InputBox("ENTER PRODUCT_CODE", "SEARCH A RECORD", "NOSTRING")
        search_row = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Find(search_string.ToUpper)
        If Not search_row Is Nothing Then
            For record_count = 0 To POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count - 1
                If search_string.ToUpper = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record_count).Item("Powder_Code") Then
                    record = record_count
                    Call display_records(record)
                    Call display_statusbar(record)
                End If
            Next
        Else
            MsgBox("RECORD DOES NOT EXIST", MsgBoxStyle.Information, "SEARCH A RECORD")
        End If
    End Sub
    'This Procedure display records in Powder Master Controls
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            Me.txt_product_code.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Code")
            Me.txt_product_name.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Name")
            Me.txt_batch_size.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Batch_Size"))
            Me.txt_shelf_life.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Shelf_Life"))
            Me.txt_description.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Description")
            Me.txt_min_uniformity.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Min_Uniformity_Weight"))
            Me.txt_max_uniformity.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Max_Uniformity_Weight"))
            Me.txt_average.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Average_Weight"))
            Me.txt_fine_ness.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Fine_ness"))
            Me.txt_min_bulk_density.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Min_Bulk_density"))
            Me.txt_max_bulk_density.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Max_Bulk_density"))
            Me.txt_assay.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Assay")
            Me.txt_batch_size_unit.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Batch_Size_Unit")
            Me.txt_identification.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(record).Item("Powder_Identification")
            If Me.btn_identification_show.Text = "Show" Then
                Me.txt_identification.Visible = True
                Me.btn_identification_show.Text = "Hide"
            End If
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub tlstr_btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_delete.Click
        Dim msg_box As Integer
        Dim delete_row As DataRow
        Try
            If Me.txt_product_code.Text <> "" Then
                delete_row = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Find(Me.txt_product_code.Text)
                If Not delete_row Is Nothing Then
                    msg_box = MsgBox("DO YOU WANT TO DELETE THIS RECORD", MsgBoxStyle.YesNo, "DELETE A RECORD")
                    If msg_box = MsgBoxResult.Yes Then
                        delete_row.Delete()
                        MsgBox("RECORD IS DELETED", MsgBoxStyle.Information, "DELETE A RECORD")
                        Call POWDER_MODULE.powder_updatedatabase_master()
                        record = record - 1
                        Call display_records(record)
                        Call display_statusbar(record)
                    End If
                Else
                    MsgBox("PRODUCT_CODE IS INCORRECT", MsgBoxStyle.Information, "DELETE A RECORD")
                    Me.txt_product_code.SelectionStart = 0
                    Me.txt_product_code.SelectionLength = Me.txt_product_code.TextLength
                    Me.txt_product_code.Focus()
                End If
            Else
                MsgBox("ENTER PRODUCT_CODE", MsgBoxStyle.Information, "DELETE A RECORD")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        powder_master_grid.Show()
        Me.Hide()
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count > 0 Then
            record = record + 1
            If record > POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count > 0 Then
            record = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    'This procedure clears the content of all the controls on Powder Master
    Private Sub clear_all()
        Me.txt_product_code.Text = ""
        Me.txt_product_name.Text = ""
        Me.txt_batch_size.Text = ""
        Me.txt_shelf_life.Text = ""
        Me.txt_description.Text = ""
        Me.txt_min_uniformity.Text = ""
        Me.txt_max_uniformity.Text = ""
        Me.txt_average.Text = ""
        Me.txt_fine_ness.Text = ""
        Me.txt_min_bulk_density.Text = ""
        Me.txt_max_bulk_density.Text = ""
        Me.txt_assay.Text = ""
        Me.txt_identification.Text = ""
        Me.txt_batch_size_unit.Text = ""
        If Me.btn_identification_show.Text = "Hide" Then
            Me.txt_identification.Visible = False
            Me.btn_identification_show.Text = "Show"
        End If
        Me.txt_product_code.Focus()
    End Sub
    Private Sub tlstr_btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_clear.Click
        Call clear_all()
        Call display_statusbar(-1)
    End Sub
    Private Sub txt_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_product_code.KeyPress
        If (e.KeyChar < "A" Or e.KeyChar > "Z") And (e.KeyChar < "a" Or e.KeyChar > "z") And e.KeyChar <> vbBack Then
            e.KeyChar = ""
            MsgBox("ENTER ALPHABETS ONLY", MsgBoxStyle.Information, "PRODUCT_CODE")
        End If
    End Sub
    Private Sub txt_batch_size_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch_size.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "BATCH_SIZE")
        End If
    End Sub
    Private Sub txt_shelf_life_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_shelf_life.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "SHELF_LIFE")
        End If
    End Sub
    Private Sub txt_min_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "UNIFORMITY1")
        End If
    End Sub
    Private Sub txt_max_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "UNIFORMITY2")
        End If
    End Sub
    Private Sub txt_average_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "AVERAGE")
        End If
    End Sub
    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
    End Sub
    Private Sub txt_min_bulk_density_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_fine_ness.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "BULK DENSITY")
        End If
    End Sub
    Private Sub txt_max_bulk_density_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_bulk_density.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "BULK DENSITY")
        End If
    End Sub
    Private Sub txt_fine_ness_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_bulk_density.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "FINE-NESS")
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