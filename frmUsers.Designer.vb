<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgUser = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsAdminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrentDB = New elibrary.currentDB()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksellerDataSet1 = New elibrary.booksellerDataSet1()
        Me.BookTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookTableTableAdapter = New elibrary.booksellerDataSet1TableAdapters.bookTableTableAdapter()
        Me.UserTableTableAdapter = New elibrary.booksellerDataSet1TableAdapters.userTableTableAdapter()
        Me.UserTableTableAdapter1 = New elibrary.currentDBTableAdapters.userTableTableAdapter()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksellerDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgUser
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgUser.AutoGenerateColumns = False
        Me.dgUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgUser.ColumnHeadersHeight = 18
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.IsAdminDataGridViewTextBoxColumn})
        Me.dgUser.DataSource = Me.UserTableBindingSource1
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUser.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgUser.Location = New System.Drawing.Point(0, 0)
        Me.dgUser.Name = "dgUser"
        Me.dgUser.RowHeadersVisible = False
        Me.dgUser.RowHeadersWidth = 51
        Me.dgUser.RowTemplate.Height = 24
        Me.dgUser.Size = New System.Drawing.Size(880, 393)
        Me.dgUser.TabIndex = 0
        Me.dgUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgUser.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgUser.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgUser.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgUser.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Jellee Bold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgUser.ThemeStyle.HeaderStyle.Height = 18
        Me.dgUser.ThemeStyle.ReadOnly = False
        Me.dgUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgUser.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgUser.ThemeStyle.RowsStyle.Height = 24
        Me.dgUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "userID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "userID"
        Me.UserIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "username"
        Me.UsernameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'IsAdminDataGridViewTextBoxColumn
        '
        Me.IsAdminDataGridViewTextBoxColumn.DataPropertyName = "isAdmin"
        Me.IsAdminDataGridViewTextBoxColumn.HeaderText = "isAdmin"
        Me.IsAdminDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IsAdminDataGridViewTextBoxColumn.Name = "IsAdminDataGridViewTextBoxColumn"
        '
        'UserTableBindingSource1
        '
        Me.UserTableBindingSource1.DataMember = "userTable"
        Me.UserTableBindingSource1.DataSource = Me.CurrentDB
        '
        'CurrentDB
        '
        Me.CurrentDB.DataSetName = "currentDB"
        Me.CurrentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "userTable"
        Me.UserTableBindingSource.DataSource = Me.BooksellerDataSet1
        '
        'BooksellerDataSet1
        '
        Me.BooksellerDataSet1.DataSetName = "booksellerDataSet1"
        Me.BooksellerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookTableBindingSource
        '
        Me.BookTableBindingSource.DataMember = "bookTable"
        Me.BookTableBindingSource.DataSource = Me.BooksellerDataSet1
        '
        'BookTableTableAdapter
        '
        Me.BookTableTableAdapter.ClearBeforeFill = True
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
        '
        'UserTableTableAdapter1
        '
        Me.UserTableTableAdapter1.ClearBeforeFill = True
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(109, 421)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(181, 57)
        Me.Guna2Button2.TabIndex = 10
        Me.Guna2Button2.Text = "Delete User"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(556, 421)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(181, 57)
        Me.Guna2Button1.TabIndex = 11
        Me.Guna2Button1.Text = "Refresh Table"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 498)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.dgUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsers"
        Me.Text = "frmUsers"
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksellerDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgUser As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BooksellerDataSet1 As booksellerDataSet1
    Friend WithEvents BookTableBindingSource As BindingSource
    Friend WithEvents BookTableTableAdapter As booksellerDataSet1TableAdapters.bookTableTableAdapter
    Friend WithEvents UserTableBindingSource As BindingSource
    Friend WithEvents UserTableTableAdapter As booksellerDataSet1TableAdapters.userTableTableAdapter
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsAdminDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentDB As currentDB
    Friend WithEvents UserTableBindingSource1 As BindingSource
    Friend WithEvents UserTableTableAdapter1 As currentDBTableAdapters.userTableTableAdapter
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
