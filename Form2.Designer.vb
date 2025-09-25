<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtMaSV = New System.Windows.Forms.TextBox()
        Me.txtHocKy = New System.Windows.Forms.TextBox()
        Me.txtSoTien = New System.Windows.Forms.TextBox()
        Me.txtTrangThai = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvHocPhi = New System.Windows.Forms.DataGridView()
        CType(Me.dgvHocPhi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(610, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(635, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bảng Quản Lý Học Phí"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(701, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Số Tiền"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(230, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mã sinh viên"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Học Kỳ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(701, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Trạng Thái"
        '
        'txtMaSV
        '
        Me.txtMaSV.Location = New System.Drawing.Point(374, 140)
        Me.txtMaSV.Name = "txtMaSV"
        Me.txtMaSV.Size = New System.Drawing.Size(189, 22)
        Me.txtMaSV.TabIndex = 5
        '
        'txtHocKy
        '
        Me.txtHocKy.Location = New System.Drawing.Point(374, 217)
        Me.txtHocKy.Name = "txtHocKy"
        Me.txtHocKy.Size = New System.Drawing.Size(189, 22)
        Me.txtHocKy.TabIndex = 6
        '
        'txtSoTien
        '
        Me.txtSoTien.Location = New System.Drawing.Point(815, 140)
        Me.txtSoTien.Name = "txtSoTien"
        Me.txtSoTien.Size = New System.Drawing.Size(222, 22)
        Me.txtSoTien.TabIndex = 7
        '
        'txtTrangThai
        '
        Me.txtTrangThai.Location = New System.Drawing.Point(815, 217)
        Me.txtTrangThai.Name = "txtTrangThai"
        Me.txtTrangThai.Size = New System.Drawing.Size(222, 22)
        Me.txtTrangThai.TabIndex = 8
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(1262, 116)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(1262, 193)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 10
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(1262, 252)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 11
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvHocPhi
        '
        Me.dgvHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHocPhi.Location = New System.Drawing.Point(36, 304)
        Me.dgvHocPhi.Name = "dgvHocPhi"
        Me.dgvHocPhi.RowHeadersWidth = 51
        Me.dgvHocPhi.RowTemplate.Height = 24
        Me.dgvHocPhi.Size = New System.Drawing.Size(1830, 544)
        Me.dgvHocPhi.TabIndex = 12
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1904, 860)
        Me.Controls.Add(Me.dgvHocPhi)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtTrangThai)
        Me.Controls.Add(Me.txtSoTien)
        Me.Controls.Add(Me.txtHocKy)
        Me.Controls.Add(Me.txtMaSV)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dgvHocPhi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtHocKy As TextBox
    Friend WithEvents txtSoTien As TextBox
    Friend WithEvents txtTrangThai As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents dgvHocPhi As DataGridView
End Class
