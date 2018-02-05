'This form is concerned with Liquid Master ,for more details see LIQUID_MODULE
Public Class liquid_master
    Dim record As Integer
    Private Sub liquid_master_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call LIQUID_MODULE.liquid_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub liquid_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LIQUID_MODULE.liquid_open_connection()
        Call LIQUID_MODULE.liquid_filldataset_master()
        Call display_statusbar(-1)
        Me.conmenu_liquid_master.Hide()
        Me.txt_identification.Visible = False
        Me.txt_product_code.Focus()
    End Sub
    'This Procedure display currebt record nummber and total number of records in status bar of Liquid Master   
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        status_lbl_record_number.Text = CStr(pointer)
        status_lbl_total_record.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count)
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.txt_product_code.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    add_row = add_master()
                    LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Add(add_row)
                    record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1
                    Call LIQUID_MODULE.liquid_updatedatabase_master()
                    Call display_statusbar(record)
                    MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                End If
            Else
                MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Add Procedure of Liquid Master
    Private Function add_master() As DataRow
        Dim liquid_row As DataRow
        liquid_row = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").NewRow()
        liquid_row.Item("Liquid_Code") = Me.txt_product_code.Text
        If Me.txt_product_name.Text = "" Then
            liquid_row.Item("Liquid_Name") = "No Name"
        Else
            liquid_row.Item("Liquid_Name") = Me.txt_product_name.Text
        End If

        If Me.txt_batch_size.Text = "" Then
            liquid_row.Item("Liquid_Batch_Size") = CInt("0")
        Else
            liquid_row.Item("Liquid_Batch_Size") = CInt(Me.txt_batch_size.Text)
        End If

        If Me.txt_shelf_life.Text = "" Then
            liquid_row.Item("Liquid_Shelf_Life") = CInt("0")
        Else
            liquid_row.Item("Liquid_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If

        If Me.txt_description.Text = "" Then
            liquid_row.Item("Liquid_Description") = "No Description"
        Else
            liquid_row.Item("Liquid_Description") = Me.txt_description.Text
        End If

        If Me.txt_min_uniformity.Text = "" Then
            liquid_row.Item("Liquid_Min_Uniformity_Volume") = Val("0")
        Else
            liquid_row.Item("Liquid_Min_Uniformity_Volume") = Val(Me.txt_min_uniformity.Text)
        End If

        If Me.txt_max_uniformity.Text = "" Then
            liquid_row.Item("Liquid_Max_Uniformity_Volume") = Val("0")
        Else
            liquid_row.Item("Liquid_Max_Uniformity_Volume") = Val(Me.txt_max_uniformity.Text)
        End If

        If Me.txt_average.Text = "" Then
            liquid_row.Item("Liquid_Average_Volume") = Val("0")
        Else
            liquid_row.Item("Liquid_Average_Volume") = Val(Me.txt_average.Text)
        End If

        If Me.txt_min_ph.Text = "" Then
            liquid_row.Item("Liquid_Min_Ph") = Val("0")
        Else
            liquid_row.Item("Liquid_Min_Ph") = Val(Me.txt_min_ph.Text)
        End If

        If Me.txt_max_ph.Text = "" Then
            liquid_row.Item("Liquid_Max_Ph") = Val("0")
        Else
            liquid_row.Item("Liquid_Max_Ph") = Val(Me.txt_max_ph.Text)
        End If

        If Me.txt_min_weight.Text = "" Then
            liquid_row.Item("Liquid_Min_Weight") = Val("0")
        Else
            liquid_row.Item("Liquid_Min_Weight") = Val(Me.txt_min_weight.Text)
        End If

        If Me.txt_max_weight.Text = "" Then
            liquid_row.Item("Liquid_Max_Weight") = Val("0")
        Else
            liquid_row.Item("Liquid_Max_Weight") = Val(Me.txt_max_weight.Text)
        End If

        If Me.txt_assay.Text = "" Then
            liquid_row.Item("Liquid_Assay") = "No Assay"
        Else
            liquid_row.Item("Liquid_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            liquid_row.Item("Liquid_Batch_Size_Unit") = "No Unit"
        Else
            liquid_row.Item("Liquid_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        If Me.txt_identification.Text = "" Then
            liquid_row.Item("Liquid_Identification") = "No Identification"
        Else
            liquid_row.Item("Liquid_Identification") = Me.txt_identification.Text
        End If
        Return liquid_row
    End Function
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.txt_product_code.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO EDIT THIS RECORD ?", MsgBoxStyle.YesNo, "Edit Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    Call edit_master(record)
                    MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                End If
            Else
                MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Edit Procedure of Liquid Master  
    Private Sub edit_master(ByVal record As Integer)
        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Code") = Me.txt_product_code.Text
        If Me.txt_product_name.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Name") = "No Name"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Name") = Me.txt_product_name.Text
        End If

        If Me.txt_batch_size.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Batch_Size") = CInt("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Batch_Size") = CInt(Me.txt_batch_size.Text)
        End If

        If Me.txt_shelf_life.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Shelf_Life") = CInt("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If

        If Me.txt_description.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Description") = "No Description"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Description") = Me.txt_description.Text
        End If

        If Me.txt_min_uniformity.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Uniformity_Volume") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Uniformity_Volume") = Val(Me.txt_min_uniformity.Text)
        End If

        If Me.txt_max_uniformity.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Uniformity_Volume") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Uniformity_Volume") = Val(Me.txt_max_uniformity.Text)
        End If

        If Me.txt_average.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Average_Volume") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Average_Volume") = Val(Me.txt_average.Text)
        End If
        If Me.txt_min_ph.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Ph") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Ph") = Val(Me.txt_min_ph.Text)
        End If

        If Me.txt_max_ph.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Ph") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Ph") = Val(Me.txt_max_ph.Text)
        End If
        If Me.txt_min_weight.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Weight") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Weight") = Val(Me.txt_min_weight.Text)
        End If
        If Me.txt_max_weight.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Weight") = Val("0")
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Weight") = Val(Me.txt_max_weight.Text)
        End If
        If Me.txt_assay.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Assay") = "No Assay"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Batch_Size_Unit") = "No Unit"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        If Me.txt_identification.Text = "" Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Identification") = "No Identification"
        Else
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Identification") = Me.txt_identification.Text
        End If
        Call LIQUID_MODULE.liquid_updatedatabase_master()
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Dim search_row As DataRow
        Dim search_string As String, count As Integer
        search_string = InputBox("ENTER PRODUCT_CODE", "SEARCH A RECORD", "NOSTRING")
        search_row = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Find(search_string.ToUpper)
        If Not search_row Is Nothing Then
            For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1
                If search_string.ToUpper = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(count).Item("Liquid_Code") Then
                    record = count
                    Call display_records(record)
                    Call display_statusbar(record)
                End If
            Next
        Else
            MsgBox("RECORD DOES NOT EXIST", MsgBoxStyle.Information, "Enter Product Code")
        End If
    End Sub
    'This Procedure display records in Liquid Master Controls    
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            Me.txt_product_code.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Code")
            Me.txt_product_name.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Name")
            Me.txt_batch_size.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Batch_Size"))
            Me.txt_shelf_life.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Shelf_Life"))
            Me.txt_description.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Description")
            Me.txt_min_uniformity.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Uniformity_Volume"))
            Me.txt_max_uniformity.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Uniformity_Volume"))
            Me.txt_average.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Average_Volume"))
            Me.txt_min_ph.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Ph"))
            Me.txt_max_ph.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Ph"))
            Me.txt_min_weight.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Min_Weight"))
            Me.txt_max_weight.Text = CStr(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Max_Weight"))
            Me.txt_assay.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Assay")
            Me.txt_identification.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Identification")
            Me.txt_batch_size_unit.Text = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows(record).Item("Liquid_Batch_Size_Unit")
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
                delete_row = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Find(Me.txt_product_code.Text)
                If Not delete_row Is Nothing Then
                    msg_box = MsgBox("DO YOU WANT TO DELETE THIS RECORD ?", MsgBoxStyle.YesNo, "Delete Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        delete_row.Delete()
                        MsgBox("RECORD IS DELETED", MsgBoxStyle.Information, "Delete a Record")
                        Call LIQUID_MODULE.liquid_updatedatabase_master()
                        record = record - 1
                        Call display_records(record)
                        Call display_statusbar(record)
                    End If
                Else
                    MsgBox("PRODUCT CODE IS INCORRECT", MsgBoxStyle.Information, "Incorrect Product Code")
                    Me.txt_product_code.SelectionStart = 0
                    Me.txt_product_code.SelectionLength = Me.txt_product_code.TextLength
                    Me.txt_product_code.Focus()
                End If
            Else
                MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        liquid_master_grid.Show()
        Me.Hide()
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count > 0 Then
            record = record + 1
            If record > LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count > 0 Then
            record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_MASTER").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    'This procedure clears the content of all the controls on Liquid Master
    Private Sub clear_all()
        Me.txt_product_code.Text = ""
        Me.txt_product_name.Text = ""
        Me.txt_batch_size.Text = ""
        Me.txt_shelf_life.Text = ""
        Me.txt_description.Text = ""
        Me.txt_min_uniformity.Text = ""
        Me.txt_max_uniformity.Text = ""
        Me.txt_average.Text = ""
        Me.txt_min_ph.Text = ""
        Me.txt_max_ph.Text = ""
        Me.txt_min_weight.Text = ""
        Me.txt_max_weight.Text = ""
        Me.txt_assay.Text = ""
        Me.txt_batch_size_unit.Text = ""
        Me.txt_identification.Text = ""
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
    Private Sub txt_min_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Volume")
        End If
    End Sub
    Private Sub txt_max_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Volume")
        End If
    End Sub
    Private Sub txt_min_ph_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_ph.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "PH")
        End If
    End Sub
    Private Sub txt_max_ph_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_ph.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "PH")
        End If
    End Sub
    Private Sub txt_min_weight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_weight.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Weight/ml")
        End If
    End Sub
    Private Sub txt_max_weight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_weight.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Weight/ml")
        End If
    End Sub
    Private Sub txt_average_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Average Net Volume")
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
    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
        frm_mdi.Show()
    End Sub
End Class