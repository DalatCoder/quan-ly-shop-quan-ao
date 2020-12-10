USE QL_ShopQuanAo;
GO


create PROCEDURE sp_insert_ChiTietBanHang
@ID_QA INT,
@ID_BH INT,
@SoLuongSanPham INT
AS
BEGIN
	IF (NOT EXISTS (SELECT * FROM QuanAo WHERE QuanAo.ID_QA = @ID_QA OR QuanAo.Is_Alive = 1))
		RETURN

	IF (NOT EXISTS (SELECT * FROM BanHang WHERE BanHang.ID_BH = @ID_BH))
		RETURN

	INSERT ChiTietBanHang(ID_BH, ID_QA, SoLuongSanPham)
	VALUES (@ID_BH, @ID_QA, @SoLuongSanPham)

	DECLARE @SLtonKho INT;
	SELECT @SLtonKho = SoLuong FROM QuanAo WHERE ID_QA = @ID_QA

	DECLARE @SLMoi INT = @SLtonKho - @SoLuongSanPham;
	UPDATE QuanAo
	SET SoLuong = @SLMoi
	WHERE ID_QA = @ID_QA
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

-- select * from ChiTietBanHang
-- go

CREATE PROCEDURE sp_select_ChiTietBanHang
@ID_BH INT
AS
BEGIN
	SELECT ID_CTBH, QuanAo.ID_QA, Ten_QA, GiaBan, SoLuongSanPham
	FROM ChiTietBanHang 
	INNER JOIN QuanAo ON QuanAo.ID_QA = ChiTietBanHang.ID_QA
	WHERE ID_BH = @ID_BH
END
GO

-- exec sp_select_ChiTietBanHang 1
CREATE TRIGGER UTG_Delete_ChiTietBanHang
ON ChiTietBanHang FOR DELETE
AS
BEGIN
	SELECT * FROM ChiTietBanHang
	DECLARE @id_QA INT
	DECLARE @soSanPhamDuocChon INT

	SELECT @id_QA = ID_QA, @soSanPhamDuocChon = SoLuongSanPham FROM deleted

	DECLARE @soLuongSanPhamTrongKho INT
	SELECT @soLuongSanPhamTrongKho = SoLuong FROM QuanAo WHERE ID_QA = @id_QA

	DECLARE @soLuongSanPhamMoi INT = @soSanPhamDuocChon + @soLuongSanPhamTrongKho
	UPDATE QuanAo
	SET 
		SoLuong = @soLuongSanPhamMoi
	WHERE ID_QA = @id_QA
END
GO

CREATE proc sp_select_sanphambanchaynhat
as
begin
Select Top 1 Ten_QA, SUM(SoLuongSanPham) as SoLuongSanPham
from QuanAo, ChiTietBanHang
where QuanAo.ID_QA = ChiTietBanHang.ID_QA
group by Ten_QA
order by SoLuongSanPham desc
end
go

create proc sp_select_sanphambandduoc
(@ID_QA int)
as
begin
select  SUM(SoLuongSanPham) as SoLuongSanPham
from QuanAo, ChiTietBanHang
where QuanAo.ID_QA = ChiTietBanHang.ID_QA and QuanAo.ID_QA =  @ID_QA
end
