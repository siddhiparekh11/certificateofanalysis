'This form is concerned with Cream Master Grid for more details see CREAM_MODULE
Public Class cream_master_grid
    Private Sub cream_master_grid_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        cream_master.Show()
    End Sub
    Private Sub cream_master_grid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.grd_cream_master.DataSource = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER")
        Me.conmenu_cream_master_grid.Hide()
        Call display_statusbar(-1)
    End Sub
    Private Sub btn_lst_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_go.Click
        Try
            Dim count As Integer
            Dim flag As Boolean
            For count = 0 To CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count - 1
                If Me.txt_product_code.Text = CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows(count).Item("Cream_Code") Then
                    Me.grd_cream_master.Rows(count).Selected = True
                    Me.grd_cream_master.CurrentCell = Me.grd_cream_master.SelectedCells(1)
                    Call display_statusbar(count)
                    flag = True
                End If
            Next
            If flag = False Then
                MsgBox("NO RECORD FOUND", MsgBoxStyle.Information, "Enter Correct Product Code")
                If Me.grd_cream_master.RowCount >= 0 Then
                    Me.grd_cream_master.Rows(0).Selected = True
                    Me.grd_cream_master.CurrentCell = Me.grd_cream_master.SelectedCells(1)
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
            MsgBox("ENTER ALPHABETS ONLY", MsgBoxStyle.Information, "Product Code")
        End If
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    'This Procedure display currebt record nummber and total number of records in status bar of Cream Master Grid  
    Private Sub display_statusbar(ByVal pointer As Integer)
        pointer = pointer + 1
        Me.status_lbl_record_number.Text = CStr(pointer)
        Me.status_lbl_total_record.Text = CStr(CREAM_MODULE.cream_dataset.Tables("CREAM_MASTER").Rows.Count)
    End Sub
    Private Sub grd_cream_master_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grd_cream_master.SelectionChanged
        Call display_statusbar(Me.grd_cream_master.CurrentRow.Index)
    End Sub
End Class
