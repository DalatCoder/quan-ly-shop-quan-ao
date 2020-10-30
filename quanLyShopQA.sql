create database QL_ShopQuanAo
use QL_ShopQuanAo

----------table
create table LoaiQA
(
ID_LQA int not null,
Ten_LQA nvarchar(30)
)
create table HinhQA
(
	ID_HQA int not null,
	HinhQA image,
	HinhQAP nvarchar(max)
)
create table QuanAo
(
ID_HQA int,
Ten_QA nvarchar(100),
Size char(5),
GiaBan float not null,
ID_QA int not null,
SoLuong int,
GhiChu nvarchar(max),
Discount float,
ID_LQA int
)
create table KieuNguoiDung
(
ID_KND int not null,
Ten_KND nvarchar(50)
)
create table NguoiDung
(
	ID_ND int not null,
	ID_KND int,
	HoTen nvarchar(50),
	TenDangNhap nvarchar(50),
	MatKhau nvarchar(50),
	SDT nvarchar(50),
)

CREATE TABLE ChiTietBanHang
(
	ID_CTBH int not null,
	ID_QA int,
	ID_BH int,
	SoLuongSanPham int,
)
create table BanHang
(
	ID_BH int not null,
	ID_ND int,
	ID_GD nvarchar(50),
	NgayBanHang datetime
)

---------PK-
ALTER TABLE LoaiQA WITH NOCHECK ADD CONSTRAINT PK_LoaiQA PRIMARY KEY CLUSTERED 
(
	ID_Loai ASC 
)
ALTER TABLE HinhQA WITH NOCHECK ADD CONSTRAINT PK_HinhQA PRIMARY KEY CLUSTERED 
(
	ID_HQA ASC 
)
ALTER TABLE QuanAo WITH NOCHECK ADD CONSTRAINT PK_QuanAo PRIMARY KEY CLUSTERED 
(
	ID_QA ASC 
)
ALTER TABLE KieuNguoiDung WITH NOCHECK ADD CONSTRAINT PK_KieuNguoiDung PRIMARY KEY CLUSTERED 
(
	ID_KND ASC 
)
ALTER TABLE NguoiDung WITH NOCHECK ADD CONSTRAINT PK_NguoiDung PRIMARY KEY CLUSTERED 
(
	ID_ND ASC 
)
ALTER TABLE ChiTietBanHang WITH NOCHECK ADD CONSTRAINT PK_ChiTietBanHang PRIMARY KEY CLUSTERED 
(
	ID_CTBH ASC 
)
ALTER TABLE BanHang WITH NOCHECK ADD CONSTRAINT PK_BanHang PRIMARY KEY CLUSTERED 
(
	ID_BH ASC 
)
-------FK-
ALTER TABLE QuanAo
ADD CONSTRAINT FK_HinhQA_QuanAo
Foreign key (ID_HQA) REFERENCES HinhQA(ID_HQA)
ALTER TABLE QuanAo
ADD CONSTRAINT FK_LoaiQA_QuanAo
Foreign key (ID_Loai) REFERENCES LoaiQA(ID_Loai)
ALTER TABLE QuanAo
ADD CONSTRAINT FK_LoaiQA_QuanAo
Foreign key (ID_Loai) REFERENCES LoaiQA(ID_Loai)
ALTER TABLE ChiTietBanHang
ADD CONSTRAINT FK_QuanAo_ChiTietBanHang
Foreign key (ID_QA) REFERENCES QuanAo(ID_QA)
ALTER TABLE ChiTietBanHang
ADD CONSTRAINT FK_BanHang_ChiTietBanHang
Foreign key (ID_BH) REFERENCES BanHang(ID_BH)
ALTER TABLE NguoiDung
ADD CONSTRAINT FK_KieuNguoiDung_NguoiDung
Foreign key (ID_KND) REFERENCES KieuNguoiDung(ID_KND)
-------proc
-------insert
CREATE PROCEDURE sp_insert_LoaiQA
(
@Ten_LQA nvarchar(30)
)
AS
BEGIN
DECLARE @ID_LQA int
	SELECT @ID_LQA=ISNULL(MAX(@ID_LQA),0) FROM LoaiQA
	SET @ID_LQA = @ID_LQA + 1
INSERT INTO LoaiQA (ID_LQA,Ten_LQA)
			VALUES (@ID_LQA,@Ten_LQA)
END
GO

CREATE PROCEDURE sp_insert_QA
(
@Ten_QA nvarchar(100),
@Size char(5),
@GiaBan float not null,
@SoLuong int,
@GhiChu nvarchar(max),
@Discount float,
@ID_LQA int not null,
@HinhQA image,
@HinhQAP nvarchar(max)
)
AS
BEGIN
DECLARE @ID_QA int
	SELECT @ID_QA=ISNULL(MAX(@ID_QA),0) FROM QuanAo
	SET @ID_QA = @ID_QA + 1
DECLARE @ID_HQA int
	SET @ID_HQA = @ID_QA
INSERT INTO HinhQA (ID_HQA,HinhQA,HinhQAP)
			VALUES (@ID_HQA,@HinhQA,@HinhQAP)
INSERT INTO QuanAo(ID_QA,ID_HQA,Ten_QA,Size,Discount,SoLuong,GiaBan,GhiChu,ID_LQA)
	VALUES (@ID_QA,@ID_HQA,@Ten_QA,@Size,@Discount,@SoLuong,@GiaBan,@GhiChu,@ID_LQA)
END
GO
-----------******---------
CREATE PROCEDURE sp_insert_BanHang
(	
	@ID_GD nvarchar(50),
	@NgayBanHang datetime,
	@HoTen nvarchar(50),
	@SDT nvarchar(50)
)
AS
BEGIN
DECLARE @ID_BH  int
SELECT @ID_BH =ISNULL(MAX(@ID_BH),0) FROM BanHang
DECLARE @ID_ND int
SELECT @ID_ND =ISNULL(MAX(@ID_ND),0) FROM NguoiDung
SET @ID_ND = @ID_ND + 1

INSERT INTO NguoiDung (ID_ND,ID_KND,HoTen,SDT)
VALUES (@ID_ND,1,@HoTen,@SDT)

INSERT INTO BanHang (ID_BH,ID_GD,ID_ND,NgayBanHang)
VALUES (@ID_BH,@ID_GD,@ID_ND,@NgayBanHang)


END
GO
-----------******---------


CREATE PROCEDURE sp_insert_ChiTietBanHang
(
	@ID_QA int,
	@ID_BH int,
	@SoLuongSanPham int
)
AS
BEGIN
DECLARE @ID_CTBH int
SELECT @ID_CTBH=ISNULL(MAX(@ID_CTBH),0) FROM ChiTietBanHang
SET @ID_CTBH = @ID_CTBH + 1
INSERT INTO ChiTietBanHang (ID_CTBH,ID_BH,ID_QA,SoLuongSanPham)
VALUES (@ID_CTBH,@ID_BH,@ID_QA,@SoLuongSanPham)
END
GO
-----------------------
CREATE PROCEDURE sp_select_ChiTietBanHang
(
@ID_BH int
)
AS
BEGIN
SELECT
SoLuongSanPham,Ten_QA,GiaBan
FROM
ChiTietBanHang INNER JOIN QuanAo
ON
QuanAo.ID_QA = ChiTietBanHang.ID_QA
WHERE
ID_BH = @ID_BH
END
GO

CREATE PROCEDURE sp_select_DangNhapAdmin
(
@TenDangNhap nvarchar(50),
@MatKhau nvarchar(50)
)
AS
BEGIN
SELECT
ID_ND,ID_KND,HoTen,TenDangNhap,MatKhau
FROM
NguoiDung
WHERE
TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND ID_KND = 0
END
GO

CREATE PROCEDURE sp_select_DangNhapNguoiDung
(
@TenDangNhap nvarchar(50),
@MatKhau nvarchar(50)
)
AS
BEGIN
SELECT HoTen,ID_ND
FROM NguoiDung
WHERE
TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau AND ID_KND = 1
END
GO

CREATE PROCEDURE sp_select_LoaiQA
AS
BEGIN
SELECT ID_LQA,Ten_LQA
FROM LoaiQA
END
GO

CREATE PROCEDURE sp_select_Master_LoaiQA
AS
BEGIN
	select LoaiQA.ID_LQA,count(QuanAo.ID_LQA)  AS SoLuongSanPham,Ten_LQA
	from QuanAo join LoaiQA on QuanAo.ID_LQA=LoaiQA.ID_LQA
	where QuanAo.ID_LQA=LoaiQA.ID_LQA
	group by LoaiQA.ID_LQA,Ten_LQA
END
GO


CREATE PROCEDURE sp_select_HinhSanPham
(
@ID_HQA int
)
AS
BEGIN
SELECT HinhQA
FROM HinhQA
WHERE ID_HQA = @ID_HQA
END
GO

CREATE PROCEDURE sp_select_SanPham
AS
BEGIN
SELECT
ID_QA,Ten_QA,Ten_LQA,ID_HQA,
SUBSTRING(GhiChu, 1, 150) + '...' AS GhiChu,GiaBan
FROM
QuanAo INNER JOIN LoaiQA
ON
LoaiQA.ID_LQA = QuanAo.ID_LQA
END
GO

CREATE PROCEDURE sp_select_search_SanPham
(
@TieuChuanTim nvarchar(255)
)
AS
BEGIN
SELECT
ID_QA,Ten_QA,Ten_LQA,ID_HQA,
SUBSTRING(GhiChu, 1, 150) + '...' AS GhiChu,GiaBan,Discount
FROM
QuanAo INNER JOIN LoaiQA
ON
LoaiQA.ID_LQA = QuanAo.ID_LQA
WHERE
Ten_LQA LIKE '%' + @TieuChuanTim + '%' OR
Ten_QA LIKE '%' + @TieuChuanTim + '%' OR
GhiChu LIKE '%' + @TieuChuanTim + '%'OR
Discount LIKE '%'+@TieuChuanTim+'%'
END
GO


CREATE PROCEDURE sp_select_SanPham_ByID
(
@ID_QA int
)
AS
BEGIN
SELECT
ID_QA,Ten_QA,Ten_LQA,ID_HQA,GhiChu,GiaBan,Discount
FROM
QuanAo INNER JOIN LoaiQA
ON
LoaiQA.ID_LQA = QuanAo.ID_LQA
WHERE
ID_QA = @ID_QA
END
GO

CREATE PROCEDURE sp_select_SanPham_ByID_LQA
(
@ID_LQA int
)
AS
BEGIN
SELECT 
ID_QA,Ten_QA,Ten_LQA,ID_HQA,GhiChu,GiaBan,Discount
FROM 
LoaiQA INNER JOIN QuanAo 
ON 
LoaiQA.ID_LQA = QuanAo.ID_LQA
WHERE 
QuanAo.ID_LQA = @ID_LQA
END
GO


CREATE PROCEDURE sp_select_SanPham_By_GiaCa_Discount
(
@GiaBanThap float,
@GiaBanCao float,
@Disscount float
)
AS
BEGIN
SELECT 
ID_QA,Ten_QA,ID_HQA,GhiChu,GiaBan,Discount
FROM 
QuanAo 
Where
(@GiaBanThap <GiaBan and GiaBan< @GiaBanCao) or
(@Disscount=Discount)
END
GO
--------------