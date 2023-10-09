<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sv))
        Me.pnDMSinhVien = New System.Windows.Forms.Panel()
        Me.pnDMSinhVienbot = New System.Windows.Forms.Panel()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btInd = New System.Windows.Forms.Button()
        Me.btThem = New System.Windows.Forms.Button()
        Me.rdNu = New System.Windows.Forms.RadioButton()
        Me.rdNam = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHocBong = New System.Windows.Forms.TextBox()
        Me.txtMaKhoa = New System.Windows.Forms.TextBox()
        Me.txtHoSV = New System.Windows.Forms.TextBox()
        Me.txtNoiSinh = New System.Windows.Forms.TextBox()
        Me.txtNgaySinh = New System.Windows.Forms.TextBox()
        Me.txtTenSV = New System.Windows.Forms.TextBox()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New QuanLySinhVien.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoiSinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HocBongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.pnData = New System.Windows.Forms.Panel()
        Me.pnDMSinhVien.SuspendLayout()
        Me.pnDMSinhVienbot.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnData.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnDMSinhVien
        '
        Me.pnDMSinhVien.Controls.Add(Me.pnData)
        Me.pnDMSinhVien.Controls.Add(Me.pnDMSinhVienbot)
        Me.pnDMSinhVien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnDMSinhVien.Location = New System.Drawing.Point(0, 0)
        Me.pnDMSinhVien.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnDMSinhVien.Name = "pnDMSinhVien"
        Me.pnDMSinhVien.Size = New System.Drawing.Size(962, 633)
        Me.pnDMSinhVien.TabIndex = 2
        '
        'pnDMSinhVienbot
        '
        Me.pnDMSinhVienbot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnDMSinhVienbot.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.pnDMSinhVienbot.Controls.Add(Me.btXoa)
        Me.pnDMSinhVienbot.Controls.Add(Me.btSua)
        Me.pnDMSinhVienbot.Controls.Add(Me.btInd)
        Me.pnDMSinhVienbot.Controls.Add(Me.btThem)
        Me.pnDMSinhVienbot.Controls.Add(Me.rdNu)
        Me.pnDMSinhVienbot.Controls.Add(Me.rdNam)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label8)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label6)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label4)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label2)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label7)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label5)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label3)
        Me.pnDMSinhVienbot.Controls.Add(Me.Label1)
        Me.pnDMSinhVienbot.Controls.Add(Me.txtHocBong)
        Me.pnDMSinhVienbot.Controls.Add(Me.txtMaKhoa)
        Me.pnDMSinhVienbot.Controls.Add(Me.txtHoSV)
        Me.pnDMSinhVienbot.Controls.Add(Me.txtNoiSinh)
        Me.pnDMSinhVienbot.Controls.Add(Me.txtNgaySinh)
        Me.pnDMSinhVienbot.Controls.Add(Me.txtTenSV)
        Me.pnDMSinhVienbot.Controls.Add(Me.txtMaSV)
        Me.pnDMSinhVienbot.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.pnDMSinhVienbot.Location = New System.Drawing.Point(3, 281)
        Me.pnDMSinhVienbot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnDMSinhVienbot.Name = "pnDMSinhVienbot"
        Me.pnDMSinhVienbot.Size = New System.Drawing.Size(962, 350)
        Me.pnDMSinhVienbot.TabIndex = 0
        '
        'btXoa
        '
        Me.btXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btXoa.FlatAppearance.BorderSize = 0
        Me.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoa.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btXoa.ForeColor = System.Drawing.Color.DimGray
        Me.btXoa.Location = New System.Drawing.Point(755, 281)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(143, 57)
        Me.btXoa.TabIndex = 4
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
        Me.btSua.Location = New System.Drawing.Point(804, 177)
        Me.btSua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(143, 57)
        Me.btSua.TabIndex = 4
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = False
        '
        'btInd
        '
        Me.btInd.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btInd.FlatAppearance.BorderSize = 0
        Me.btInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInd.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btInd.ForeColor = System.Drawing.Color.DimGray
        Me.btInd.Location = New System.Drawing.Point(731, 71)
        Me.btInd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btInd.Name = "btInd"
        Me.btInd.Size = New System.Drawing.Size(216, 57)
        Me.btInd.TabIndex = 4
        Me.btInd.Text = "In Danh Sách"
        Me.btInd.UseVisualStyleBackColor = False
        '
        'btThem
        '
        Me.btThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btThem.FlatAppearance.BorderSize = 0
        Me.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThem.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btThem.ForeColor = System.Drawing.Color.DimGray
        Me.btThem.Location = New System.Drawing.Point(638, 177)
        Me.btThem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(143, 57)
        Me.btThem.TabIndex = 4
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = False
        '
        'rdNu
        '
        Me.rdNu.AutoSize = True
        Me.rdNu.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet1, "DMSV.Phai", True))
        Me.rdNu.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdNu.ForeColor = System.Drawing.Color.DimGray
        Me.rdNu.Location = New System.Drawing.Point(215, 110)
        Me.rdNu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdNu.Name = "rdNu"
        Me.rdNu.Size = New System.Drawing.Size(57, 29)
        Me.rdNu.TabIndex = 3
        Me.rdNu.TabStop = True
        Me.rdNu.Text = "Nữ"
        Me.rdNu.UseVisualStyleBackColor = True
        '
        'rdNam
        '
        Me.rdNam.AutoSize = True
        Me.rdNam.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSet1, "DMSV.Phai", True))
        Me.rdNam.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdNam.ForeColor = System.Drawing.Color.DimGray
        Me.rdNam.Location = New System.Drawing.Point(215, 77)
        Me.rdNam.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rdNam.Name = "rdNam"
        Me.rdNam.Size = New System.Drawing.Size(71, 29)
        Me.rdNam.TabIndex = 2
        Me.rdNam.TabStop = True
        Me.rdNam.Text = "Nam"
        Me.rdNam.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(317, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Học Bổng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(49, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 25)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Mã Khoa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(226, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Phái"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(36, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ Sinh Viên"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(392, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nơi Sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(268, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(212, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ngày Sinh (yyyy/mm/dd)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(26, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên Sinh Viên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(36, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'txtHocBong
        '
        Me.txtHocBong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHocBong.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMSV.HocBong", True))
        Me.txtHocBong.Location = New System.Drawing.Point(282, 307)
        Me.txtHocBong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHocBong.Name = "txtHocBong"
        Me.txtHocBong.Size = New System.Drawing.Size(170, 31)
        Me.txtHocBong.TabIndex = 0
        '
        'txtMaKhoa
        '
        Me.txtMaKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMSV.MaKhoa", True))
        Me.txtMaKhoa.Location = New System.Drawing.Point(14, 307)
        Me.txtMaKhoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaKhoa.Name = "txtMaKhoa"
        Me.txtMaKhoa.Size = New System.Drawing.Size(170, 31)
        Me.txtMaKhoa.TabIndex = 0
        '
        'txtHoSV
        '
        Me.txtHoSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMSV.HoSV", True))
        Me.txtHoSV.Location = New System.Drawing.Point(14, 157)
        Me.txtHoSV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHoSV.Name = "txtHoSV"
        Me.txtHoSV.Size = New System.Drawing.Size(170, 31)
        Me.txtHoSV.TabIndex = 0
        '
        'txtNoiSinh
        '
        Me.txtNoiSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoiSinh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMSV.NoiSinh", True))
        Me.txtNoiSinh.Location = New System.Drawing.Point(333, 77)
        Me.txtNoiSinh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNoiSinh.Multiline = True
        Me.txtNoiSinh.Name = "txtNoiSinh"
        Me.txtNoiSinh.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNoiSinh.Size = New System.Drawing.Size(226, 102)
        Me.txtNoiSinh.TabIndex = 0
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNgaySinh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMSV.NgaySinh", True))
        Me.txtNgaySinh.Location = New System.Drawing.Point(282, 236)
        Me.txtNgaySinh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(170, 31)
        Me.txtNgaySinh.TabIndex = 0
        '
        'txtTenSV
        '
        Me.txtTenSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMSV.TenSV", True))
        Me.txtTenSV.Location = New System.Drawing.Point(14, 236)
        Me.txtTenSV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTenSV.Name = "txtTenSV"
        Me.txtTenSV.Size = New System.Drawing.Size(170, 31)
        Me.txtTenSV.TabIndex = 0
        '
        'txtMaSV
        '
        Me.txtMaSV.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSet1, "DMSV.MaSV", True))
        Me.txtMaSV.Location = New System.Drawing.Point(14, 75)
        Me.txtMaSV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(170, 31)
        Me.txtMaSV.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSVDataGridViewTextBoxColumn, Me.HoSVDataGridViewTextBoxColumn, Me.TenSVDataGridViewTextBoxColumn, Me.PhaiDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.NoiSinhDataGridViewTextBoxColumn, Me.MaKhoaDataGridViewTextBoxColumn, Me.HocBongDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "DMSV"
        Me.DataGridView1.DataSource = Me.DataSet1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 11)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(950, 272)
        Me.DataGridView1.TabIndex = 0
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
        'MaSVDataGridViewTextBoxColumn
        '
        Me.MaSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.HeaderText = "MaSV"
        Me.MaSVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaSVDataGridViewTextBoxColumn.Name = "MaSVDataGridViewTextBoxColumn"
        Me.MaSVDataGridViewTextBoxColumn.Width = 125
        '
        'HoSVDataGridViewTextBoxColumn
        '
        Me.HoSVDataGridViewTextBoxColumn.DataPropertyName = "HoSV"
        Me.HoSVDataGridViewTextBoxColumn.HeaderText = "HoSV"
        Me.HoSVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoSVDataGridViewTextBoxColumn.Name = "HoSVDataGridViewTextBoxColumn"
        Me.HoSVDataGridViewTextBoxColumn.Width = 125
        '
        'TenSVDataGridViewTextBoxColumn
        '
        Me.TenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV"
        Me.TenSVDataGridViewTextBoxColumn.HeaderText = "TenSV"
        Me.TenSVDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenSVDataGridViewTextBoxColumn.Name = "TenSVDataGridViewTextBoxColumn"
        Me.TenSVDataGridViewTextBoxColumn.Width = 125
        '
        'PhaiDataGridViewTextBoxColumn
        '
        Me.PhaiDataGridViewTextBoxColumn.DataPropertyName = "Phai"
        Me.PhaiDataGridViewTextBoxColumn.HeaderText = "Phai"
        Me.PhaiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhaiDataGridViewTextBoxColumn.Name = "PhaiDataGridViewTextBoxColumn"
        Me.PhaiDataGridViewTextBoxColumn.Width = 125
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 125
        '
        'NoiSinhDataGridViewTextBoxColumn
        '
        Me.NoiSinhDataGridViewTextBoxColumn.DataPropertyName = "NoiSinh"
        Me.NoiSinhDataGridViewTextBoxColumn.HeaderText = "NoiSinh"
        Me.NoiSinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NoiSinhDataGridViewTextBoxColumn.Name = "NoiSinhDataGridViewTextBoxColumn"
        Me.NoiSinhDataGridViewTextBoxColumn.Width = 125
        '
        'MaKhoaDataGridViewTextBoxColumn
        '
        Me.MaKhoaDataGridViewTextBoxColumn.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.HeaderText = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn.Name = "MaKhoaDataGridViewTextBoxColumn"
        Me.MaKhoaDataGridViewTextBoxColumn.Width = 125
        '
        'HocBongDataGridViewTextBoxColumn
        '
        Me.HocBongDataGridViewTextBoxColumn.DataPropertyName = "HocBong"
        Me.HocBongDataGridViewTextBoxColumn.HeaderText = "HocBong"
        Me.HocBongDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HocBongDataGridViewTextBoxColumn.Name = "HocBongDataGridViewTextBoxColumn"
        Me.HocBongDataGridViewTextBoxColumn.Width = 125
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT    DMSV.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         DMSV"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO [DMSV] ([MaSV], [HoSV], [TenSV], [Phai], [NgaySinh], [NoiSinh], [MaKh" &
    "oa], [HocBong]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.[Char], 0, "MaSV"), New System.Data.OleDb.OleDbParameter("HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, "HoSV"), New System.Data.OleDb.OleDbParameter("TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSV"), New System.Data.OleDb.OleDbParameter("Phai", System.Data.OleDb.OleDbType.WChar, 0, "Phai"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, "NoiSinh"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("HocBong", System.Data.OleDb.OleDbType.[Double], 0, "HocBong")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.[Char], 0, "MaSV"), New System.Data.OleDb.OleDbParameter("HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, "HoSV"), New System.Data.OleDb.OleDbParameter("TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSV"), New System.Data.OleDb.OleDbParameter("Phai", System.Data.OleDb.OleDbType.WChar, 0, "Phai"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, "NoiSinh"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("HocBong", System.Data.OleDb.OleDbType.[Double], 0, "HocBong"), New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HoSV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HoSV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Phai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phai", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NoiSinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HocBong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HocBong", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HoSV", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HoSV", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Phai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phai", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NoiSinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HocBong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HocBong", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DMSV", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSV", "MaSV"), New System.Data.Common.DataColumnMapping("HoSV", "HoSV"), New System.Data.Common.DataColumnMapping("TenSV", "TenSV"), New System.Data.Common.DataColumnMapping("Phai", "Phai"), New System.Data.Common.DataColumnMapping("NgaySinh", "NgaySinh"), New System.Data.Common.DataColumnMapping("NoiSinh", "NoiSinh"), New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("HocBong", "HocBong")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DTRHIDRO\DTRHIDRO;Integrated Security=SSPI;Initia" &
    "l Catalog=QuanLyDiemSV"
        '
        'pnData
        '
        Me.pnData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnData.Controls.Add(Me.DataGridView1)
        Me.pnData.Location = New System.Drawing.Point(0, 0)
        Me.pnData.Name = "pnData"
        Me.pnData.Size = New System.Drawing.Size(962, 283)
        Me.pnData.TabIndex = 5
        '
        'Sv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 633)
        Me.Controls.Add(Me.pnDMSinhVien)
        Me.Name = "Sv"
        Me.Text = "Sv"
        Me.pnDMSinhVien.ResumeLayout(False)
        Me.pnDMSinhVienbot.ResumeLayout(False)
        Me.pnDMSinhVienbot.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnData.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnDMSinhVien As Panel
    Friend WithEvents pnDMSinhVienbot As Panel
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents btInd As Button
    Friend WithEvents btThem As Button
    Friend WithEvents rdNu As RadioButton
    Friend WithEvents rdNam As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHocBong As TextBox
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents txtHoSV As TextBox
    Friend WithEvents txtNoiSinh As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtTenSV As TextBox
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoiSinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HocBongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents pnData As Panel
End Class
