Imports System.Data.SqlClient

Public Class FrmSinhvienvb
    Dim connStr As String = "Data Source=LAPTOP-1CRISS0V\SQLEXPRESS;Initial Catalog=QLSinhVien9;Integrated Security=True"

    Private Sub LoadData()
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "SELECT * FROM SinhVien000"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvSinhvien.DataSource = dt
        End Using
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "INSERT INTO SinhVien000(MaSV, HoTen, NgaySinh, Lop, DiaChi) VALUES(@MaSV, @HoTen, @NgaySinh, @Lop, @DiaChi)"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txtNgaySinh.Text))
            cmd.Parameters.AddWithValue("@Lop", txtLop.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            cmd.Parameters.AddWithValue("@Gioitinh", txtGioitinh.Text)
            cmd.ExecuteNonQuery()
        End Using
        LoadData()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "UPDATE SinhVien000 SET HoTen=@HoTen, NgaySinh=@NgaySinh, Lop=@Lop, DiaChi=@DiaChi WHERE MaSV=@MaSV"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text)
            cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(txtNgaysinh.Text))
            cmd.Parameters.AddWithValue("@Lop", txtLop.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text)
            cmd.Parameters.AddWithValue("@Gioitinh", txtGioitinh.Text)
            cmd.ExecuteNonQuery()
        End Using
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Using conn As New SqlConnection(connStr)
            conn.Open()
            Dim sql As String = "DELETE FROM SinhVien000 WHERE MaSV=@MaSV"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
            cmd.ExecuteNonQuery()
        End Using
        LoadData()
    End Sub

    Private Sub btnTaithongtin_Click(sender As Object, e As EventArgs) Handles btnTaithongtin.Click

        Try
            Using conn As New SqlConnection(connStr)
                conn.Open()
                Dim sql As String = "SELECT MaSV, HoTen, GioiTinh, NgaySinh, Lop FROM SinhVien000"
                Dim da As New SqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvSinhvien.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi tải dữ liệu: " & ex.Message)
        End Try
    End Sub
End Class
