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

-----------------------------------------------------------------------
----------------------------- PROCEDURE -------------------------------
-----------------------------------------------------------------------

------------------------------- Quan Ao -------------------------------
CREATE PROCEDURE sp_select_QuanAo_All
AS
	BEGIN
		SELECT * FROM dbo.QuanAo
	END
GO

CREATE PROCEDURE sp_select_QuanAo_by_ID
(
	@ID_QA INT
)
AS
	BEGIN
		SELECT * FROM dbo.QuanAo WHERE [ID_QA] = @ID_QA
	END
GO

CREATE PROCEDURE sp_insert_QuanAo
(
	@Ten_QA NVARCHAR(100),
	@Size CHAR(5),
	@GiaBan FLOAT NOT NULL,
	@SoLuong INT,
	@GhiChu NVARCHAR(MAX),
	@Discount FLOAT,
	@ID_LQA INT NOT NULL,
	@HinhQA IMAGE,
	@HinhQAP NVARCHAR(MAX)
)
AS
BEGIN
		IF (NOT EXISTS (SELECT * FROM dbo.QuanAo WHERE Ten_QA = @Ten_QA))
		BEGIN
			DECLARE @ID_HQA INT
			INSERT INTO dbo.HinhQA(HinhQA, HinhQAP) VALUES (@HinhQA, @HinhQAP)
			SET @ID_HQA = @@IDENTITY

			INSERT INTO dbo.QuanAo(Ten_QA, Size, GiaBan, SoLuong, GhiChu, Discount, ID_HQA, ID_LQA)
				VALUES (@Ten_QA, @Size, @GiaBan, @SoLuong, @GhiChu, @Discount, @ID_HQA, @ID_LQA) 
		END
END
GO

CREATE PROCEDURE sp_update_QuanAo
(
	@ID_QA INT,
	@Ten_QA NVARCHAR(100),
	@Size CHAR(5),
	@GiaBan FLOAT NOT NULL,
	@SoLuong INT,
	@GhiChu NVARCHAR(MAX),
	@Discount FLOAT,
	@ID_LQA INT NOT NULL,
	@ID_HQA INT,
	@HinhQA IMAGE,
	@HinhQAP NVARCHAR(MAX)
)
AS
BEGIN
	UPDATE dbo.HinhQA
	SET
		[HinhQA] = @HinhQA,
		[HinhQAP] = @HinhQAP
	WHERE ID_HQA = @ID_HQA

	UPDATE dbo.QuanAo
	SET
		[Ten_QA] = @Ten_QA,
		[Size] = @Size,
		[GiaBan] = @GiaBan,
		[SoLuong] = @SoLuong,
		[GhiChu] = @GhiChu,
		[Discount] = @Discount
	WHERE ID_QA = @ID_QA
END
GO

CREATE PROCEDURE sp_delete_QuanAo_By_ID
(
	@ID_QA INT
)
AS
BEGIN
	DELETE FROM dbo.QuanAo WHERE ID_QA = @ID_QA
END
GO
