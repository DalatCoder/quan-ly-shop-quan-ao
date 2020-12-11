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

EXEC sp_select_DangNhap N'THIHA', N'123'
EXEC sp_select_DangNhap N'THIHA', N'345'
EXEC sp_select_DangNhap N'NHANVIEN', N'111'

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