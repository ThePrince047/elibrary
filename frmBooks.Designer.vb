<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgBooks = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BookIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookTableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrentDB = New elibrary.currentDB()
        Me.BookTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksellerDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksellerDataSet = New elibrary.booksellerDataSet()
        Me.BookTableTableAdapter = New elibrary.booksellerDataSetTableAdapters.bookTableTableAdapter()
        Me.BookTableTableAdapter1 = New elibrary.currentDBTableAdapters.bookTableTableAdapter()
        Me.btnInsertBook = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookTableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentDB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksellerDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksellerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgBooks
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgBooks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgBooks.AutoGenerateColumns = False
        Me.dgBooks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgBooks.ColumnHeadersHeight = 18
        Me.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookIDDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn, Me.AuthorNameDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn})
        Me.dgBooks.DataSource = Me.BookTableBindingSource1
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBooks.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgBooks.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgBooks.Location = New System.Drawing.Point(0, 0)
        Me.dgBooks.Name = "dgBooks"
        Me.dgBooks.RowHeadersVisible = False
        Me.dgBooks.RowHeadersWidth = 51
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBooks.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgBooks.RowTemplate.Height = 24
        Me.dgBooks.Size = New System.Drawing.Size(880, 316)
        Me.dgBooks.TabIndex = 0
        Me.dgBooks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBooks.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgBooks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgBooks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgBooks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgBooks.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgBooks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgBooks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgBooks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised
        Me.dgBooks.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Jellee Bold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBooks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgBooks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgBooks.ThemeStyle.HeaderStyle.Height = 18
        Me.dgBooks.ThemeStyle.ReadOnly = False
        Me.dgBooks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgBooks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgBooks.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgBooks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgBooks.ThemeStyle.RowsStyle.Height = 24
        Me.dgBooks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgBooks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BookIDDataGridViewTextBoxColumn
        '
        Me.BookIDDataGridViewTextBoxColumn.DataPropertyName = "bookID"
        Me.BookIDDataGridViewTextBoxColumn.HeaderText = "bookID"
        Me.BookIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BookIDDataGridViewTextBoxColumn.Name = "BookIDDataGridViewTextBoxColumn"
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "bookName"
        Me.BookNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        '
        'AuthorNameDataGridViewTextBoxColumn
        '
        Me.AuthorNameDataGridViewTextBoxColumn.DataPropertyName = "authorName"
        Me.AuthorNameDataGridViewTextBoxColumn.HeaderText = "authorName"
        Me.AuthorNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AuthorNameDataGridViewTextBoxColumn.Name = "AuthorNameDataGridViewTextBoxColumn"
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "genre"
        Me.GenreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        '
        'BookTableBindingSource1
        '
        Me.BookTableBindingSource1.DataMember = "bookTable"
        Me.BookTableBindingSource1.DataSource = Me.CurrentDB
        '
        'CurrentDB
        '
        Me.CurrentDB.DataSetName = "currentDB"
        Me.CurrentDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookTableBindingSource
        '
        Me.BookTableBindingSource.DataMember = "bookTable"
        Me.BookTableBindingSource.DataSource = Me.BooksellerDataSetBindingSource
        '
        'BooksellerDataSetBindingSource
        '
        Me.BooksellerDataSetBindingSource.DataSource = Me.BooksellerDataSet
        Me.BooksellerDataSetBindingSource.Position = 0
        '
        'BooksellerDataSet
        '
        Me.BooksellerDataSet.DataSetName = "booksellerDataSet"
        Me.BooksellerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BookTableTableAdapter
        '
        Me.BookTableTableAdapter.ClearBeforeFill = True
        '
        'BookTableTableAdapter1
        '
        Me.BookTableTableAdapter1.ClearBeforeFill = True
        '
        'btnInsertBook
        '
        Me.btnInsertBook.BorderRadius = 10
        Me.btnInsertBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInsertBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInsertBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInsertBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInsertBook.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.btnInsertBook.Font = New System.Drawing.Font("Jellee Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertBook.ForeColor = System.Drawing.Color.White
        Me.btnInsertBook.Location = New System.Drawing.Point(38, 420)
        Me.btnInsertBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInsertBook.Name = "btnInsertBook"
        Me.btnInsertBook.Size = New System.Drawing.Size(181, 57)
        Me.btnInsertBook.TabIndex = 7
        Me.btnInsertBook.Text = "Insert Book"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(351, 420)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(181, 57)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "Refresh Table"
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
        Me.Guna2Button2.Location = New System.Drawing.Point(656, 420)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(181, 57)
        Me.Guna2Button2.TabIndex = 9
        Me.Guna2Button2.Text = "Delete Book"
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 498)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btnInsertBook)
        Me.Controls.Add(Me.dgBooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBooks"
        Me.Text = "frmBooks"
        CType(Me.dgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookTableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentDB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksellerDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksellerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgBooks As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BooksellerDataSetBindingSource As BindingSource
    Friend WithEvents BooksellerDataSet As booksellerDataSet
    Friend WithEvents BookTableBindingSource As BindingSource
    Friend WithEvents BookTableTableAdapter As booksellerDataSetTableAdapters.bookTableTableAdapter
    Friend WithEvents BookIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentDB As currentDB
    Friend WithEvents BookTableBindingSource1 As BindingSource
    Friend WithEvents BookTableTableAdapter1 As currentDBTableAdapters.bookTableTableAdapter
    Friend WithEvents btnInsertBook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
