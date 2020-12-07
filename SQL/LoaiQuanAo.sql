USE QL_ShopQuanAo;
GO

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

CREATE PROCEDURE sp_select_LoaiQuanAo_by_Name
@Name NVARCHAR(200)
AS
BEGIN
	SELECT * FROM LoaiQA
	WHERE dbo.fuConvertToUnsign1(Ten_LQA) LIKE '%' + dbo.fuConvertToUnsign1(@Name) + '%'
END
GO

-- EXEC sp_select_LoaiQuanAo_by_Name 'ao'
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


