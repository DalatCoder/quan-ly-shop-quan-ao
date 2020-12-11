USE QL_ShopQuanAo;
GO

CREATE PROCEDURE sp_select_BanHang_All
AS
	BEGIN		
		SELECT ID_BH, ID_GD, HoTen, SDT, NgayBanHang, Discount
		FROM dbo.BanHang
		JOIN KhachHang ON BanHang.ID_KH = KhachHang.ID_KH
		WHERE ID_GD IS NOT NULL
	END	
GO

-- EXEC sp_select_BanHang_All
-- GO

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

	DECLARE @ID INT;
	SELECT @ID = MAX(ID_BH) FROM BanHang;

	SELECT * FROM BanHang WHERE ID_BH = @ID;
END
GO

-- SELECT * FROM ChiTietBanHang
-- SELECT * FROM KhachHang

-- EXEC sp_insert_BanHang '202002120105', 10, 'Nguyen Trong Hieu', '0374408253', 'Da Lat'
-- EXEC sp_insert_BanHang '202002120108', 10, N'Phạm Thị Hồng Nhung', '0374408256', 'Da Lat'
-- GO

-- BÁN HÀNG --
-- MỖI KHÁCH HÀNG CÓ DUY NHẤT 1 ĐƠN HÀNG CHƯA ĐƯỢC THANH TOÁN

-- LẤY ĐƠN HÀNG CHƯA ĐƯỢC THANH TOÁN CỦA 1 KHÁCH HÀNG
CREATE PROCEDURE sp_select_BanHang_ChuaThanhToan_By_KhachHang
@ID_KH INT
AS
BEGIN
	SELECT ID_BH
	FROM BanHang
	WHERE ID_KH = @ID_KH AND ID_GD IS NULL
END
GO

-- SELECT * FROM BanHang

-- EXEC sp_select_BanHang_ChuaThanhToan_By_KhachHang 2
-- GO

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

-- EXEC sp_insert_BanHang_ChuaThanhToan N'Nguyễn Trọng Hiếu', N'0374408253', N'Đà Lạt';
-- GO

-- SELECT * FROM KhachHang

-- EXEC sp_select_BanHang_ChuaThanhToan_By_KhachHang 1

-- SELECT * FROM BanHang;
-- GO

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

-- EXEC sp_ThanhToanBanHang 8, '20201120', 10

-- SELECT * FROM BanHang
-- GO

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

-- EXEC sp_delete_BanHang 8
-- GO

CREATE PROC USP_HaOcCho
@message NVARCHAR(100)
AS
BEGIN
	DECLARE @ngaySinh DATETIME = '20002010';

	
END
GO

-- them proc tim don hang theo ngay
CREATE PROC sp_select_banHang_FromDateToDate
@fromDate DATE, @toDate DATE
AS
BEGIN
	SELECT ID_BH, ID_GD, HoTen, SDT, NgayBanHang, Discount FROM BanHang
	JOIN KhachHang ON BanHang.ID_KH = KhachHang.ID_KH
	WHERE 
		ID_GD IS NOT NULL AND 
		@fromDate <= NgayBanHang AND NgayBanHang <= @toDate
END
GO

-- EXEC sp_select_banHang_FromDateToDate '20201201', '20201231'
-- GO

-- tinh so luong don hang cua 1 khach hang
CREATE PROCEDURE sp_select_BanHang_By_KhacHang_ID
@ID_KH INT
AS
BEGIN
	SELECT COUNT(*) FROM BanHang WHERE ID_KH = @ID_KH AND ID_GD IS NOT NULL
END
GO

-- EXEC sp_select_BanHang_By_KhacHang_ID 2
-- GO

CREATE PROCEDURE sp_select_BanHang_By_KhachHang_SDT
@SDT NVARCHAR(100) 
AS
BEGIN
	SELECT COUNT(*) FROM BanHang
	JOIN KhachHang ON KhachHang.ID_KH = BanHang.ID_KH
	WHERE SDT = @SDT AND ID_GD IS NOT NULL
END
GO

-- EXEC sp_select_BanHang_By_KhachHang_SDT '0374408253';
-- GO

CREATE PROC sp_TinhTongTienChuaGiamGia
@fromdate DATE, @todate DATE
AS
BEGIN
	SELECT SUM(ChiTietBanHang.SoLuongSanPham * QuanAo.GiaBan) FROM ChiTietBanHang
	JOIN QuanAo	ON ChiTietBanHang.ID_QA = QuanAo.ID_QA
	JOIN BanHang ON ChiTietBanHang.ID_BH = BanHang.ID_BH
	WHERE @fromdate <= NgayBanHang AND NgayBanHang<=@todate
END
GO

-- EXEC sp_TinhTongTienChuaGiamGia '20201201', '20201231';
-- GO

CREATE PROC	sp_TinhTongTienGiamGia 
@fromdate DATE, @todate DATE
AS
BEGIN
	SELECT SUM(ChiTietBanHang.SoLuongSanPham*QuanAo.GiaBan*(BanHang.Discount/100)) FROM ChiTietBanHang
	JOIN QuanAo	ON ChiTietBanHang.ID_QA = QuanAo.ID_QA
	JOIN BanHang ON ChiTietBanHang.ID_BH = BanHang.ID_BH
	WHERE @fromdate <= NgayBanHang AND NgayBanHang<=@todate
END
GO

-- EXEC sp_TinhTongTienGiamGia '20201201', '20201231';

