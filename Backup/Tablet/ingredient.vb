Public Class ingredient
    Dim record As Integer
    Private Sub display_status_bar(ByVal record_no As Integer, ByVal total_record As Integer, ByVal table_name As String)
        Dim pointer As Integer
        pointer = record_no + 1
        Me.status_lbl_recno.Text = CStr(pointer)
        Me.status_lbl_totrec.Text = CStr(total_record)
        Me.status_lbl_table.Text = table_name
    End Sub
    Private Sub ingredient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        INGREDIENT_MODULE.ingredient_close_connection()
    End Sub
    Private Sub ingredient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call INGREDIENT_MODULE.ingredient_open_connection()
        Me.tab_ingredient.SelectTab(0)
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            Call INGREDIENT_MODULE.ingredient_filldataset_nondescriptive()
            Call display_status_bar(-1, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
        End If
        Me.conmenu_ingredient.Hide()
    End Sub
    Private Sub tab_ingredient_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_ingredient.Click
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            Call INGREDIENT_MODULE.ingredient_filldataset_nondescriptive()
            Call display_status_bar(-1, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            Call INGREDIENT_MODULE.ingredient_filldataset_descriptive()
            Call display_status_bar(-1, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
        End If
    End Sub
    Private Sub txt_descriptive_label_claim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descriptive_label_claim.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Label Claim")
        End If
    End Sub
    Private Sub txt_non_label_claim_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_non_label_claim.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Label Claim")
        End If
    End Sub
    Private Sub txt_descriptive_limit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descriptive_limit.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Limit")
        End If
    End Sub
    Private Sub txt_non_limit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_non_limit1.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Limit")
        End If
    End Sub
    Private Sub txt_non_limit2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_non_limit2.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> ".") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS ONLY", MsgBoxStyle.Information, "Limit")
        End If
    End Sub
    Private Sub cmb_descriptive_ingredient_type_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub cmb_non_ingredient_type_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub tlstr_btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_clear.Click
        Call clear_all()
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim msg_box As Integer
        Dim add_non_descriptive As DataRow
        Dim add_descriptive As DataRow
        Try
            If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
                If Me.txt_non_ingredient_no.Text <> "" Then
                    msg_box = MsgBox("DO U WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        add_non_descriptive = add_ingredient()
                        INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Add(add_non_descriptive)
                        INGREDIENT_MODULE.ingredient_updatabase_nondescriptive()
                        MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                        record = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                        Call display_status_bar(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGEDIENT")
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NUMBER", MsgBoxStyle.Information, "Ingredient Number")
                    Me.txt_non_ingredient_no.Focus()
                End If
            ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
                If Me.txt_descriptive_ingredient_no.Text <> "" Then
                    msg_box = MsgBox("DO U WANT TO ADD THIS RECORD", MsgBoxStyle.YesNo, "Add a Record")
                    If msg_box = MsgBoxResult.Yes Then
                        add_descriptive = add_ingredient()
                        INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Add(add_descriptive)
                        INGREDIENT_MODULE.ingredient_updatabase_descriptive()
                        MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                        record = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                        Call display_status_bar(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NUMBER", MsgBoxStyle.Information, "Ingredient No.")
                    Me.txt_descriptive_ingredient_no.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Function add_ingredient() As DataRow
        Dim ingredient_row As DataRow
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            ingredient_row = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").NewRow()
            ingredient_row.Item("Ingredient_No") = Me.txt_non_ingredient_no.Text
            If Me.txt_non_ingredient_name.Text = "" Then
                ingredient_row.Item("Ingredient_Name") = "No Name"
            Else
                ingredient_row.Item("Ingredient_Name") = Me.txt_non_ingredient_name.Text
            End If
            If Me.txt_non_label_claim.Text = "" Then
                ingredient_row.Item("Label_Claim") = Val("0")
            Else
                ingredient_row.Item("Label_Claim") = Val(Me.txt_non_label_claim.Text)
            End If
            If Me.txt_non_limit1.Text = "" Then
                ingredient_row.Item("Min_Limit") = Val("0")
            Else
                ingredient_row.Item("Min_Limit") = Val(Me.txt_non_limit1.Text)
            End If
            If Me.txt_non_limit2.Text = "" Then
                ingredient_row.Item("Max_Limit") = Val("0")
            Else
                ingredient_row.Item("Max_Limit") = Val(Me.txt_non_limit2.Text)
            End If
            If Me.lbl_non_limit1.Text = "" Then
                ingredient_row.Item("Min_Limit_Percentage") = Val("0")
            Else
                ingredient_row.Item("Min_Limit_Percentage") = Val(Me.lbl_non_limit1.Text)
            End If
            If Me.lbl_non_limit2.Text = "" Then
                ingredient_row.Item("Max_Limit_Percentage") = Val("0")
            Else
                ingredient_row.Item("Max_Limit_Percentage") = Val(Me.lbl_non_limit2.Text)
            End If
            If Me.txt_non_unit.Text = "" Then
                ingredient_row.Item("Unit") = "u"
            Else
                ingredient_row.Item("Unit") = Me.txt_non_unit.Text
            End If
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            ingredient_row = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").NewRow()
            ingredient_row.Item("Ingredient_No") = Me.txt_descriptive_ingredient_no.Text
            If Me.txt_descriptive_ingredient_name.Text = "" Then
                ingredient_row.Item("Ingredient_Name") = "No Name"
            Else
                ingredient_row.Item("Ingredient_Name") = Me.txt_descriptive_ingredient_name.Text
            End If
            If Me.txt_descriptive_label_claim.Text = "" Then
                ingredient_row.Item("Label_Claim") = Val("0")
            Else
                ingredient_row.Item("Label_Claim") = Val(Me.txt_descriptive_label_claim.Text)
            End If
            If Me.txt_descriptive_limit.Text = "" Then
                ingredient_row.Item("Limit") = Val("0")
            Else
                ingredient_row.Item("Limit") = Val(Me.txt_descriptive_limit.Text)
            End If
            If Me.lbl_descriptive_limit.Text = "" Then
                ingredient_row.Item("Limit_Percentage") = Val("0")
            Else
                ingredient_row.Item("Limit_Percentage") = Val(Me.lbl_descriptive_limit.Text)
            End If
            If Me.txt_descriptive_unit.Text = "" Then
                ingredient_row.Item("Unit") = "u"
            Else
                ingredient_row.Item("Unit") = Me.txt_descriptive_unit.Text
            End If
        End If
        Return ingredient_row
    End Function
    Private Sub txt_non_ingredient_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_non_ingredient_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "I") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND CAPITAL LETTER I ONLY", MsgBoxStyle.Information, "Ingredient No")
        End If
    End Sub
    Private Sub txt_descriptive_ingredient_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descriptive_ingredient_no.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "I") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND CAPITAL LETTER I ONLY", MsgBoxStyle.Information, "Ingredient No")
        End If
    End Sub
    Private Sub btn_non_per_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_non_per.Click
        Dim non_limit1 As Double
        Dim non_limit2 As Double
        If Me.txt_non_label_claim.Text <> "" Then
            If Me.txt_non_limit1.Text <> "" And Me.txt_non_limit2.Text <> "" Then
                non_limit1 = System.Math.Round((Val(Me.txt_non_limit1.Text) * 100) / Val(Me.txt_non_label_claim.Text), 2)
                Me.lbl_non_limit1.Text = CStr(non_limit1)
                non_limit2 = System.Math.Round((Val(Me.txt_non_limit2.Text) * 100) / Val(Me.txt_non_label_claim.Text), 2)
                Me.lbl_non_limit2.Text = CStr(non_limit2)
            Else
                MsgBox("EITHER OF LIMIT FIELD IS BLANK", MsgBoxStyle.Information, "Limit Percentage Validation")
            End If
        Else
            MsgBox("THE LABEL CLAIM IS BLANK", MsgBoxStyle.Information, "Label Claim Check")
            Me.txt_non_label_claim.Focus()
        End If
    End Sub
    Private Sub btn_descriptive_per_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_descriptive_per.Click
        Dim descriptive_limit As Double
        If Me.txt_descriptive_label_claim.Text <> "" Then
            If Me.txt_descriptive_limit.Text <> "" Then
                descriptive_limit = System.Math.Round((Val(Me.txt_descriptive_limit.Text) * 100) / Val(Me.txt_descriptive_label_claim.Text), 2)
                Me.lbl_descriptive_limit.Text = CStr(descriptive_limit)
            Else
                MsgBox("THE LIMIT FIELD IS BALNK", MsgBoxStyle.Information, "Limit Percentage Validation")
                Me.txt_descriptive_limit.Focus()
            End If
        Else
            MsgBox("THE LABEL CLAIM IS BLANK", MsgBoxStyle.Information, "Label Claim Check")
            Me.txt_descriptive_label_claim.Focus()
        End If
    End Sub
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
                If Me.txt_non_ingredient_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD ?", MsgBoxStyle.YesNo, "Edit Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        Call edit_ingredient()
                        MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NUMBER", MsgBoxStyle.Information, "Ingredient Number")
                    Me.txt_non_ingredient_no.Focus()
                End If
            ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
                If Me.txt_descriptive_ingredient_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD", MsgBoxStyle.YesNo, "Edit a record")
                    If msg_box = MsgBoxResult.Yes Then
                        Call edit_ingredient()
                        MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NUMBER", MsgBoxStyle.Information, "Ingredient No.")
                    Me.txt_descriptive_ingredient_no.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub edit_ingredient()
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Ingredient_No") = Me.txt_non_ingredient_no.Text
            If Me.txt_non_ingredient_name.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Ingredient_Name") = "No Name"
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Ingredient_Name") = Me.txt_non_ingredient_name.Text
            End If
            If Me.txt_non_label_claim.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Label_Claim") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Label_Claim") = Val(Me.txt_non_label_claim.Text)
            End If
            If Me.txt_non_limit1.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Min_Limit") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Min_Limit") = Val(Me.txt_non_limit1.Text)
            End If
            If Me.txt_non_limit2.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Max_Limit") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Max_Limit") = Val(Me.txt_non_limit2.Text)
            End If
            If Me.lbl_non_limit1.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Min_Limit_Percentage") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Min_Limit_Percentage") = Val(Me.lbl_non_limit1.Text)
            End If
            If Me.lbl_non_limit2.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Max_Limit_Percentage") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Max_Limit_Percentage") = Val(Me.lbl_non_limit2.Text)
            End If
            If Me.txt_non_unit.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Unit") = "u"
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(record).Item("Unit") = Me.txt_non_unit.Text
            End If

            Call INGREDIENT_MODULE.ingredient_updatabase_nondescriptive()
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Ingredient_No") = Me.txt_descriptive_ingredient_no.Text
            If Me.txt_descriptive_ingredient_name.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Ingredient_Name") = "No Name"
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Ingredient_Name") = Me.txt_descriptive_ingredient_name.Text
            End If
            If Me.txt_descriptive_label_claim.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Label_Claim") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Label_Claim") = Val(Me.txt_descriptive_label_claim.Text)
            End If
            If Me.txt_descriptive_limit.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Limit") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Limit") = Val(Me.txt_descriptive_limit.Text)
            End If
            If Me.lbl_descriptive_limit.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Limit_Percentage") = Val("0")
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Limit_Percentage") = Val(Me.lbl_descriptive_limit.Text)
            End If
            If Me.txt_descriptive_unit.Text = "" Then
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Unit") = "u"
            Else
                INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(record).Item("Unit") = Me.txt_descriptive_unit.Text
            End If

            Call INGREDIENT_MODULE.ingredient_updatabase_descriptive()
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = 0
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = 0
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        End If
    End Sub
    Private Sub display_records(ByVal rec As Integer)
        If rec >= 0 Then
            If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
                Me.txt_non_ingredient_no.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Ingredient_No")
                Me.txt_non_ingredient_name.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Ingredient_Name")
                Me.txt_non_label_claim.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Label_Claim")
                Me.txt_non_limit1.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Min_Limit")
                Me.txt_non_limit2.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Max_Limit")
                Me.lbl_non_limit1.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Min_Limit_Percentage")
                Me.lbl_non_limit2.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Max_Limit_Percentage")
                Me.txt_non_unit.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Unit")
                Me.lbl_non_limit_unit.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Unit")
            ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
                Me.txt_descriptive_ingredient_no.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Ingredient_No")
                Me.txt_descriptive_ingredient_name.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Ingredient_Name")
                Me.txt_descriptive_label_claim.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Label_Claim")
                Me.txt_descriptive_limit.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Limit")
                Me.lbl_descriptive_limit.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Limit_Percentage")
                Me.txt_descriptive_unit.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Unit")
                Me.lbl_descriptive_unit.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(rec).Item("Unit")
            End If
        Else
            Call clear_all()
        End If

    End Sub
    Private Sub clear_all()
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            Me.txt_non_ingredient_no.Text = ""
            Me.txt_non_ingredient_name.Text = ""
            Me.txt_non_label_claim.Text = ""
            Me.txt_non_limit1.Text = ""
            Me.txt_non_limit2.Text = ""
            Me.lbl_non_limit1.Text = ""
            Me.lbl_non_limit2.Text = ""
            Me.txt_non_unit.Text = ""
            Me.lbl_non_limit_unit.Text = ""
            Call display_status_bar(-1, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")

        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            Me.txt_descriptive_ingredient_no.Text = ""
            Me.txt_descriptive_ingredient_name.Text = ""
            Me.txt_descriptive_label_claim.Text = ""
            Me.txt_descriptive_limit.Text = ""
            Me.lbl_descriptive_limit.Text = ""
            Me.txt_descriptive_unit.Text = ""
            Me.lbl_descriptive_unit.Text = ""
            Call display_status_bar(-1, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = record - 1
                If record < 0 Then
                    record = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                End If
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = record - 1
                If record < 0 Then
                    record = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                End If
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = record + 1
                If record > INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1 Then
                    record = 0
                End If
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            If INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count > 0 Then
                record = record + 1
                If record > (INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1) Then
                    record = 0
                End If
                Call display_records(record)
                Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
            Else
                MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "No Records")
            End If
        End If
    End Sub
    Private Sub tlstr_btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_search.Click
        Dim search_string As String, count As Integer, flag As Boolean
        Try
            search_string = InputBox("ENTER INGREDIENT_NO", "SEARCH A RECORD", "NOSTRING")
            If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
                For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                    If search_string.ToUpper = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_No") Then
                        flag = True
                        record = count
                        Call display_records(record)
                        Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
                        Exit For
                    Else
                        flag = False
                    End If
                Next
                If flag = False Then
                    MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Enter Correct Non Descriptive Ingredient No.")
                End If

            ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
                For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                    If search_string.ToUpper = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_No") Then
                        flag = True
                        record = count
                        Call display_records(record)
                        Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
                        Exit For
                    Else
                        flag = False
                    End If
                Next
                If flag = False Then
                    MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Enter Correct Descriptive Ingredient No.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_delete.Click
        Dim count As Integer, flag As Boolean, msg_box As Integer
        Try
            If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
                If Me.txt_non_ingredient_no.Text <> "" Then
                    For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                        If Me.txt_non_ingredient_no.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_No") Then
                            flag = True
                            Exit For
                        Else
                            flag = False
                        End If
                    Next
                    If flag = False Then
                        MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Incorrect Non Descriptive Ingredient No.")
                    Else
                        msg_box = MsgBox("ARE U SURE YOU WANT TO DELETE THIS RECORD ?", MsgBoxStyle.YesNo, "Delete Confirmation")
                        If msg_box = MsgBoxResult.Yes Then
                            INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Delete()
                            Call INGREDIENT_MODULE.ingredient_updatabase_nondescriptive()
                            MsgBox("RECORD IS DELETED", MsgBoxStyle.Information, "Delete a Record")
                            record = count - 1
                            Call display_records(record)
                            Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
                        End If
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NO", MsgBoxStyle.Information, "Ingredient No.")
                    Me.txt_non_ingredient_no.Focus()
                End If
            ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
                If Me.txt_descriptive_ingredient_no.Text <> "" Then
                    For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                        If Me.txt_descriptive_ingredient_no.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_No") Then
                            flag = True
                            Exit For
                        Else
                            flag = False
                        End If
                    Next
                    If flag = False Then
                        MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Enter Correct Descriptive Ingredient No.")
                    Else
                        msg_box = MsgBox("ARE U SURE YOU WANT TO DELETE THIS RECORD ?", MsgBoxStyle.YesNo, "Delete Confirmation")
                        If msg_box = MsgBoxResult.Yes Then
                            INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Delete()
                            Call INGREDIENT_MODULE.ingredient_updatabase_descriptive()
                            MsgBox("RECORD IS DELETED", MsgBoxStyle.Information, "Delete a Record")
                            record = count - 1
                            If record < 0 Then
                                record = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                            End If
                            Call display_records(record)
                            Call display_status_bar(record, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
                        End If
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NO", MsgBoxStyle.Information, "Ingredient No.")
                    Me.txt_descriptive_ingredient_no.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub tlstr_btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_list.Click
        If Me.tab_ingredient.SelectedTab Is Me.tab_non_descriptive Then
            ingredient_list.grd_ingredient.DataSource = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT")
            ingredient_list_show = True
        ElseIf Me.tab_ingredient.SelectedTab Is Me.tab_descriptive Then
            ingredient_list.grd_ingredient.DataSource = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT")
            ingredient_list_show = False
        End If
        ingredient_list.Show()
        Me.Hide()
    End Sub
End Class