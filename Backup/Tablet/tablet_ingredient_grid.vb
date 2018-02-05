Public Class tablet_ingredient_grid

    Private Sub tablet_ingredient_grid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.grd_tab_ing.DataSource = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT")
        Me.grd_tab_ing.MultiSelect = True
        Call display_statusbar("No Batch Number Selected")
        Me.conmenu_tablet_ingredient_grid.Hide()
    End Sub
    Private Sub btn_lst_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lst_go.Click
        Dim count As Integer
        Dim flag As Boolean
        Try
            For count = 0 To TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count - 1
                If Me.txt_batch_no.Text = TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(count).Item("Tablet_Batch_No") Then
                    Me.grd_tab_ing.Rows(count).Selected = True
                    Me.grd_tab_ing.CurrentCell = Me.grd_tab_ing.SelectedCells(1)
                    flag = True
                    Call display_statusbar(Me.txt_batch_no.Text)
                    Exit For
                End If
            Next
            If flag = False Then
                MsgBox("NO RECORD FOUND", MsgBoxStyle.Information, "Incorrect Product Code")
                If TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows.Count - 1 >= 0 Then
                    Me.grd_tab_ing.Rows(0).Selected = True
                    Me.grd_tab_ing.CurrentCell = Me.grd_tab_ing.SelectedCells(1)
                End If
                Call display_statusbar("No Batch Number Selected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub display_statusbar(ByVal batch_number As String)
        Me.status_lbl_batch_no.Text = batch_number
    End Sub
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim delete_string As String, msg_box As Integer
        Try
            delete_string = Me.grd_tab_ing.CurrentRow.Cells(0).Value
            msg_box = MsgBox("DO YOU WANT TO DELETE THIS RECORD", MsgBoxStyle.YesNo, "Delete A Record")
            If msg_box = MsgBoxResult.Yes Then
                TABLET_MODULE.tablet_dataset.Tables("TABLET_INGREDIENT").Rows(Me.grd_tab_ing.CurrentRow.Index).Delete()
                Call TABLET_MODULE.tablet_updatedatabase_ingredient()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try

    End Sub
End Class