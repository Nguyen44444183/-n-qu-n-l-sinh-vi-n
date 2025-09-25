<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSinhVien = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHocPhi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLopKhoa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDangXuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSinhVien, Me.mnuHocPhi, Me.mnuLopKhoa, Me.mnuDangXuat})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(2401, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSinhVien
        '
        Me.mnuSinhVien.Name = "mnuSinhVien"
        Me.mnuSinhVien.Size = New System.Drawing.Size(140, 24)
        Me.mnuSinhVien.Text = "Quản Lý Sinh Viên"
        '
        'mnuHocPhi
        '
        Me.mnuHocPhi.Name = "mnuHocPhi"
        Me.mnuHocPhi.Size = New System.Drawing.Size(130, 24)
        Me.mnuHocPhi.Text = "Quản Lý Học Phí"
        '
        'mnuLopKhoa
        '
        Me.mnuLopKhoa.Name = "mnuLopKhoa"
        Me.mnuLopKhoa.Size = New System.Drawing.Size(142, 24)
        Me.mnuLopKhoa.Text = "Quản Lý Lớp Khoa"
        '
        'mnuDangXuat
        '
        Me.mnuDangXuat.Name = "mnuDangXuat"
        Me.mnuDangXuat.Size = New System.Drawing.Size(93, 24)
        Me.mnuDangXuat.Text = "Đăng Xuất"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1921, 808)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuSinhVien As ToolStripMenuItem
    Friend WithEvents mnuHocPhi As ToolStripMenuItem
    Friend WithEvents mnuLopKhoa As ToolStripMenuItem
    Friend WithEvents mnuDangXuat As ToolStripMenuItem
End Class
