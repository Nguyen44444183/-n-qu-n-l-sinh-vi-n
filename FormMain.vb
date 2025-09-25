Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hệ thống quản lý sinh viên"
    End Sub

    Private Sub mnuSinhVien_Click(sender As Object, e As EventArgs) Handles mnuSinhVien.Click
        Dim f As New FrmSinhvienvb
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuHocPhi_Click(sender As Object, e As EventArgs) Handles mnuHocPhi.Click
        Dim f As New Form2
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuLopKhoa_Click(sender As Object, e As EventArgs) Handles mnuLopKhoa.Click
        Dim f As New FormLopKhoa
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuDangXuat_Click(sender As Object, e As EventArgs) Handles mnuDangXuat.Click
        Dim f As New Form1
        f.Show()
        Me.Close()
    End Sub
End Class