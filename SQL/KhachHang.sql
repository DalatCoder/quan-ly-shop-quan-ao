USE QL_ShopQuanAo;
GO


--them proc xem khach hang
CREATE PROCEDURE sp_select_KhachHang
AS SELECT * FROM KhachHang
GO

-- EXEC sp_select_KhachHang
-- GO

CREATE PROCEDURE sp_select_KhachHang_By_ID
@id INT
AS
BEGIN
	SELECT * FROM KhachHang WHERE ID_KH = @id
END
GO

-- EXEC sp_select_KhachHang_By_ID 1
-- GO

CREATE PROCEDURE sp_selectKhachHang_By_SDT
@sdt NVARCHAR(50)
AS
BEGIN
	SELECT * FROM KhachHang WHERE SDT = @sdt
END
GO

CREATE PROCEDURE sp_select_KhachHang_By_KeyWord
@TieuChuanTim NVARCHAR(100)
AS
BEGIN
	SELECT *
	FROM KhachHang
	WHERE 
		dbo.fuConvertToUnsign1(HoTen) LIKE '%' + dbo.fuConvertToUnsign1(@TieuChuanTim) + '%' OR
		SDT LIKE '%' + @TieuChuanTim + '%'
END
GO


-- EXEC sp_select_KhachHang_By_KeyWord 'hieu'
-- EXEC sp_select_KhachHang_By_KeyWord '037'

CREATE PROC sp_select_TimKiemKhachHang
@SDT VARCHAR(10)
AS
BEGIN
	SELECT * FROM KhachHang
	WHERE KhachHang.SDT LIKE '%'+@SDT+'%'
END
GO

-- EXEC sp_select_TimKiemKhachHang '82'