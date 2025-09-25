CREATE DATABASE QLSinhVien9;
GO
USE QLSinhVien9;

CREATE TABLE TaiKhoan000 (
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50) NOT NULL,
);

CREATE TABLE SinhVien000 (
    MaSV NVARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(200),
    Lop NVARCHAR(50)
);

CREATE TABLE LopKhoa (
    MaLop NVARCHAR(20) PRIMARY KEY,
    TenLop NVARCHAR(100),
    Khoa NVARCHAR(100)
);

CREATE TABLE HocPhi (
    MaHP INT IDENTITY PRIMARY KEY,
    MaSV NVARCHAR(20),
    HocKy NVARCHAR(20),
    SoTien DECIMAL(18,2),
    TrangThai NVARCHAR(20),
    FOREIGN KEY (MaSV) REFERENCES SinhVien000(MaSV)
);
INSERT INTO TaiKhoan000 VALUES
('admin','123'),
('sv001','111'),
('sv002','222'),
('sv003','333'),
('sv004','444'),
('sv005','555'),
('sv006','666');
select * from TaiKhoan000
INSERT INTO LopKhoa VALUES
('CTK43', N'Công nghệ Thông tin K43', N'Công nghệ Thông tin'),
('QTKD42', N'Quản trị Kinh doanh K42', N'Kinh tế'),
('KT44',  N'Kế toán K44', N'Kinh tế');
select * from LopKhoa
INSERT INTO SinhVien000 VALUES
('SV001', N'Nguyễn Văn An',  '2003-05-12', N'Nam', N'Hà Nội',     'CTK43'),
('SV002', N'Trần Thị Bình',  '2002-09-23', N'Nữ', N'Hải Phòng',   'CTK43'),
('SV003', N'Lê Văn Cường',  '2003-01-15', N'Nam', N'Hà Nam',      'QTKD42'),
('SV004', N'Phạm Thị Dung', '2002-11-02', N'Nữ', N'Hưng Yên',     'QTKD42'),
('SV005', N'Hoàng Văn Nam',  '2003-07-21', N'Nam', N'Nam Định',    'KT44'),
('SV006', N'Nguyễn Thị Hạnh','2002-03-10', N'Nữ', N'Thanh Hóa',   'KT44');
select * from SinhVien000
INSERT INTO HocPhi (MaSV,HocKy,SoTien,TrangThai) VALUES
('SV001', 'HK1-2023', 5000000, N'Đã nộp'),
('SV001', 'HK2-2023', 5200000, N'Chưa nộp'),

('SV002', 'HK1-2023', 5000000, N'Đã nộp'),
('SV002', 'HK2-2023', 5200000, N'Đã nộp'),

('SV003', 'HK1-2023', 4800000, N'Chưa nộp'),

('SV004', 'HK1-2023', 4700000, N'Đã nộp'),

('SV005', 'HK1-2023', 4500000, N'Chưa nộp'),

('SV006', 'HK1-2023', 4600000, N'Đã nộp');
select * from HocPhi

IF OBJECT_ID('HocPhiMoi', 'U') IS NOT NULL
    DROP TABLE HocPhiMoi;
GO

CREATE TABLE HocPhiMoi (
    MaHP INT PRIMARY KEY,           
    MaSV NVARCHAR(10) NOT NULL,     
    HocKy NVARCHAR(20) NOT NULL,    
    SoTien INT NOT NULL,            
    TrangThai NVARCHAR(20) NOT NULL 
);
INSERT INTO HocPhiMoi (MaHP, MaSV, HocKy, SoTien, TrangThai)
VALUES
(1, 'SV001', 'HK1-2024', 5000000, N'Chưa nộp'),
(2, 'SV001', 'HK2-2024', 5200000, N'Đã nộp'),
(3, 'SV002', 'HK1-2024', 4800000, N'Đã nộp'),
(4, 'SV002', 'HK2-2024', 5300000, N'Chưa nộp'),
(5, 'SV003', 'HK1-2024', 4500000, N'Đã nộp'),
(6, 'SV003', 'HK2-2024', 5500000, N'Chưa nộp');
SELECT * FROM HocPhiMoi;
DROP TABLE IF EXISTS HocPhiMoi;
CREATE TABLE HocPhi00 (
    MaSV NVARCHAR(10) NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL,
    NgayDong DATE NOT NULL
);
INSERT INTO HocPhi (MaSV, SoTien, ngaydong5) VALUES
('SV001', 2500000, '2025-01-10'),
('SV002', 3000000, '2025-01-15'),
('SV003', 2000000, '2025-02-01'),
('SV004', 3500000, '2025-02-05'),
('SV005', 2800000, '2025-02-20'),
('SV006', 4000000, '2025-03-01');
SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'HocPhi';
DROP TABLE IF EXISTS HocPhi;
IF OBJECT_ID('HocPhi', 'U') IS NOT NULL
    DROP TABLE HocPhi;
GO

CREATE TABLE HocPhi (
    MaSV NVARCHAR(10) NOT NULL,
    HocKy NVARCHAR(20) NOT NULL,
    SoTien DECIMAL(18,2) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL
);
GO
INSERT INTO HocPhi (MaSV, HocKy, SoTien, TrangThai)
VALUES
('SV001', N'HK1-2024', 5000000, N'Đã nộp'),
('SV001', N'HK2-2024', 5200000, N'Chưa nộp'),
('SV002', N'HK1-2024', 4800000, N'Đã nộp'),
('SV002', N'HK2-2024', 5300000, N'Chưa nộp'),
('SV003', N'HK1-2024', 4500000, N'Đã nộp'),
('SV003', N'HK2-2024', 5500000, N'Chưa nộp');
select * from HocPhi






