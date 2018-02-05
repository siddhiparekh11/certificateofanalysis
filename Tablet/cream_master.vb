'This form is concerned with Cream Master ,for more details see CREAM_MODULE
Public Class cream_master
    Dim record As Integer
    Private Sub cream_master_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call CREAM_MODULE.cream_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub cream_master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CREAM_MODULE.cream_open_connection()
        Call CREAM_MODULE.cream_filldataset_master()
        Call display_statusbar(-1)
        Me.conmenu_cream_master.Hide()
        Me.txt_product_code.Focus()
        Me.txt_identification.Visible = False
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.txt_product_code.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    add_row = add_master()
                    CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Add(add_row)
                    record = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1
                    Call CREAM_MODULE.cream_updatedatabase_master()
                    Call display_statusbar(record)
                    MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                End If
            Else
                MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Blank Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Add Procedure of Cream Master
    Private Function add_master() As DataRow
        Dim add_row As DataRow
        add_row = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").NewRow()
        add_row.Item("Cream_Code") = Me.txt_product_code.Text
        If Me.txt_product_name.Text = "" Then
            add_row.Item("Cream_Name") = "No Name"
        Else
            add_row.Item("Cream_Name") = Me.txt_product_name.Text
        End If
        If Me.txt_batch_size.Text = "" Then
            add_row.Item("Cream_Batch_Size") = CInt("0")
        Else
            add_row.Item("Cream_Batch_Size") = CInt(Me.txt_batch_size.Text)
        End If
        If Me.txt_shelf_life.Text = "" Then
            add_row.Item("Cream_Shelf_Life") = CInt("0")
        Else
            add_row.Item("Cream_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If
        If Me.txt_description.Text = "" Then
            add_row.Item("Cream_Description") = "No Description"
        Else
            add_row.Item("Cream_Description") = Me.txt_description.Text
        End If
       If Me.txt_min_uniformity.Text = "" Then
            add_row.Item("Cream_Min_Uniformity_Weight") = Val("0")
        Else
            add_row.Item("Cream_Min_Uniformity_Weight") = Val(Me.txt_min_uniformity.Text)
        End If
        If Me.txt_max_uniformity.Text = "" Then
            add_row.Item("Cream_Max_Uniformity_Weight") = Val("0")
        Else
            add_row.Item("Cream_Max_Uniformity_Weight") = Val(Me.txt_max_uniformity.Text)
        End If
        If Me.txt_average.Text = "" Then
            add_row.Item("Cream_Average_Weight") = Val("0")
        Else
            add_row.Item("Cream_Average_Weight") = Val(Me.txt_average.Text)
        End If
        If Me.txt_assay.Text = "" Then
            add_row.Item("Cream_Assay") = "No Assay"
        Else
            add_row.Item("Cream_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_identification.Text = "" Then
            add_row.Item("Cream_Identification") = "No Identification"
        Else
            add_row.Item("Cream_Identification") = Me.txt_identification.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            add_row.Item("Cream_Batch_Size_Unit") = "No Unit"
        Else
            add_row.Item("Cream_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        Return add_row
    End Function
    'This Procedure display currebt record nummber and total number of records in status bar of Cream Master   
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        status_lbl_record_number.Text = CStr(pointer)
        status_lbl_total_record.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count)
    End Sub
    'Edit Procedure of Cream Master   
    Private Sub edit_master(ByVal record As Integer)
        CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Code") = Me.txt_product_code.Text

        If Me.txt_product_name.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Name") = "No Name"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Name") = Me.txt_product_name.Text
        End If

        If Me.txt_batch_size.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Batch_Size") = CInt("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Batch_Size") = CInt(Me.txt_batch_size.Text)
        End If

        If Me.txt_shelf_life.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Shelf_Life") = CInt("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If

        If Me.txt_description.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Description") = "No Description"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Description") = Me.txt_description.Text
        End If

        If Me.txt_min_uniformity.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Min_Uniformity_Weight") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Min_Uniformity_Weight") = Val(Me.txt_min_uniformity.Text)
        End If
        If Me.txt_max_uniformity.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Max_Uniformity_Weight") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Max_Uniformity_Weight") = Val(Me.txt_max_uniformity.Text)
        End If

        If Me.txt_average.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Average_Weight") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Average_Weight") = Val(Me.txt_average.Text)
        End If
        If Me.txt_assay.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Assay") = "No Assay"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Batch_Size_Unit") = "No Unit"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        If Me.txt_identification.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Identification") = "No Identification"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Identification") = Me.txt_identification.Text
        End If
        Call CREAM_MODULE.cream_updatedatabase_master()
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Dim search_row As DataRow
        Dim search_string As String, count As Integer
        search_string = InputBox("ENTER PRODUCT_CODE", "SEARCH A RECORD", "NOSTRING")
        search_row = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Find(search_string.ToUpper)
        If Not search_row Is Nothing Then
            For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1
                If search_string.ToUpper = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Code") Then
                    record = count
                    Call display_records(record)
                    Call display_statusbar(record)
                End If
            Next
        Else
            MsgBox("RECORD DOES NOT EXIST", MsgBoxStyle.Information, "Enter Correct Product Code")
        End If
    End Sub
    'This Procedure display records in Cream Master Controls   
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            Me.txt_product_code.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Code")
            Me.txt_product_name.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Name")
            Me.txt_batch_size.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Batch_Size"))
            Me.txt_shelf_life.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Shelf_Life"))
            Me.txt_description.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Description")
            Me.txt_min_uniformity.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Min_Uniformity_Weight"))
            Me.txt_max_uniformity.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Max_Uniformity_Weight"))
            Me.txt_average.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Average_Weight"))
            Me.txt_assay.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Assay")
            Me.txt_batch_size_unit.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Batch_Size_Unit")
            Me.txt_identification.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(record).Item("Cream_Identification")
            If Me.btn_identification_show.Text = "Show" Then
                Me.txt_identification.Visible = True
                Me.btn_identification_show.Text = "Hide"
            End If
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count > 0 Then
            record = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count > 0 Then
            record = record + 1
            If record > CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub tlstr_btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_delete.Click
        Dim msg_box As Integer
        Dim delete_row As DataRow
        Try
            If Me.txt_product_code.Text <> "" Then
                delete_row = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Find(Me.txt_product_code.Text)
                If Not delete_row Is Nothing Then
                    msg_box = MsgBox("DO YOU WANT TO DELETE THIS RECORD ?", MsgBoxStyle.YesNo, "Delete Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        delete_row.Delete()
                        MsgBox("RECORD IS DELETED", MsgBoxStyle.Information, "Delete a Record")
                        Call CREAM_MODULE.cream_updatedatabase_master()
                        record = record - 1
                        Call display_records(record)
                        Call display_statusbar(record)
                    End If
                Else
                    MsgBox("PRODUCT CODE IS INCORRECT", MsgBoxStyle.Information, "Enter Correct Product Code")
                    Me.txt_product_code.SelectionStart = 0
                    Me.txt_product_code.SelectionLength = Me.txt_product_code.TextLength
                    Me.txt_product_code.Focus()
                End If
            Else
                MsgBox("ENTER PRODUCT CODE", MsgBoxStyle.Information, "Enter Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_clear.Click
        Call clear_all()
        Call display_statusbar(-1)
    End Sub
    Private Sub txt_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_product_code.KeyPress
        If (e.KeyChar < "A" Or e.KeyChar > "Z") And (e.KeyChar < "a" Or e.KeyChar > "z") And e.KeyChar <> vbBack Then
            e.KeyChar = ""
            MsgBox("ENTER ALPHABETS ONLY", MsgBoxStyle.Information, "Product Code")
        End If
    End Sub
    Private Sub txt_batch_size_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_batch_size.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Batch Size")
        End If
    End Sub
    Private Sub txt_shelf_life_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_shelf_life.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Shelf Life")
        End If
    End Sub
    Private Sub txt_min_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_min_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Weight")
        End If
    End Sub
    Private Sub txt_average_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Average Weight")
        End If
    End Sub
    Private Sub txt_max_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformity Of Weight")
        End If
    End Sub
    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        cream_master_grid.Show()
        Me.Hide()
    End Sub
    'This procedure clears the content of all the controls on Tablet Master
    Private Sub clear_all()
        Me.txt_product_code.Text = ""
        Me.txt_product_name.Text = ""
        Me.txt_batch_size.Text = ""
        Me.txt_shelf_life.Text = ""
        Me.txt_description.Text = ""
        Me.txt_min_uniformity.Text = ""
        Me.txt_max_uniformity.Text = ""
        Me.txt_average.Text = ""
        Me.txt_assay.Text = ""
        Me.txt_batch_size_unit.Text = ""
        Me.txt_identification.Text = ""
        If Me.btn_identification_show.Text = "Hide" Then
            Me.txt_identification.Visible = False
            Me.btn_identification_show.Text = "Show"
        End If
        Me.txt_product_code.Focus()
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
                MsgBox("ENTER PRODUCT_CODE", MsgBoxStyle.Information, "Blank Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
End Class


