<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddBook
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NightControlBox1 = New ReaLTaiizor.Controls.NightControlBox()
        Me.tbBookName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbGenre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
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
        Me.NightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.NightControlBox1.EnableMaximizeButton = False
        Me.NightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.NightControlBox1.EnableMinimizeButton = False
        Me.NightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.NightControlBox1.Location = New System.Drawing.Point(562, 1)
        Me.NightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White
        Me.NightControlBox1.Name = "NightControlBox1"
        Me.NightControlBox1.Size = New System.Drawing.Size(139, 31)
        Me.NightControlBox1.TabIndex = 0
        '
        'tbBookName
        '
        Me.tbBookName.BorderRadius = 10
        Me.tbBookName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbBookName.DefaultText = ""
        Me.tbBookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbBookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbBookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbBookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbBookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBookName.Font = New System.Drawing.Font("Jellee Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbBookName.Location = New System.Drawing.Point(303, 85)
        Me.tbBookName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbBookName.Name = "tbBookName"
        Me.tbBookName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbBookName.PlaceholderText = ""
        Me.tbBookName.SelectedText = ""
        Me.tbBookName.Size = New System.Drawing.Size(315, 50)
        Me.tbBookName.TabIndex = 2
        '
        'tbAuthor
        '
        Me.tbAuthor.BorderRadius = 10
        Me.tbAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAuthor.DefaultText = ""
        Me.tbAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAuthor.Font = New System.Drawing.Font("Jellee Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAuthor.Location = New System.Drawing.Point(303, 164)
        Me.tbAuthor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbAuthor.Name = "tbAuthor"
        Me.tbAuthor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAuthor.PlaceholderText = ""
        Me.tbAuthor.SelectedText = ""
        Me.tbAuthor.Size = New System.Drawing.Size(315, 50)
        Me.tbAuthor.TabIndex = 3
        '
        'tbGenre
        '
        Me.tbGenre.BorderRadius = 10
        Me.tbGenre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbGenre.DefaultText = ""
        Me.tbGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbGenre.Font = New System.Drawing.Font("Jellee Bold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbGenre.Location = New System.Drawing.Point(303, 238)
        Me.tbGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbGenre.Name = "tbGenre"
        Me.tbGenre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbGenre.PlaceholderText = ""
        Me.tbGenre.SelectedText = ""
        Me.tbGenre.Size = New System.Drawing.Size(315, 50)
        Me.tbGenre.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Jellee Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(102, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Book Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Jellee Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(102, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 28)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Author Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Jellee Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(102, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Genre"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Jellee Bold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(364, 342)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 55)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "Add Book"
        '
        'frmAddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbGenre)
        Me.Controls.Add(Me.tbAuthor)
        Me.Controls.Add(Me.tbBookName)
        Me.Controls.Add(Me.NightControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddBook"
        Me.Text = "frmAddBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NightControlBox1 As ReaLTaiizor.Controls.NightControlBox
    Friend WithEvents tbBookName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbGenre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
