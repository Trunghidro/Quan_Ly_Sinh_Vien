Imports System.Data.OleDb

Public Class Sv

    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
    End Sub
    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Try
            OleDbConnection1.Open()
            Dim gt As String = ""
            If rdNam.Checked = True Then
                gt = "Nam"
            Else rdNu.Checked = True
                gt = "Nữ"
            End If
            Dim sql As String = "INSERT INTO DMSV
                      (MaSV, HoSV, TenSV, Phai, NgaySinh, NoiSinh, MaKhoa, HocBong)
VALUES    ('" & txtMaSV.Text & "', N'" & txtHoSV.Text & "', N'" & txtTenSV.Text & "', N'" & gt & "'
, '" & txtNgaySinh.Text & "', N'" & txtNoiSinh.Text & "'
, '" & txtMaKhoa.Text & "', '" & txtHocBong.Text & "')"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btSua_Click(sender As Object, e As EventArgs) Handles btSua.Click
        Try
            OleDbConnection1.Open()
            Dim gt As String = ""
            If rdNam.Checked = True Then
                gt = "Nam"
            Else rdNu.Checked = True
                gt = "Nữ"
            End If
            Dim sql As String = "UPDATE [dbo].[DMSV]
   SET [MaSV] = '" & txtMaSV.Text & "'
      ,[HoSV] = N'" & txtHoSV.Text & "'
      ,[TenSV] =  N'" & txtTenSV.Text & "'
      ,[Phai] = N'" & gt & "'
      ,[NgaySinh] = '" & txtNgaySinh.Text & "'
      ,[NoiSinh] = N'" & txtNoiSinh.Text & "'
      ,[MaKhoa] = '" & txtMaKhoa.Text & "'
      ,[HocBong] = '" & txtHocBong.Text & "'
 WHERE [MaSV] = '" & txtMaSV.Text & "'"
            OleDbUpdateCommand1.CommandText() = Sql
            OleDbUpdateCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoa_Click(sender As Object, e As EventArgs) Handles btXoa.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [dbo].[DMSV]
      WHERE [MaSV] = '" & txtMaSV.Text & "'"
            OleDbDeleteCommand1.CommandText() = Sql
            OleDbDeleteCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btInd_Click(sender As Object, e As EventArgs) Handles btInd.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "SELECT    MaSV, HoSV, TenSV, Phai, NgaySinh, NoiSinh, MaKhoa, HocBong
FROM         DMSV"
            OleDbSelectCommand1.CommandText = sql
            OleDbSelectCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class