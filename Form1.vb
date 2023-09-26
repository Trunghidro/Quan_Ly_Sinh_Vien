Imports System.Windows.Forms.VisualStyles

Public Class Form1
    'controler loaddata
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
        OleDbDataAdapter2.Fill(DataSet11)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'cotroler chuyen tab
    Private Sub btDMSinhVien_Click(sender As Object, e As EventArgs) Handles btDMSinhVien.Click
        pnDMSinhVien.Visible = True
        pnDMKhoa.Visible = False
    End Sub

    Private Sub btDMKhoa_Click(sender As Object, e As EventArgs) Handles btDMKhoa.Click
        pnDMKhoa.Visible = True
        pnDMSinhVien.Visible = False
    End Sub

    'controler tab Sinh Vien
    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Dim gt As String = ""
        If rdNam.Checked = True Then
            gt = "Nam"
        Else rdNu.Checked = True
            gt = "Nữ"
        End If
        Try
            OleDbConnection1.Open()
            Dim sqla As String = "INSERT INTO DMSV
                      (MaSV, HoSV, TenSV, Phai, NgaySinh, NoiSinh, MaKhoa, HocBong)
VALUES    (N'" & txtMaSV.Text & "',N'" & txtHoSV.Text & "',N'" & txtTenSV.Text & "',N'" & gt & "',
N'" & txtNgaySinh.Text & "',N'" & txtNoiSinh.Text & "',N'" & txtMaKhoa.Text & "',N'" & txtHocBong.Text & "')"
            OleDbInsertCommand1.CommandText = sqla
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Dim gt As String = ""
        If rdNam.Checked = True Then
            gt = "Nam"
        Else rdNu.Checked = True
            gt = "Nữ"
        End If
        Try
            OleDbConnection1.Open()
            Dim sqlb As String = "UPDATE    [DMSV]
SET             [MaSV] = N'" & txtMaSV.Text & "', [HoSV] = N'" & txtHoSV.Text & "'
, [TenSV] = N'" & txtTenSV.Text & "', [Phai] = N'" & gt & "', [NgaySinh] = N'" & txtNgaySinh.Text & "',
[NoiSinh] = N'" & txtNoiSinh.Text & "', [MaKhoa] = N'" & txtMaKhoa.Text & "', [HocBong] = N'" & txtHocBong.Text & "'
WHERE     (([MaSV] = N'" & txtMaSV.Text & "') "
            OleDbUpdateCommand1.CommandText() = sqlb
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Dim gt As String = ""
        If rdNam.Checked = True Then
            gt = "Nam"
        Else rdNu.Checked = True
            gt = "Nữ"
        End If
        Try
            OleDbConnection1.Open()
            Dim sqlc As String = "DELETE FROM [DMSV]
WHERE     (([MaSV] = N'" & txtMaSV.Text & "))"
            OleDbDeleteCommand1.CommandText() = sqlc
            OleDbDeleteCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    ' controler tab Khoa
    Private Sub btThem1_Click(sender As Object, e As EventArgs) Handles btThem1.Click
        loaddata()
        Try
            OleDbConnection1.Open()
            Dim sql0 As String = "INSERT INTO DMKhoa
                      (MaKhoa, TenKhoa)
VALUES    (N'" & txtMaKhoa1.Text & "',N'" & txtTenKhoa.Text & "')"
            OleDbInsertCommand2.CommandText = sql0
            OleDbInsertCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btSua1_Click(sender As Object, e As EventArgs) Handles btSua1.Click
        loaddata()
        Try
            OleDbConnection1.Open()
            Dim sql1 As String = "UPDATE    DMKhoa
SET             MaKhoa = N'" & txtMaKhoa1.Text & "', TenKhoa = N'" & txtTenKhoa.Text & "'
WHERE     (MaKhoa = N'" & txtMaKhoa1.Text & "')"
            OleDbUpdateCommand2.CommandText = sql1
            OleDbUpdateCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoa1_Click(sender As Object, e As EventArgs) Handles btXoa1.Click
        loaddata()
        Try
            OleDbConnection1.Open()
            Dim sql2 As String = "DELETE FROM DMKhoa
WHERE     (MaKhoa =  N'" & txtMaKhoa1.Text & "')"
            OleDbDeleteCommand2.CommandText = sql2
            OleDbDeleteCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'show hang tuyen
    Private Sub btShow_Click(sender As Object, e As EventArgs) Handles btShow.Click
        OleDbConnection1.Open()
        Dim show As String = "SELECT    MaSV, HoSV, TenSV, Phai, NgaySinh, NoiSinh, MaKhoa, HocBong
FROM         DMSV"
        OleDbSelectCommand1.CommandText = show
        OleDbSelectCommand1.ExecuteNonQuery()
        OleDbConnection1.Close()
        DataSet1.Clear()
        loaddata()
    End Sub

    Private Sub btShow1_Click(sender As Object, e As EventArgs) Handles btShow1.Click
        OleDbConnection1.Open()
        Dim show As String = "SELECT    MaKhoa, TenKhoa
FROM         DMKhoa"
        OleDbSelectCommand2.CommandText = show
        OleDbSelectCommand2.ExecuteNonQuery()
        OleDbConnection1.Close()
        DataSet11.Clear()
        loaddata()
    End Sub
End Class
