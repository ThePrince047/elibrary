<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splashscreen
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
        Me.ProgressBar1 = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.lb_percent = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(152, 455)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(375, 30)
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Text = "Guna2ProgressBar1"
        Me.ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'lb_percent
        '
        Me.lb_percent.AutoSize = True
        Me.lb_percent.Font = New System.Drawing.Font("Jellee Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_percent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.lb_percent.Location = New System.Drawing.Point(307, 412)
        Me.lb_percent.Name = "lb_percent"
        Me.lb_percent.Size = New System.Drawing.Size(60, 28)
        Me.lb_percent.TabIndex = 2
        Me.lb_percent.Text = "000"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 8
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.ErrorImage = Nothing
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Guna2PictureBox1.Image = Global.elibrary.My.Resources.Resources.book
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(152, 91)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(375, 250)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'splashscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(699, 496)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.lb_percent)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "splashscreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splashscreen"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents lb_percent As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
