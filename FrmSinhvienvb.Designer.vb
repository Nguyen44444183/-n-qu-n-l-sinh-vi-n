<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSinhvienvb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtGioitinh = New System.Windows.Forms.TextBox()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.txtLop = New System.Windows.Forms.TextBox()
        Me.dgvSinhvien = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnTaithongtin = New System.Windows.Forms.Button()
        Me.txtNgaysinh = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvSinhvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(967, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bảng Quản Lý Thông Tin Sinh Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Họ tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã sinh viên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(98, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ngày Sinh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(620, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Lớp"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(620, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giới tính "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(620, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Địa chỉ "
        '
        'txtMaSV
        '
        Me.txtMaSV.Location = New System.Drawing.Point(262, 98)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(213, 22)
        Me.txtMaSV.TabIndex = 7
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(262, 164)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(213, 22)
        Me.txtHoTen.TabIndex = 8
        '
        'txtGioitinh
        '
        Me.txtGioitinh.Location = New System.Drawing.Point(731, 98)
        Me.txtGioitinh.Name = "txtGioitinh"
        Me.txtGioitinh.Size = New System.Drawing.Size(206, 22)
        Me.txtGioitinh.TabIndex = 9
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(731, 164)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(206, 22)
        Me.txtDiachi.TabIndex = 11
        '
        'txtLop
        '
        Me.txtLop.Location = New System.Drawing.Point(731, 224)
        Me.txtLop.Name = "txtLop"
        Me.txtLop.Size = New System.Drawing.Size(206, 22)
        Me.txtLop.TabIndex = 12
        '
        'dgvSinhvien
        '
        Me.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSinhvien.Location = New System.Drawing.Point(32, 271)
        Me.dgvSinhvien.Name = "dgvSinhvien"
        Me.dgvSinhvien.RowHeadersWidth = 51
        Me.dgvSinhvien.RowTemplate.Height = 24
        Me.dgvSinhvien.Size = New System.Drawing.Size(1452, 423)
        Me.dgvSinhvien.TabIndex = 13
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(1049, 98)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(85, 29)
        Me.btnThem.TabIndex = 14
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(1049, 223)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(85, 23)
        Me.btnXoa.TabIndex = 15
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(1049, 161)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(85, 25)
        Me.btnSua.TabIndex = 16
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnTaithongtin
        '
        Me.btnTaithongtin.Location = New System.Drawing.Point(1217, 161)
        Me.btnTaithongtin.Name = "btnTaithongtin"
        Me.btnTaithongtin.Size = New System.Drawing.Size(112, 25)
        Me.btnTaithongtin.TabIndex = 17
        Me.btnTaithongtin.Text = "Tải Thông Tin"
        Me.btnTaithongtin.UseVisualStyleBackColor = True
        '
        'txtNgaysinh
        '
        Me.txtNgaysinh.Location = New System.Drawing.Point(262, 224)
        Me.txtNgaysinh.Name = "txtNgaysinh"
        Me.txtNgaysinh.Size = New System.Drawing.Size(213, 22)
        Me.txtNgaysinh.TabIndex = 18
        '
        'FrmSinhvienvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1521, 741)
        Me.Controls.Add(Me.txtNgaysinh)
        Me.Controls.Add(Me.btnTaithongtin)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.dgvSinhvien)
        Me.Controls.Add(Me.txtLop)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.txtGioitinh)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSinhvienvb"
        Me.Text = "FrmSinhvienvb"
        CType(Me.dgvSinhvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtGioitinh As TextBox
    Friend WithEvents txtDiachi As TextBox
    Friend WithEvents txtLop As TextBox
    Friend WithEvents dgvSinhvien As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnTaithongtin As Button
    Friend WithEvents txtNgaysinh As DateTimePicker
End Class
