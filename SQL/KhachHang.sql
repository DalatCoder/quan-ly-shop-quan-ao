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