<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminPortal
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnltop = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAccount = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTest = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlMain = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnltop.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        '
        'pnltop
        '
        Me.pnltop.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.pnltop.Controls.Add(Me.Label1)
        Me.pnltop.Controls.Add(Me.NightControlBox1)
        Me.pnltop.Controls.Add(Me.Guna2PictureBox2)
        Me.pnltop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnltop.Location = New System.Drawing.Point(0, 0)
        Me.pnltop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnltop.Name = "pnltop"
        Me.pnltop.Size = New System.Drawing.Size(1104, 37)
        Me.pnltop.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Admin Portal"
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
        Me.NightControlBox1.Location = New System.Drawing.Point(961, 4)
        Me.NightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Name = "NightControlBox1"
        Me.NightControlBox1.Size = New System.Drawing.Size(139, 31)
        Me.NightControlBox1.TabIndex = 1
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.lblName)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.btnAccount)
        Me.Guna2Panel2.Controls.Add(Me.btnTest)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(224, 498)
        Me.Guna2Panel2.TabIndex = 3
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(19, 185)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(181, 57)
        Me.Guna2Button1.TabIndex = 4
        Me.Guna2Button1.Text = "Books"
        '
        'btnAccount
        '
        Me.btnAccount.BorderRadius = 10
        Me.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAccount.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnAccount.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccount.ForeColor = System.Drawing.Color.White
        Me.btnAccount.Location = New System.Drawing.Point(19, 430)
        Me.btnAccount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAccount.Name = "btnAccount"
        Me.btnAccount.Size = New System.Drawing.Size(181, 57)
        Me.btnAccount.TabIndex = 0
        Me.btnAccount.Text = "Log Out"
        '
        'btnTest
        '
        Me.btnTest.BorderRadius = 10
        Me.btnTest.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTest.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTest.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTest.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnTest.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.Location = New System.Drawing.Point(19, 104)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(181, 57)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Users"
        '
        'pnlMain
        '
        Me.pnlMain.Location = New System.Drawing.Point(224, 37)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(880, 480)
        Me.pnlMain.TabIndex = 4
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.pnltop
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.elibrary.My.Resources.Resources.icons8_book
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(3, 5)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(25, 20)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Jellee Bold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Welcome ,"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(24, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(110, 34)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Label8"
        '
        'frmAdminPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1104, 535)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.pnltop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAdminPortal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminPortal"
        Me.pnltop.ResumeLayout(False)
        Me.pnltop.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnltop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAccount As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlMain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Label2 As Label
    Friend WithEvents lblName As Label
End Class
