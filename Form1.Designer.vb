<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnTitleBar = New System.Windows.Forms.Panel()
        Me.lbcurrentHome = New System.Windows.Forms.Label()
        Me.icLogoHome = New FontAwesome.Sharp.IconPictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnSlideBar = New System.Windows.Forms.FlowLayoutPanel()
        Me.btSV = New FontAwesome.Sharp.IconButton()
        Me.btKhoa = New FontAwesome.Sharp.IconButton()
        Me.slidebarTransition = New System.Windows.Forms.Timer(Me.components)
        Me.pnContainer = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnTitleBar.SuspendLayout()
        CType(Me.icLogoHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnSlideBar.SuspendLayout()
        Me.pnContainer.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnTitleBar
        '
        Me.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnTitleBar.Controls.Add(Me.lbcurrentHome)
        Me.pnTitleBar.Controls.Add(Me.icLogoHome)
        Me.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnTitleBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnTitleBar.Name = "pnTitleBar"
        Me.pnTitleBar.Size = New System.Drawing.Size(1182, 79)
        Me.pnTitleBar.TabIndex = 0
        '
        'lbcurrentHome
        '
        Me.lbcurrentHome.AutoSize = True
        Me.lbcurrentHome.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lbcurrentHome.ForeColor = System.Drawing.Color.DimGray
        Me.lbcurrentHome.Location = New System.Drawing.Point(94, 36)
        Me.lbcurrentHome.Name = "lbcurrentHome"
        Me.lbcurrentHome.Size = New System.Drawing.Size(66, 28)
        Me.lbcurrentHome.TabIndex = 2
        Me.lbcurrentHome.Text = "Home"
        '
        'icLogoHome
        '
        Me.icLogoHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.icLogoHome.ForeColor = System.Drawing.Color.DimGray
        Me.icLogoHome.IconChar = FontAwesome.Sharp.IconChar.List
        Me.icLogoHome.IconColor = System.Drawing.Color.DimGray
        Me.icLogoHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.icLogoHome.IconSize = 50
        Me.icLogoHome.Location = New System.Drawing.Point(12, 23)
        Me.icLogoHome.Name = "icLogoHome"
        Me.icLogoHome.Size = New System.Drawing.Size(50, 50)
        Me.icLogoHome.TabIndex = 2
        Me.icLogoHome.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(922, 419)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnSlideBar
        '
        Me.pnSlideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnSlideBar.Controls.Add(Me.btSV)
        Me.pnSlideBar.Controls.Add(Me.btKhoa)
        Me.pnSlideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnSlideBar.Location = New System.Drawing.Point(0, 79)
        Me.pnSlideBar.Name = "pnSlideBar"
        Me.pnSlideBar.Size = New System.Drawing.Size(90, 674)
        Me.pnSlideBar.TabIndex = 1
        '
        'btSV
        '
        Me.btSV.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.btSV.FlatAppearance.BorderSize = 0
        Me.btSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSV.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btSV.ForeColor = System.Drawing.Color.DimGray
        Me.btSV.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btSV.IconColor = System.Drawing.Color.DimGray
        Me.btSV.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSV.Location = New System.Drawing.Point(3, 3)
        Me.btSV.Name = "btSV"
        Me.btSV.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btSV.Size = New System.Drawing.Size(257, 54)
        Me.btSV.TabIndex = 2
        Me.btSV.Text = "        Sinh Viên"
        Me.btSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btSV.UseVisualStyleBackColor = False
        '
        'btKhoa
        '
        Me.btKhoa.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btKhoa.FlatAppearance.BorderSize = 0
        Me.btKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btKhoa.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btKhoa.ForeColor = System.Drawing.Color.DimGray
        Me.btKhoa.IconChar = FontAwesome.Sharp.IconChar.Clipboard
        Me.btKhoa.IconColor = System.Drawing.Color.DimGray
        Me.btKhoa.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btKhoa.Location = New System.Drawing.Point(3, 63)
        Me.btKhoa.Name = "btKhoa"
        Me.btKhoa.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btKhoa.Size = New System.Drawing.Size(257, 54)
        Me.btKhoa.TabIndex = 2
        Me.btKhoa.Text = "        Khoa"
        Me.btKhoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btKhoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btKhoa.UseVisualStyleBackColor = False
        '
        'slidebarTransition
        '
        Me.slidebarTransition.Interval = 1
        '
        'pnContainer
        '
        Me.pnContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnContainer.AutoSize = True
        Me.pnContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.pnContainer.Controls.Add(Me.PictureBox2)
        Me.pnContainer.Controls.Add(Me.PictureBox1)
        Me.pnContainer.Location = New System.Drawing.Point(213, 79)
        Me.pnContainer.Name = "pnContainer"
        Me.pnContainer.Size = New System.Drawing.Size(1008, 677)
        Me.pnContainer.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(677, 418)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(245, 256)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.pnContainer)
        Me.Controls.Add(Me.pnSlideBar)
        Me.Controls.Add(Me.pnTitleBar)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.pnTitleBar.ResumeLayout(False)
        Me.pnTitleBar.PerformLayout()
        CType(Me.icLogoHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnSlideBar.ResumeLayout(False)
        Me.pnContainer.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnTitleBar As Panel
    Friend WithEvents pnSlideBar As FlowLayoutPanel
    Friend WithEvents icLogoHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lbcurrentHome As Label
    Friend WithEvents btSV As FontAwesome.Sharp.IconButton
    Friend WithEvents btKhoa As FontAwesome.Sharp.IconButton
    Friend WithEvents slidebarTransition As Timer
    Friend WithEvents pnContainer As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
