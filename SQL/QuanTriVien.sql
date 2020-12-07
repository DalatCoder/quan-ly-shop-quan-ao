USE QL_ShopQuanAo;
GO

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

-- EXEC sp_select_Account_By_UserName N'TRONGHIEU'
-- GO

-- EXEC sp_select_DangNhapAdmin N'TRONGHIEU', N'123'