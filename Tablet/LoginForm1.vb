Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub OK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            If Me.txt_name.Text <> "" And Me.txt_pwd.Text <> "" Then
                LOGIN_MODULE.drow = LOGIN_MODULE.ds.Tables("LOGIN_MASTER").Rows.Find(Me.txt_name.Text)
                If Not drow Is Nothing Then
                    If Me.txt_pwd.Text = drow.Item("User_Password") Then
                        Call LOGIN_MODULE.fill_dataset_detail()
                        LOGIN_MODULE.drow1 = LOGIN_MODULE.ds.Tables("LOGIN_DETAIL").NewRow()
                        LOGIN_MODULE.drow1.Item("User_Name") = Me.txt_name.Text
                        LOGIN_MODULE.drow1.Item("Start_Time") = Format(DateTime.Now, "hh:mm:ss tt")
                        LOGIN_MODULE.drow1.Item("Log_On_Date") = Format(DateTime.Now, "dd/MM/yy")
                        LOGIN_MODULE.ds.Tables("LOGIN_DETAIL").Rows.Add(drow1)
                        LOGIN_MODULE.update_database_detail()
                        MsgBox("WELCOME", , "Login Form")
                        Call LOGIN_MODULE.close_login_conn()
                        frm_mdi.Show()
                    Else
                        MsgBox("PASSWORD IS INCORRECT", MsgBoxStyle.Information, "Login Form")
                        Me.txt_pwd.SelectionStart = 0
                        Me.txt_pwd.SelectionLength = Me.txt_pwd.TextLength
                        Me.txt_pwd.Focus()
                    End If
                Else
                    MsgBox("USERNAME IS INCORRECT", MsgBoxStyle.Information, "Login Form")
                End If
            Else
                MsgBox("EITHER USERNAME OR PASSWORD OR BOTH FIELDS ARE BLANK", MsgBoxStyle.Information, "Login Form")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper)
        End Try
    End Sub
    Private Sub LoginForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LOGIN_MODULE.open_login_conn()
        Call LOGIN_MODULE.fill_dataset_master()
    End Sub
    Private Sub Cancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub
End Class
