Imports System.Data.SqlClient
Public Class Form2
    Dim connStr As String = "Data Source=LAPTOP-1CRISS0V\SQLEXPRESS;Initial Catalog=QLSinhVien9;Integrated Security=True"
    Private Sub LoadData()
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "SELECT MaSV, HocKy, SoTien, TrangThai FROM HocPhi"
            Dim da As New SqlDataAdapter(sql, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvHocPhi.DataSource = dt
        End Using
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "INSERT INTO HocPhi (MaSV, HocKy, SoTien, TrangThai) 
                                 VALUES (@MaSV, @HocKy, @SoTien, @TrangThai)"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
                cmd.Parameters.AddWithValue("@HocKy", txtHocKy.Text)
                cmd.Parameters.AddWithValue("@SoTien", Decimal.Parse(txtSoTien.Text))
                cmd.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
        MessageBox.Show("Thêm thành công!")
        LoadData()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "UPDATE HocPhi 
                                 SET SoTien = @SoTien, TrangThai = @TrangThai 
                                 WHERE MaSV = @MaSV AND HocKy = @HocKy"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
                cmd.Parameters.AddWithValue("@HocKy", txtHocKy.Text)
                cmd.Parameters.AddWithValue("@SoTien", Decimal.Parse(txtSoTien.Text))
                cmd.Parameters.AddWithValue("@TrangThai", txtTrangThai.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
        MessageBox.Show("Sửa thành công!")
        LoadData()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Using conn As New SqlConnection(connStr)
            Dim sql As String = "DELETE FROM HocPhi WHERE MaSV = @MaSV AND HocKy = @HocKy"
            Using cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text)
                cmd.Parameters.AddWithValue("@HocKy", txtHocKy.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        End Using
        MessageBox.Show("Xóa thành công!")
        LoadData()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class