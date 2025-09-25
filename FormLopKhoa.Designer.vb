<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLopKhoa
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
        Me.txtMaLop = New System.Windows.Forms.TextBox()
        Me.txtTenLop = New System.Windows.Forms.TextBox()
        Me.txtKhoa = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvLopKhoa = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLopKhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(547, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(680, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bảng Quản Lý Lớp Khoa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MaLop"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TenLop"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(701, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Khoa"
        '
        'txtMaLop
        '
        Me.txtMaLop.Location = New System.Drawing.Point(374, 133)
        Me.txtMaLop.Name = "txtMaLop"
        Me.txtMaLop.Size = New System.Drawing.Size(207, 22)
        Me.txtMaLop.TabIndex = 4
        '
        'txtTenLop
        '
        Me.txtTenLop.Location = New System.Drawing.Point(374, 218)
        Me.txtTenLop.Name = "txtTenLop"
        Me.txtTenLop.Size = New System.Drawing.Size(207, 22)
        Me.txtTenLop.TabIndex = 5
        '
        'txtKhoa
        '
        Me.txtKhoa.Location = New System.Drawing.Point(832, 133)
        Me.txtKhoa.Name = "txtKhoa"
        Me.txtKhoa.Size = New System.Drawing.Size(264, 22)
        Me.txtKhoa.TabIndex = 6
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(1339, 104)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 7
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(1339, 170)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(1339, 245)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 9
        Me.btnXoa.Text = "Xoa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvLopKhoa
        '
        Me.dgvLopKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLopKhoa.Location = New System.Drawing.Point(102, 316)
        Me.dgvLopKhoa.Name = "dgvLopKhoa"
        Me.dgvLopKhoa.RowHeadersWidth = 51
        Me.dgvLopKhoa.RowTemplate.Height = 24
        Me.dgvLopKhoa.Size = New System.Drawing.Size(1569, 439)
        Me.dgvLopKhoa.TabIndex = 10
        '
        'FormLopKhoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1826, 796)
        Me.Controls.Add(Me.dgvLopKhoa)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtKhoa)
        Me.Controls.Add(Me.txtTenLop)
        Me.Controls.Add(Me.txtMaLop)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLopKhoa"
        Me.Text = "FormLopKhoa"
        CType(Me.dgvLopKhoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaLop As TextBox
    Friend WithEvents txtTenLop As TextBox
    Friend WithEvents txtKhoa As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents dgvLopKhoa As DataGridView
End Class
