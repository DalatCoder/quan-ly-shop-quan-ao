USE QL_ShopQuanAo;
GO

CREATE PROCEDURE sp_select_DangNhap
@TenDangNhap NVARCHAR(50),
@MatKhau NVARCHAR(50)
AS
BEGIN
	SELECT ID_QTV,TenDangNhap, MatKhau, Ten_KTK FROM QuanTriVien
	JOIN KieuTaiKhoan ON QuanTriVien.ID_KTK = KieuTaiKhoan.ID_KTK
	WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau
END
GO

-- EXEC sp_select_DangNhap N'THIHA', N'123'
-- EXEC sp_select_DangNhap N'THIHA', N'345'
-- EXEC sp_select_DangNhap N'NHANVIEN', N'111'

CREATE PROCEDURE sp_select_Account_By_UserName
@username NVARCHAR(100)
AS
BEGIN
	SELECT ID_QTV,TenDangNhap, MatKhau, Ten_KTK FROM QuanTriVien
	JOIN KieuTaiKhoan ON QuanTriVien.ID_KTK = KieuTaiKhoan.ID_KTK
	WHERE @username = TenDangNhap
END
GO

-- EXEC sp_select_Account_By_UserName N'TRONGHIEU'
-- GO

-- EXEC sp_select_DangNhapAdmin N'TRONGHIEU', N'123'


CREATE PROCEDURE sp_select_GetAccount
AS
BEGIN
	SELECT ID_QTV, TenDangNhap, MatKhau, Ten_KTK
	FROM QuanTriVien
	JOIN KieuTaiKhoan ON QuanTriVien.ID_KTK = KieuTaiKhoan.ID_KTK
END
GO

-- EXEC sp_select_GetAccount


CREATE PROCEDURE sp_select_KieuTaiKhoan
AS
BEGIN
	SELECT * FROM KieuTaiKhoan
END
GO

-- EXEC sp_select_KieuTaiKhoan


CREATE PROC sp_insert_QuanTriVien
@ID_KTK INT, @TenDangNhap NVARCHAR(50), @MatKhau NVARCHAR(50)
AS
BEGIN
	IF(EXISTS(SELECT * FROM QuanTriVien WHERE TenDangNhap=@TenDangNhap))
		RETURN

	INSERT QuanTriVien(ID_KTK,TenDangNhap,MatKhau)
	VALUES (@ID_KTK, @TenDangNhap, @MatKhau)
END
GO

-- EXEC sp_insert_QuanTriVien 1, N'NHANVIEN2', N'222'


CREATE PROC sp_delete_QuanTriVien
@id_qtv INT
AS
BEGIN
	DELETE FROM QuanTriVien
	WHERE ID_QTV = @id_qtv
END
GO

