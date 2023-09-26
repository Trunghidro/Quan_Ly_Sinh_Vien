<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnTab = New System.Windows.Forms.Panel()
        Me.btDMKhoa = New System.Windows.Forms.Button()
        Me.btDMSinhVien = New System.Windows.Forms.Button()
        Me.pnDMKhoa = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btShow1 = New System.Windows.Forms.Button()
        Me.btXoa1 = New System.Windows.Forms.Button()
        Me.btSua1 = New System.Windows.Forms.Button()
        Me.btThem1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaKhoa1 = New System.Windows.Forms.TextBox()
        Me.DataSet11 = New QuanLySinhVien.DataSet1()
        Me.txtTenKhoa = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MaKhoaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSet1 = New QuanLySinhVien.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnDMSinhVien = New System.Windows.Forms.Panel()
        Me.pnDMSinhVienbot = New System.Windows.Forms.Panel()
        Me.btXoa = New System.Windows.Forms.Button()
        Me.btSua = New System.Windows.Forms.Button()
        Me.btShow = New System.Windows.Forms.Button()
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
        Me.MaSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenSVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoiSinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaKhoaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HocBongDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.pnTab.SuspendLayout()
        Me.pnDMKhoa.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnDMSinhVien.SuspendLayout()
        Me.pnDMSinhVienbot.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnTab
        '
        Me.pnTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.pnTab.Controls.Add(Me.btDMKhoa)
        Me.pnTab.Controls.Add(Me.btDMSinhVien)
        Me.pnTab.Location = New System.Drawing.Point(9, 10)
        Me.pnTab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnTab.Name = "pnTab"
        Me.pnTab.Size = New System.Drawing.Size(821, 91)
        Me.pnTab.TabIndex = 0
        '
        'btDMKhoa
        '
        Me.btDMKhoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btDMKhoa.FlatAppearance.BorderSize = 2
        Me.btDMKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDMKhoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btDMKhoa.ForeColor = System.Drawing.Color.DimGray
        Me.btDMKhoa.Location = New System.Drawing.Point(471, 2)
        Me.btDMKhoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btDMKhoa.Name = "btDMKhoa"
        Me.btDMKhoa.Size = New System.Drawing.Size(348, 80)
        Me.btDMKhoa.TabIndex = 0
        Me.btDMKhoa.Text = "Danh Mục Khoa"
        Me.btDMKhoa.UseVisualStyleBackColor = False
        '
        'btDMSinhVien
        '
        Me.btDMSinhVien.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btDMSinhVien.FlatAppearance.BorderSize = 2
        Me.btDMSinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDMSinhVien.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btDMSinhVien.ForeColor = System.Drawing.Color.DimGray
        Me.btDMSinhVien.Location = New System.Drawing.Point(4, 2)
        Me.btDMSinhVien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btDMSinhVien.Name = "btDMSinhVien"
        Me.btDMSinhVien.Size = New System.Drawing.Size(348, 80)
        Me.btDMSinhVien.TabIndex = 0
        Me.btDMSinhVien.Text = "Danh Mục Sinh Viên"
        Me.btDMSinhVien.UseVisualStyleBackColor = False
        '
        'pnDMKhoa
        '
        Me.pnDMKhoa.Controls.Add(Me.Panel1)
        Me.pnDMKhoa.Controls.Add(Me.DataGridView2)
        Me.pnDMKhoa.Location = New System.Drawing.Point(9, 108)
        Me.pnDMKhoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnDMKhoa.Name = "pnDMKhoa"
        Me.pnDMKhoa.Size = New System.Drawing.Size(821, 492)
        Me.pnDMKhoa.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btShow1)
        Me.Panel1.Controls.Add(Me.btXoa1)
        Me.Panel1.Controls.Add(Me.btSua1)
        Me.Panel1.Controls.Add(Me.btThem1)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtMaKhoa1)
        Me.Panel1.Controls.Add(Me.txtTenKhoa)
        Me.Panel1.Location = New System.Drawing.Point(4, 280)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 210)
        Me.Panel1.TabIndex = 1
        '
        'btShow1
        '
        Me.btShow1.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btShow1.FlatAppearance.BorderSize = 2
        Me.btShow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btShow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btShow1.ForeColor = System.Drawing.Color.DimGray
        Me.btShow1.Location = New System.Drawing.Point(496, 118)
        Me.btShow1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btShow1.Name = "btShow1"
        Me.btShow1.Size = New System.Drawing.Size(162, 46)
        Me.btShow1.TabIndex = 9
        Me.btShow1.Text = "In Danh Sách"
        Me.btShow1.UseVisualStyleBackColor = False
        '
        'btXoa1
        '
        Me.btXoa1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btXoa1.FlatAppearance.BorderSize = 2
        Me.btXoa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoa1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btXoa1.ForeColor = System.Drawing.Color.DimGray
        Me.btXoa1.Location = New System.Drawing.Point(670, 32)
        Me.btXoa1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btXoa1.Name = "btXoa1"
        Me.btXoa1.Size = New System.Drawing.Size(107, 46)
        Me.btXoa1.TabIndex = 8
        Me.btXoa1.Text = "Xóa"
        Me.btXoa1.UseVisualStyleBackColor = False
        '
        'btSua1
        '
        Me.btSua1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btSua1.FlatAppearance.BorderSize = 2
        Me.btSua1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSua1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btSua1.ForeColor = System.Drawing.Color.DimGray
        Me.btSua1.Location = New System.Drawing.Point(527, 32)
        Me.btSua1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btSua1.Name = "btSua1"
        Me.btSua1.Size = New System.Drawing.Size(107, 46)
        Me.btSua1.TabIndex = 7
        Me.btSua1.Text = "Sửa"
        Me.btSua1.UseVisualStyleBackColor = False
        '
        'btThem1
        '
        Me.btThem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btThem1.FlatAppearance.BorderSize = 2
        Me.btThem1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btThem1.ForeColor = System.Drawing.Color.DimGray
        Me.btThem1.Location = New System.Drawing.Point(380, 32)
        Me.btThem1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btThem1.Name = "btThem1"
        Me.btThem1.Size = New System.Drawing.Size(107, 46)
        Me.btThem1.TabIndex = 6
        Me.btThem1.Text = "Thêm"
        Me.btThem1.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(222, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 18)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Tên Khoa"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(34, 24)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 18)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Mã Khoa"
        '
        'txtMaKhoa1
        '
        Me.txtMaKhoa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaKhoa1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet11, "DMKhoa.MaKhoa", True))
        Me.txtMaKhoa1.Location = New System.Drawing.Point(18, 60)
        Me.txtMaKhoa1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaKhoa1.Name = "txtMaKhoa1"
        Me.txtMaKhoa1.Size = New System.Drawing.Size(128, 20)
        Me.txtMaKhoa1.TabIndex = 4
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTenKhoa
        '
        Me.txtTenKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet11, "DMKhoa.TenKhoa", True))
        Me.txtTenKhoa.Location = New System.Drawing.Point(201, 60)
        Me.txtTenKhoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenKhoa.Name = "txtTenKhoa"
        Me.txtTenKhoa.Size = New System.Drawing.Size(128, 20)
        Me.txtTenKhoa.TabIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaKhoaDataGridViewTextBoxColumn1, Me.TenKhoaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataMember = "DMKhoa"
        Me.DataGridView2.DataSource = Me.DataSet11
        Me.DataGridView2.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(812, 271)
        Me.DataGridView2.TabIndex = 0
        '
        'MaKhoaDataGridViewTextBoxColumn1
        '
        Me.MaKhoaDataGridViewTextBoxColumn1.DataPropertyName = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn1.HeaderText = "MaKhoa"
        Me.MaKhoaDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MaKhoaDataGridViewTextBoxColumn1.Name = "MaKhoaDataGridViewTextBoxColumn1"
        Me.MaKhoaDataGridViewTextBoxColumn1.Width = 125
        '
        'TenKhoaDataGridViewTextBoxColumn
        '
        Me.TenKhoaDataGridViewTextBoxColumn.DataPropertyName = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.HeaderText = "TenKhoa"
        Me.TenKhoaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenKhoaDataGridViewTextBoxColumn.Name = "TenKhoaDataGridViewTextBoxColumn"
        Me.TenKhoaDataGridViewTextBoxColumn.Width = 125
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
        'pnDMSinhVien
        '
        Me.pnDMSinhVien.Controls.Add(Me.pnDMSinhVienbot)
        Me.pnDMSinhVien.Controls.Add(Me.DataGridView1)
        Me.pnDMSinhVien.Location = New System.Drawing.Point(9, 106)
        Me.pnDMSinhVien.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnDMSinhVien.Name = "pnDMSinhVien"
        Me.pnDMSinhVien.Size = New System.Drawing.Size(821, 496)
        Me.pnDMSinhVien.TabIndex = 1
        '
        'pnDMSinhVienbot
        '
        Me.pnDMSinhVienbot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.pnDMSinhVienbot.Controls.Add(Me.btXoa)
        Me.pnDMSinhVienbot.Controls.Add(Me.btSua)
        Me.pnDMSinhVienbot.Controls.Add(Me.btShow)
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
        Me.pnDMSinhVienbot.Location = New System.Drawing.Point(0, 232)
        Me.pnDMSinhVienbot.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnDMSinhVienbot.Name = "pnDMSinhVienbot"
        Me.pnDMSinhVienbot.Size = New System.Drawing.Size(817, 285)
        Me.pnDMSinhVienbot.TabIndex = 0
        '
        'btXoa
        '
        Me.btXoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btXoa.FlatAppearance.BorderSize = 2
        Me.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btXoa.ForeColor = System.Drawing.Color.DimGray
        Me.btXoa.Location = New System.Drawing.Point(644, 158)
        Me.btXoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btXoa.Name = "btXoa"
        Me.btXoa.Size = New System.Drawing.Size(107, 46)
        Me.btXoa.TabIndex = 4
        Me.btXoa.Text = "Xóa"
        Me.btXoa.UseVisualStyleBackColor = False
        '
        'btSua
        '
        Me.btSua.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btSua.FlatAppearance.BorderSize = 2
        Me.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btSua.ForeColor = System.Drawing.Color.DimGray
        Me.btSua.Location = New System.Drawing.Point(644, 94)
        Me.btSua.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btSua.Name = "btSua"
        Me.btSua.Size = New System.Drawing.Size(107, 46)
        Me.btSua.TabIndex = 4
        Me.btSua.Text = "Sửa"
        Me.btSua.UseVisualStyleBackColor = False
        '
        'btShow
        '
        Me.btShow.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btShow.FlatAppearance.BorderSize = 2
        Me.btShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btShow.ForeColor = System.Drawing.Color.DimGray
        Me.btShow.Location = New System.Drawing.Point(426, 138)
        Me.btShow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btShow.Name = "btShow"
        Me.btShow.Size = New System.Drawing.Size(162, 46)
        Me.btShow.TabIndex = 4
        Me.btShow.Text = "In Danh Sách"
        Me.btShow.UseVisualStyleBackColor = False
        '
        'btThem
        '
        Me.btThem.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btThem.FlatAppearance.BorderSize = 2
        Me.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btThem.ForeColor = System.Drawing.Color.DimGray
        Me.btThem.Location = New System.Drawing.Point(644, 32)
        Me.btThem.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btThem.Name = "btThem"
        Me.btThem.Size = New System.Drawing.Size(107, 46)
        Me.btThem.TabIndex = 4
        Me.btThem.Text = "Thêm"
        Me.btThem.UseVisualStyleBackColor = False
        '
        'rdNu
        '
        Me.rdNu.AutoSize = True
        Me.rdNu.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.Phai", True))
        Me.rdNu.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdNu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.rdNu.Location = New System.Drawing.Point(183, 49)
        Me.rdNu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdNu.Name = "rdNu"
        Me.rdNu.Size = New System.Drawing.Size(41, 17)
        Me.rdNu.TabIndex = 3
        Me.rdNu.TabStop = True
        Me.rdNu.Text = "Nữ"
        Me.rdNu.UseVisualStyleBackColor = True
        '
        'rdNam
        '
        Me.rdNam.AutoSize = True
        Me.rdNam.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.Phai", True))
        Me.rdNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rdNam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.rdNam.Location = New System.Drawing.Point(183, 28)
        Me.rdNam.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rdNam.Name = "rdNam"
        Me.rdNam.Size = New System.Drawing.Size(50, 17)
        Me.rdNam.TabIndex = 2
        Me.rdNam.TabStop = True
        Me.rdNam.Text = "Nam"
        Me.rdNam.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(249, 196)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 18)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Học Bổng"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(48, 196)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Mã Khoa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(202, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Phái"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(38, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ Sinh Viên"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(305, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Nơi Sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(212, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ngày Sinh (yyyy/mm/dd)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 138)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tên Sinh Viên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Sinh Viên"
        '
        'txtHocBong
        '
        Me.txtHocBong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHocBong.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.HocBong", True))
        Me.txtHocBong.Location = New System.Drawing.Point(223, 216)
        Me.txtHocBong.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHocBong.Name = "txtHocBong"
        Me.txtHocBong.Size = New System.Drawing.Size(128, 20)
        Me.txtHocBong.TabIndex = 0
        '
        'txtMaKhoa
        '
        Me.txtMaKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaKhoa.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.MaKhoa", True))
        Me.txtMaKhoa.Location = New System.Drawing.Point(22, 216)
        Me.txtMaKhoa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaKhoa.Name = "txtMaKhoa"
        Me.txtMaKhoa.Size = New System.Drawing.Size(128, 20)
        Me.txtMaKhoa.TabIndex = 0
        '
        'txtHoSV
        '
        Me.txtHoSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoSV.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.HoSV", True))
        Me.txtHoSV.Location = New System.Drawing.Point(22, 94)
        Me.txtHoSV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtHoSV.Name = "txtHoSV"
        Me.txtHoSV.Size = New System.Drawing.Size(128, 20)
        Me.txtHoSV.TabIndex = 0
        '
        'txtNoiSinh
        '
        Me.txtNoiSinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoiSinh.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.NoiSinh", True))
        Me.txtNoiSinh.Location = New System.Drawing.Point(263, 29)
        Me.txtNoiSinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNoiSinh.Multiline = True
        Me.txtNoiSinh.Name = "txtNoiSinh"
        Me.txtNoiSinh.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNoiSinh.Size = New System.Drawing.Size(170, 83)
        Me.txtNoiSinh.TabIndex = 0
        '
        'txtNgaySinh
        '
        Me.txtNgaySinh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNgaySinh.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.NgaySinh", True))
        Me.txtNgaySinh.Location = New System.Drawing.Point(223, 158)
        Me.txtNgaySinh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNgaySinh.Name = "txtNgaySinh"
        Me.txtNgaySinh.Size = New System.Drawing.Size(128, 20)
        Me.txtNgaySinh.TabIndex = 0
        '
        'txtTenSV
        '
        Me.txtTenSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTenSV.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.TenSV", True))
        Me.txtTenSV.Location = New System.Drawing.Point(22, 158)
        Me.txtTenSV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTenSV.Name = "txtTenSV"
        Me.txtTenSV.Size = New System.Drawing.Size(128, 20)
        Me.txtTenSV.TabIndex = 0
        '
        'txtMaSV
        '
        Me.txtMaSV.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaSV.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.DataSet1, "DMSV.MaSV", True))
        Me.txtMaSV.Location = New System.Drawing.Point(22, 28)
        Me.txtMaSV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(128, 20)
        Me.txtMaSV.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaSVDataGridViewTextBoxColumn, Me.HoSVDataGridViewTextBoxColumn, Me.TenSVDataGridViewTextBoxColumn, Me.PhaiDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.NoiSinhDataGridViewTextBoxColumn, Me.MaKhoaDataGridViewTextBoxColumn, Me.HocBongDataGridViewTextBoxColumn})
        Me.DataGridView1.DataMember = "DMSV"
        Me.DataGridView1.DataSource = Me.DataSet1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(819, 227)
        Me.DataGridView1.TabIndex = 0
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
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLOLEDB.1;Data Source=DTRHIDRO\DTRHIDRO;Password=1234;User ID=sa;Initia" &
    "l Catalog=QuanLyDiemSV"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO DMSV" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                      (MaSV, HoSV, TenSV, Phai, NgaySinh, NoiSi" &
    "nh, MaKhoa, HocBong)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES    (?,?,?,?,?,?,?,?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.[Char], 0, "MaSV"), New System.Data.OleDb.OleDbParameter("HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, "HoSV"), New System.Data.OleDb.OleDbParameter("TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSV"), New System.Data.OleDb.OleDbParameter("Phai", System.Data.OleDb.OleDbType.WChar, 0, "Phai"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, "NoiSinh"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("HocBong", System.Data.OleDb.OleDbType.[Double], 0, "HocBong")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = resources.GetString("OleDbUpdateCommand1.CommandText")
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaSV", System.Data.OleDb.OleDbType.[Char], 0, "MaSV"), New System.Data.OleDb.OleDbParameter("HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, "HoSV"), New System.Data.OleDb.OleDbParameter("TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, "TenSV"), New System.Data.OleDb.OleDbParameter("Phai", System.Data.OleDb.OleDbType.WChar, 0, "Phai"), New System.Data.OleDb.OleDbParameter("NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "NgaySinh"), New System.Data.OleDb.OleDbParameter("NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, "NoiSinh"), New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("HocBong", System.Data.OleDb.OleDbType.[Double], 0, "HocBong"), New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Phai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phai", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NoiSinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HocBong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HocBong", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = resources.GetString("OleDbDeleteCommand1.CommandText")
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaSV", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_HoSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HoSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenSV", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenSV", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_Phai", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phai", System.Data.OleDb.OleDbType.WChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phai", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_NgaySinh", System.Data.OleDb.OleDbType.DBTimeStamp, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NgaySinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_NoiSinh", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_NoiSinh", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NoiSinh", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_MaKhoa", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("IsNull_HocBong", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.OleDb.OleDbParameter("Original_HocBong", System.Data.OleDb.OleDbType.[Double], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "HocBong", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DMSV", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaSV", "MaSV"), New System.Data.Common.DataColumnMapping("HoSV", "HoSV"), New System.Data.Common.DataColumnMapping("TenSV", "TenSV"), New System.Data.Common.DataColumnMapping("Phai", "Phai"), New System.Data.Common.DataColumnMapping("NgaySinh", "NgaySinh"), New System.Data.Common.DataColumnMapping("NoiSinh", "NoiSinh"), New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("HocBong", "HocBong")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT    DMKhoa.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         DMKhoa"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO DMKhoa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                      (MaKhoa, TenKhoa)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES    (?,?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa")})
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE    DMKhoa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SET             MaKhoa = ?, TenKhoa = ?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (MaKhoa = ?)" &
    " AND (TenKhoa = ?)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, "MaKhoa"), New System.Data.OleDb.OleDbParameter("TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, "TenKhoa"), New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM DMKhoa" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (MaKhoa = ?) AND (TenKhoa = ?)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_MaKhoa", System.Data.OleDb.OleDbType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MaKhoa", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_TenKhoa", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TenKhoa", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DMKhoa", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MaKhoa", "MaKhoa"), New System.Data.Common.DataColumnMapping("TenKhoa", "TenKhoa")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 612)
        Me.Controls.Add(Me.pnDMKhoa)
        Me.Controls.Add(Me.pnDMSinhVien)
        Me.Controls.Add(Me.pnTab)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnTab.ResumeLayout(False)
        Me.pnDMKhoa.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnDMSinhVien.ResumeLayout(False)
        Me.pnDMSinhVienbot.ResumeLayout(False)
        Me.pnDMSinhVienbot.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnTab As Panel
    Friend WithEvents pnDMKhoa As Panel
    Friend WithEvents btDMKhoa As Button
    Friend WithEvents btDMSinhVien As Button
    Friend WithEvents pnDMSinhVien As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents MaSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenSVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoiSinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HocBongDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents pnDMSinhVienbot As Panel
    Friend WithEvents txtHoSV As TextBox
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHocBong As TextBox
    Friend WithEvents txtMaKhoa As TextBox
    Friend WithEvents txtNoiSinh As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtTenSV As TextBox
    Friend WithEvents rdNu As RadioButton
    Friend WithEvents rdNam As RadioButton
    Friend WithEvents btThem As Button
    Friend WithEvents btXoa As Button
    Friend WithEvents btSua As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MaKhoaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TenKhoaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OleDbSelectCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As OleDb.OleDbDataAdapter
    Friend WithEvents btXoa1 As Button
    Friend WithEvents btSua1 As Button
    Friend WithEvents btThem1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMaKhoa1 As TextBox
    Friend WithEvents txtTenKhoa As TextBox
    Friend WithEvents DataSet11 As DataSet1
    Friend WithEvents btShow As Button
    Friend WithEvents btShow1 As Button
End Class
