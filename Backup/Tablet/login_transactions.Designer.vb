<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_transactions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab_new = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_new_close = New System.Windows.Forms.Button
        Me.btn_new_clear = New System.Windows.Forms.Button
        Me.btn_create_user = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_new_name = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_con_pwd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_pwd = New System.Windows.Forms.TextBox
        Me.tab_existing = New System.Windows.Forms.TabPage
        Me.btn_show_existing_users = New System.Windows.Forms.Button
        Me.grp_exist_user = New System.Windows.Forms.GroupBox
        Me.lst_show_existing_users = New System.Windows.Forms.ListBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btn_existing_clear = New System.Windows.Forms.Button
        Me.btn_existing_close = New System.Windows.Forms.Button
        Me.btn_change_pwd = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txt_existing_name = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_new_pwd = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_old_pwd = New System.Windows.Forms.TextBox
        Me.tab_delete = New System.Windows.Forms.TabPage
        Me.btn_show_delete_users = New System.Windows.Forms.Button
        Me.grp_delete_user = New System.Windows.Forms.GroupBox
        Me.lst_show_delete_user = New System.Windows.Forms.ListBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btn_delete_clear = New System.Windows.Forms.Button
        Me.btn_delete_close = New System.Windows.Forms.Button
        Me.btn_delete_user = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txt_delete_name = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_delete_con_pwd = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_delete_pwd = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.tab_new.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tab_existing.SuspendLayout()
        Me.grp_exist_user.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tab_delete.SuspendLayout()
        Me.grp_delete_user.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tab_new)
        Me.TabControl1.Controls.Add(Me.tab_existing)
        Me.TabControl1.Controls.Add(Me.tab_delete)
        Me.TabControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(14, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(525, 395)
        Me.TabControl1.TabIndex = 2
        '
        'tab_new
        '
        Me.tab_new.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tab_new.Controls.Add(Me.GroupBox2)
        Me.tab_new.Controls.Add(Me.GroupBox1)
        Me.tab_new.Location = New System.Drawing.Point(4, 26)
        Me.tab_new.Name = "tab_new"
        Me.tab_new.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_new.Size = New System.Drawing.Size(517, 365)
        Me.tab_new.TabIndex = 0
        Me.tab_new.Text = "New User"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_new_close)
        Me.GroupBox2.Controls.Add(Me.btn_new_clear)
        Me.GroupBox2.Controls.Add(Me.btn_create_user)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 77)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'btn_new_close
        '
        Me.btn_new_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_new_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_close.Location = New System.Drawing.Point(288, 22)
        Me.btn_new_close.Name = "btn_new_close"
        Me.btn_new_close.Size = New System.Drawing.Size(116, 38)
        Me.btn_new_close.TabIndex = 0
        Me.btn_new_close.Text = "Cl&ose"
        Me.btn_new_close.UseVisualStyleBackColor = False
        '
        'btn_new_clear
        '
        Me.btn_new_clear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_new_clear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_clear.Location = New System.Drawing.Point(152, 22)
        Me.btn_new_clear.Name = "btn_new_clear"
        Me.btn_new_clear.Size = New System.Drawing.Size(116, 38)
        Me.btn_new_clear.TabIndex = 0
        Me.btn_new_clear.Text = "C&lear"
        Me.btn_new_clear.UseVisualStyleBackColor = False
        '
        'btn_create_user
        '
        Me.btn_create_user.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_create_user.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create_user.Location = New System.Drawing.Point(14, 22)
        Me.btn_create_user.Name = "btn_create_user"
        Me.btn_create_user.Size = New System.Drawing.Size(116, 38)
        Me.btn_create_user.TabIndex = 0
        Me.btn_create_user.Text = "&Create User"
        Me.btn_create_user.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_new_name)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_con_pwd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_pwd)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 153)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txt_new_name
        '
        Me.txt_new_name.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_name.Location = New System.Drawing.Point(192, 19)
        Me.txt_new_name.Name = "txt_new_name"
        Me.txt_new_name.Size = New System.Drawing.Size(194, 23)
        Me.txt_new_name.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txt_new_name, "Enter user name")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name"
        '
        'txt_con_pwd
        '
        Me.txt_con_pwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_con_pwd.Location = New System.Drawing.Point(192, 108)
        Me.txt_con_pwd.MaxLength = 10
        Me.txt_con_pwd.Name = "txt_con_pwd"
        Me.txt_con_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_con_pwd.Size = New System.Drawing.Size(194, 23)
        Me.txt_con_pwd.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txt_con_pwd, "Confirm your password")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Confirm Password"
        '
        'txt_pwd
        '
        Me.txt_pwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pwd.Location = New System.Drawing.Point(192, 64)
        Me.txt_pwd.MaxLength = 10
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd.Size = New System.Drawing.Size(194, 23)
        Me.txt_pwd.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt_pwd, "Enter password with minimum 6 characters")
        '
        'tab_existing
        '
        Me.tab_existing.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tab_existing.Controls.Add(Me.btn_show_existing_users)
        Me.tab_existing.Controls.Add(Me.grp_exist_user)
        Me.tab_existing.Controls.Add(Me.GroupBox3)
        Me.tab_existing.Controls.Add(Me.GroupBox4)
        Me.tab_existing.ForeColor = System.Drawing.Color.Black
        Me.tab_existing.Location = New System.Drawing.Point(4, 26)
        Me.tab_existing.Name = "tab_existing"
        Me.tab_existing.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_existing.Size = New System.Drawing.Size(517, 365)
        Me.tab_existing.TabIndex = 1
        Me.tab_existing.Text = "Existing User"
        '
        'btn_show_existing_users
        '
        Me.btn_show_existing_users.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_show_existing_users.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_existing_users.Location = New System.Drawing.Point(360, 226)
        Me.btn_show_existing_users.Name = "btn_show_existing_users"
        Me.btn_show_existing_users.Size = New System.Drawing.Size(116, 38)
        Me.btn_show_existing_users.TabIndex = 2
        Me.btn_show_existing_users.Text = "Show Users"
        Me.btn_show_existing_users.UseVisualStyleBackColor = False
        '
        'grp_exist_user
        '
        Me.grp_exist_user.Controls.Add(Me.lst_show_existing_users)
        Me.grp_exist_user.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_exist_user.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_exist_user.Location = New System.Drawing.Point(38, 198)
        Me.grp_exist_user.Name = "grp_exist_user"
        Me.grp_exist_user.Size = New System.Drawing.Size(272, 76)
        Me.grp_exist_user.TabIndex = 12
        Me.grp_exist_user.TabStop = False
        Me.grp_exist_user.Text = "Existing Users"
        '
        'lst_show_existing_users
        '
        Me.lst_show_existing_users.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_show_existing_users.FormattingEnabled = True
        Me.lst_show_existing_users.ItemHeight = 16
        Me.lst_show_existing_users.Location = New System.Drawing.Point(70, 28)
        Me.lst_show_existing_users.Name = "lst_show_existing_users"
        Me.lst_show_existing_users.ScrollAlwaysVisible = True
        Me.lst_show_existing_users.Size = New System.Drawing.Size(168, 20)
        Me.lst_show_existing_users.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_existing_clear)
        Me.GroupBox3.Controls.Add(Me.btn_existing_close)
        Me.GroupBox3.Controls.Add(Me.btn_change_pwd)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(458, 77)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        '
        'btn_existing_clear
        '
        Me.btn_existing_clear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_existing_clear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_existing_clear.Location = New System.Drawing.Point(189, 23)
        Me.btn_existing_clear.Name = "btn_existing_clear"
        Me.btn_existing_clear.Size = New System.Drawing.Size(116, 38)
        Me.btn_existing_clear.TabIndex = 2
        Me.btn_existing_clear.Text = "C&lear"
        Me.btn_existing_clear.UseVisualStyleBackColor = False
        '
        'btn_existing_close
        '
        Me.btn_existing_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_existing_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_existing_close.Location = New System.Drawing.Point(321, 23)
        Me.btn_existing_close.Name = "btn_existing_close"
        Me.btn_existing_close.Size = New System.Drawing.Size(116, 38)
        Me.btn_existing_close.TabIndex = 1
        Me.btn_existing_close.Text = "Cl&ose"
        Me.btn_existing_close.UseVisualStyleBackColor = False
        '
        'btn_change_pwd
        '
        Me.btn_change_pwd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_change_pwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_change_pwd.Location = New System.Drawing.Point(20, 23)
        Me.btn_change_pwd.Name = "btn_change_pwd"
        Me.btn_change_pwd.Size = New System.Drawing.Size(152, 38)
        Me.btn_change_pwd.TabIndex = 0
        Me.btn_change_pwd.Text = "Change  &Password"
        Me.btn_change_pwd.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_existing_name)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txt_new_pwd)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_old_pwd)
        Me.GroupBox4.Location = New System.Drawing.Point(30, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(458, 151)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'txt_existing_name
        '
        Me.txt_existing_name.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_existing_name.Location = New System.Drawing.Point(166, 19)
        Me.txt_existing_name.Name = "txt_existing_name"
        Me.txt_existing_name.Size = New System.Drawing.Size(194, 23)
        Me.txt_existing_name.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txt_existing_name, "Enter valid user name")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "User Name"
        '
        'txt_new_pwd
        '
        Me.txt_new_pwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_pwd.Location = New System.Drawing.Point(166, 108)
        Me.txt_new_pwd.MaxLength = 10
        Me.txt_new_pwd.Name = "txt_new_pwd"
        Me.txt_new_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_new_pwd.Size = New System.Drawing.Size(194, 23)
        Me.txt_new_pwd.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txt_new_pwd, "Enter your new password that you want to change")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Old Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "New Password"
        '
        'txt_old_pwd
        '
        Me.txt_old_pwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_old_pwd.Location = New System.Drawing.Point(166, 64)
        Me.txt_old_pwd.MaxLength = 10
        Me.txt_old_pwd.Name = "txt_old_pwd"
        Me.txt_old_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_old_pwd.Size = New System.Drawing.Size(194, 23)
        Me.txt_old_pwd.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txt_old_pwd, "Enter valid password")
        '
        'tab_delete
        '
        Me.tab_delete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.tab_delete.Controls.Add(Me.btn_show_delete_users)
        Me.tab_delete.Controls.Add(Me.grp_delete_user)
        Me.tab_delete.Controls.Add(Me.GroupBox5)
        Me.tab_delete.Controls.Add(Me.GroupBox6)
        Me.tab_delete.Location = New System.Drawing.Point(4, 26)
        Me.tab_delete.Name = "tab_delete"
        Me.tab_delete.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_delete.Size = New System.Drawing.Size(517, 365)
        Me.tab_delete.TabIndex = 2
        Me.tab_delete.Text = "Delete User"
        '
        'btn_show_delete_users
        '
        Me.btn_show_delete_users.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_show_delete_users.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_show_delete_users.Location = New System.Drawing.Point(355, 225)
        Me.btn_show_delete_users.Name = "btn_show_delete_users"
        Me.btn_show_delete_users.Size = New System.Drawing.Size(116, 38)
        Me.btn_show_delete_users.TabIndex = 0
        Me.btn_show_delete_users.Text = "Show Users"
        Me.btn_show_delete_users.UseVisualStyleBackColor = False
        '
        'grp_delete_user
        '
        Me.grp_delete_user.Controls.Add(Me.lst_show_delete_user)
        Me.grp_delete_user.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_delete_user.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grp_delete_user.Location = New System.Drawing.Point(40, 197)
        Me.grp_delete_user.Name = "grp_delete_user"
        Me.grp_delete_user.Size = New System.Drawing.Size(272, 76)
        Me.grp_delete_user.TabIndex = 14
        Me.grp_delete_user.TabStop = False
        Me.grp_delete_user.Text = "Existing Users"
        '
        'lst_show_delete_user
        '
        Me.lst_show_delete_user.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_show_delete_user.FormattingEnabled = True
        Me.lst_show_delete_user.ItemHeight = 16
        Me.lst_show_delete_user.Location = New System.Drawing.Point(70, 28)
        Me.lst_show_delete_user.Name = "lst_show_delete_user"
        Me.lst_show_delete_user.ScrollAlwaysVisible = True
        Me.lst_show_delete_user.Size = New System.Drawing.Size(168, 20)
        Me.lst_show_delete_user.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_delete_clear)
        Me.GroupBox5.Controls.Add(Me.btn_delete_close)
        Me.GroupBox5.Controls.Add(Me.btn_delete_user)
        Me.GroupBox5.Location = New System.Drawing.Point(31, 283)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(451, 77)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        '
        'btn_delete_clear
        '
        Me.btn_delete_clear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete_clear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_clear.Location = New System.Drawing.Point(163, 23)
        Me.btn_delete_clear.Name = "btn_delete_clear"
        Me.btn_delete_clear.Size = New System.Drawing.Size(116, 38)
        Me.btn_delete_clear.TabIndex = 0
        Me.btn_delete_clear.Text = "C&lear"
        Me.btn_delete_clear.UseVisualStyleBackColor = False
        '
        'btn_delete_close
        '
        Me.btn_delete_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_close.Location = New System.Drawing.Point(308, 23)
        Me.btn_delete_close.Name = "btn_delete_close"
        Me.btn_delete_close.Size = New System.Drawing.Size(116, 38)
        Me.btn_delete_close.TabIndex = 0
        Me.btn_delete_close.Text = "Cl&ose"
        Me.btn_delete_close.UseVisualStyleBackColor = False
        '
        'btn_delete_user
        '
        Me.btn_delete_user.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_delete_user.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete_user.Location = New System.Drawing.Point(16, 23)
        Me.btn_delete_user.Name = "btn_delete_user"
        Me.btn_delete_user.Size = New System.Drawing.Size(116, 38)
        Me.btn_delete_user.TabIndex = 0
        Me.btn_delete_user.Text = "&Delete User"
        Me.btn_delete_user.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txt_delete_name)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txt_delete_con_pwd)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txt_delete_pwd)
        Me.GroupBox6.Location = New System.Drawing.Point(31, 27)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(461, 153)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'txt_delete_name
        '
        Me.txt_delete_name.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_delete_name.Location = New System.Drawing.Point(187, 19)
        Me.txt_delete_name.Name = "txt_delete_name"
        Me.txt_delete_name.Size = New System.Drawing.Size(194, 23)
        Me.txt_delete_name.TabIndex = 0
        Me.txt_delete_name.Tag = ""
        Me.ToolTip1.SetToolTip(Me.txt_delete_name, "Enter valid user name")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "User Name"
        '
        'txt_delete_con_pwd
        '
        Me.txt_delete_con_pwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_delete_con_pwd.Location = New System.Drawing.Point(187, 108)
        Me.txt_delete_con_pwd.MaxLength = 10
        Me.txt_delete_con_pwd.Name = "txt_delete_con_pwd"
        Me.txt_delete_con_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_delete_con_pwd.Size = New System.Drawing.Size(194, 23)
        Me.txt_delete_con_pwd.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_delete_con_pwd, "Confirm your password")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Confirm Password"
        '
        'txt_delete_pwd
        '
        Me.txt_delete_pwd.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_delete_pwd.Location = New System.Drawing.Point(187, 64)
        Me.txt_delete_pwd.MaxLength = 10
        Me.txt_delete_pwd.Name = "txt_delete_pwd"
        Me.txt_delete_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_delete_pwd.Size = New System.Drawing.Size(194, 23)
        Me.txt_delete_pwd.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txt_delete_pwd, "Enter valid password")
        '
        'login_transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 419)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "login_transactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN TRANSACTIONS"
        Me.TabControl1.ResumeLayout(False)
        Me.tab_new.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_existing.ResumeLayout(False)
        Me.grp_exist_user.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.tab_delete.ResumeLayout(False)
        Me.grp_delete_user.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_new As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_new_clear As System.Windows.Forms.Button
    Friend WithEvents btn_create_user As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_new_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_con_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_pwd As System.Windows.Forms.TextBox
    Friend WithEvents tab_existing As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_existing_close As System.Windows.Forms.Button
    Friend WithEvents btn_change_pwd As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_existing_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_new_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_old_pwd As System.Windows.Forms.TextBox
    Friend WithEvents tab_delete As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_delete_close As System.Windows.Forms.Button
    Friend WithEvents btn_delete_user As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_delete_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_delete_con_pwd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_delete_pwd As System.Windows.Forms.TextBox
    Friend WithEvents btn_show_existing_users As System.Windows.Forms.Button
    Friend WithEvents grp_exist_user As System.Windows.Forms.GroupBox
    Friend WithEvents lst_show_existing_users As System.Windows.Forms.ListBox
    Friend WithEvents btn_new_close As System.Windows.Forms.Button
    Friend WithEvents btn_existing_clear As System.Windows.Forms.Button
    Friend WithEvents btn_delete_clear As System.Windows.Forms.Button
    Friend WithEvents btn_show_delete_users As System.Windows.Forms.Button
    Friend WithEvents grp_delete_user As System.Windows.Forms.GroupBox
    Friend WithEvents lst_show_delete_user As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
