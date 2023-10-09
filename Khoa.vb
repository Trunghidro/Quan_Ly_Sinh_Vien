Imports System.Data.OleDb

Public Class Khoa

    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
    End Sub
    Private Sub btThem_Click(sender As Object, e As EventArgs) Handles btThem.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO DMKhoa
                      (MaKhoa, TenKhoa)
VALUES    ('" & txtMaKhoa.Text & "', N'" & txtTenKhoa.Text & "')"
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
            Dim sql As String = "UPDATE [dbo].[DMKhoa]
   SET [MaKhoa] = '" & txtMaKhoa.Text & "'
      ,[TenKhoa] = N'" & txtTenKhoa.Text & "'
 WHERE [MaKhoa] = '" & txtMaKhoa.Text & "' "
            OleDbUpdateCommand1.CommandText = Sql
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
            Dim sql As String = "ELETE FROM [dbo].[DMKhoa]
      WHERE [MaKhoa] = '" & txtMaKhoa.Text & "' "
            OleDbDeleteCommand1.CommandText = sql
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
            Dim sql As String = "SELECT    MaKhoa, TenKhoa
FROM         DMKhoa"
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