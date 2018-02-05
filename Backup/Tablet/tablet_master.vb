'This form is concerned with Tablet Master ,for more details see TABLET_MODULE
Public Class tablet_master
    Dim record As Integer
    Private Sub tablet_master_formclosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call TABLET_MODULE.tablet_close_connection()
    End Sub
    Private Sub tablet_master_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call TABLET_MODULE.tablet_open_connection()
        Call TABLET_MODULE.tablet_filldataset_master()
        Call display_statusbar(-1)
        Me.conmenu_tablet_master.Hide()
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
                    TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Add(add_row)
                    record = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count - 1
                    Call TABLET_MODULE.tablet_updatedatabase_master()
                    Call display_statusbar(record)
                    MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                End If
            Else
                MsgBox("ENTER PRODUCT_CODE", MsgBoxStyle.Information, "Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Add Procedure of Tablet Master
    Private Function add_master() As DataRow
        Dim add_row As DataRow
        add_row = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").NewRow()
        add_row.Item("Tablet_Code") = Me.txt_product_code.Text
        If Me.txt_product_name.Text = "" Then
            add_row.Item("Tablet_Name") = "No Name"
        Else
            add_row.Item("Tablet_Name") = Me.txt_product_name.Text
        End If
        If Me.txt_batch_size.Text = "" Then
            add_row.Item("Tablet_Batch_Size") = CLng("0")
        Else
            add_row.Item("Tablet_Batch_Size") = CLng(Me.txt_batch_size.Text)
        End If
        If Me.txt_shelf_life.Text = "" Then
            add_row.Item("Tablet_Shelf_Life") = CInt("0")
        Else
            add_row.Item("Tablet_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If
        If Me.txt_description.Text = "" Then
            add_row.Item("Tablet_Description") = "No Description"
        Else
            add_row.Item("Tablet_Description") = Me.txt_description.Text
        End If
        If Me.txt_dissolution.Text = "" Then
            add_row.Item("Tablet_Dissolution") = "No Dissolution"
        Else
            add_row.Item("Tablet_Dissolution") = Me.txt_dissolution.Text
        End If
        If Me.txt_disintegration_time.Text = "" Then
            add_row.Item("Tablet_Disintegration_Time") = "No Time"
        Else
            add_row.Item("Tablet_Disintegration_Time") = Me.txt_disintegration_time.Text
        End If
        If Me.txt_uniformity.Text = "" Then
            add_row.Item("Tablet_Uniformity") = Val("0")
        Else
            add_row.Item("Tablet_Uniformity") = Val(Me.txt_uniformity.Text)
        End If
        If Me.txt_average.Text = "" Then
            add_row.Item("Tablet_Average_Weight") = Val("0")
        Else
            add_row.Item("Tablet_Average_Weight") = Val(Me.txt_average.Text)
        End If
        If Me.txt_average_range.Text = "" Then
            add_row.Item("Tablet_Average_Weight_Range") = Val("0")
        Else
            add_row.Item("Tablet_Average_Weight_Range") = Val(Me.txt_average_range.Text)
        End If
        If Me.txt_assay.Text = "" Then
            add_row.Item("Tablet_Assay") = "No Assay"
        Else
            add_row.Item("Tablet_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_identification.Text = "" Then
            add_row.Item("Tablet_Identification") = "No Identification"
        Else
            add_row.Item("Tablet_Identification") = Me.txt_identification.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            add_row.Item("Tablet_Batch_Size_Unit") = "No Unit"
        Else
            add_row.Item("Tablet_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        Return add_row
    End Function
    'This Procedure display currebt record nummber and total number of records in status bar of Tablet Master   
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        status_lbl_record_number.Text = CStr(pointer)
        status_lbl_total_record.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count)
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
                MsgBox("ENTER PRODUCT_CODE", MsgBoxStyle.Information, "Product Code")
                Me.txt_product_code.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    'Edit Procedure of Tablet Master   
    Private Sub edit_master(ByVal record As Integer)
        TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Code") = Me.txt_product_code.Text

        If Me.txt_product_name.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Name") = "No Name"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Name") = Me.txt_product_name.Text
        End If

        If Me.txt_batch_size.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Batch_Size") = CLng("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Batch_Size") = CLng(Me.txt_batch_size.Text)
        End If

        If Me.txt_shelf_life.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Shelf_Life") = CInt("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Shelf_Life") = CInt(Me.txt_shelf_life.Text)
        End If

        If Me.txt_description.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Description") = "No Description"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Description") = Me.txt_description.Text
        End If

        If Me.txt_dissolution.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Dissolution") = "No Dissolution"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Dissolution") = Me.txt_dissolution.Text
        End If
        If Me.txt_disintegration_time.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Disintegration_Time") = "No Time"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Disintegration_Time") = Me.txt_disintegration_time.Text
        End If

        If Me.txt_uniformity.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Uniformity") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Uniformity") = Val(Me.txt_uniformity.Text)
        End If

        If Me.txt_average.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Average_Weight") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Average_Weight") = Val(Me.txt_average.Text)
        End If

        If Me.txt_average_range.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Average_Weight_Range") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Average_Weight_Range") = Val(Me.txt_average_range.Text)
        End If

        If Me.txt_assay.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Assay") = "No Assay"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Assay") = Me.txt_assay.Text
        End If
        If Me.txt_batch_size_unit.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Batch_Size_Unit") = "No Unit"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Batch_Size_Unit") = Me.txt_batch_size_unit.Text
        End If
        If Me.txt_identification.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Identification") = "No Identification"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Identification") = Me.txt_identification.Text
        End If
        Call TABLET_MODULE.tablet_updatedatabase_master()
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Dim search_row As DataRow
        Dim search_string As String, count As Integer
        search_string = InputBox("ENTER PRODUCT_CODE", "SEARCH A RECORD", "NOSTRING")
        search_row = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Find(search_string.ToUpper)
        If Not search_row Is Nothing Then
            For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count - 1
                If search_string.ToUpper = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(count).Item("Tablet_Code") Then
                    record = count
                    Call display_records(record)
                    Call display_statusbar(record)
                End If
            Next
        Else
            MsgBox("RECORD DOES NOT EXIST", MsgBoxStyle.Information, "Enter Correct Product Code")
        End If
    End Sub
    'This Procedure display records in Tablet Master Controls   
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            Me.txt_product_code.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Code")
            Me.txt_product_name.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Name")
            Me.txt_batch_size.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Batch_Size"))
            Me.txt_shelf_life.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Shelf_Life"))
            Me.txt_description.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Description")
            Me.txt_dissolution.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Dissolution")
            Me.txt_disintegration_time.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Disintegration_Time")
            Me.txt_uniformity.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Uniformity"))
            Me.txt_average.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Average_Weight"))
            Me.txt_average_range.Text = CStr(TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Average_Weight_Range"))
            Me.txt_assay.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Assay")
            Me.txt_batch_size_unit.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Batch_Size_Unit")
            Me.txt_identification.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows(record).Item("Tablet_Identification")
            If Me.btn_identification_show.Text = "Show" Then
                Me.txt_identification.Visible = True
                Me.btn_identification_show.Text = "Hide"
            End If
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count > 0 Then
            record = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count > 0 Then
            record = record + 1
            If record > TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Count - 1 Then
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
                delete_row = TABLET_MODULE.tablet_dataset.Tables("TABLET_MASTER").Rows.Find(Me.txt_product_code.Text)
                If Not delete_row Is Nothing Then
                    msg_box = MsgBox("DO YOU WANT TO DELETE THIS RECORD ?", MsgBoxStyle.YesNo, "Delete Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        delete_row.Delete()
                        MsgBox("RECORD IS DELETED", MsgBoxStyle.Information, "Delete a Record")
                        Call TABLET_MODULE.tablet_updatedatabase_master()
                        record = record - 1
                        Call display_records(record)
                        Call display_statusbar(record)
                    End If
                Else
                    MsgBox("PRODUCT_CODE IS INCORRECT", MsgBoxStyle.Information, "Product Code")
                    Me.txt_product_code.SelectionStart = 0
                    Me.txt_product_code.SelectionLength = Me.txt_product_code.TextLength
                    Me.txt_product_code.Focus()
                End If
            Else
                MsgBox("ENTER PRODUCT_CODE", MsgBoxStyle.Information, "Product Code")
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
    Private Sub txt_uniformity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_uniformity.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Uniformiy Of Weight")
        End If
    End Sub
    Private Sub txt_average_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Average Weight")
        End If
    End Sub
    Private Sub txt_average_range_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_average_range.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Average Weight")
        End If
    End Sub
    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        tablet_master_grid.Show()
        Me.Hide()
    End Sub
    'This procedure clears the content of all the controls on Tablet Master
    Private Sub clear_all()
        Me.txt_product_code.Text = ""
        Me.txt_product_name.Text = ""
        Me.txt_batch_size.Text = ""
        Me.txt_shelf_life.Text = ""
        Me.txt_description.Text = ""
        Me.txt_dissolution.Text = ""
        Me.txt_disintegration_time.Text = ""
        Me.txt_uniformity.Text = ""
        Me.txt_average.Text = ""
        Me.txt_average_range.Text = ""
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
End Class
