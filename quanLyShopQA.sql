CREATE DATABASE QL_ShopQuanAo
GO

USE QL_ShopQuanAo
GO

-----------------------------------------------------------------------
-------------------------------- TABLE --------------------------------
-----------------------------------------------------------------------
CREATE TABLE LoaiQA
(
	ID_LQA INT NOT NULL IDENTITY(1,1),
	Ten_LQA NVARCHAR(100)
)
GO

CREATE TABLE HinhQA
(
	ID_HQA INT NOT NULL IDENTITY(1,1),
	HinhQA IMAGE,
	HinhQAP NVARCHAR(MAX)
)
GO

CREATE TABLE QuanAo
(
	ID_HQA INT,
	Ten_QA NVARCHAR(100),
	Size CHAR(5),
	GiaBan FLOAT NOT NULL,
	ID_QA INT NOT NULL IDENTITY(1,1),
	SoLuong INT,
	GhiChu NVARCHAR(MAX),
	Discount FLOAT,
	ID_LQA INT
)
GO

CREATE TABLE KieuNguoiDung
(
	ID_KND INT NOT NULL IDENTITY(1,1),
	Ten_KND NVARCHAR(50)
)
GO

CREATE TABLE QuanTriVien
(
	ID_QTV INT NOT NULL IDENTITY(1,1),
	TenDangNhap NVARCHAR(50) NOT NULL,
	MatKhau NVARCHAR(50) NOT NULL,
)

CREATE TABLE NguoiDung
(
	ID_ND INT NOT NULL IDENTITY(1,1),
	ID_KND INT,
	HoTen NVARCHAR(50),
	SDT NVARCHAR(50),
)
GO

CREATE TABLE BanHang
(
	ID_BH INT NOT NULL IDENTITY(1,1),
	ID_ND INT,
	ID_GD NVARCHAR(50),
	NgayBanHang DATETIME
)
GO

CREATE TABLE ChiTietBanHang
(
	ID_CTBH INT NOT NULL IDENTITY(1,1),
	ID_QA INT,
	ID_BH INT,
	SoLuongSanPham INT,
)
GO

-----------------------------------------------------------------------
----------------------------- PRIMARY KEY -----------------------------
-----------------------------------------------------------------------
ALTER TABLE LoaiQA WITH NOCHECK ADD CONSTRAINT PK_LoaiQA PRIMARY KEY CLUSTERED 
(
	ID_LQA ASC 
)
GO

ALTER TABLE HinhQA WITH NOCHECK ADD CONSTRAINT PK_HinhQA PRIMARY KEY CLUSTERED 
(
	ID_HQA ASC 
)
GO

ALTER TABLE QuanAo WITH NOCHECK ADD CONSTRAINT PK_QuanAo PRIMARY KEY CLUSTERED 
(
	ID_QA ASC 
)
GO

ALTER TABLE QuanTriVien WITH NOCHECK ADD CONSTRAINT PK_QuanTriVien PRIMARY KEY CLUSTERED 
(
	ID_QTV ASC 
)
GO

ALTER TABLE KieuNguoiDung WITH NOCHECK ADD CONSTRAINT PK_KieuNguoiDung PRIMARY KEY CLUSTERED 
(
	ID_KND ASC 
)
GO

ALTER TABLE NguoiDung WITH NOCHECK ADD CONSTRAINT PK_NguoiDung PRIMARY KEY CLUSTERED 
(
	ID_ND ASC 
)
GO

ALTER TABLE ChiTietBanHang WITH NOCHECK ADD CONSTRAINT PK_ChiTietBanHang PRIMARY KEY CLUSTERED 
(
	ID_CTBH ASC 
)
GO

ALTER TABLE BanHang WITH NOCHECK ADD CONSTRAINT PK_BanHang PRIMARY KEY CLUSTERED 
(
	ID_BH ASC 
)
GO

-----------------------------------------------------------------------
----------------------------- FOREIGN KEY -----------------------------
-----------------------------------------------------------------------
ALTER TABLE QuanAo
ADD CONSTRAINT FK_HinhQA_QuanAo
FOREIGN KEY (ID_HQA) REFERENCES HinhQA(ID_HQA)
GO

ALTER TABLE QuanAo
ADD CONSTRAINT FK_LoaiQA_QuanAo
FOREIGN KEY (ID_LQA) REFERENCES LoaiQA(ID_LQA)
GO

ALTER TABLE ChiTietBanHang
ADD CONSTRAINT FK_QuanAo_ChiTietBanHang
FOREIGN KEY (ID_QA) REFERENCES QuanAo(ID_QA)
GO

ALTER TABLE ChiTietBanHang
ADD CONSTRAINT FK_BanHang_ChiTietBanHang
FOREIGN KEY (ID_BH) REFERENCES BanHang(ID_BH)
GO

ALTER TABLE BanHang
ADD CONSTRAINT FK_NguoiDung_BanHang
FOREIGN KEY (ID_ND) REFERENCES NguoiDung(ID_ND)
GO

ALTER TABLE NguoiDung
ADD CONSTRAINT FK_KieuNguoiDung_NguoiDung
FOREIGN KEY (ID_KND) REFERENCES KieuNguoiDung(ID_KND)
GO