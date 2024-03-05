<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmsignup
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsernameSignup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmailSignup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPasswordSignup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtConpasswordSignup = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbUser = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.rbAdmin = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Jellee Bold", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(108, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sign Up"
        '
        'txtUsernameSignup
        '
        Me.txtUsernameSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtUsernameSignup.BorderRadius = 8
        Me.txtUsernameSignup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsernameSignup.DefaultText = ""
        Me.txtUsernameSignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsernameSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsernameSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameSignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsernameSignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsernameSignup.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsernameSignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.txtUsernameSignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsernameSignup.Location = New System.Drawing.Point(13, 133)
        Me.txtUsernameSignup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtUsernameSignup.Name = "txtUsernameSignup"
        Me.txtUsernameSignup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsernameSignup.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtUsernameSignup.PlaceholderText = "Username"
        Me.txtUsernameSignup.SelectedText = ""
        Me.txtUsernameSignup.Size = New System.Drawing.Size(358, 46)
        Me.txtUsernameSignup.TabIndex = 3
        '
        'txtEmailSignup
        '
        Me.txtEmailSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEmailSignup.BorderRadius = 8
        Me.txtEmailSignup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmailSignup.DefaultText = ""
        Me.txtEmailSignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmailSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmailSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailSignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmailSignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailSignup.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailSignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.txtEmailSignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmailSignup.Location = New System.Drawing.Point(13, 195)
        Me.txtEmailSignup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtEmailSignup.Name = "txtEmailSignup"
        Me.txtEmailSignup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmailSignup.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtEmailSignup.PlaceholderText = "Email"
        Me.txtEmailSignup.SelectedText = ""
        Me.txtEmailSignup.Size = New System.Drawing.Size(358, 46)
        Me.txtEmailSignup.TabIndex = 4
        '
        'txtPasswordSignup
        '
        Me.txtPasswordSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPasswordSignup.BorderRadius = 8
        Me.txtPasswordSignup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPasswordSignup.DefaultText = ""
        Me.txtPasswordSignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPasswordSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPasswordSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordSignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPasswordSignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordSignup.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasswordSignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.txtPasswordSignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPasswordSignup.Location = New System.Drawing.Point(13, 258)
        Me.txtPasswordSignup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPasswordSignup.Name = "txtPasswordSignup"
        Me.txtPasswordSignup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordSignup.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtPasswordSignup.PlaceholderText = "Password"
        Me.txtPasswordSignup.SelectedText = ""
        Me.txtPasswordSignup.Size = New System.Drawing.Size(358, 46)
        Me.txtPasswordSignup.TabIndex = 5
        '
        'txtConpasswordSignup
        '
        Me.txtConpasswordSignup.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConpasswordSignup.BorderRadius = 8
        Me.txtConpasswordSignup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConpasswordSignup.DefaultText = ""
        Me.txtConpasswordSignup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConpasswordSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConpasswordSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConpasswordSignup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConpasswordSignup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConpasswordSignup.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConpasswordSignup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.txtConpasswordSignup.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConpasswordSignup.Location = New System.Drawing.Point(13, 321)
        Me.txtConpasswordSignup.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtConpasswordSignup.Name = "txtConpasswordSignup"
        Me.txtConpasswordSignup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConpasswordSignup.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtConpasswordSignup.PlaceholderText = "Confirm Password"
        Me.txtConpasswordSignup.SelectedText = ""
        Me.txtConpasswordSignup.Size = New System.Drawing.Size(358, 46)
        Me.txtConpasswordSignup.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(115, 477)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Already User ?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(133, 514)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 34)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Log In"
        '
        'rbUser
        '
        Me.rbUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbUser.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbUser.CheckedState.BorderThickness = 0
        Me.rbUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbUser.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbUser.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbUser.Location = New System.Drawing.Point(208, 92)
        Me.rbUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbUser.Name = "rbUser"
        Me.rbUser.Size = New System.Drawing.Size(25, 20)
        Me.rbUser.TabIndex = 12
        Me.rbUser.Text = "User"
        Me.rbUser.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbUser.UncheckedState.BorderThickness = 2
        Me.rbUser.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbUser.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rbAdmin
        '
        Me.rbAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbAdmin.CheckedState.BorderThickness = 0
        Me.rbAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbAdmin.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rbAdmin.Font = New System.Drawing.Font("Jellee Bold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdmin.Location = New System.Drawing.Point(77, 92)
        Me.rbAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(25, 20)
        Me.rbAdmin.TabIndex = 11
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rbAdmin.UncheckedState.BorderThickness = 2
        Me.rbAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rbAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Jellee Bold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(108, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Admin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Jellee Bold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(239, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 22)
        Me.Label5.TabIndex = 14
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
        Me.NightControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.NightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.NightControlBox1.CloseHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NightControlBox1.DefaultLocation = True
        Me.NightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.NightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NightControlBox1.EnableMaximizeButton = False
        Me.NightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NightControlBox1.EnableMinimizeButton = True
        Me.NightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NightControlBox1.Location = New System.Drawing.Point(728, 0)
        Me.NightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Name = "NightControlBox1"
        Me.NightControlBox1.Size = New System.Drawing.Size(139, 31)
        Me.NightControlBox1.TabIndex = 15
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Guna2PictureBox2.Image = Global.elibrary.My.Resources.Resources.bookanim
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(424, 72)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(414, 418)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 1
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderRadius = 30
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(-24, 0)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(417, 571)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSubmit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSubmit.BorderRadius = 15
        Me.btnSubmit.BorderThickness = 2
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubmit.FillColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.btnSubmit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnSubmit.HoverState.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(96, 392)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(174, 69)
        Me.btnSubmit.TabIndex = 16
        Me.btnSubmit.Text = "Submit"
        '
        'frmsignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(867, 571)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.NightControlBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.rbUser)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConpasswordSignup)
        Me.Controls.Add(Me.txtPasswordSignup)
        Me.Controls.Add(Me.txtEmailSignup)
        Me.Controls.Add(Me.txtUsernameSignup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmsignup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsernameSignup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmailSignup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPasswordSignup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtConpasswordSignup As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2CustomRadioButton2 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Guna2CustomRadioButton1 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents closeBtn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents rbUser As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents rbAdmin As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
End Class
