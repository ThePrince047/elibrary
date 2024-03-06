<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtUsernameLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPasswordLogin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.loginSubmitBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.forgotPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.signuptxt = New System.Windows.Forms.Label()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.rbAdmin = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.rbUser = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Me.cbShowPass = New Guna.UI2.WinForms.Guna2CheckBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2PictureBox1.BorderRadius = 30
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(464, 0)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(420, 571)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'txtUsernameLogin
        '
        Me.txtUsernameLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUsernameLogin.BorderRadius = 8
        Me.txtUsernameLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameLogin.DefaultText = ""
        Me.txtUsernameLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsernameLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsernameLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsernameLogin.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtUsernameLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.txtUsernameLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsernameLogin.Location = New System.Drawing.Point(485, 189)
        Me.txtUsernameLogin.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtUsernameLogin.Name = "txtUsernameLogin"
        Me.txtUsernameLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtUsernameLogin.PlaceholderText = "Username"
        Me.txtUsernameLogin.SelectedText = ""
        Me.txtUsernameLogin.Size = New System.Drawing.Size(358, 49)
        Me.txtUsernameLogin.TabIndex = 2
        '
        'txtPasswordLogin
        '
        Me.txtPasswordLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPasswordLogin.BorderRadius = 8
        Me.txtPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPasswordLogin.DefaultText = ""
        Me.txtPasswordLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPasswordLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPasswordLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordLogin.Font = New System.Drawing.Font("Jellee Bold", 9.0!)
        Me.txtPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtPasswordLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordLogin.Location = New System.Drawing.Point(485, 266)
        Me.txtPasswordLogin.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.txtPasswordLogin.Name = "txtPasswordLogin"
        Me.txtPasswordLogin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordLogin.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtPasswordLogin.PlaceholderText = "Password"
        Me.txtPasswordLogin.SelectedText = ""
        Me.txtPasswordLogin.Size = New System.Drawing.Size(358, 49)
        Me.txtPasswordLogin.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Jellee Bold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(599, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 49)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Log In"
        '
        'loginSubmitBtn
        '
        Me.loginSubmitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.loginSubmitBtn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.loginSubmitBtn.BorderRadius = 15
        Me.loginSubmitBtn.BorderThickness = 2
        Me.loginSubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginSubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loginSubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loginSubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginSubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loginSubmitBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.loginSubmitBtn.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold)
        Me.loginSubmitBtn.ForeColor = System.Drawing.Color.White
        Me.loginSubmitBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.loginSubmitBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.loginSubmitBtn.HoverState.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginSubmitBtn.Location = New System.Drawing.Point(586, 390)
        Me.loginSubmitBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.loginSubmitBtn.Name = "loginSubmitBtn"
        Me.loginSubmitBtn.Size = New System.Drawing.Size(174, 69)
        Me.loginSubmitBtn.TabIndex = 5
        Me.loginSubmitBtn.Text = "Submit"
        '
        'forgotPassword
        '
        Me.forgotPassword.AutoSize = True
        Me.forgotPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.forgotPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgotPassword.Font = New System.Drawing.Font("Jellee Bold", 9.0!)
        Me.forgotPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.forgotPassword.Location = New System.Drawing.Point(696, 332)
        Me.forgotPassword.Name = "forgotPassword"
        Me.forgotPassword.Size = New System.Drawing.Size(147, 18)
        Me.forgotPassword.TabIndex = 6
        Me.forgotPassword.Text = "Forgot Passowrd ?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Jellee Bold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(611, 478)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New User ?"
        '
        'signuptxt
        '
        Me.signuptxt.AutoSize = True
        Me.signuptxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.signuptxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signuptxt.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signuptxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.signuptxt.Location = New System.Drawing.Point(602, 517)
        Me.signuptxt.Name = "signuptxt"
        Me.signuptxt.Size = New System.Drawing.Size(123, 34)
        Me.signuptxt.TabIndex = 8
        Me.signuptxt.Text = "Sign Up"
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2PictureBox2.ErrorImage = Nothing
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2PictureBox2.Image = Global.elibrary.My.Resources.Resources.bookanim
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(12, 61)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(417, 419)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 9
        Me.Guna2PictureBox2.TabStop = False
        '
        'rbAdmin
        '
        Me.rbAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbAdmin.CheckedState.BorderThickness = 0
        Me.rbAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbAdmin.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbAdmin.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rbAdmin.ForeColor = System.Drawing.Color.White
        Me.rbAdmin.Location = New System.Drawing.Point(551, 138)
        Me.rbAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(25, 20)
        Me.rbAdmin.TabIndex = 12
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbAdmin.UncheckedState.BorderThickness = 2
        Me.rbAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbUser
        '
        Me.rbUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbUser.CheckedState.BorderThickness = 0
        Me.rbUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbUser.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbUser.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rbUser.ForeColor = System.Drawing.Color.White
        Me.rbUser.Location = New System.Drawing.Point(683, 138)
        Me.rbUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbUser.Name = "rbUser"
        Me.rbUser.Size = New System.Drawing.Size(25, 20)
        Me.rbUser.TabIndex = 13
        Me.rbUser.Text = "Admin"
        Me.rbUser.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbUser.UncheckedState.BorderThickness = 2
        Me.rbUser.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbUser.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Jellee Bold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(582, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Admin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Jellee Bold", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(714, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "User"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 8
        Me.Guna2Elipse1.TargetControl = Me
        '
        'NightControlBox1
        '
        Me.NightControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NightControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NightControlBox1.CloseHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NightControlBox1.DefaultLocation = True
        Me.NightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.NightControlBox1.EnableMaximizeButton = False
        Me.NightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.NightControlBox1.EnableMinimizeButton = True
        Me.NightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.NightControlBox1.Location = New System.Drawing.Point(728, 0)
        Me.NightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Name = "NightControlBox1"
        Me.NightControlBox1.Size = New System.Drawing.Size(139, 31)
        Me.NightControlBox1.TabIndex = 17
        '
        'cbShowPass
        '
        Me.cbShowPass.AutoSize = True
        Me.cbShowPass.BackColor = System.Drawing.Color.White
        Me.cbShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbShowPass.CheckedState.BorderRadius = 0
        Me.cbShowPass.CheckedState.BorderThickness = 0
        Me.cbShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbShowPass.ForeColor = System.Drawing.Color.White
        Me.cbShowPass.Location = New System.Drawing.Point(810, 284)
        Me.cbShowPass.Name = "cbShowPass"
        Me.cbShowPass.Size = New System.Drawing.Size(18, 17)
        Me.cbShowPass.TabIndex = 18
        Me.cbShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbShowPass.UncheckedState.BorderRadius = 0
        Me.cbShowPass.UncheckedState.BorderThickness = 0
        Me.cbShowPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbShowPass.UseVisualStyleBackColor = False
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 571)
        Me.Controls.Add(Me.cbShowPass)
        Me.Controls.Add(Me.NightControlBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbUser)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.signuptxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.forgotPassword)
        Me.Controls.Add(Me.loginSubmitBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPasswordLogin)
        Me.Controls.Add(Me.txtUsernameLogin)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmlogin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtUsernameLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPasswordLogin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents forgotPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents signuptxt As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2CustomRadioButton1 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Guna2CustomRadioButton2 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbAdmin As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents rbUser As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents loginSubmitBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents cbShowPass As Guna.UI2.WinForms.Guna2CheckBox
End Class

