<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Khoa
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
        Me.pnDMKhoa = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btInd = New System.Windows.Forms.Button()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaKhoa = New System.Windows.Forms.TextBox()
        Me.txtTenKhoa = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New QuanLySinhVien.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.pnDMKhoa.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnDMKhoa
        '
        Me.pnDMKhoa.Controls.Add(Me.Panel1)
        Me.pnDMKhoa.Controls.Add(Me.DataGridView2)
        Me.pnDMKhoa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnDMKhoa.Location = New System.Drawing.Point(0, 0)
        Me.pnDMKhoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnDMKhoa.Name = "pnDMKhoa"
        Me.pnDMKhoa.Size = New System.Drawing.Size(962, 633)
        Me.pnDMKhoa.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btInd)
        Me.Panel1.Controls.Add(Me.btXoa)
        Me.Panel1.Controls.Add(Me.btSua)
        Me.Panel1.Controls.Add(Me.btThem)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtMaKhoa)
        Me.Panel1.Controls.Add(Me.txtTenKhoa)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 333)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(962, 300)
        Me.Panel1.TabIndex = 1
        '
        'btInd
        '
        Me.btInd.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btInd.FlatAppearance.BorderSize = 0
        Me.btInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInd.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btInd.ForeColor = System.Drawing.Color.DimGray
        Me.btInd.Location = New System.Drawing.Point(734, 13)
        Me.btInd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btInd.Name = "btInd"
        Me.btInd.Size = New System.Drawing.Size(216, 57)
        Me.btInd.TabIndex = 9
        Me.btInd.Text = "In Danh Sách"
        Me.btInd.UseVisualStyleBackColor = False
        '
        'btXoa
        '
        Me.btXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btXoa.FlatAppearance.BorderSize = 0
        Me.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoa.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btXoa.ForeColor = System.Drawing.Color.DimGray
        Me.btXoa.Location = New System.Drawing.Point(807, 160)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(143, 57)
        Me.btXoa.TabIndex = 8
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = False
        '
        'btSua
        '
        Me.btSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btSua.FlatAppearance.BorderSize = 0
        Me.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSua.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btSua.ForeColor = System.Drawing.Color.DimGray
        Me.btSua.Location = New System.Drawing.Point(625, 160)
        Me.btSua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(143, 57)
        Me.btSua.TabIndex = 7
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = False
        '
        'btThem
        '
        Me.btThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btThem.FlatAppearance.BorderSize = 0
        Me.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btThem.ForeColor = System.Drawing.Color.DimGray
        Me.btThem.Location = New System.Drawing.Point(441, 160)
        Me.btThem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(143, 57)
        Me.btThem.TabIndex = 6
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(219, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 28)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Tên Khoa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(45, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 28)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Mã Khoa"
        '
        'txtMaKhoa
        '
        Me.txtMaKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMKhoa.MaKhoa", True))
        Me.txtMaKhoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaKhoa.Location = New System.Drawing.Point(24, 74)
        Me.txtMaKhoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaKhoa.Name = "txtMaKhoa"
        Me.txtMaKhoa.Size = New System.Drawing.Size(170, 34)
        Me.txtMaKhoa.TabIndex = 4
        '
        'txtTenKhoa
        '
        Me.txtTenKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMKhoa.TenKhoa", True))
        Me.txtTenKhoa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtTenKhoa.Location = New System.Drawing.Point(223, 74)
        Me.txtTenKhoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTenKhoa.Name = "txtTenKhoa"
        Me.txtTenKhoa.Size = New System.Drawing.Size(170, 34)
        Me.txtTenKhoa.TabIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKhoaDataGridViewTextBoxColumn, Me.TenKhoaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataMember = "DMKhoa"
        Me.DataGridView2.DataSource = Me.DataSet1
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(962, 334)
        Me.DataGridView2.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'MaKhoaDataGridViewTextBoxColumn
        '
        Me.MaKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn.Name = "MaKhoaDataGridViewTextBoxColumn"
        Me.MaKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'TenKhoaDataGridViewTextBoxColumn
        '
        Me.TenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenKhoaDataGridViewTextBoxColumn.Name = "TenKhoaDataGridViewTextBoxColumn"
        Me.TenKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT    DMKhoa.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         DMKhoa"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [DMKhoa] ([MaKhoa], [TenKhoa]) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE [DMKhoa] SET [MaKhoa] = ?, [TenKhoa] = ? WHERE (([MaKhoa] = ?) AND ([TenKh" &
    "oa] = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa"), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM [DMKhoa] WHERE (([MaKhoa] = ?) AND ([TenKhoa] = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DMKhoa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("TenKhoa", "TenKhoa")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DTRHIDRO\DTRHIDRO;Integrated Security=SSPI;Initia" &
    "l Catalog=QuanLyDiemSV"
        '
        'Khoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 633)
        Me.Controls.Add(Me.pnDMKhoa)
        Me.Name = "Khoa"
        Me.Text = "Khoa"
        Me.pnDMKhoa.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnDMKhoa As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btInd As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btThem As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents txtTenKhoa As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
End Class
