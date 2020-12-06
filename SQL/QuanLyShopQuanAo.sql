
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
	Ten_LQA NVARCHAR(100) NOT NULL
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
	GhiChu NVARCHAR(MAX) NULL
)
GO

CREATE TABLE QuanTriVien
(
	ID_QTV INT NOT NULL IDENTITY(1,1),
	TenDangNhap NVARCHAR(50) NOT NULL,
	MatKhau NVARCHAR(50) NOT NULL,
)

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
	SoLuongSanPham INT NOT NULL,
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

INSERT HinhQA(ID_QA, HinhQAP, HinhQA)
VALUES
	(1, N'D:/image1.jpg', 0x89504E470D0A1A0A00000),
	(2, N'D:/image2.jpg', 0x89504E470D0A1A0A00000),
	(3, N'D:/image3.jpg', 0x89504E470D0A1A0A00000),
	(4, N'D:/image4.jpg', 0x89504E470D0A1A0A00000),
	(5, N'D:/image5.jpg', 0x89504E470D0A1A0A00000),
	(6, N'D:/image6.jpg', 0x89504E470D0A1A0A00000),
	(7, N'D:/image7.jpg', 0x89504E470D0A1A0A00000),
	(8, N'D:/image8.jpg', 0x89504E470D0A1A0A00000)
SELECT * FROM HinhQA

INSERT QuanTriVien(TenDangNhap, MatKhau)
VALUES
	(N'TRONGHIEU', N'123'),
	(N'KHAIQUAN', N'123'),
	(N'THIHA', N'123'),
	(N'HONGNHUNG', N'123')
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
GO
--------------------------------------------------------------------------------
--                                 PROCEDURE                                  --
--------------------------------------------------------------------------------

--------------------------------- Loai Quan Ao ---------------------------------
CREATE PROCEDURE sp_select_LoaiQuanAo_All
AS
	BEGIN
		SELECT * FROM dbo.LoaiQA
	END
GO

-- EXEC sp_select_LoaiQuanAo_All
-- GO

CREATE PROCEDURE sp_select_LoaiQuanAo_by_ID
@ID_LQA INT
AS
	BEGIN
		SELECT * FROM dbo.LoaiQA WHERE [ID_LQA] = @ID_LQA
	END
GO

-- EXEC sp_select_LoaiQuanAo_by_ID 1
-- GO

CREATE PROCEDURE sp_select_Master_LoaiQA
AS
BEGIN
	SELECT LoaiQA.ID_LQA, COUNT(QuanAo.ID_LQA)  AS SoLuongSanPham, Ten_LQA
	FROM QuanAo JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.ID_LQA = LoaiQA.ID_LQA
	GROUP BY LoaiQA.ID_LQA,Ten_LQA
END
GO

-- EXEC sp_select_Master_LoaiQA
-- GO

CREATE PROCEDURE sp_insert_LoaiQuanAo
@Ten_LQA NVARCHAR(30)
AS
BEGIN
	IF (NOT EXISTS (SELECT * FROM dbo.LoaiQA WHERE Ten_LQA = @Ten_LQA))
		INSERT INTO dbo.LoaiQA (Ten_LQA) VALUES (@Ten_LQA)
END
GO

-- EXEC sp_insert_LoaiQuanAo N'Áo sơ mi'
-- GO
-- SELECT * FROM LoaiQA
-- GO

CREATE PROCEDURE sp_update_LoaiQuanAo
@ID_LQA INT, @Ten_LQA NVARCHAR(30)
AS
BEGIN
	UPDATE dbo.LoaiQA
	SET
		[Ten_LQA] = @Ten_LQA
	WHERE ID_LQA = @ID_LQA
END
GO

-- SELECT * FROM LoaiQA

-- EXEC sp_update_LoaiQuanAo 9, N'Áo sơ mi'
-- GO

--------------------------------- Hinh Quan Ao ---------------------------------
CREATE PROCEDURE sp_select_HinhSanPham
@ID_HQA INT
AS
BEGIN
	SELECT HinhQA
	FROM HinhQA
	WHERE ID_HQA = @ID_HQA
END
GO

----------------------------------- Quan Ao ------------------------------------

ALTER PROCEDURE sp_select_QuanAo
AS
BEGIN
	SELECT 
		QuanAo.ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
		SUBSTRING(GhiChu, 1, 150) + '...' AS [GhiChu], 
		ID_HQA, 
		LoaiQA.ID_LQA, 
		Ten_LQA
		
	FROM QuanAo
	JOIN HinhQA ON QuanAo.ID_QA = HinhQA.ID_QA
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
END
GO

-- EXEC sp_select_QuanAo
-- GO

CREATE PROCEDURE sp_select_QuanAo_by_ID
@ID_QA INT
AS
BEGIN
	SELECT QuanAo.ID_QA, Ten_QA, Size, GiaBan, SoLuong, SUBSTRING(GhiChu, 1, 150) + '...' AS GhiChu, ID_HQA, LoaiQA.ID_LQA, Ten_LQA
	FROM QuanAo
	JOIN HinhQA ON QuanAo.ID_QA = HinhQA.ID_QA
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.ID_QA = @ID_QA
END
GO

-- EXEC sp_select_QuanAo_by_ID 1
-- GO

CREATE PROCEDURE sp_select_QuanAo_by_ID_LQA
@ID_LQA INT
AS
BEGIN
	SELECT QuanAo.ID_QA, Ten_QA, Size, GiaBan, SoLuong, SUBSTRING(GhiChu, 1, 150) + '...' AS GhiChu, ID_HQA, LoaiQA.ID_LQA, Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	JOIN HinhQA ON HinhQA.ID_QA = QuanAo.ID_QA
	WHERE LoaiQA.ID_LQA = @ID_LQA
END
GO

CREATE PROCEDURE sp_select_search_QuanAo
@TieuChuanTim NVARCHAR(255)
AS
BEGIN
	SELECT QuanAo.ID_QA, Ten_QA, Size, GiaBan, SoLuong, SUBSTRING(GhiChu, 1, 150) + '...' AS GhiChu, ID_HQA, LoaiQA.ID_LQA, Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	JOIN HinhQA ON HinhQA.ID_QA = QuanAo.ID_QA
	WHERE
		-- dbo.fuConvertToUnsign1(Ten_LQA) LIKE '%' + dbo.fuConvertToUnsign1(@TieuChuanTim) + '%' OR
		dbo.fuConvertToUnsign1(Ten_QA) LIKE '%' + dbo.fuConvertToUnsign1(@TieuChuanTim) + '%' OR
		QuanAo.ID_QA LIKE '%' + @TieuChuanTim + '%'
		-- dbo.fuConvertToUnsign1(GhiChu) LIKE '%' + dbo.fuConvertToUnsign1(@TieuChuanTim) + '%' 
END
GO

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

-- EXEC sp_select_search_QuanAo N'Ao'
-- GO

CREATE PROCEDURE sp_select_QuanAo_By_GiaCa
@GiaBanThap FLOAT, 
@GiaBanCao FLOAT
AS
BEGIN
	SELECT QuanAo.ID_QA, Ten_QA, Size, GiaBan, SoLuong, SUBSTRING(GhiChu, 1, 150) + '...' AS GhiChu, ID_HQA, LoaiQA.ID_LQA, Ten_LQA
	FROM QuanAo
	JOIN HinhQA ON QuanAo.ID_QA = HinhQA.ID_HQA
	WHERE (@GiaBanThap <= GiaBan AND GiaBan <= @GiaBanCao)
END
GO

-- EXEC sp_select_QuanAo_By_GiaCa 100000, 200000
-- GO

CREATE PROCEDURE sp_insert_QuanAo
@Ten_QA NVARCHAR(100),
@Size CHAR(5),
@GiaBan FLOAT,
@SoLuong INT,
@GhiChu NVARCHAR(MAX),
@ID_LQA INT,
@HinhQA IMAGE,
@HinhQAP NVARCHAR(MAX)
AS
BEGIN
	IF (@ID_LQA = NULL OR @ID_LQA = '')
		RETURN

	IF (NOT EXISTS(SELECT * FROM LoaiQA WHERE LoaiQA.ID_LQA = @ID_LQA))
		RETURN

	IF (EXISTS (SELECT * FROM QuanAo WHERE QuanAo.Ten_QA = @Ten_QA))
		RETURN

	INSERT QuanAo(Ten_QA, ID_LQA, Size, SoLuong, GiaBan, GhiChu)
	VALUES (@Ten_QA, @ID_LQA, @Size, @SoLuong, @GiaBan, @GhiChu)

	DECLARE @ID_MAX INT
	SELECT @ID_MAX = MAX(ID_QA) FROM QuanAo
	
	INSERT HinhQA(ID_QA, HinhQA, HinhQAP)
	VALUES (@ID_MAX, @HinhQA, @HinhQAP)
END
GO

-- EXEC sp_insert_QuanAo N'ten', 'M', 20000, 10, 'ghi chu', 1, 0x089504E470D0A1A0A00000, 'd:/image24142.jp'
-- GO

CREATE PROCEDURE sp_update_QuanAo
@ID_QA INT,
@Ten_QA NVARCHAR(100),
@Size CHAR(5),
@GiaBan FLOAT,
@SoLuong INT,
@GhiChu NVARCHAR(MAX),
@ID_LQA INT,
@ID_HQA INT,
@HinhQA IMAGE,
@HinhQAP NVARCHAR(MAX)
AS
BEGIN
	IF (@ID_LQA = NULL OR @ID_LQA = '')
		RETURN

	IF (NOT EXISTS(SELECT * FROM LoaiQA WHERE LoaiQA.ID_LQA = @ID_LQA))
		RETURN

	IF (NOT EXISTS (SELECT * FROM QuanAo WHERE QuanAo.ID_QA = @ID_QA))
		RETURN	

	UPDATE QuanAo
	SET
		Ten_QA = @Ten_QA,
		Size = @Size,
		GiaBan = @GiaBan,
		SoLuong = @SoLuong,
		GhiChu = @GhiChu,
		ID_LQA = @ID_LQA
	WHERE ID_QA = @ID_QA

	UPDATE HinhQA
	SET
		HinhQA = @HinhQA,
		HinhQAP = @HinhQAP
	WHERE ID_HQA = ID_HQA
END
GO

-- SELECT * FROM QuanAo
-- EXEC sp_delete_QuanAo_By_ID 14
-- GO

----------------------------------- Ban Hang -----------------------------------
CREATE PROCEDURE sp_select_BanHang_All
AS
	BEGIN		
		SELECT ID_BH, ID_GD, HoTen, SDT, NgayBanHang, Discount
		FROM dbo.BanHang
		JOIN KhachHang ON BanHang.ID_KH = KhachHang.ID_KH
		WHERE ID_GD IS NOT NULL
	END	
GO

EXEC sp_select_BanHang_All
GO

CREATE PROCEDURE sp_select_BanHang_by_ID
@ID_BH INT
AS
	BEGIN
		SELECT  ID_BH, ID_GD, NgayBanHang, Discount, HoTen, SDT
		FROM dbo.BanHang
		JOIN KhachHang ON BanHang.ID_KH = KhachHang.ID_KH
		WHERE BanHang.ID_BH = @ID_BH AND ID_GD IS NOT NULL
	END
GO

-- EXEC sp_select_BanHang_by_ID 1
-- GO

CREATE PROCEDURE sp_insert_BanHang
@ID_GD NVARCHAR(50),
@Discount FLOAT,
@HoTen NVARCHAR(50),
@SDT NVARCHAR(50),
@DiaChi NVARCHAR(MAX)
AS
BEGIN
	IF (EXISTS (SELECT * FROM BanHang WHERE BanHang.ID_GD = @ID_GD))
		RETURN

	DECLARE @ID_KH INT
	IF (NOT EXISTS (SELECT * FROM KhachHang WHERE KhachHang.SDT = @SDT))
	BEGIN
		INSERT KhachHang(HoTen, SDT, DiaChi)
		VALUES (@HoTen, @SDT, @DiaChi)

		SELECT @ID_KH = MAX(ID_KH) FROM KhachHang
	END
	ELSE
	BEGIN
		SELECT @ID_KH = ID_KH FROM KhachHang WHERE KhachHang.SDT = @SDT
	END

	INSERT BanHang(ID_GD, ID_KH, NgayBanHang, Discount)
	VALUES (@ID_GD, @ID_KH, GETDATE(), @Discount)
END
GO

-- SELECT * FROM BanHang
-- SELECT * FROM KhachHang

-- EXEC sp_insert_BanHang '202002120105', 10, 'Nguyen Trong Hieu', '0374408253', 'Da Lat'
-- EXEC sp_insert_BanHang '202002120106', 10, N'Phạm Thị Hồng Nhung', '0374408256', 'Da Lat'
-- GO

-- BÁN HÀNG --
-- MỖI KHÁCH HÀNG CÓ DUY NHẤT 1 ĐƠN HÀNG CHƯA ĐƯỢC THANH TOÁN

-- LẤY ĐƠN HÀNG CHƯA ĐƯỢC THANH TOÁN CỦA 1 KHÁCH HÀNG
CREATE PROCEDURE sp_select_BanHang_ChuaThanhToan_By_KhachHang
@ID_KH INT
AS
BEGIN
	SELECT *
	FROM BanHang
	WHERE ID_KH = 4 AND ID_GD IS NULL
END
GO

SELECT * FROM BanHang

EXEC sp_select_BanHang_ChuaThanhToan_By_KhachHang 2
GO

-- TẠO ĐƠN HÀNG MỚI, CHƯA ĐƯỢC THANH TOÁN
CREATE PROCEDURE sp_insert_BanHang_ChuaThanhToan
@HoTen NVARCHAR(50),
@SDT NVARCHAR(50),
@DiaChi NVARCHAR(MAX)
AS
BEGIN
	DECLARE @ID_KH INT
	IF (NOT EXISTS (SELECT * FROM KhachHang WHERE KhachHang.SDT = @SDT))
	BEGIN
		INSERT KhachHang(HoTen, SDT, DiaChi)
		VALUES (@HoTen, @SDT, @DiaChi)

		SELECT @ID_KH = MAX(ID_KH) FROM KhachHang
	END
	ELSE
	BEGIN
		SELECT @ID_KH = ID_KH FROM KhachHang WHERE KhachHang.SDT = @SDT
	END

	INSERT BanHang(ID_KH, NgayBanHang)
	VALUES (@ID_KH, GETDATE())
END
GO

EXEC sp_insert_BanHang_ChuaThanhToan N'Nguyễn Trọng Hiếu', N'0374408253', N'Đà Lạt';
GO

SELECT * FROM KhachHang

EXEC sp_select_BanHang_ChuaThanhToan_By_KhachHang 1

SELECT * FROM BanHang;
GO

-- THANH TOÁN ĐƠN HÀNG
CREATE PROCEDURE sp_ThanhToanBanHang
@ID_BH INT, @ID_GD NVARCHAR(30), @discount FLOAT
AS
BEGIN
	IF (EXISTS (SELECT * FROM BanHang WHERE ID_BH = @ID_BH AND ID_GD <> NULL))
		RETURN

	UPDATE BanHang
	SET
		ID_GD = @ID_GD,
		Discount = @discount
	WHERE ID_BH = @ID_BH
END
GO

EXEC sp_ThanhToanBanHang 8, '20201120', 10

SELECT * FROM BanHang
GO

-- HỦY ĐƠN HÀNG
CREATE PROCEDURE sp_delete_BanHang
@ID_BH INT
AS
BEGIN
	IF (EXISTS (SELECT * FROM BanHang WHERE ID_BH = @ID_BH AND ID_GD IS NOT NULL))
		RETURN

	DELETE ChiTietBanHang
	WHERE ID_BH = @ID_BH

	DELETE BanHang
	WHERE ID_BH = @ID_BH
END
GO

EXEC sp_delete_BanHang 8
GO

CREATE PROC USP_HaOcCho
@message NVARCHAR(100)
AS
BEGIN
	DECLARE @ngaySinh DATETIME = '20002010';

	
END
GO


------------------------------ Chi Tiet Ban Hang -------------------------------
CREATE PROCEDURE sp_insert_ChiTietBanHang
@ID_QA INT,
@ID_BH INT,
@SoLuongSanPham INT
AS
BEGIN
	IF (NOT EXISTS (SELECT * FROM QuanAo WHERE QuanAo.ID_QA = @ID_QA))
		RETURN

	IF (NOT EXISTS (SELECT * FROM BanHang WHERE BanHang.ID_BH = @ID_BH))
		RETURN

	DECLARE @isBillCheckout INT = -1
	SELECT @isBillCheckout = ID_BH FROM BanHang WHERE BanHang.ID_BH = @ID_BH AND BanHang.ID_GD <> NULL

	IF (@isBillCheckout > -1)
		RETURN

	DECLARE @isExistsChiTietBanHang INT = -1
	DECLARE @SLSanPhamCoSan INT = 0
	SELECT @isExistsChiTietBanHang = ID_CTBH, @SLSanPhamCoSan = SoLuongSanPham FROM ChiTietBanHang WHERE ID_BH = @ID_BH AND ID_QA = @ID_QA

	IF (@isExistsChiTietBanHang > 0)
	BEGIN
		DECLARE @SLSanPhamMoi INT = @SLSanPhamCoSan + @SoLuongSanPham
		IF (@SLSanPhamMoi > 0)
			UPDATE ChiTietBanHang
			SET SoLuongSanPham = @SLSanPhamMoi
			WHERE ID_BH = @ID_BH AND ID_QA = @ID_QA
		ELSE
			DELETE ChiTietBanHang WHERE ID_BH = @ID_BH AND ID_QA = @ID_QA
	END
	ELSE
	BEGIN
		INSERT ChiTietBanHang(ID_BH, ID_QA, SoLuongSanPham)
		VALUES (@ID_BH, @ID_QA, @SoLuongSanPham)
	END
END
GO

-- SELECT * FROM KhachHang

-- INSERT BanHang(ID_KH, NgayBanHang, Discount)
-- VALUES (3, '20200212', 10)

-- SELECT * FROM BanHang

-- EXEC sp_insert_ChiTietBanHang 1, 5, 1
-- EXEC sp_insert_ChiTietBanHang 1, 5, 1
-- EXEC sp_insert_ChiTietBanHang 3, 5, 1
-- EXEC sp_insert_ChiTietBanHang 1, 5, -1

-- EXEC sp_select_BanHang_All

-- EXEC sp_select_ChiTietBanHang 5

-- SELECT * FROM ChiTietBanHang

-- SELECT * FROM BanHang
-- SELECT * FROM ChiTietBanHang
-- GO

CREATE PROCEDURE sp_select_ChiTietBanHang
@ID_BH INT
AS
BEGIN
	SELECT Ten_QA, GiaBan, SoLuongSanPham
	FROM ChiTietBanHang 
	INNER JOIN QuanAo ON QuanAo.ID_QA = ChiTietBanHang.ID_QA
	WHERE ID_BH = @ID_BH
END
GO

---------------------------------- Dang Nhap -----------------------------------
CREATE PROCEDURE sp_select_DangNhapAdmin
@TenDangNhap NVARCHAR(50),
@MatKhau NVARCHAR(50)
AS
BEGIN
	SELECT TenDangNhap, MatKhau
	FROM QuanTriVien
	WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau
END
GO

CREATE PROCEDURE sp_select_Account_By_UserName
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM QuanTriVien WHERE @username = TenDangNhap
END
GO

EXEC sp_select_Account_By_UserName N'TRONGHIEU'
GO

-- EXEC sp_select_DangNhapAdmin N'TRONGHIEU', N'123'


--them proc xem khach hang
CREATE PROCEDURE sp_select_KhachHang
AS SELECT * FROM KhachHang
GO

EXEC sp_select_KhachHang
GO

CREATE PROCEDURE sp_select_KhachHang_By_ID
@id INT
AS
BEGIN
	SELECT * FROM KhachHang WHERE ID_KH = @id
END
GO

EXEC sp_select_KhachHang_By_ID 1
GO

CREATE PROCEDURE sp_selectKhachHang_By_SDT
@sdt NVARCHAR(50)
AS
BEGIN
	SELECT * FROM KhachHang WHERE SDT = @sdt
END
GO

EXEC sp_selectKhachHang_By_SDT '0374408253';
GO

-- them proc tim don hang theo ngay
CREATE PROC sp_select_banHang_FromDateToDate
@fromDate DATETIME, @toDate DATETIME
AS
BEGIN
	SELECT ID_BH, ID_GD, HoTen, SDT, NgayBanHang, Discount FROM BanHang
	JOIN KhachHang ON BanHang.ID_KH = KhachHang.ID_KH
	WHERE 
		ID_GD IS NOT NULL AND 
		@fromDate <= NgayBanHang AND NgayBanHang <= @toDate
END
GO

EXEC sp_select_banHang_FromDateToDate '20201201', '20201231'
GO

-- tinh so luong don hang cua 1 khach hang
CREATE PROCEDURE sp_select_BanHang_By_KhacHang_ID
@ID_KH INT
AS
BEGIN
	SELECT COUNT(*) FROM BanHang WHERE ID_KH = @ID_KH AND ID_GD IS NOT NULL
END
GO

EXEC sp_select_BanHang_By_KhacHang_ID 2
GO

CREATE PROCEDURE sp_select_BanHang_By_KhachHang_SDT
@SDT NVARCHAR(100) 
AS
BEGIN
	SELECT COUNT(*) FROM BanHang
	JOIN KhachHang ON KhachHang.ID_KH = BanHang.ID_KH
	WHERE SDT = @SDT AND ID_GD IS NOT NULL
END
GO

EXEC sp_select_BanHang_By_KhachHang_SDT '0374408253';
GO
