<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTenTaiKhoan = New System.Windows.Forms.TextBox()
        Me.txtMatkhau = New System.Windows.Forms.TextBox()
        Me.btnDangnhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(168, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng Nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Tài Khoản "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mật Khẩu"
        '
        'txtTenTaiKhoan
        '
        Me.txtTenTaiKhoan.Location = New System.Drawing.Point(262, 98)
        Me.txtTenTaiKhoan.Name = "txtTenTaiKhoan"
        Me.txtTenTaiKhoan.Size = New System.Drawing.Size(223, 22)
        Me.txtTenTaiKhoan.TabIndex = 3
        '
        'txtMatkhau
        '
        Me.txtMatkhau.Location = New System.Drawing.Point(262, 172)
        Me.txtMatkhau.Name = "txtMatkhau"
        Me.txtMatkhau.Size = New System.Drawing.Size(223, 22)
        Me.txtMatkhau.TabIndex = 4
        '
        'btnDangnhap
        '
        Me.btnDangnhap.Location = New System.Drawing.Point(140, 233)
        Me.btnDangnhap.Name = "btnDangnhap"
        Me.btnDangnhap.Size = New System.Drawing.Size(101, 34)
        Me.btnDangnhap.TabIndex = 5
        Me.btnDangnhap.Text = "Đăng nhập"
        Me.btnDangnhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(322, 233)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(94, 34)
        Me.btnThoat.TabIndex = 6
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 345)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangnhap)
        Me.Controls.Add(Me.txtMatkhau)
        Me.Controls.Add(Me.txtTenTaiKhoan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenTaiKhoan As TextBox
    Friend WithEvents txtMatkhau As TextBox
    Friend WithEvents btnDangnhap As Button
    Friend WithEvents btnThoat As Button
End Class
