-- CSDL quản lý cơ sở vật chất trường học + tài khoản/phân quyền (SQL Server)
-- Có thể chạy lại nhiều lần: chỉ tạo phần còn thiếu, không xóa dữ liệu cũ.
IF DB_ID(N'QLCSVC') IS NULL CREATE DATABASE QLCSVC;
GO
USE QLCSVC;
GO
IF OBJECT_ID('LoaiThietBi','U') IS NULL CREATE TABLE LoaiThietBi(
  MaLoai INT IDENTITY PRIMARY KEY, TenLoai NVARCHAR(100) NOT NULL UNIQUE);
IF OBJECT_ID('Phong','U') IS NULL CREATE TABLE Phong(
  MaPhong VARCHAR(10) PRIMARY KEY, TenPhong NVARCHAR(100) NOT NULL, Toa NVARCHAR(50),
  Tang INT DEFAULT 1, SucChua INT DEFAULT 0, LoaiPhong NVARCHAR(50));
IF OBJECT_ID('ThietBi','U') IS NULL CREATE TABLE ThietBi(
  MaTB INT IDENTITY PRIMARY KEY, TenTB NVARCHAR(150) NOT NULL,
  MaLoai INT NOT NULL REFERENCES LoaiThietBi(MaLoai),
  MaPhong VARCHAR(10) NOT NULL REFERENCES Phong(MaPhong),
  SoLuong INT NOT NULL DEFAULT 1 CHECK (SoLuong >= 0),
  TinhTrang NVARCHAR(30) NOT NULL DEFAULT N'Tốt' CHECK (TinhTrang IN (N'Tốt',N'Cần bảo trì',N'Hỏng',N'Thanh lý')),
  NgayMua DATE, GiaTri DECIMAL(18,0) DEFAULT 0, GhiChu NVARCHAR(255));
-- ===== Tài khoản & phân quyền =====
IF OBJECT_ID('VaiTro','U') IS NULL CREATE TABLE VaiTro(
  MaVaiTro INT IDENTITY PRIMARY KEY, TenVaiTro NVARCHAR(50) NOT NULL UNIQUE);
IF OBJECT_ID('NguoiDung','U') IS NULL CREATE TABLE NguoiDung(
  MaND INT IDENTITY PRIMARY KEY,
  TenDangNhap VARCHAR(50) NOT NULL UNIQUE,
  MatKhauHash VARBINARY(64) NOT NULL,          -- PBKDF2-SHA256, không lưu mật khẩu thô
  Salt VARBINARY(16) NOT NULL,
  HoTen NVARCHAR(100),
  MaVaiTro INT NOT NULL REFERENCES VaiTro(MaVaiTro),
  TrangThai BIT NOT NULL DEFAULT 1,            -- 1 hoạt động, 0 bị khóa
  BatDoiMatKhau BIT NOT NULL DEFAULT 1,        -- buộc đổi mật khẩu lần đầu
  SoLanSai INT NOT NULL DEFAULT 0,
  KhoaDen DATETIME NULL,
  NgayTao DATETIME NOT NULL DEFAULT GETDATE());
IF OBJECT_ID('NhatKy','U') IS NULL CREATE TABLE NhatKy(
  MaNK INT IDENTITY PRIMARY KEY, MaND INT NULL REFERENCES NguoiDung(MaND),
  HanhDong NVARCHAR(100), DoiTuong NVARCHAR(200), ThoiGian DATETIME NOT NULL DEFAULT GETDATE());
GO
CREATE OR ALTER VIEW vw_ThietBi AS
SELECT t.MaTB, t.TenTB, l.TenLoai, p.TenPhong, t.SoLuong, t.TinhTrang, t.NgayMua, t.GiaTri, t.GhiChu, t.MaLoai, t.MaPhong
FROM ThietBi t JOIN LoaiThietBi l ON t.MaLoai=l.MaLoai JOIN Phong p ON t.MaPhong=p.MaPhong;
GO
IF NOT EXISTS(SELECT 1 FROM VaiTro) INSERT VaiTro(TenVaiTro) VALUES (N'Admin'),(N'QuanLy'),(N'NguoiXem');
IF NOT EXISTS(SELECT 1 FROM LoaiThietBi) INSERT LoaiThietBi(TenLoai) VALUES (N'Máy chiếu'),(N'Máy tính'),(N'Bàn ghế'),(N'Điều hòa'),(N'Thiết bị thí nghiệm');
IF NOT EXISTS(SELECT 1 FROM Phong) INSERT Phong VALUES ('A101',N'Phòng học A101',N'Tòa A',1,50,N'Phòng học'),
 ('A102',N'Phòng học A102',N'Tòa A',1,50,N'Phòng học'),('B201',N'Phòng máy B201',N'Tòa B',2,40,N'Phòng máy'),
 ('C301',N'Phòng thí nghiệm C301',N'Tòa C',3,30,N'Phòng thí nghiệm');
IF NOT EXISTS(SELECT 1 FROM ThietBi) INSERT ThietBi(TenTB,MaLoai,MaPhong,SoLuong,TinhTrang,NgayMua,GiaTri,GhiChu) VALUES
 (N'Máy chiếu Epson EB-X06',1,'A101',1,N'Tốt','2022-08-15',12500000,NULL),
 (N'Điều hòa Daikin 18000BTU',4,'A101',2,N'Tốt','2021-06-01',16000000,NULL),
 (N'Bàn ghế sinh viên',3,'A102',25,N'Cần bảo trì','2019-09-10',450000,N'Một số bộ lung lay'),
 (N'PC Dell OptiPlex',2,'B201',40,N'Tốt','2023-01-20',14500000,NULL),
 (N'Kính hiển vi quang học',5,'C301',10,N'Hỏng','2018-03-05',3200000,N'Chờ sửa chữa');
-- Tài khoản admin đầu tiên (admin / admin123) được app tự tạo ở lần chạy đầu và bắt đổi mật khẩu.
GO
