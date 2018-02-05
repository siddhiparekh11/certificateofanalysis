Public NotInheritable Class SplashScreen1

  

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ProgressBar1.Maximum = 30
        Timer1.Enabled = True
    End Sub

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
        End If
    End Sub
End Class
