Public Class sop_master

    Private Sub sop_master_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call sop_module.sop_close_connection()
        frm_mdi.Show()
    End Sub

    Private Sub sop_master_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call sop_module.sop_open_connection()
        Call sop_module.sop_fill_dataset_master()
        Me.grd_sop_master.DataSource = sop_module.sop_dataset.Tables("SOP_MASTER")
        Me.grd_sop_master.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.conmenu_sop_master.Hide()
        Call display_statusbar(-1)
    End Sub
    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim sop_row As DataRow, current_cell As Integer
        Try
            If Me.txt_sop_no.Text = "" Then
                MsgBox("ENTER SOP NUMBER ", MsgBoxStyle.Information, "ADD A RECORD")
                Me.txt_sop_no.Focus()
            Else
                sop_row = sop_module.sop_dataset.Tables("SOP_MASTER").NewRow()
                sop_row.Item("Sop_No") = Me.txt_sop_no.Text
                sop_row.Item("Sop_Name") = Me.txt_sop_name.Text
                sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Add(sop_row)
                current_cell = Me.grd_sop_master.Rows.Count - 1
                Call display_statusbar(current_cell)
                Me.grd_sop_master.CurrentCell = Me.grd_sop_master.Rows(current_cell).Cells(0)
                Call sop_module.sop_update_database_master()
                MsgBox("RECORD IS ADDED")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub display_statusbar(ByVal pointer As Integer)
        Me.status_record_number.Text = CStr(pointer + 1)
        Me.status_total_records.Text = CStr(sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count)
    End Sub
    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        Dim current_row, msg_box As Integer
        Try
            current_row = Me.grd_sop_master.CurrentRow.Index
            If Me.txt_sop_no.Text <> "" Then
                msg_box = MsgBox("DO U WANT TO UPDATE THE CURRENT RECORD", MsgBoxStyle.YesNo)
                If msg_box = MsgBoxResult.Yes Then
                    sop_module.sop_dataset.Tables("SOP_MASTER").Rows(current_row).Item("Sop_No") = Me.txt_sop_no.Text
                    sop_module.sop_dataset.Tables("SOP_MASTER").Rows(current_row).Item("Sop_Name") = Me.txt_sop_name.Text
                    Call sop_module.sop_update_database_master()
                    MsgBox("RECORD IS UPDATED")
                End If
            Else
                MsgBox("ENTER SOP NUMBER", MsgBoxStyle.Information, "EDIT A RECORD")
                Me.txt_sop_no.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString.ToUpper)
        End Try
    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim current_row, msg_box As Integer
        Try
            current_row = Me.grd_sop_master.CurrentRow.Index
            msg_box = MsgBox("DO U WANT TO DELETE THE CURRENT RECORD", MsgBoxStyle.YesNo)
            If msg_box = MsgBoxResult.Yes Then
                sop_module.sop_dataset.Tables("SOP_MASTER").Rows(current_row).Delete()
                Call sop_module.sop_update_database_master()
                MsgBox("RECORD IS DELETED")
                Call display_statusbar(current_row - 1)
                Call clear_all()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub grd_sop_master_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_sop_master.Click
        Call display()
    End Sub
    Private Sub clear_all()
        Me.cmb_dept.Text = ""
        Me.txt_sop_no.Text = ""
        Me.txt_sop_name.Text = ""
        Call display_statusbar(-1)
        Me.cmb_dept.Focus()


    End Sub
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Try
            Call clear_all()
            If sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count - 1 >= 0 Then
                Me.grd_sop_master.CurrentCell = Me.grd_sop_master.Rows(0).Cells(0)
                Call display_statusbar(Me.grd_sop_master.CurrentRow.Index)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try

    End Sub
    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        Dim s As String, search_row As DataRow
        Dim count As Integer
        s = UCase(InputBox("ENTER SOP_NO", "SEARCH", "nostring"))
        search_row = sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Find(s)
        If search_row Is Nothing Then
            MsgBox("RECORD NOT FOUND", MsgBoxStyle.Information, "Search a Record")
        Else
            For count = 0 To sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count - 1
                If s = sop_module.sop_dataset.Tables("SOP_MASTER").Rows(count).Item("Sop_No") Then
                    Me.grd_sop_master.Rows(count).Selected = True
                    Me.grd_sop_master.CurrentCell = Me.grd_sop_master.SelectedCells(0)
                    Call display_statusbar(count)
                    Call display()
                End If
            Next
        End If
    End Sub
    Private Sub display()
        If Me.grd_sop_master.RowCount >= 0 Then
            Me.txt_sop_no.Text = Me.grd_sop_master.CurrentRow.Cells(0).Value
            Me.txt_sop_name.Text = Me.grd_sop_master.CurrentRow.Cells(1).Value
            Me.cmb_dept.Text = ""
            Call display_statusbar(Me.grd_sop_master.CurrentRow.Index)
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub cmb_dept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_dept.KeyPress
        If e.KeyChar <> vbBack Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub cmb_dept_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_dept.SelectedValueChanged
        Me.txt_sop_no.Text = Me.cmb_dept.Text & "-"
    End Sub

    Private Sub cmb_dept_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_dept.TextChanged
        If Me.cmb_dept.Text = "" Then
            Me.txt_sop_no.Text = ""
        End If
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_first.Click
        If sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count > 0 Then
            Me.grd_sop_master.Rows(0).Selected = True
            Me.grd_sop_master.CurrentCell = Me.grd_sop_master.SelectedCells(0)
            Call display_statusbar(0)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        If sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count > 0 Then
            Me.grd_sop_master.Rows(Me.grd_sop_master.RowCount - 1).Selected = True
            Me.grd_sop_master.CurrentCell = Me.grd_sop_master.SelectedCells(0)
            Call display_statusbar(Me.grd_sop_master.RowCount - 1)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        If sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count > 0 Then
            If Me.grd_sop_master.CurrentRow.Index = 0 Then
                Me.grd_sop_master.Rows(Me.grd_sop_master.RowCount - 1).Selected = True
            Else
                Me.grd_sop_master.Rows(Me.grd_sop_master.CurrentRow.Index - 1).Selected = True
            End If
            Me.grd_sop_master.CurrentCell = Me.grd_sop_master.SelectedCells(0)
            Call display_statusbar(Me.grd_sop_master.CurrentRow.Index)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If sop_module.sop_dataset.Tables("SOP_MASTER").Rows.Count > 0 Then
            If Me.grd_sop_master.CurrentRow.Index = Me.grd_sop_master.RowCount - 1 Then
                Me.grd_sop_master.Rows(0).Selected = True
            Else
                Me.grd_sop_master.Rows(Me.grd_sop_master.CurrentRow.Index + 1).Selected = True
            End If
            Me.grd_sop_master.CurrentCell = Me.grd_sop_master.SelectedCells(0)
            Call display_statusbar(Me.grd_sop_master.CurrentRow.Index)
            Call display()
        Else
            MsgBox("THERE ARE NO RECORDS", MsgBoxStyle.Information)

        End If

    End Sub

    
End Class
