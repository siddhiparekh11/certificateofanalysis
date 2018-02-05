Imports System.Math
Public Class powder_ingredient
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
    Private Sub btn_found_validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_found_validate.Click
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
    Private Sub btn_label_claim_validate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_label_claim_validate.Click
        Dim min, max, result As Double
        If Me.txt_found.Text <> "" Then
            If Me.cmb_ingredient_name.Text <> "" Then
                min = Val(Me.lbl_limit1_percentage.Text)
                max = Val(Me.lbl_limit2_percentage.Text)
                result = round(((Val(Me.txt_found.Text) * 100) / (Val(Me.lbl_label_claim.Text))), 2)
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

    Private Sub powder_ingredient_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        POWDER_MODULE.powder_close_connection()
    End Sub

    Private Sub POWDER_ingredient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call INGREDIENT_MODULE.ingredient_open_connection()
        Call INGREDIENT_MODULE.ingredient_filldataset_nondescriptive()
        Call initialize_ingredient_arrays()
        Call INGREDIENT_MODULE.ingredient_close_connection()
        Call POWDER_MODULE.powder_open_connection()
        Call POWDER_MODULE.powder_filldataset_detail()
        For count = 0 To POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows.Count - 1
            batch_no(count) = POWDER_MODULE.powder_dataset.Tables("POWDER_DETAIL").Rows(count).Item("Powder_Batch_No")
        Next
        Call display_statusbar(-1)
    End Sub
    Private Sub initialize_ingredient_arrays()
        Dim count As Integer
        ReDim ingredient_name(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVECRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim label_claim(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim unit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim min_limit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim min_limit_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim max_limit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        ReDim max_limit_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1)
        For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
            ingredient_name(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_Name")
            label_claim(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Claim")
            min_limit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Min_Limit")
            min_limit_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Min_Limit_Percentage")
            max_limit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Max_Limit")
            max_limit_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Max_Limit_Percentage")
            unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Unit")
        Next
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim add_row As DataRow
        Dim msg_box As Integer
        Try
            If Me.cmb_batch_no.Text <> "" Then
                msg_box = MsgBox("DO YOU WANT TO ADD THIS RECORD", MsgBoxStyle.YesNo, "Add a Record")
                If msg_box = MsgBoxResult.Yes Then
                    add_row = add_ingredient()
                    POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Add(add_row)
                    record = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count - 1
                    Call POWDER_MODULE.powder_updatedatabase_ingredient()
                    Call display_statusbar(record)
                    MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                End If
            Else
                MsgBox("PLEASE SELECT BATCH_NO", MsgBoxStyle.Information, "Batch NO")
                Me.cmb_batch_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Function add_ingredient() As DataRow
        Dim add_row As DataRow
        add_row = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").NewRow()
        add_row.Item("Powder_Batch_No") = Me.cmb_batch_no.Text
        If Me.cmb_ingredient_name.Text = "" Then
            add_row.Item("Powder_Ingredient_Name") = "No Name"
        Else
            add_row.Item("Powder_Ingredient_Name") = Me.cmb_ingredient_name.Text
        End If
        If Me.lbl_label_claim.Text = "" Then
            add_row.Item("Powder_Label_Claim") = Val("0")
        Else
            add_row.Item("Powder_Label_Claim") = Val(Me.lbl_label_claim.Text)
        End If
        If Me.lbl_label_claim_unit.Text = "" Then
            add_row.Item("Powder_Unit") = "u"
        Else
            add_row.Item("Powder_Unit") = Me.lbl_label_claim_unit.Text
        End If
        If Me.lbl_limit1.Text = "" Then
            add_row.Item("Powder_Min_Limit") = Val("0")
        Else
            add_row.Item("Powder_Min_Limit") = Val(Me.lbl_limit1.Text)
        End If
        If Me.lbl_limit2.Text = "" Then
            add_row.Item("Powder_Max_Limit") = Val("0")
        Else
            add_row.Item("Powder_Max_Limit") = Val(Me.lbl_limit2.Text)
        End If
        If Me.lbl_limit1_percentage.Text = "" Then
            add_row.Item("Powder_Min_Limit_Percentage") = Val("0")
        Else
            add_row.Item("Powder_Min_Limit_Percentage") = Val(Me.lbl_limit1_percentage.Text)
        End If
        If Me.lbl_limit2_percentage.Text = "" Then
            add_row.Item("Powder_Max_Limit_Percentage") = Val("0")
        Else
            add_row.Item("Powder_Max_Limit_Percentage") = Val(Me.lbl_limit2_percentage.Text)
        End If
        If Me.txt_found.Text = "" Then
            add_row.Item("Powder_Found") = Val("0")
        Else
            add_row.Item("Powder_Found") = Val(Me.txt_found.Text)
        End If
        If Me.lbl_label_claim_percentage.Text = "" Then
            add_row.Item("Powder_Percentage_Label_Claim") = Val("0")
        Else
            add_row.Item("Powder_Percentage_Label_Claim") = Val(Me.lbl_label_claim_percentage.Text)
        End If
        Return add_row
    End Function
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_recno.Text = Str(pointer)
        Me.status_lbl_totrec.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count
    End Sub
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.cmb_batch_no.Text <> "" Then

                msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD", MsgBoxStyle.YesNo, "EDIT A RECORD")
                If msg_box = MsgBoxResult.Yes Then
                    Call edit_ingredient()
                    MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "EDIT A RECORD")
                End If
            Else
                MsgBox("PLEASE SELECT BATCH_NO", MsgBoxStyle.Information, "BATCH_NO CHECK")
                Me.cmb_batch_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub edit_ingredient()
        POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Batch_No") = Me.cmb_batch_no.Text
        If Me.cmb_ingredient_name.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Ingredient_Name") = "No Name"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Ingredient_Name") = Me.cmb_ingredient_name.Text
        End If
        If Me.lbl_label_claim.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Label_Claim") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Label_Claim") = Val(Me.lbl_label_claim.Text)
        End If

        If Me.lbl_limit1.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Min_Limit") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Min_Limit") = Val(Me.lbl_limit1.Text)
        End If

        If Me.lbl_limit2.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Max_Limit") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Max_Limit") = Val(Me.lbl_limit2.Text)
        End If

        If Me.lbl_label_claim_unit.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Unit") = "u"
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Unit") = Me.lbl_label_claim_unit.Text
        End If

        If Me.txt_found.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Found") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Found") = Val(Me.txt_found.Text)
        End If

        If Me.lbl_label_claim_percentage.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Percentage_Label_Claim") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Percentage_Label_Claim") = Val(Me.lbl_label_claim_percentage.Text)
        End If

        If Me.lbl_limit1_percentage.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Min_Limit_Percentage") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Min_Limit_Percentage") = Val(Me.lbl_limit1_percentage.Text)
        End If

        If Me.lbl_limit2_percentage.Text = "" Then
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Max_Limit_Percentage") = Val("0")
        Else
            POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Max_Limit_Percentage") = Val(Me.lbl_limit2_percentage.Text)
        End If

        Call POWDER_MODULE.powder_updatedatabase_ingredient()
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
            Me.txt_found.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Found")
            Me.lbl_found_unit.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Unit")
            Me.lbl_label_claim.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Label_Claim")
            Me.lbl_label_claim_percentage.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Percentage_Label_Claim")
            Me.lbl_label_claim_unit.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Unit")
            Me.lbl_limit_unit.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Unit")
            Me.lbl_limit1.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Min_Limit")
            Me.lbl_limit1_percentage.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Min_Limit_Percentage")
            Me.lbl_limit2.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Max_Limit")
            Me.lbl_limit2_percentage.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Max_Limit_Percentage")
            Me.cmb_batch_no.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Batch_No")
            Me.cmb_ingredient_name.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows(record).Item("Powder_Ingredient_Name")
        Else
            Call clear_all()
        End If
    End Sub
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count > 0 Then
            record = 0
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count > 0 Then
            record = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count - 1
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count > 0 Then
            record = record - 1
            If record < 0 Then
                record = POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count - 1
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
        End If
    End Sub
    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count > 0 Then
            record = record + 1
            If record > POWDER_MODULE.powder_dataset.Tables("POWDER_INGREDIENT").Rows.Count - 1 Then
                record = 0
            End If
            Call display_records(record)
            Call display_statusbar(record)
        Else
            MsgBox("THERE ARE NO RECORDS IN THE DATABASE", MsgBoxStyle.Information, "NO RECORDS")
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