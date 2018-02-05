Public Class cream_ingredient
    Dim batch_no() As String
    Dim ingredient_name() As String
    Dim label_claim() As Double
    Dim limit1() As Double
    Dim limit2() As Double
    Dim limit1_percentage() As Double
    Dim limit2_percentage() As Double
    Dim label_claim_unit() As String
    Dim limit_unit() As String
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
    Private Sub btn_found_validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_found_validate.Click
        Dim min, max As Double
        If Me.txt_found.Text <> "" Then
            If Me.cmb_ingredient_name.Text <> "" Then
                'min=
                'max=
                If Val(Me.txt_found.Text) >= min And Val(Me.txt_found.Text) <= max Then
                    MsgBox("THE CORRESPONDING FOUND IS CORRECT", MsgBoxStyle.Information, "Correct Found")
                Else
                    MsgBox("THE CORRESPONDING FOUND IS INCORRECT", MsgBoxStyle.Information, "Incorrect Found")
                    Me.txt_found.Focus()
                End If
            Else
                MsgBox("ENTER INGREDIENT NAME", MsgBoxStyle.Information, "Ingredient Name")
                Me.cmb_ingredient_name.Focus()
            End If
        Else
            MsgBox("FOUND FIELD IS BLANK", MsgBoxStyle.Information, "Enter Found")
            Me.txt_found.Focus()
        End If
    End Sub
    Private Sub btn_label_claim_validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_label_claim_validate.Click
        Dim min, max, result As Double
        If Me.txt_found.Text <> "" Then
            If Me.cmb_ingredient_name.Text <> "" Then
                min = Val(Me.lbl_limit1_percentage.Text)
                max = Val(Me.lbl_limit2_percentage.Text)
                result = ((Val(Me.txt_found.Text) * 100) / (Val(Me.lbl_label_claim.Text)))
                Me.lbl_label_claim_percentage.Text = CStr(result)
            Else
                MsgBox("ENTER INGREDIENT NAME", MsgBoxStyle.Information, "Ingredient Name")
                Me.cmb_ingredient_name.Focus()
            End If
        Else
            MsgBox("FOUND FIELD IS BLANK", MsgBoxStyle.Information, "Enter Found")
            Me.txt_found.Focus()
        End If
    End Sub
    Private Sub cream_ingredient_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        CREAM_MODULE.cream_close_connection()
    End Sub
    Private Sub CREAM_ingredient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call INGREDIENT_MODULE.ingredient_open_connection()
        Call INGREDIENT_MODULE.ingredient_filldataset_nondescriptive()
        Call initialize_ingredient_arrays()
        Call INGREDIENT_MODULE.ingredient_close_connection()
        Call CREAM_MODULE.cream_open_connection()
        Call CREAM_MODULE.cream_filldataset_detail()
        For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
            batch_no(count) = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows(count).Item("Batch_No")
        Next
        Call display_statusbar(-1)
    End Sub
    Private Sub initialize_ingredient_arrays()
        Dim count As Integer
        ReDim ingredient_name(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVECRIPTIVE_INGREDIENT").Rows.Count)
        ReDim label_claim(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim label_claim_unit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim limit1(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim limit1_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim limit2(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim limit2_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim limit_unit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count
            ingredient_name(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_Name")
            label_claim(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Claim")
            limit1(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit1")
            limit1_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit1_Percentage")
            limit2(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit2")
            limit2_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit2_Percentage")
            label_claim_unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Unit")
            limit_unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit_Unit")
        Next
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.cmb_batch_no.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    add_row = add_ingredient()
                    CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Add(add_row)
                    record = CREAM_MODULE.cream_dataset.Tables("CREAM_DETAIL").Rows.Count - 1
                    Call CREAM_MODULE.cream_updatedatabase_ingredient()
                    Call display_statusbar(record)
                    MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                End If
            Else
                MsgBox("PLEASE SELECT BATCH NO", MsgBoxStyle.Information, "Select Batch No")
                Me.cmb_batch_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Function add_ingredient() As DataRow
        Dim add_row As DataRow
        add_row = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").NewRow()
        add_row.Item("Batch_No") = Me.cmb_batch_no.Text
        If Me.cmb_ingredient_name.Text = "" Then
            add_row.Item("Ingredient_Name") = "No Name"
        Else
            add_row.Item("Ingredient_Name") = Me.cmb_ingredient_name.Text
        End If
        If Me.lbl_label_claim.Text = "" Then
            add_row.Item("Label_Claim") = Val("0")
        Else
            add_row.Item("Label_Claim") = Val(Me.lbl_label_claim.Text)
        End If
        If Me.lbl_label_claim_unit.Text = "" Then
            add_row.Item("Label_Unit") = "mg"
        Else
            add_row.Item("Label_Unit") = Me.lbl_label_claim_unit.Text
        End If
        If Me.lbl_limit1.Text = "" Then
            add_row.Item("Limit1") = Val("0")
        Else
            add_row.Item("Limit1") = Val(Me.lbl_limit1.Text)
        End If
        If Me.lbl_limit2.Text = "" Then
            add_row.Item("Limit2") = Val("0")
        Else
            add_row.Item("Limit2") = Val(Me.lbl_limit2.Text)
        End If
        If Me.lbl_limit_unit.Text = "" Then
            add_row.Item("Limit_Unit") = "mg"
        Else
            add_row.Item("Limit_Unit") = Val(Me.lbl_limit1.Text)
        End If
        If Me.lbl_limit1_percentage.Text = "" Then
            add_row.Item("Limit1_Per") = Val("0")
        Else
            add_row.Item("Limit1_Per") = Val(Me.lbl_limit1_percentage.Text)
        End If
        If Me.lbl_limit2_percentage.Text = "" Then
            add_row.Item("Limit2_Per") = Val("0")
        Else
            add_row.Item("Limit2_Per") = Val(Me.lbl_limit2_percentage.Text)
        End If
        If Me.txt_found.Text = "" Then
            add_row.Item("Found") = Val("0")
        Else
            add_row.Item("Found") = Val(Me.txt_found.Text)
        End If
        If Me.lbl_label_claim_percentage.Text = "" Then
            add_row.Item("Per_Label") = Val("0")
        Else
            add_row.Item("Per_Label") = Val(Me.lbl_label_claim_percentage.Text)
        End If
        Return add_row
    End Function
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_recno.Text = Str(pointer)
        Me.status_lbl_totrec.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count
    End Sub
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.cmb_batch_no.Text <> "" Then

                msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD ?", MsgBoxStyle.YesNo, "Edit Confirmation")
                If msg_box = MsgBoxResult.Yes Then
                    Call edit_CREAM_ingredient()
                    MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                End If
            Else
                MsgBox("PLEASE SELECT BATCH NO", MsgBoxStyle.Information, "Select Batch No")
                Me.cmb_batch_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub edit_CREAM_ingredient()
        CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Batch_No") = Me.cmb_batch_no.Text
        If Me.cmb_ingredient_name.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Ingredient_Name") = "No Name"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Ingredient_Name") = Me.cmb_ingredient_name.Text
        End If
        If Me.lbl_label_claim.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Label_Claim") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Label_Claim") = Val(Me.lbl_label_claim.Text)
        End If

        If Me.lbl_limit1.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit1") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit1") = Val(Me.lbl_limit1.Text)
        End If

        If Me.lbl_limit2.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit2") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit2") = Val(Me.lbl_limit2.Text)
        End If

        If Me.lbl_label_claim_unit.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Label_Unit") = "mg"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Label_Unit") = Me.lbl_label_claim_unit.Text
        End If

        If Me.lbl_limit_unit.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit_Unit") = "mg"
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit_Unit") = Me.lbl_limit_unit.Text
        End If

        If Me.txt_found.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Found") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Found") = Val(Me.txt_found.Text)
        End If

        If Me.lbl_label_claim_percentage.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Percentage_Label") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Percentage_Label") = Val(Me.lbl_label_claim_percentage.Text)
        End If

        If Me.lbl_limit1_percentage.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit1_Percentage") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit1_Percentage") = Val(Me.lbl_limit1_percentage.Text)
        End If

        If Me.lbl_limit2_percentage.Text = "" Then
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit2_Percentage") = Val("0")
        Else
            CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit2_Percentage") = Val(Me.lbl_limit2_percentage.Text)
        End If

        Call CREAM_MODULE.cream_updatedatabase_ingredient()
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
            Me.txt_found.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Found")
            Me.lbl_found_unit.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit_Unit")
            Me.lbl_label_claim.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Label_Claim")
            Me.lbl_label_claim_percentage.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Percentage_Label")
            Me.lbl_label_claim_unit.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Label_Unit")
            Me.lbl_limit_unit.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit_Unit")
            Me.lbl_limit1.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit1")
            Me.lbl_limit1_percentage.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit1_Percentage")
            Me.lbl_limit2.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit2")
            Me.lbl_limit2_percentage.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Limit2_Percentage")
            Me.cmb_batch_no.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Batch_No")
            Me.cmb_ingredient_name.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows(record).Item("Ingredient_Name")
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count > 0 Then
            record = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count > 0 Then
            record = record + 1
            If record > CREAM_MODULE.cream_dataset.Tables("CREAM_INGREDIENT").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
        End If
    End Sub
    Private Sub tlstr_btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_clear.Click
        Me.txt_found.Text = ""
        Me.lbl_found_unit.Text = ""
        Me.lbl_label_claim.Text = ""
        Me.lbl_label_claim_percentage.Text = ""
        Me.lbl_label_claim_unit.Text = ""
        Me.lbl_limit_unit.Text = ""
        Me.lbl_limit1.Text = ""
        Me.lbl_limit1_percentage.Text = ""
        Me.lbl_limit2.Text = ""
        Me.lbl_limit2_percentage.Text = ""
        Me.cmb_batch_no.Text = ""
        Me.cmb_ingredient_name.Text = ""
    End Sub
    Private Sub tlstr_btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_close.Click
        Me.Close()
    End Sub
End Class