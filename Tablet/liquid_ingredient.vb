Public Class liquid_ingredient
    Dim record As Integer
    Dim batch_no() As String
    Dim non_descriptive_ingredient_name() As String
    Dim descriptive_ingredient_name() As String
    Dim non_descriptive_ingredient_type() As String
    Dim descriptive_ingredient_type() As String
    Dim non_descriptive_label_claim() As Double
    Dim descriptive_label_claim() As Double
    Dim non_descriptive_label_claim_unit() As String
    Dim descriptive_label_claim_unit() As String
    Dim non_descriptive_limit1() As Double
    Dim descriptive_limit() As Double
    Dim non_descriptive_limit2() As Double
    Dim non_descriptive_limit1_percentage() As Double
    Dim non_descriptive_limit2_percentage() As Double
    Dim descriptive_limit_unit() As String
    Dim non_descriptive_limit_unit() As String
    Dim descriptive_limit_percentage() As Double
    Private Sub liquid_ingredient_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call LIQUID_MODULE.liquid_open_connection()
        Call LIQUID_MODULE.liquid_filldataset_detail()
        ReDim batch_no(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count)
        For count = 0 To LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows.Count - 1
            batch_no(count) = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_DETAIL").Rows(count).Item("Batch_No")
        Next
        Me.cmb_descriptive_batch_no.Items.AddRange(batch_no)
        Me.cmb_non_batch_no.Items.AddRange(batch_no)
        Call initialize_arrays_nondescriptive()
        Call initialize_arrays_descriptive()
        Call LIQUID_MODULE.liquid_filldataset_ingredient()
        Call display_statusbar(-1, LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count, "DESCRIPTIVE")
    End Sub
    Private Sub initialize_arrays_nondescriptive()
        Dim count As Integer
        Call INGREDIENT_MODULE.ingredient_filldataset_nondescriptive()
        ReDim non_descriptive_ingredient_name(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_ingredient_type(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_label_claim(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_label_claim_unit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_limit1(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_limit2(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_limit1_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_limit2_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim non_descriptive_limit_unit(INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count)
        For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
            non_descriptive_ingredient_name(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_Name")
            non_descriptive_ingredient_type(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_Type")
            non_descriptive_label_claim(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Claim")
            non_descriptive_label_claim_unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Unit")
            non_descriptive_limit1(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit1")
            non_descriptive_limit2(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit2")
            non_descriptive_limit1_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit1_Percentage")
            non_descriptive_limit2_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit2_Percentage")
            non_descriptive_limit_unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit_Unit")
        Next
    End Sub
    Private Sub initialize_arrays_descriptive()
        Dim count As Integer
        ReDim descriptive_ingredient_name(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim descriptive_ingredient_type(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim descriptive_label_claim(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim descriptive_label_claim_unit(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim descriptive_limit(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim descriptive_limit_unit(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count)
        ReDim descriptive_limit_percentage(INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count)
        For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
            descriptive_ingredient_name(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_Name")
            descriptive_ingredient_type(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_Type")
            descriptive_label_claim(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Claim")
            descriptive_label_claim_unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Label_Unit")
            descriptive_limit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit")
            descriptive_limit_percentage(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit_Percentage")
            descriptive_limit_unit(count) = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Limit_Unit")
        Next
    End Sub
    Private Sub tlstr_btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_add.Click
        Dim msg_box As Integer
        Dim add_non_descriptive As DataRow
        Dim add_descriptive As DataRow
        Try
            If Me.tab_liquid_ingredient.SelectedTab Is Me.non_descriptive Then
                If Me.cmb_non_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO U WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        add_non_descriptive = add_ingredient()
                        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Add(add_non_descriptive)
                        LIQUID_MODULE.liquid_updatedatabase_ingredient()
                        MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "ADD A RECORD")
                        record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count - 1
                        Call display_statusbar(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count - 1, LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
                    End If
                Else
                    MsgBox("ENTER BATCH NUMBER", MsgBoxStyle.Information, "Batch No.")
                    Me.cmb_non_batch_no.Focus()
                End If
            ElseIf Me.tab_liquid_ingredient.SelectedTab Is Me.descriptive Then
                If Me.cmb_descriptive_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO U WANT TO ADD THIS RECORD ?", MsgBoxStyle.YesNo, "Add Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        add_descriptive = add_ingredient()
                        LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Add(add_descriptive)
                        LIQUID_MODULE.liquid_updatedatabase_ingredient()
                        MsgBox("RECORD IS INSERTED", MsgBoxStyle.Information, "Add a Record")
                        record = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count - 1
                        Call display_statusbar(LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count - 1, LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
                    End If
                Else
                    MsgBox("ENTER BATCH NUMBER", MsgBoxStyle.Information, "Batch No.")
                    Me.cmb_descriptive_batch_no.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Function add_ingredient() As DataRow
        Dim ingredient_row As DataRow
        ingredient_row = LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").NewRow()
        If Me.tab_liquid_ingredient.SelectedTab Is Me.non_descriptive Then
            ingredient_row.Item("Batch_No") = Me.cmb_non_batch_no.Text
            If Me.cmb_non_ingredient_name.Text = "" Then
                ingredient_row.Item("Ingredient_Name") = "No Name"
            Else
                ingredient_row.Item("Ingredient_Name") = Me.cmb_non_ingredient_name.Text
            End If
            If Me.lbl_non_ingredient_type.Text = "" Then
                ingredient_row.Item("Ingredient_Type") = "No Type"
            Else
                ingredient_row.Item("Ingredient_Type") = Me.lbl_non_ingredient_type.Text
            End If
            If Me.lbl_non_label_claim.Text = "" Then
                ingredient_row.Item("Label_Claim") = Val("0")
            Else
                ingredient_row.Item("Label_Claim") = Val(Me.lbl_non_label_claim.Text)
            End If
            If Me.lbl_non_limit1.Text = "" Or Me.lbl_non_limit2.Text = "" Then
                ingredient_row.Item("Limit") = "No Limit"
            Else
                ingredient_row.Item("Limit") = Me.lbl_non_limit1.Text & "-" & Me.lbl_non_limit2.Text
            End If
            If Me.lbl_non_limit1_per.Text = "" Or Me.lbl_non_limit2_per.Text = "" Then
                ingredient_row.Item("Limit_Per") = "No Limit"
            Else
                ingredient_row.Item("Limit_Per") = Me.lbl_non_limit1_per.Text & "-" & Me.lbl_non_limit2_per.Text
            End If
            If Me.txt_non_found.Text = "" Then
                ingredient_row.Item("Found") = Val("0")
            Else
                ingredient_row.Item("Found") = Val(Me.txt_non_found.Text)
            End If
            If Me.lbl_non_percentage_claim.Text = "" Then
                ingredient_row.Item("Per_Label") = Val("0")
            Else
                ingredient_row.Item("Per_Label") = Val(Me.lbl_non_percentage_claim.Text)
            End If

            If Me.lbl_non_limit_unit.Text = "" Then
                ingredient_row.Item("Limit_Unit") = "u"
            Else
                ingredient_row.Item("Limit_Unit") = Me.lbl_non_limit_unit.Text
            End If

            If Me.lbl_non_label_unit.Text = "" Then
                ingredient_row.Item("Label_Unit") = "u"
            Else
                ingredient_row.Item("Label_Unit") = Me.lbl_non_label_unit.Text
            End If
        ElseIf Me.tab_liquid_ingredient.SelectedTab Is Me.descriptive Then
            ingredient_row.Item("Batch_No") = Me.cmb_descriptive_batch_no.Text
            If Me.cmb_descriptive_ingredient_name.Text = "" Then
                ingredient_row.Item("Ingredient_Name") = "No Name"
            Else
                ingredient_row.Item("Ingredient_Name") = Me.cmb_descriptive_ingredient_name.Text
            End If
            If Me.lbl_descriptive_ingredient_type.Text = "" Then
                ingredient_row.Item("Ingredient_Type") = "No Type"
            Else
                ingredient_row.Item("Ingredient_Type") = Me.lbl_descriptive_ingredient_type.Text
            End If
            If Me.lbl_descriptive_label_claim.Text = "" Then
                ingredient_row.Item("Label_Claim") = Val("0")
            Else
                ingredient_row.Item("Label_Claim") = Val(Me.lbl_descriptive_label_claim.Text)
            End If
            If Me.lbl_descriptive_limit.Text = "" Then
                ingredient_row.Item("Limit") = "No Limit"
            Else
                ingredient_row.Item("Limit") = "Not less than" & Me.lbl_descriptive_limit.Text
            End If
            If Me.lbl_descriptive_limit_per.Text = "" Then
                ingredient_row.Item("Limit_Per") = "No Limit"
            Else
                ingredient_row.Item("Limit_Per") = "Not less than" & Me.lbl_descriptive_limit_per.Text
            End If
            If Me.txt_descriptive_found.Text = "" Then
                ingredient_row.Item("Found") = Val("0")
            Else
                ingredient_row.Item("Found") = Val(Me.txt_descriptive_found.Text)
            End If
            If Me.lbl_descriptive_percentage_claim.Text = "" Then
                ingredient_row.Item("Per_Label") = Val("0")
            Else
                ingredient_row.Item("Per_Label") = Val(Me.lbl_descriptive_percentage_claim.Text)
            End If

            If Me.lbl_descriptive_limit_unit.Text = "" Then
                ingredient_row.Item("Limit_Unit") = "u"
            Else
                ingredient_row.Item("Limit_Unit") = Me.lbl_descriptive_limit_unit.Text
            End If

            If Me.lbl_descriptive_label_unit.Text = "" Then
                ingredient_row.Item("Label_Unit") = "u"
            Else
                ingredient_row.Item("Label_Unit") = Me.lbl_descriptive_label_unit.Text
            End If
        End If
        Return ingredient_row
    End Function
    Private Sub display_statusbar(ByVal record_no As Integer, ByVal total_record As Integer, ByVal table_name As String)
        Dim pointer As Integer
        pointer = record_no + 1
        Me.status_lbl_record_number.Text = CStr(pointer)
        Me.status_lbl_total_record.Text = CStr(total_record)
        Me.status_lbl_table.Text = table_name
    End Sub
    Private Sub cmb_descriptive_ingredient_name_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_descriptive_ingredient_name.SelectedValueChanged
        Me.lbl_descriptive_label_claim.Text = CStr(descriptive_label_claim(Me.cmb_descriptive_ingredient_name.SelectedIndex))
        Me.lbl_descriptive_label_unit.Text = descriptive_label_claim_unit(Me.cmb_descriptive_ingredient_name.SelectedIndex)
        Me.lbl_descriptive_limit.Text = CStr(descriptive_limit(Me.cmb_descriptive_ingredient_name.SelectedIndex))
        Me.lbl_descriptive_limit_per.Text = CStr(descriptive_limit_percentage(Me.cmb_descriptive_ingredient_name.SelectedIndex))
        Me.lbl_descriptive_limit_unit.Text = descriptive_limit_unit(Me.cmb_descriptive_ingredient_name.SelectedIndex)
        Me.lbl_descriptive_found_unit.Text = descriptive_limit_unit(Me.cmb_descriptive_ingredient_name.SelectedIndex)
        Me.lbl_descriptive_ingredient_type.Text = descriptive_ingredient_type(Me.cmb_descriptive_ingredient_name.SelectedIndex)
    End Sub

    Private Sub cmb_descriptive_ingredient_name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_descriptive_ingredient_name.TextChanged
        If Me.cmb_descriptive_ingredient_name.Text = "" Then
            Me.lbl_descriptive_label_claim.Text = "0"
            Me.lbl_descriptive_label_unit.Text = "u"
            Me.lbl_descriptive_limit.Text = "0"
            Me.lbl_descriptive_limit_per.Text = "0"
            Me.lbl_descriptive_limit_unit.Text = "u"
            Me.lbl_descriptive_found_unit.Text = "u"
            Me.lbl_descriptive_ingredient_type.Text = "No Type"
        End If
    End Sub
    Private Sub cmb_non_ingredient_name_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_non_ingredient_name.SelectedValueChanged
        Me.lbl_non_ingredient_type.Text = non_descriptive_ingredient_type(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_label_claim.Text = non_descriptive_label_claim(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_label_unit.Text = non_descriptive_label_claim_unit(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_limit1.Text = non_descriptive_limit1(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_limit2.Text = non_descriptive_limit2(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_limit1_per.Text = non_descriptive_limit1_percentage(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_limit2_per.Text = non_descriptive_limit2_percentage(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_limit_unit.Text = non_descriptive_limit_unit(Me.cmb_non_ingredient_name.SelectedIndex)
        Me.lbl_non_found_unit.Text = non_descriptive_limit_unit(Me.cmb_non_ingredient_name.SelectedIndex)
    End Sub
    Private Sub cmb_non_ingredient_name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_non_ingredient_name.TextChanged
        If Me.cmb_non_ingredient_name.Text = "" Then
            Me.lbl_non_ingredient_type.Text = "No Type"
            Me.lbl_non_label_claim.Text = "0"
            Me.lbl_non_label_unit.Text = "u"
            Me.lbl_non_limit1.Text = "0"
            Me.lbl_non_limit2.Text = "0"
            Me.lbl_non_limit1_per.Text = "0"
            Me.lbl_non_limit2_per.Text = "0"
            Me.lbl_non_limit_unit.Text = "u"
            Me.lbl_non_found_unit.Text = "u"
        End If
    End Sub
    Private Sub tab_liquid_ingredient_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_liquid_ingredient.Click
        If Me.tab_liquid_ingredient.SelectedTab Is Me.non_descriptive Then
            Call display_statusbar(-1, LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count, "NON DESCRIPTIVE")
        ElseIf Me.tab_liquid_ingredient.SelectedTab Is Me.descriptive Then
            Call display_statusbar(-1, LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows.Count, "DESCRIPTIVE")
        End If
    End Sub
    Private Sub btn_descriptive_validate_claim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_descriptive_validate_claim.Click
        Dim per_claim As Double
        If Me.txt_descriptive_found.Text <> "" Then
            If descriptive_label_claim(Me.cmb_descriptive_ingredient_name.SelectedIndex) <> Val("0") Then
                per_claim = (Val(Me.txt_descriptive_found.Text) * 100) / (descriptive_label_claim(Me.cmb_descriptive_ingredient_name.SelectedIndex))
                Me.lbl_descriptive_percentage_claim.Text = CStr(per_claim)
            Else
                MsgBox("CHECK LABEL CLAIM IN DESCRIPTIVE INGREDIENT TABLE", MsgBoxStyle.Information, "Label Claim")
            End If

        Else
            MsgBox("FOUND FIELD IS BLANK", MsgBoxStyle.Information, "Found")
            Me.txt_descriptive_found.Focus()
        End If
    End Sub
    Private Sub btn_non_validate_claim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_non_validate_claim.Click
        Dim per_claim As Double
        If Me.txt_non_found.Text <> "" Then
            If non_descriptive_label_claim(Me.cmb_non_ingredient_name.SelectedIndex) <> Val("0") Then
                per_claim = (Val(Me.txt_non_found.Text) * 100) / (non_descriptive_label_claim(Me.cmb_descriptive_ingredient_name.SelectedIndex))
                Me.lbl_non_percentage_claim.Text = CStr(per_claim)
            Else
                MsgBox("CHECK LABEL CLAIM IN DESCRIPTIVE INGREDIENT TABLE", MsgBoxStyle.Information, "Label Claim")
            End If

        Else
            MsgBox("FOUND FIELD IS BLANK", MsgBoxStyle.Information, "Found")
            Me.txt_non_found.Focus()
        End If
    End Sub
    Private Sub tlstr_btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlstr_btn_edit.Click
        Dim msg_box As Integer
        Try
            If Me.tab_liquid_ingredient.SelectedTab Is Me.non_descriptive Then
                If Me.cmb_non_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD ?", MsgBoxStyle.YesNo, "Edit Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        Call edit_ingredient()
                        MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NUMBER", MsgBoxStyle.Information, "Ingredient No.")
                    Me.cmb_non_batch_no.Focus()
                End If
            ElseIf Me.tab_liquid_ingredient.SelectedTab Is Me.descriptive Then
                If Me.cmb_descriptive_batch_no.Text <> "" Then
                    msg_box = MsgBox("DO YOU WANT TO UPDATE THIS RECORD ?", MsgBoxStyle.YesNo, "Edit Confirmation")
                    If msg_box = MsgBoxResult.Yes Then
                        Call edit_ingredient()
                        MsgBox("RECORD IS UPDATED", MsgBoxStyle.Information, "Edit a Record")
                    End If
                Else
                    MsgBox("ENTER INGREDIENT NUMBER", MsgBoxStyle.Information, "Ingredient No.")
                    Me.cmb_descriptive_batch_no.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub edit_ingredient()
        If Me.tab_liquid_ingredient.SelectedTab Is Me.non_descriptive Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Batch_No") = Me.cmb_non_batch_no.Text
            If Me.cmb_non_ingredient_name.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Name") = "No Name"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Name") = Me.cmb_non_ingredient_name.Text
            End If
            If Me.lbl_non_ingredient_type.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Type") = "No Type"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Type") = Me.lbl_non_ingredient_type.Text
            End If
            If Me.lbl_non_label_claim.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Claim") = Val("0")
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Claim") = Val(Me.lbl_non_label_claim.Text)
            End If
            If Me.lbl_non_label_unit.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Unit") = "u"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Unit") = Me.lbl_non_label_unit.Text
            End If
            If Me.lbl_non_limit1.Text = "" Or Me.lbl_non_limit2.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit") = "No Limit"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit") = Me.lbl_non_limit1.Text & "-" & Me.lbl_non_limit2.Text
            End If
            If Me.lbl_non_limit1_per.Text = "" Or Me.lbl_non_limit2_per.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Per") = "No Limit"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Per") = Me.lbl_non_limit1_per.Text & "-" & Me.lbl_non_limit2_per.Text
            End If
            If Me.lbl_non_limit_unit.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Unit") = "u"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Unit") = Me.lbl_non_limit_unit.Text
            End If
            If Me.txt_non_found.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Found") = Val("0")
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Found") = Val(Me.txt_non_found.Text)
            End If
            If Me.lbl_non_percentage_claim.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Per_Label") = Val("0")
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Per_Label") = Val(Me.lbl_non_percentage_claim.Text)
            End If
        ElseIf Me.tab_liquid_ingredient.SelectedTab Is Me.descriptive Then
            LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Batch_No") = Me.cmb_descriptive_batch_no.Text
            If Me.cmb_descriptive_ingredient_name.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Name") = "No Name"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Name") = Me.cmb_descriptive_ingredient_name.Text
            End If
            If Me.lbl_descriptive_ingredient_type.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Type") = "No Type"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Ingredient_Type") = Me.lbl_descriptive_ingredient_type.Text
            End If
            If Me.lbl_descriptive_label_claim.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Claim") = Val("0")
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Claim") = Val(Me.lbl_descriptive_ingredient_type.Text)
            End If
            If Me.lbl_descriptive_label_unit.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Unit") = "u"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Label_Unit") = Me.lbl_descriptive_label_unit.Text
            End If
            If Me.lbl_descriptive_limit.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit") = "No Limit"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit") = "Not less than" & Me.lbl_descriptive_limit.Text
            End If
            If Me.lbl_descriptive_limit_per.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Per") = "No Limit"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Per") = "Not less than" & Me.lbl_descriptive_limit_per.Text
            End If
            If Me.lbl_descriptive_limit_unit.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Unit") = "u"
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Limit_Unit") = Me.lbl_descriptive_limit_unit.Text
            End If
            If Me.txt_descriptive_found.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Found") = Val("0")
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Found") = Val(Me.txt_descriptive_found.Text)
            End If
            If Me.lbl_descriptive_percentage_claim.Text = "" Then
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Per_Label") = Val("0")
            Else
                LIQUID_MODULE.liquid_dataset.Tables("LIQUID_INGREDIENT").Rows(record).Item("Per_Label") = Val(Me.lbl_descriptive_percentage_claim.Text)
            End If
        End If
    End Sub
    Private Sub liquid_ingredient_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        frm_mdi.Show()
    End Sub
End Class