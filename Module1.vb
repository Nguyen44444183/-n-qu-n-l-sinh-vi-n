Imports System.Data.SqlClient
Module Database
    Public conn As SqlConnection

    Public Sub ConnectDB()
        Dim strConn As String = "Data Source=LAPTOP-1CRISS0V.\SQLEXPRESS;Initial Catalog=QLSinhVien;Integrated Security=True"
        conn = New SqlConnection(strConn)
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Kết nối thất bại: " & ex.Message)
        End Try
    End Sub

End Module
