Imports system.math
Public Class frm_uniform_validate
    Private Sub btn_max_result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_max_result.Click
        If Me.txt_max.Text <> "" Then
            Me.txt_max_result.Text = CStr(Round(((Val(Me.txt_max.Text) - Val(Me.lb_amax_tb1.Text)) / (Val(Me.lb_amax_tb1.Text)) * 100), 2))
        Else
            MsgBox("ENTER MAXIMUM AVERAGE WEIGHT(INDIVIDUAL)", MsgBoxStyle.Information, "Uniformity of weight")
            Me.txt_max.Focus()
        End If
    End Sub
    Private Sub btn_max_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_max_clear.Click
        Me.txt_max.Text = ""
        Me.txt_max_result.Text = ""
    End Sub
    Private Sub btn_min_result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min_result.Click
        If Me.txt_min.Text <> "" Then
            Me.txt_min_result.Text = CStr(Round(((Val(Me.lb_amin_tb2.Text) - Val(Me.txt_min.Text)) / (Val(Me.lb_amin_tb2.Text)) * 100), 2))
        Else
            MsgBox("ENTER MAXIMUM AVERAGE WEIGHT(INDIVIDUAL)", MsgBoxStyle.Information, "Uniformity of weight")
            Me.txt_min.Focus()
        End If
    End Sub
    Private Sub btn_min_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min_clear.Click
        Me.txt_min.Text = ""
        Me.txt_min_result.Text = ""
    End Sub
End Class