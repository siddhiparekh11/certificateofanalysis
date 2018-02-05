Public Class ingredient_list
    Private Sub txt_ingredient_list_search_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ingredient_list_search.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And (e.KeyChar <> vbBack) And (e.KeyChar <> "I") Then
            e.KeyChar = ""
            MsgBox("ENTER DIGITS AND CAPITAL LETTER I ONLY", MsgBoxStyle.Information, "Check Ingredient No")
        End If
    End Sub
    Private Sub btn_list_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_list_go.Click
        Dim count As Integer, flag As Boolean
        Try
            If Me.txt_ingredient_list_search.Text <> "" Then
                If ingredient_list_show = True Then
                    For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                        If Me.txt_ingredient_list_search.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_No") Then
                            Me.grd_ingredient.Rows(count).Selected = True
                            Me.grd_ingredient.CurrentCell = Me.grd_ingredient.SelectedCells(0)
                            flag = True
                        End If
                    Next
                    If flag = False Then
                        MsgBox("NO RECORD FOUND", MsgBoxStyle.Information, "Enter Correct Ingredient No.")
                        If INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count - 1 >= 0 Then
                            Me.grd_ingredient.Rows(0).Selected = True
                            Me.grd_ingredient.CurrentCell = Me.grd_ingredient.SelectedCells(0)
                        End If
                    End If
                ElseIf ingredient_list_show = False Then

                    For count = 0 To INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1
                        If Me.txt_ingredient_list_search.Text = INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows(count).Item("Ingredient_No") Then
                            Me.grd_ingredient.Rows(count).Selected = True
                            Me.grd_ingredient.CurrentCell = Me.grd_ingredient.SelectedCells(0)
                            flag = True
                        End If
                    Next
                    If flag = False Then
                        MsgBox("NO RECORD FOUND", MsgBoxStyle.Information, "Enter Correct Ingredient No.")
                        Me.txt_ingredient_list_search.Text = ""
                        If INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count - 1 >= 0 Then
                            Me.grd_ingredient.Rows(0).Selected = True
                            Me.grd_ingredient.CurrentCell = Me.grd_ingredient.SelectedCells(0)
                        End If
                    End If
                End If
            Else
                MsgBox("ENTER INGREDIENT NUMBER", MsgBoxStyle.Information, "Ingredient No.")
                Me.txt_ingredient_list_search.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub grd_ingredient_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_ingredient.Click
        If ingredient_list_show = True Then
            Call display_status_bar(Me.grd_ingredient.CurrentRow.Index, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
        ElseIf ingredient_list_show = False Then
            Call display_status_bar(Me.grd_ingredient.CurrentRow.Index, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
        End If
    End Sub
    Private Sub display_status_bar(ByVal record_no As Integer, ByVal total_record As Integer, ByVal table_name As String)
        Dim pointer As Integer
        pointer = record_no + 1
        Me.status_lbl_recno.Text = CStr(pointer)
        Me.status_lbl_totrec.Text = CStr(total_record)
        Me.status_lbl_table.Text = table_name
    End Sub
    Private Sub ingredient_list_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ingredient.Show()
    End Sub
    Private Sub ingredient_list_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If ingredient_list_show = True Then
            Call display_status_bar(-1, INGREDIENT_MODULE.ingredient_dataset.Tables("NON_DESCRIPTIVE_INGREDIENT").Rows.Count, "NON_DESCRIPTIVE_INGREDIENT")
        Else
            Call display_status_bar(-1, INGREDIENT_MODULE.ingredient_dataset.Tables("DESCRIPTIVE_INGREDIENT").Rows.Count, "DESCRIPTIVE_INGREDIENT")
        End If
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class