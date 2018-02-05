Public Class login_transactions
    Dim dtab As TabPage
    Private Sub btn_create_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_create_user.Click
        Try
            If Me.txt_new_name.Text <> "" Then
                If Me.txt_pwd.Text <> "" Then
                    If Me.txt_con_pwd.Text <> "" Then
                        If Len(Me.txt_pwd.Text) >= 6 And Len(Me.txt_con_pwd.Text) >= 6 Then
                            If (Me.txt_pwd.Text = Me.txt_con_pwd.Text) Then
                                drow = ds.Tables("LOGIN_MASTER").NewRow()
                                drow.Item("User_Name") = Me.txt_new_name.Text
                                drow.Item("User_Password") = Me.txt_con_pwd.Text
                                ds.Tables("LOGIN_MASTER").Rows.Add(drow)
                                Call update_database_master()
                                MsgBox("USER HAS BEEN CREATED", MsgBoxStyle.Information, "User Creation")
                            Else
                                MsgBox("CONFIRM YOUR PASSWORD", MsgBoxStyle.Information, "User Creation")
                                Me.txt_con_pwd.SelectionStart = 0
                                Me.txt_con_pwd.SelectionLength = Me.txt_con_pwd.TextLength
                                Me.txt_con_pwd.Focus()
                            End If
                        Else
                            MsgBox("THE LENGTH OF THE PASSWORDS FIELD(s) SHOULD BE ATLEAST 6 CHARACTERS ", MsgBoxStyle.Information, "User Creation")
                            Me.txt_pwd.Text = ""
                            Me.txt_con_pwd.Text = ""
                        End If
                    Else
                        MsgBox("CONFIRM PASSWORD IS BLANK", MsgBoxStyle.Information, "User Creation")
                        Me.txt_con_pwd.Focus()
                    End If
                Else
                    MsgBox("PASSWORD IS BLANK", MsgBoxStyle.Information, "User Creation")
                    Me.txt_pwd.Focus()
                End If
            Else
                MsgBox("USERNAME IS BLANK", MsgBoxStyle.Information, "User Creation")
                Me.txt_new_name.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "User Creation Error")
        End Try
    End Sub
    Private Sub login_transactions_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Call LOGIN_MODULE.close_login_conn()
        frm_mdi.Show()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LOGIN_MODULE.open_login_conn()
        Call LOGIN_MODULE.fill_dataset_master()
        'ToolTip1.SetToolTip(Me.txt_pwd, "ENTER ATLEAST 6 CHARACTERS")
    End Sub
    Private Sub btn_change_pwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_change_pwd.Click
        Dim msg_box As Integer, existing_password As String
        Try
            If Me.txt_existing_name.Text <> "" Then
                If Me.txt_old_pwd.Text <> "" Then
                    If Me.txt_new_pwd.Text <> "" Then
                        drow = ds.Tables("LOGIN_MASTER").Rows.Find(Me.txt_existing_name.Text)
                        If Not drow Is Nothing Then
                            existing_password = drow.Item("User_Password")
                            If existing_password = Me.txt_old_pwd.Text Then
                                msg_box = MsgBox("ARE U SURE U WANT TO CHANGE THE PASSWORD ?", MsgBoxStyle.YesNo, "Change Password")
                                If msg_box = MsgBoxResult.Yes Then
                                    drow.Item("User_Password") = Me.txt_new_pwd.Text
                                    Call LOGIN_MODULE.update_database_master()
                                    MsgBox("YOUR PASSWORD HAS BEEN CHANGED", MsgBoxStyle.Information, "Change Password")
                                End If
                            Else
                                MsgBox("OLD PASSWORD IS INCORRECT", MsgBoxStyle.Information, "Change Password")
                                Me.txt_old_pwd.SelectionStart = 0
                                Me.txt_old_pwd.SelectionLength = Me.txt_old_pwd.TextLength
                                Me.txt_old_pwd.Focus()
                            End If
                        Else
                            MsgBox("USERNAME IS INCORRECT", MsgBoxStyle.Information, "Change Password")
                            Me.txt_existing_name.SelectionStart = 0
                            Me.txt_existing_name.SelectionLength = Me.txt_existing_name.TextLength
                            Me.txt_existing_name.Focus()
                        End If
                    Else
                        MsgBox("NEW PASSWORD IS BLANK", MsgBoxStyle.Information, "Change Password")
                        Me.txt_new_pwd.Focus()
                    End If
                Else
                    MsgBox("OLD PASSWORD IS BLANK", MsgBoxStyle.Information, "Change Password")
                    Me.txt_old_pwd.Focus()
                End If
            Else
                MsgBox("USERNAME IS BLANK", MsgBoxStyle.Information, "Change Password")
                Me.txt_existing_name.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub btn_existing_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_existing_close.Click
        Me.Close()
    End Sub
    Private Sub btn_delete_user_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_user.Click
        Dim msg_box As Integer, delete_password As String
        Try
            If Me.txt_delete_name.Text <> "" Then
                If Me.txt_delete_pwd.Text <> "" Then
                    If Me.txt_delete_con_pwd.Text <> "" Then
                        If Me.txt_delete_pwd.Text = Me.txt_delete_con_pwd.Text Then
                            drow = ds.Tables("LOGIN_MASTER").Rows.Find(Me.txt_delete_name.Text)
                            If Not drow Is Nothing Then
                                delete_password = drow.Item("User_Password")
                                If delete_password = Me.txt_delete_con_pwd.Text Then
                                    msg_box = MsgBox("ARE U SURE U WANT TO DELETE THE USER ?", MsgBoxStyle.YesNo, "Delete User")
                                    If msg_box = MsgBoxResult.Yes Then
                                        ds.Tables("LOGIN_MASTER").Rows.Find(Me.txt_delete_name.Text).Delete()
                                        Call LOGIN_MODULE.update_database_master()
                                        MsgBox("USER HAS BEEN DELETED", MsgBoxStyle.Information, "Delete User")
                                    End If
                                Else
                                    MsgBox("PASSWORD IS INCORRECT", MsgBoxStyle.Information, "Delete User")
                                End If
                            Else
                                MsgBox("USERNAME IS INCORRECT", MsgBoxStyle.Information, "Delete User")
                                Me.txt_delete_name.SelectionStart = 0
                                Me.txt_delete_name.SelectionLength = Me.txt_delete_name.TextLength
                                Me.txt_delete_name.Focus()
                            End If
                        Else
                            MsgBox("MAKE SURE THE DATA IN BOTH THE PASSWORD FIELDS ARE SAME", MsgBoxStyle.Information, "Delete User")
                            Me.txt_delete_pwd.Text = ""
                            Me.txt_delete_con_pwd.Text = ""
                            Me.txt_delete_pwd.Focus()
                        End If
                    Else
                        MsgBox("CONFIRM PASSWORD IS BLANK", MsgBoxStyle.Information, "Delete User")
                        Me.txt_delete_pwd.Focus()
                    End If
                Else
                    MsgBox("PASSWORD IS BLANK", MsgBoxStyle.Information, "Delete User")
                    Me.txt_delete_pwd.Focus()
                End If
            Else
                MsgBox("USERNAME IS BLANK", MsgBoxStyle.Information, "Delete User")
                Me.txt_delete_name.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToUpper, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab Is Me.tab_existing Then
            Me.grp_exist_user.Visible = False
            Me.btn_show_existing_users.Text = "Show Users"
            Me.lst_show_existing_users.Items.Clear()
            Me.txt_existing_name.Text = ""
            Me.txt_old_pwd.Text = ""
            Me.txt_new_pwd.Text = ""
        ElseIf Me.TabControl1.SelectedTab Is Me.tab_new Then
            Me.txt_new_name.Text = ""
            Me.txt_con_pwd.Text = ""
            Me.txt_pwd.Text = ""
        ElseIf Me.TabControl1.SelectedTab Is Me.tab_delete Then
            Me.grp_delete_user.Visible = False
            Me.btn_show_delete_users.Text = "Show Users"
            Me.lst_show_delete_user.Items.Clear()
            Me.txt_delete_name.Text = ""
            Me.txt_delete_pwd.Text = ""
            Me.txt_delete_con_pwd.Text = ""
        End If
    End Sub
    Private Sub btn_show_existing_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show_existing_users.Click
        Dim show_user As Integer
        If Me.btn_show_existing_users.Text = "Show Users" Then
            If ds.Tables("LOGIN_MASTER").Rows.Count > 0 Then
                Me.grp_exist_user.Visible = True
                For show_user = 0 To ds.Tables("LOGIN_MASTER").Rows.Count - 1
                    Me.lst_show_existing_users.Items.Add(ds.Tables("LOGIN_MASTER").Rows(show_user).Item(0))
                Next
                Me.btn_show_existing_users.Text = "Hide Users"
            Else
                MsgBox("CURRENTLY THERE ARE NO SUBSCRIBED USERS", MsgBoxStyle.Information, "User Confirmation")
            End If
        Else
            Me.grp_exist_user.Visible = False
            Me.lst_show_existing_users.Items.Clear()
            Me.btn_show_existing_users.Text = "Show Users"
        End If
    End Sub
    Private Sub btn_new_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new_close.Click
        Me.Close()
    End Sub
    Private Sub btn_new_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new_clear.Click
        Me.txt_new_name.Text = ""
        Me.txt_pwd.Text = ""
        Me.txt_con_pwd.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_existing_clear.Click
        Me.txt_existing_name.Text = ""
        Me.txt_old_pwd.Text = ""
        Me.txt_new_pwd.Text = ""
    End Sub
    Private Sub btn_delete_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_clear.Click
        Me.txt_delete_name.Text = ""
        Me.txt_delete_pwd.Text = ""
        Me.txt_delete_con_pwd.Text = ""
    End Sub
    Private Sub btn_show_delete_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show_delete_users.Click
        Dim show_user As Integer
        If Me.btn_show_delete_users.Text = "Show Users" Then
            If ds.Tables("LOGIN_MASTER").Rows.Count > 0 Then
                Me.grp_delete_user.Visible = True
                For show_user = 0 To ds.Tables("LOGIN_MASTER").Rows.Count - 1
                    Me.lst_show_delete_user.Items.Add(ds.Tables("LOGIN_MASTER").Rows(show_user).Item(0))
                Next
                Me.btn_show_delete_users.Text = "Hide Users"
            Else
                MsgBox("CURRENTLY THERE ARE NO SUBSCRIBED USERS", MsgBoxStyle.Information, "User Confirmation")
            End If
        Else
            Me.grp_delete_user.Visible = False
            Me.lst_show_delete_user.Items.Clear()
            Me.btn_show_delete_users.Text = "Show Users"
        End If
    End Sub
    Private Sub btn_delete_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_close.Click
        Me.Close()
    End Sub
End Class