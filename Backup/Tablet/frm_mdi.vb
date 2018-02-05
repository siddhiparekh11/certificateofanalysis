Public Class frm_mdi
    Private Sub TabletMaster_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabletMaster_menu.Click
        tablet_master.Show()
    End Sub
    Private Sub TabletDetail_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabletDetail_menu.Click
        tablet_detail.Show()
        Me.Hide()
    End Sub
    Private Sub TabletIngredient_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabletIngredient_menu.Click
        tablet_ingredient.Show()
        Me.Hide()
    End Sub
    Private Sub LiquidMaster_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidMaster_Menu.Click
        liquid_master.Show()
        Me.Hide()
    End Sub
    Private Sub PowderMaster_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowderMaster_menu.Click
        powder_master.Show()
        Me.Hide()
    End Sub
    Private Sub CreamMaster_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreamMaster_menu.Click
        cream_master.Show()
        Me.Hide()
    End Sub
    Private Sub TABLETToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TABLETToolStripMenuItem1.Click
        tablet_report_viewer.Show()
        Me.Hide()
    End Sub
    Private Sub LIQUIDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIQUIDToolStripMenuItem1.Click
        liquid_report_viewer.Show()
        Me.Hide()
    End Sub
    Private Sub CREAMToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CREAMToolStripMenuItem1.Click
        cream_report_viewer.Show()
        Me.Hide()
    End Sub
    Private Sub POWDERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POWDERToolStripMenuItem1.Click
        powder_report_viewer.Show()
        Me.Hide()
    End Sub
    Private Sub SOPMASTERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOPMASTERToolStripMenuItem.Click
        sop_master.Show()
        Me.Hide()
    End Sub
    Private Sub SOPDETAILToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOPDETAILToolStripMenuItem.Click
        sop_detail.Show()
        Me.Hide()
    End Sub
    Private Sub SOPALERTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOPALERTToolStripMenuItem.Click
        sop_alert.Show()
        Me.Hide()
    End Sub
    Private Sub LiquidDetail_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidDetail_menu.Click
        liquid_detail.Show()
        Me.Hide()
    End Sub
    Private Sub LiquidIngredient_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LiquidIngredient_menu.Click
        liquid_ingredient.Show()
        Me.Hide()
    End Sub
    Private Sub CreamDetail_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreamDetail_menu.Click
        cream_detail.Show()
        Me.Hide()
    End Sub
    Private Sub BackUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem.Click
        FileCopy(Application.StartupPath & "\coa_and_sop.mdb", "d:\project_backup\backup_database.mdb")
        MsgBox("BACK UP HAS BEEN TAKEN", MsgBoxStyle.Information, "BACK UP")
    End Sub
    Private Sub LoginTransactionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginTransactionsToolStripMenuItem.Click
        login_transactions.Show()
        Me.Hide()
    End Sub
    Private Sub frm_mdi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoginForm1.Visible = False
    End Sub
    Private Sub PowderDetail_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowderDetail_menu.Click
        powder_detail.Show()
        Me.Hide()
    End Sub
    Private Sub PowderIngredient_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowderIngredient_menu.Click
        powder_ingredient.Show()
        Me.Hide()
    End Sub
    Private Sub CreamIngredient_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreamIngredient_menu.Click
        cream_ingredient.Show()
        Me.Hide()
    End Sub
    Private Sub Ingredient_menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ingredient_menu.Click
        ingredient.Show()
    End Sub
    Private Sub SOPToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SOPToolStripMenuItem1.Click
        sop_report_viewer.Show()
        Me.Hide()
    End Sub
End Class