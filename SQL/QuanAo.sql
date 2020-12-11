USE QL_ShopQuanAo;
GO

CREATE PROCEDURE sp_select_QuanAo_All
AS
BEGIN
	SELECT 
		ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
        CASE 
            WHEN LEN(GhiChu) > 150 THEN SUBSTRING(GhiChu, 1, 150) + ' ...'      
			ELSE GhiChu      
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.Is_Alive = 1 AND LoaiQA.Is_Alive = 1
END
GO

CREATE PROCEDURE sp_select_QuanAo_By_Name
@Name NVARCHAR(100)
AS
BEGIN
	SELECT 
		ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
        CASE 
            WHEN LEN(GhiChu) > 150 THEN SUBSTRING(GhiChu, 1, 150) + ' ...'        
			ELSE GhiChu       
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.Is_Alive = 1 AND LoaiQA.Is_Alive = 1 AND Ten_QA = @Name
END
GO

-- EXEC sp_select_QuanAo_All
-- GO

CREATE PROCEDURE sp_select_QuanAo_by_ID
@ID_QA INT
AS
BEGIN
	SELECT 
		ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
        CASE 
            WHEN LEN(GhiChu) > 150 THEN SUBSTRING(GhiChu, 1, 150) + ' ...'     
			ELSE GhiChu          
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.ID_QA = @ID_QA AND QuanAo.Is_Alive = 1 AND LoaiQA.Is_Alive = 1
END
GO

-- EXEC sp_select_QuanAo_by_ID 1
-- GO

CREATE PROCEDURE sp_select_QuanAo_by_ID_LQA
@ID_LQA INT
AS
BEGIN
	SELECT 
		ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
        CASE 
            WHEN LEN(GhiChu) > 150 THEN SUBSTRING(GhiChu, 1, 150) + ' ...'      
			ELSE GhiChu         
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE LoaiQA.ID_LQA = @ID_LQA AND QuanAo.Is_Alive = 1 AND LoaiQA.Is_Alive = 1
END
GO

-- EXEC sp_select_QuanAo_by_ID_LQA 1
-- GO

CREATE PROCEDURE sp_insert_QuanAo
@Ten_QA NVARCHAR(100),
@Size CHAR(5),
@GiaBan FLOAT,
@SoLuong INT,
@GhiChu NVARCHAR(MAX),
@ID_LQA INT,
@HinhQA IMAGE NULL,
@HinhQAP NVARCHAR(MAX) NULL
AS
BEGIN
	IF (@ID_LQA IS NULL OR @ID_LQA = '')
		RETURN

	IF (NOT EXISTS(SELECT * FROM LoaiQA WHERE LoaiQA.ID_LQA = @ID_LQA))
		RETURN

	IF (EXISTS (SELECT * FROM QuanAo WHERE QuanAo.Ten_QA = @Ten_QA))
		RETURN

	INSERT QuanAo(Ten_QA, ID_LQA, Size, SoLuong, GiaBan, GhiChu)
	VALUES (@Ten_QA, @ID_LQA, @Size, @SoLuong, @GiaBan, @GhiChu)

	DECLARE @ID_MAX INT
	SELECT @ID_MAX = MAX(ID_QA) FROM QuanAo

	IF (@HinhQA IS NULL OR @HinhQAP IS NULL)
		RETURN
	
	INSERT HinhQA(ID_QA, HinhQA, HinhQAP)
	VALUES (@ID_MAX, @HinhQA, @HinhQAP)
END
GO

-- EXEC sp_insert_QuanAo N'Quan ao moi', 'M', 20000, 10, 'ghi chu', 1, null, null
-- GO

CREATE PROCEDURE sp_update_QuanAo
@ID_QA INT,
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
	IF (@ID_LQA IS NULL OR @ID_LQA = '')
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
	WHERE ID_QA = @ID_QA AND QuanAo.Is_Alive = 1

	IF (@HinhQA IS NULL OR @HinhQAP IS NULL OR @HinhQAP = '')
		RETURN

	IF (NOT EXISTS(SELECT * FROM HinhQA WHERE ID_QA = @ID_QA))
	BEGIN
		INSERT HinhQA(HinhQA, HinhQAP, ID_QA)
		VALUES (@HinhQA, @HinhQAP, @ID_QA)
	END
	ELSE
	BEGIN
		UPDATE HinhQA
		SET
			HinhQA = @HinhQA,
			HinhQAP = @HinhQAP
		WHERE ID_QA = @ID_QA
	END
END
GO

-- EXEC sp_update_QuanAo 9, N'Ten sau khi update 1', 'L', 200000, 100, N'Day la ghi chu', 4, NULL, NULL
-- EXEC sp_select_QuanAo_All
-- GO	

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO

CREATE PROCEDURE sp_select_QuanAo_By_Keyword
@TieuChuanTim NVARCHAR(255)
AS
BEGIN
	SELECT 
		ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
        CASE 
            WHEN LEN(GhiChu) > 150 THEN SUBSTRING(GhiChu, 1, 150) + ' ...'      
			ELSE GhiChu         
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE
		QuanAo.Is_Alive = 1 AND LoaiQA.Is_Alive = 1 AND (
			dbo.fuConvertToUnsign1(Ten_QA) LIKE '%' + dbo.fuConvertToUnsign1(@TieuChuanTim) + '%' OR
			QuanAo.ID_QA LIKE '%' + @TieuChuanTim + '%'
		)
END
GO

-- EXEC sp_select_QuanAo_By_Keyword N'vay'
-- GO

CREATE PROCEDURE sp_select_QuanAo_By_Price
@GiaBanThap FLOAT, 
@GiaBanCao FLOAT
AS
BEGIN
	SELECT 
		ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
        CASE 
            WHEN LEN(GhiChu) > 150 THEN SUBSTRING(GhiChu, 1, 150) + ' ...'        
			ELSE GhiChu       
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.Is_Alive = 1 AND LoaiQA.Is_Alive = 1 AND (@GiaBanThap <= GiaBan AND GiaBan <= @GiaBanCao)
END
GO

-- EXEC sp_select_QuanAo_By_Price 150000, 200000
-- GO

CREATE PROCEDURE sp_select_search_QuanAo_GiaCa
@ten NVARCHAR(255),
@GiaBanThap FLOAT, 
@GiaBanCao FLOAT
AS
BEGIN
	SELECT 
		ID_QA, 
		Ten_QA, 
		Size, 
		GiaBan, 
		SoLuong, 
        CASE 
            WHEN LEN(GhiChu) > 150 THEN SUBSTRING(GhiChu, 1, 150) + ' ...'      
			ELSE GhiChu      
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE
		QuanAo.Is_Alive = 1 AND LoaiQA.Is_Alive = 1 AND
		dbo.fuConvertToUnsign1(Ten_QA) LIKE '%' + dbo.fuConvertToUnsign1(@ten) + '%' AND
		(@GiaBanThap <= GiaBan AND GiaBan <= @GiaBanCao)
		
END
GO

-- EXEC sp_select_search_QuanAo_GiaCa 'ao',100000,250000

CREATE PROCEDURE sp_delete_QuanAo
@ID_QA INT
AS
BEGIN
	UPDATE QuanAo
	SET
		Is_Alive = 0
	WHERE ID_QA = @ID_QA
END
GO

-- EXEC sp_delete_QuanAo 5

-- SELECT * FROM QuanAo

-- EXEC sp_select_QuanAo_All