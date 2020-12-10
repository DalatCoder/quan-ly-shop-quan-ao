--------------------------------------------------------------------------------
--                          SHOP MANAGEMENT DATABASE                          --
--------------------------------------------------------------------------------
CREATE DATABASE QL_ShopQuanAo
GO
	
USE QL_ShopQuanAo
GO

--------------------------------------------------------------------------------
--                                   TABLE                                    --
--------------------------------------------------------------------------------
CREATE TABLE LoaiQA
(
	ID_LQA INT NOT NULL IDENTITY(1,1),
	Ten_LQA NVARCHAR(100) NOT NULL,
	Is_Alive BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE HinhQA
(
	ID_HQA INT NOT NULL IDENTITY(1,1),
	HinhQA IMAGE NOT NULL,
	HinhQAP NVARCHAR(MAX) NOT NULL,
	ID_QA INT NOT NULL
)
GO

CREATE TABLE QuanAo
(
	ID_QA INT NOT NULL IDENTITY(1,1),
	Ten_QA NVARCHAR(100) NOT NULL,
	Size CHAR(5) NOT NULL,
	ID_LQA INT NOT NULL,
	GiaBan FLOAT NOT NULL,
	SoLuong INT NOT NULL,
	GhiChu NVARCHAR(MAX) NULL,
	Is_Alive BIT NOT NULL DEFAULT 1
)
GO

CREATE TABLE KieuTaiKhoan
(
	ID_KTK INT NOT NULL IDENTITY(1,1),
	Ten_KTK NVARCHAR(50) NOT NULL
)
GO

CREATE TABLE QuanTriVien
(
	ID_QTV INT NOT NULL IDENTITY(1,1),
	TenDangNhap NVARCHAR(50) NOT NULL,
	MatKhau NVARCHAR(50) NOT NULL,
	ID_KTK INT NOT NULL
)
GO

CREATE TABLE KhachHang
(
	ID_KH INT NOT NULL IDENTITY(1,1),
	HoTen NVARCHAR(50) NOT NULL,
	SDT NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(MAX) NULL
)
GO

CREATE TABLE BanHang
(
	ID_BH INT NOT NULL IDENTITY(1,1),
	ID_KH INT NOT NULL,
	ID_GD NVARCHAR(50) DEFAULT NULL, -- NULL: Khách hàng chưa thanh toán tiền OR 'yyyyddmmhhMMss': thời gian hóa đơn được thanh toán
	NgayBanHang DATETIME DEFAULT GETDATE(),
	Discount FLOAT DEFAULT 0
)
GO

CREATE TABLE ChiTietBanHang
(
	ID_CTBH INT NOT NULL IDENTITY(1,1),
	ID_QA INT NOT NULL,
	ID_BH INT NOT NULL,
	SoLuongSanPham INT NOT NULL
	-- GiaBan FLOAT NOT NULL
)
GO

--------------------------------------------------------------------------------
--                                PRIMARY KEY                                 --
--------------------------------------------------------------------------------
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

ALTER TABLE KieuTaiKhoan WITH NOCHECK ADD CONSTRAINT PK_KieuTaiKhoan PRIMARY KEY CLUSTERED 
(
	ID_KTK ASC 
)
GO

ALTER TABLE QuanTriVien WITH NOCHECK ADD CONSTRAINT PK_QuanTriVien PRIMARY KEY CLUSTERED 
(
	ID_QTV ASC 
)
GO

ALTER TABLE KhachHang WITH NOCHECK ADD CONSTRAINT PK_KhachHang PRIMARY KEY CLUSTERED 
(
	ID_KH ASC 
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

--------------------------------------------------------------------------------
--                                FOREIGN KEY                                 --
--------------------------------------------------------------------------------
ALTER TABLE HinhQA
ADD CONSTRAINT FK_QuanAo_HinhQuanAo
FOREIGN KEY (ID_QA) REFERENCES QuanAo(ID_QA)
GO

ALTER TABLE QuanAo
ADD CONSTRAINT FK_LoaiQA_QuanAo
FOREIGN KEY (ID_LQA) REFERENCES LoaiQA(ID_LQA)
GO

ALTER TABLE QuanTriVien
ADD CONSTRAINT FK_KieuTaiKhoan_QuanTriVien
FOREIGN KEY (ID_KTK) REFERENCES KieuTaiKhoan(ID_KTK)
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
ADD CONSTRAINT FK_KhachHang_BanHang
FOREIGN KEY (ID_KH) REFERENCES KhachHang(ID_KH)
GO

--------------------------------------------------------------------------------
--                                Du lieu mau                                 --
--------------------------------------------------------------------------------

INSERT LoaiQA(Ten_LQA)
VALUES 
	(N'Quần jean'),
	(N'Áo thun'),
	(N'Váy'),
	(N'Áo len')
GO
SELECT * FROM LoaiQA

INSERT QuanAo(Ten_QA, ID_LQA, Size, SoLuong, GiaBan, GhiChu)
VALUES
	(N'Quần jean ngắn', 1, 'M', 100, 100000, N'Quần jean hấp dẫn cho ngày hè năng động'),
	(N'Quần jean dài', 1, 'M', 100, 120000, N'Quần jean hấp dẫn cho ngày đông buốt giá'),
	(N'Áo thun hiệu con bò cười', 2, 'M', 50, 50000, N'Áo thun con bò'),
	(N'Áo thun Doremon', 2, 'M', 100, 50000, N'Áo thun doremon'),
	(N'Váy Doremon', 3, 'M', 70, 50000, N'Váy doremon'),
	(N'Váy dài', 3, 'M', 70, 150000, N'Váy dài siêu cấp'),
	(N'Áo len mỏng', 4, 'M', 70, 200000, N'Áo len mát mẻ'),
	(N'Áo len dày', 4, 'M', 70, 300000, N'Áo len ấm áp')
SELECT * FROM QuanAo

INSERT KieuTaiKhoan(Ten_KTK)
VALUES 
	(N'Quản trị viên'),
	(N'Nhân viên')

SELECT * FROM KieuTaiKhoan

INSERT QuanTriVien(TenDangNhap, MatKhau,ID_KTK)
VALUES
	(N'TRONGHIEU', N'123',1),
	(N'KHAIQUAN', N'123',1),
	(N'THIHA', N'123',1),
	(N'HONGNHUNG', N'123',1),
	(N'NHANVIEN', N'111',2)

SELECT * FROM QuanTriVien

INSERT KhachHang(HoTen, SDT, DiaChi)
VALUES
	(N'Nguyễn Trọng Hiếu', '0374408253', N'Đà Lạt'),
	(N'Nguyễn Thị Hà', '0374408254', N'Đà Lạt'),
	(N'Trần Hữu Khải Quân', '0374408255', N'Đà Lạt')

SELECT * FROM KhachHang

INSERT BanHang(ID_KH, ID_GD, Discount, NgayBanHang)
VALUES
	(1, '202001121054', 30, GETDATE()),
	(2, '202002121055', 50, GETDATE()),
	(3, '202003122054', 10, GETDATE())
SELECT * FROM BanHang
SELECT * FROM QuanAo

INSERT ChiTietBanHang(ID_BH, ID_QA, SoLuongSanPham)
VALUES
	(1, 1, 2),
	(1, 2, 2),
	(1, 3, 1),
	(2, 4, 1),
	(2, 5, 2),
	(1, 6, 3),
	(3, 7, 5),
	(3, 8, 1)
SELECT * FROM ChiTietBanHang