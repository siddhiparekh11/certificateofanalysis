Public Class sop_detail
    Dim sop_name() As String
    Private Sub sop_detail_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call sop_module.sop_close_connection()
        frm_mdi.Show()
    End Sub
    Private Sub sop_detail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim count As Integer
        Call sop_module.sop_open_connection()
        Call sop_module.sop_fill_dataset_master()
        ReDim sop_name(sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count)
        For count = 0 To sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count - 1
            Me.cmb_sop_no.Items.Add(sop_module.sop_dataset.Tables("SOP_MASTER").Rows(count).Item("Sop_No"))
            sop_name(count) = sop_module.sop_dataset.Tables("SOP_MASTER").Rows(count).Item("Sop_Name")
        Next
        Call sop_module.sop_fill_dataset_detail()
        Call initialize_grid_columns()
        Me.conmenu_sop_detail.Hide()
        Call display_statusbar(-1)
    End Sub

    Private Sub cmb_sop_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_sop_no.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmb_sop_no_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_sop_no.SelectedValueChanged
        Me.txt_sop_count.Text = Me.cmb_sop_no.Text & "/"
        Me.txt_sop_supersedes.Text = Me.cmb_sop_no.Text & "/"
        Me.lbl_sop_name.Text = sop_name(Me.cmb_sop_no.SelectedIndex)
    End Sub
    Private Sub cmb_sop_no_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_sop_no.TextChanged
        If Me.cmb_sop_no.Text = "" Then
            Me.txt_sop_supersedes.Text = ""
            Me.txt_sop_count.Text = ""
            Me.lbl_sop_name.Text = ""
        End If
    End Sub
    Private Sub display_statusbar(ByVal pointer As Integer)
        Me.status_lbl_record_number.Text = CStr(pointer + 1)
        Me.status_lbl_total_record.Text = CStr(sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count)
    End Sub
    Private Sub initialize_grid_columns()
        Me.grd_sop_detail.AutoGenerateColumns = False
        Me.grd_sop_detail.DataSource = sop_module.sop_dataset.Tables("SOP_DETAIL")
        Me.sop_no.DataPropertyName = "Sop_No"
        Me.sop_count.DataPropertyName = "Sop_Count"
        Me.sop_supersedes.DataPropertyName = "Sop_Supersedes"
        Me.issue_date.DataPropertyName = "Issue_Date"
        Me.review_date.DataPropertyName = "Review_Date"
        Me.effective_date.DataPropertyName = "Effective_Date"
    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim sop_row As DataRow, current_cell As Integer
        Try
            If Me.cmb_sop_no.Text = "" Then
                MsgBox("ENTER SOP NUMBER ", MsgBoxStyle.Information, "ADD A RECORD")
                Me.cmb_sop_no.Focus()
            Else
                sop_row = sop_module.sop_dataset.Tables("SOP_DETAIL").NewRow()
                sop_row.Item("Sop_No") = Me.cmb_sop_no.Text
                If Me.txt_sop_count.Text = "" Then
                    sop_row.Item("Sop_Count") = "No Number"
                Else
                    sop_row.Item("Sop_Count") = Me.txt_sop_count.Text
                End If
                If Me.txt_sop_count.Text = "" Then
                    sop_row.Item("Sop_Supersedes") = "No Number"
                Else
                    sop_row.Item("Sop_Supersedes") = Me.txt_sop_supersedes.Text
                End If
                sop_row.Item("Issue_Date") = Me.dtp_issue.Value
                sop_row.Item("Effective_Date") = Me.dtp_effective.Value
                sop_row.Item("Review_Date") = Me.dtp_review.Value
                sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Add(sop_row)
                current_cell = Me.grd_sop_detail.Rows.Count - 1
                Call display_statusbar(current_cell)
                Me.grd_sop_detail.CurrentCell = Me.grd_sop_detail.Rows(current_cell).Cells(0)
                Call sop_module.sop_update_database_detail()
                MsgBox("RECORD IS ADDED")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim current_row, msg_box As Integer
        Try
            current_row = Me.grd_sop_detail.CurrentRow.Index
            If Me.cmb_sop_no.Text <> "" Then
                msg_box = MsgBox("DO U WANT TO UPDATE THE CURRENT RECORD", MsgBoxStyle.YesNo)
                If msg_box = MsgBoxResult.Yes Then
                    sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Sop_No") = Me.cmb_sop_no.Text
                    If Me.txt_sop_count.Text = "" Then
                        sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Sop_Count") = "No Number"
                    Else
                        sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Sop_Count") = Me.txt_sop_count.Text
                    End If
                    If Me.txt_sop_supersedes.Text = "" Then
                        sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Sop_Supersedes") = "No Number"
                    Else
                        sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Sop_Supersedes") = Me.txt_sop_supersedes.Text
                    End If
                    sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Issue_Date") = Me.dtp_issue.Value
                    sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Review_Date") = Me.dtp_review.Value
                    sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Item("Effective_Date") = Me.dtp_effective.Value
                    Call sop_module.sop_update_database_detail()
                    MsgBox("RECORD IS UPDATED")
                End If
            Else
                MsgBox("ENTER SOP NUMBER", MsgBoxStyle.Information, "EDIT A RECORD")
                Me.cmb_sop_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString.ToUpper)
        End Try
    End Sub

    Private Sub grd_sop_detail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_sop_detail.Click
        Call display()
    End Sub
    Private Sub display()
        If Me.grd_sop_detail.RowCount >= 0 Then
            Me.cmb_sop_no.Text = Me.grd_sop_detail.CurrentRow.Cells(0).Value
            Me.txt_sop_count.Text = Me.grd_sop_detail.CurrentRow.Cells(1).Value
            Me.txt_sop_supersedes.Text = Me.grd_sop_detail.CurrentRow.Cells(2).Value
            Me.dtp_issue.Value = Me.grd_sop_detail.CurrentRow.Cells(3).Value
            Me.dtp_effective.Value = Me.grd_sop_detail.CurrentRow.Cells(4).Value
            Me.dtp_review.Value = Me.grd_sop_detail.CurrentRow.Cells(5).Value
            Call display_statusbar(Me.grd_sop_detail.CurrentRow.Index)
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)
        End If

    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim current_row, msg_box As Integer
        Try
            current_row = Me.grd_sop_detail.CurrentRow.Index
            msg_box = MsgBox("DO U WANT TO DELETE THE CURRENT RECORD", MsgBoxStyle.YesNo)
            If msg_box = MsgBoxResult.Yes Then
                sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(current_row).Delete()
                Call sop_module.sop_update_database_detail()
                MsgBox("RECORD IS DELETED")
                Call display_statusbar(current_row - 1)
                Call clear_all()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        Dim s As String
        Dim count As Integer, flag As Boolean
        s = UCase(InputBox("ENTER SOP_COUNT", "SEARCH", "nostring"))
       For count = 0 To sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count - 1
            If s = sop_module.sop_dataset.Tables("SOP_DETAIL").Rows(count).Item("Sop_Count") Then
                flag = True
                Me.grd_sop_detail.Rows(count).Selected = True
                Me.grd_sop_detail.CurrentCell = Me.grd_sop_detail.SelectedCells(0)
                Call display_statusbar(count)
                Call display()
            End If
        Next
        If flag = False Then
            MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "SEARCH A RECORD")
        End If

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Try
            Call clear_all()
            If sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count - 1 >= 0 Then
                Me.grd_sop_detail.CurrentCell = Me.grd_sop_detail.Rows(0).Cells(0)
                Call display_statusbar(Me.grd_sop_detail.CurrentRow.Index)
            End If
            Me.cmb_sop_no.Focus()
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try

    End Sub
    Private Sub clear_all()
        Me.cmb_sop_no.Text = ""
        Me.dtp_issue.Value = Date.Now
        Me.dtp_review.Value = Date.Now
        Me.dtp_effective.Value = Date.Now
    End Sub

    
    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count > 0 Then
            Me.grd_sop_detail.Rows(0).Selected = True
            Me.grd_sop_detail.CurrentCell = Me.grd_sop_detail.SelectedCells(0)
            Call display_statusbar(0)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count > 0 Then
            Me.grd_sop_detail .Rows(Me.grd_sop_detail.RowCount - 1).Selected = True
            Me.grd_sop_detail.CurrentCell = Me.grd_sop_detail.SelectedCells(0)
            Call display_statusbar(Me.grd_sop_detail.RowCount - 1)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count > 0 Then
            If Me.grd_sop_detail.CurrentRow.Index = 0 Then
                Me.grd_sop_detail.Rows(Me.grd_sop_detail.RowCount - 1).Selected = True
            Else
                Me.grd_sop_detail.Rows(Me.grd_sop_detail.CurrentRow.Index - 1).Selected = True
            End If
            Me.grd_sop_detail.CurrentCell = Me.grd_sop_detail.SelectedCells(0)
            Call display_statusbar(Me.grd_sop_detail.CurrentRow.Index)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If sop_module.sop_dataset.Tables("SOP_DETAIL").Rows.Count > 0 Then
            If Me.grd_sop_detail.CurrentRow.Index = Me.grd_sop_detail.RowCount - 1 Then
                Me.grd_sop_detail.Rows(0).Selected = True
            Else
                Me.grd_sop_detail.Rows(Me.grd_sop_detail.CurrentRow.Index + 1).Selected = True
            End If
            Me.grd_sop_detail.CurrentCell = Me.grd_sop_detail.SelectedCells(0)
            Call display_statusbar(Me.grd_sop_detail.CurrentRow.Index)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)

        End If
    End Sub
End Class