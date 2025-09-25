Imports System.Data.SqlClient
Public Class FormLopKhoa
    Dim conn As New SqlConnection("Data Source=LAPTOP-1CRISS0V\SQLEXPRESS;Initial Catalog=QLSinhVien9;Integrated Security=True")
    Private Sub LoadLopKhoa()
        Try
            Dim sql As String = "SELECT * FROM LopKhoa"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvLopKhoa.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Lỗi load dữ liệu: " & ex.Message)
        End Try

    End Sub
    Private Sub FrmLopKhoa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLopKhoa()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim sql As String = "INSERT INTO LopKhoa (TenLop, Khoa,MaLop) VALUES (@TenLop, @Khoa,@MaLop)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text)
                cmd.Parameters.AddWithValue("@Khoa", txtKhoa.Text)
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
            LoadLopKhoa()
            MessageBox.Show("Thêm lớp thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi thêm: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Try
            Dim sql As String = "UPDATE LopKhoa SET TenLop=@TenLop, Khoa=@Khoa WHERE MaLop=@MaLop"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
                cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text)
                cmd.Parameters.AddWithValue("@Khoa", txtKhoa.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
            LoadLopKhoa()
            MessageBox.Show("Sửa lớp thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi sửa: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim sql As String = "DELETE FROM LopKhoa WHERE MaLop=@MaLop"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
            LoadLopKhoa()
            MessageBox.Show("Xóa lớp thành công!")
        Catch ex As Exception
            MessageBox.Show("Lỗi xóa: " & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgvLopKhoa_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLopKhoa.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLopKhoa.Rows(e.RowIndex)
            txtMaLop.Text = row.Cells("MaLop").Value.ToString()
            txtTenLop.Text = row.Cells("TenLop").Value.ToString()
            txtKhoa.Text = row.Cells("Khoa").Value.ToString()
        End If
    End Sub
End Class