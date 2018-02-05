Public Class liquid_calculation
    Private Sub btn_max_result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_max_result.Click
        If Me.txt_max.Text <> "" Then
            Me.txt_max_result.Text = CStr(((Val(Me.txt_max.Text) * 100) / Val(Me.lb_amax_tb1.Text)))
        Else
            MsgBox("ENTER MAXIMUM AVERAGE WEIGHT(INDIVIDUAL)", MsgBoxStyle.Information, "Uniformity of Weight")
            Me.txt_max.Focus()
        End If
    End Sub
    Private Sub btn_max_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_max_clear.Click
        Me.txt_max.Text = ""
        Me.txt_max_result.Text = ""
    End Sub
    Private Sub btn_min_result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min_result.Click
        If Me.txt_min.Text <> "" Then
            Me.txt_min_result.Text = CStr(((100 * Val(Me.txt_min.Text)) / Val(Me.lb_amin_tb2.Text)))
        Else
            MsgBox("ENTER MAXIMUM AVERAGE WEIGHT(INDIVIDUAL)", MsgBoxStyle.Information, "Uniformity of Weight")
            Me.txt_min.Focus()
        End If
    End Sub
    Private Sub btn_min_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_min_clear.Click
        Me.txt_min.Text = ""
        Me.txt_min_result.Text = ""
    End Sub
End Class