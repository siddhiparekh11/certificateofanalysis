Imports System.Math
Public Class tablet_ingredient
    Dim batch_no() As String
    Dim ingredient_name() As String
    Dim label_claim() As Double
    Dim min_limit() As Double
    Dim max_limit() As Double
    Dim min_limit_percentage() As Double
    Dim max_limit_percentage() As Double
    Dim unit() As String
    Dim record As Integer
    Private Sub cmb_batch_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_batch_no.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmb_ingredient_name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_ingredient_name.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txt_found_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_found.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Found")
        End If
    End Sub
    Private Sub btn_found_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_found.Click
        Dim min, max As Double
        If Me.txt_found.Text <> "" Then
            If Me.cmb_ingredient_name.Text <> "" Then
                min = min_limit(Me.cmb_ingredient_name.SelectedIndex)
                max = max_limit(Me.cmb_ingredient_name.SelectedIndex)
                If Val(Me.txt_found.Text) >= min And Val(Me.txt_found.Text) <= max Then
                    MsgBox("THE CORRESPONDING FOUND IS CORRECT", MsgBoxStyle.Information, "Found")
                Else
                    MsgBox("THE CORRESPONDING FOUND IS INCORRECT", MsgBoxStyle.Information, "Found")
                    Me.txt_found.Focus()
                End If
            Else
                MsgBox("ENTER INGREDIENT NAME", MsgBoxStyle.Information, "Ingredient Name")
                Me.cmb_ingredient_name.Focus()
            End If
        Else
            MsgBox("FOUND FIELD IS BLANK", MsgBoxStyle.Information, "Found")
            Me.txt_found.Focus()
        End If
    End Sub
    Private Sub btn_label_claim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_label_claim.Click
        Dim min, max, result As Double
        If Me.txt_found.Text <> "" Then
            If Me.cmb_ingredient_name.Text <> "" Then
                min = Val(Me.lbl_limit1_percentage.Text)
                max = Val(Me.lbl_limit2_percentage.Text)
                result = Round(((Val(Me.txt_found.Text) * 100) / (Val(Me.lbl_label_claim.Text))), 2)
                If result >= min And result <= max Then
                    Me.lbl_label_claim_percentage.Text = CStr(result)
                Else
                    Me.lbl_label_claim_percentage.Text = CStr("0")
                    MsgBox("% OF LABEL CLAIM OUT OF RANGE", MsgBoxStyle.Information, "% Of Label Claim")
                End If
            Else
                MsgBox("ENTER INGREDIENT NAME", MsgBoxStyle.Information, "Ingredient Name")
                Me.cmb_ingredient_name.Focus()
            End If
            Else
                MsgBox("FOUND FIELD IS BLANK", MsgBoxStyle.Information, "Found")
                Me.txt_found.Focus()
            End If
    End Sub

    Private Sub tablet_ingredient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        TABLET_MODULE.tablet_close_connection()
    End Sub
    
    Private Sub tablet_ingredient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Try
            Call INGREDIENT_MODULE.ingredient_open_connection()
            Call INGREDIENT_MODULE.ingredient_filldataset_nondescriptive()
            Call initialize_ingredient_arrays()
            Call INGREDIENT_MODULE.ingredient_close_connection()
            Call TABLET_MODULE.tablet_open_connection()
            Call TABLET_MODULE.tablet_filldataset_detail()
            ReDim batch_no(TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1)
            For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows.Count - 1
                batch_no(count) = TABLET_MODULE.tablet_dataset.Tables("TABLET_DETAIL").Rows(count).Item("Tablet_Batch_No")
            Next
            Me.cmb_batch_no.Items.AddRange(batch_no)
            Call TABLET_MODULE.tablet_filldataset_ingredient()
            Call display_statusbar(-1)
            Me.conmenu_tablet_ingredient.Hide()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub initialize_ingredient_arrays()
        Dim count As Integer
        ReDim ingredient_name(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim label_claim(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim min_limit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim min_limit_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim max_limit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim max_limit_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim unit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
            ingredient_name(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_Name")
            label_claim(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Claim")
            min_limit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Min_Limit")
            min_limit_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Min_Limit_Percentage")
            max_limit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Max_Limit")
            max_limit_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Max_Limit_Percentage")
            unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Unit")
        Next
        Me.cmb_ingredient_name.Items.AddRange(ingredient_name)
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.cmb_batch_no.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "ADD Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    add_row = add_ingredient()
                    TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Add(add_row)
                    record = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count - 1
                    Call TABLET_MODULE.tablet_updatedatabase_ingredient()
                    Call display_statusbar(record)
                    MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                End If
            Else
                MsgBox("PLEASE SELECT BATCH_NO", MsgBoxStyle.Information, "Select Batch No")
                Me.cmb_batch_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Function add_ingredient() As DataRow
        Dim tablet_row As DataRow
        tablet_row = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").NewRow()
        tablet_row.Item("Tablet_Batch_No") = Me.cmb_batch_no.Text
        If Me.cmb_ingredient_name.Text = "" Then
            tablet_row.Item("Tablet_Ingredient_Name") = "No Name"
        Else
            tablet_row.Item("Tablet_Ingredient_Name") = Me.cmb_ingredient_name.Text
        End If

        If Me.lbl_label_claim.Text = "" Then
            tablet_row.Item("Tablet_Label_Claim") = Val("0")
        Else
            tablet_row.Item("Tablet_Label_Claim") = Val(Me.lbl_label_claim.Text)
        End If
        If Me.lbl_label_claim_unit.Text = "" Then
            tablet_row.Item("Tablet_Unit") = "u"
        Else
            tablet_row.Item("Tablet_Unit") = Me.lbl_label_claim_unit.Text
        End If
        If Me.lbl_limit1.Text = "" Then
            tablet_row.Item("Tablet_Min_Limit") = Val("0")
        Else
            tablet_row.Item("Tablet_Min_Limit") = Val(Me.lbl_limit1.Text)
        End If
        If Me.lbl_limit2.Text = "" Then
            tablet_row.Item("Tablet_Max_Limit") = Val("0")
        Else
            tablet_row.Item("Tablet_Max_Limit") = Val(Me.lbl_limit2.Text)
        End If

        If Me.lbl_limit1_percentage.Text = "" Then
            tablet_row.Item("Tablet_Min_Limit_Percentage") = Val("0")
        Else
            tablet_row.Item("Tablet_Min_Limit_Percentage") = Val(Me.lbl_limit1_percentage.Text)
        End If
        If Me.lbl_limit2_percentage.Text = "" Then
            tablet_row.Item("Tablet_Max_Limit_Percentage") = Val("0")
        Else
            tablet_row.Item("Tablet_Max_Limit_Percentage") = Val(Me.lbl_limit2_percentage.Text)
        End If
        If Me.txt_found.Text = "" Then
            tablet_row.Item("Tablet_Found") = Val("0")
        Else
            tablet_row.Item("Tablet_Found") = Val(Me.txt_found.Text)
        End If
        If Me.lbl_label_claim_percentage.Text = "" Then
            tablet_row.Item("Tablet_Percentage_Label_Claim") = Val("0")
        Else
            tablet_row.Item("Tablet_Percentage_Label_Claim") = Val(Me.lbl_label_claim_percentage.Text)
        End If
        Return tablet_row
    End Function
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_record_number.Text = Str(pointer)
        Me.status_lbl_total_record.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count
    End Sub
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.cmb_batch_no.Text <> "" Then

                msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD ?", MsgBoxStyle.YesNo, "Edit Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    Call edit_ingredient()
                    MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                End If
            Else
                MsgBox("PLEASE SELECT BATCH_NO", MsgBoxStyle.Information, "Select Batch No")
                Me.cmb_batch_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub edit_ingredient()
        TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Batch_No") = Me.cmb_batch_no.Text
        If Me.cmb_ingredient_name.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Ingredient_Name") = "No Name"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Ingredient_Name") = Me.cmb_ingredient_name.Text
        End If

        If Me.lbl_label_claim.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Label_Claim") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Label_Claim") = Val(Me.lbl_label_claim.Text)
        End If

        If Me.lbl_limit1.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Min_Limit") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Min_Limit") = Val(Me.lbl_limit1.Text)
        End If

        If Me.lbl_limit2.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Max_Limit") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Max_Limit") = Val(Me.lbl_limit2.Text)
        End If

        If Me.lbl_label_claim_unit.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Unit") = "u"
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Unit") = Me.lbl_label_claim_unit.Text
        End If

        If Me.txt_found.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Found") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Found") = Val(Me.txt_found.Text)
        End If

        If Me.lbl_label_claim_percentage.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Percentage_Label_Claim") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Percentage_Label_Claim") = Val(Me.lbl_label_claim_percentage.Text)
        End If

        If Me.lbl_limit1_percentage.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Min_Limit_Percentage") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Min_Limit_Percentage") = Val(Me.lbl_limit1_percentage.Text)
        End If

        If Me.lbl_limit2_percentage.Text = "" Then
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Max_Limit_Percentage") = Val("0")
        Else
            TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Max_Limit_Percentage") = Val(Me.lbl_limit2_percentage.Text)
        End If

        Call TABLET_MODULE.tablet_updatedatabase_ingredient()
    End Sub
    Private Sub clear_all()
        Me.cmb_batch_no.Text = ""
        Me.cmb_ingredient_name.Text = ""
        Me.lbl_found_unit.Text = ""
        Me.lbl_label_claim.Text = ""
        Me.lbl_label_claim_percentage.Text = ""
        Me.lbl_label_claim_unit.Text = ""
        Me.lbl_limit_unit.Text = ""
        Me.lbl_limit1.Text = ""
        Me.lbl_limit1_percentage.Text = ""
        Me.lbl_limit2.Text = ""
        Me.lbl_limit2_percentage.Text = ""
        Me.txt_found.Text = ""
    End Sub
    Private Sub display_records(ByVal record As Integer)
        If record >= 0 Then
            Me.txt_found.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Found")
            Me.lbl_found_unit.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Unit")
            Me.lbl_label_claim.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Label_Claim")
            Me.lbl_label_claim_percentage.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Percentage_Label_Claim")
            Me.lbl_label_claim_unit.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Unit")
            Me.lbl_limit_unit.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Unit")
            Me.lbl_limit1.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Min_Limit")
            Me.lbl_limit1_percentage.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Min_Limit_Percentage")
            Me.lbl_limit2.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Max_Limit")
            Me.lbl_limit2_percentage.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Max_Limit_Percentage")
            Me.cmb_batch_no.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Batch_No")
            Me.cmb_ingredient_name.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(record).Item("Tablet_Ingredient_Name")
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count > 0 Then
            record = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count > 0 Then
            record = record + 1
            If record > TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count - 1 Then
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

    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        tablet_ingredient_grid.Show()
        Me.Hide()
    End Sub

    Private Sub cmb_ingredient_name_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ingredient_name.SelectedValueChanged
        Me.lbl_label_claim.Text = label_claim(Me.cmb_ingredient_name.SelectedIndex)
        Me.lbl_label_claim_unit.Text = unit(Me.cmb_ingredient_name.SelectedIndex)
        Me.lbl_limit_unit.Text = unit(Me.cmb_ingredient_name.SelectedIndex)
        Me.lbl_limit1.Text = min_limit(Me.cmb_ingredient_name.SelectedIndex)
        Me.lbl_limit1_percentage.Text = min_limit_percentage(Me.cmb_ingredient_name.SelectedIndex)
        Me.lbl_limit2.Text = max_limit(Me.cmb_ingredient_name.SelectedIndex)
        Me.lbl_limit2_percentage.Text = max_limit_percentage(Me.cmb_ingredient_name.SelectedIndex)
    End Sub

    Private Sub cmb_ingredient_name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_ingredient_name.TextChanged
        If Me.cmb_ingredient_name.Text = "" Then
            Me.lbl_label_claim.Text = ""
            Me.lbl_label_claim_unit.Text = ""
            Me.lbl_limit_unit.Text = ""
            Me.lbl_limit1.Text = ""
            Me.lbl_limit1_percentage.Text = ""
            Me.lbl_limit2.Text = ""
            Me.lbl_limit2_percentage.Text = ""
        End If
    End Sub
End Class