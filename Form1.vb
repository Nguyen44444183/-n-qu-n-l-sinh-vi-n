Imports System.Data.SqlClient
Public Class Form1
    Dim connStr As String = "Data Source=LAPTOP-1CRISS0V\SQLEXPRESS;Initial Catalog=QLSinhVien9;Integrated Security=True"

    Private Sub btnDangnhap_Click(sender As Object, e As EventArgs) Handles btnDangnhap.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql = "SELECT * FROM TaiKhoan000 WHERE TenDangNhap=@ten AND MatKhau=@mk"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@ten", txtTenTaiKhoan.Text)
            cmd.Parameters.AddWithValue("@mk", txtMatkhau.Text)

            Dim rd = cmd.ExecuteReader()
            If rd.HasRows Then
                MessageBox.Show("Đăng nhập thành công!")
                Me.Hide()

                Dim frm As New FormMain()
                frm.ShowDialog()

                Me.Close()
                Else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!")
                End If
            End Using
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
End Class