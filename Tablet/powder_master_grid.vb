'This form is concerned with Powder Master Grid for more details see POWDER_MODULE
Public Class powder_master_grid
    Private Sub powder_master_grid_deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        powder_master.Show()
    End Sub
    Private Sub powder_master_grid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.conmenu_powder_master_grid.Hide()
        Me.grd_powder_master.DataSource = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER")
        Call display_statusbar(-1)
    End Sub
    Private Sub btn_lst_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_lst_go.Click
        Dim count As Integer
        Dim flag As Boolean
        Try
            For count = 0 To POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count - 1
                If Me.txt_product_code.Text = POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows(count).Item("Powder_Code") Then
                    Me.grd_powder_master.Rows(count).Selected = True
                    Me.grd_powder_master.CurrentCell = Me.grd_powder_master.SelectedCells(1)
                    flag = True
                    Call display_statusbar(count)
                    Exit For
                End If
            Next
            If flag = False Then
                MsgBox("NO RECORD FOUND", MsgBoxStyle.Information, "SEARCH A RECORD")
                If Me.grd_powder_master.RowCount >= 0 Then
                    Me.grd_powder_master.Rows(0).Selected = True
                    Me.grd_powder_master.CurrentCell = Me.grd_powder_master.SelectedCells(1)
                End If
                Call display_statusbar(-1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub txt_product_code_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_product_code.KeyPress
        If (e.KeyChar < "A" Or e.KeyChar > "Z") And (e.KeyChar < "a" Or e.KeyChar > "z") And e.KeyChar <> vbBack Then
            e.KeyChar = ""
            MsgBox("ENTER ALPHABETS ONLY", MsgBoxStyle.Information, "PRODUCT CODE")
        End If
    End Sub
    'This Procedure display currebt record nummber and total number of records in status bar of Powder Master Grid  
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_record_number.Text = CStr(pointer)
        Me.status_lbl_total_record.Text = CStr(POWDER_MODULE.powder_dataset.Tables("POWDER_MASTER").Rows.Count)
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub grd_powder_master_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_powder_master.SelectionChanged
        Call display_statusbar(Me.grd_powder_master.CurrentRow.Index)
    End Sub
End Class