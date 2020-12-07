USE [master]
GO
/****** Object:  Database [QL_ShopQuanAo]    Script Date: 12/7/2020 8:30:14 PM ******/
CREATE DATABASE [QL_ShopQuanAo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_ShopQuanAo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QL_ShopQuanAo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QL_ShopQuanAo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QL_ShopQuanAo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QL_ShopQuanAo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_ShopQuanAo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_ShopQuanAo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_ShopQuanAo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_ShopQuanAo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_ShopQuanAo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_ShopQuanAo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET RECOVERY FULL 
GO
ALTER DATABASE [QL_ShopQuanAo] SET  MULTI_USER 
GO
ALTER DATABASE [QL_ShopQuanAo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_ShopQuanAo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_ShopQuanAo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_ShopQuanAo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QL_ShopQuanAo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QL_ShopQuanAo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QL_ShopQuanAo', N'ON'
GO
ALTER DATABASE [QL_ShopQuanAo] SET QUERY_STORE = OFF
GO
USE [QL_ShopQuanAo]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 12/7/2020 8:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_update_QuanAo 9, N'Ten sau khi update 1', 'L', 200000, 100, N'Day la ghi chu', 4, NULL, NULL
-- EXEC sp_select_QuanAo_All
-- GO	

CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[BanHang]    Script Date: 12/7/2020 8:30:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanHang](
	[ID_BH] [int] IDENTITY(1,1) NOT NULL,
	[ID_KH] [int] NOT NULL,
	[ID_GD] [nvarchar](50) NULL,
	[NgayBanHang] [datetime] NULL,
	[Discount] [float] NULL,
 CONSTRAINT [PK_BanHang] PRIMARY KEY CLUSTERED 
(
	[ID_BH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietBanHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBanHang](
	[ID_CTBH] [int] IDENTITY(1,1) NOT NULL,
	[ID_QA] [int] NOT NULL,
	[ID_BH] [int] NOT NULL,
	[SoLuongSanPham] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietBanHang] PRIMARY KEY CLUSTERED 
(
	[ID_CTBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhQA]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhQA](
	[ID_HQA] [int] IDENTITY(1,1) NOT NULL,
	[HinhQA] [image] NOT NULL,
	[HinhQAP] [nvarchar](max) NOT NULL,
	[ID_QA] [int] NOT NULL,
 CONSTRAINT [PK_HinhQA] PRIMARY KEY CLUSTERED 
(
	[ID_HQA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID_KH] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiQA]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiQA](
	[ID_LQA] [int] IDENTITY(1,1) NOT NULL,
	[Ten_LQA] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_LoaiQA] PRIMARY KEY CLUSTERED 
(
	[ID_LQA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanAo]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanAo](
	[ID_QA] [int] IDENTITY(1,1) NOT NULL,
	[Ten_QA] [nvarchar](100) NOT NULL,
	[Size] [char](5) NOT NULL,
	[ID_LQA] [int] NOT NULL,
	[GiaBan] [float] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_QuanAo] PRIMARY KEY CLUSTERED 
(
	[ID_QA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanTriVien]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanTriVien](
	[ID_QTV] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_QuanTriVien] PRIMARY KEY CLUSTERED 
(
	[ID_QTV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BanHang] ADD  DEFAULT (NULL) FOR [ID_GD]
GO
ALTER TABLE [dbo].[BanHang] ADD  DEFAULT (getdate()) FOR [NgayBanHang]
GO
ALTER TABLE [dbo].[BanHang] ADD  DEFAULT ((0)) FOR [Discount]
GO
ALTER TABLE [dbo].[BanHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_BanHang] FOREIGN KEY([ID_KH])
REFERENCES [dbo].[KhachHang] ([ID_KH])
GO
ALTER TABLE [dbo].[BanHang] CHECK CONSTRAINT [FK_KhachHang_BanHang]
GO
ALTER TABLE [dbo].[ChiTietBanHang]  WITH CHECK ADD  CONSTRAINT [FK_BanHang_ChiTietBanHang] FOREIGN KEY([ID_BH])
REFERENCES [dbo].[BanHang] ([ID_BH])
GO
ALTER TABLE [dbo].[ChiTietBanHang] CHECK CONSTRAINT [FK_BanHang_ChiTietBanHang]
GO
ALTER TABLE [dbo].[ChiTietBanHang]  WITH CHECK ADD  CONSTRAINT [FK_QuanAo_ChiTietBanHang] FOREIGN KEY([ID_QA])
REFERENCES [dbo].[QuanAo] ([ID_QA])
GO
ALTER TABLE [dbo].[ChiTietBanHang] CHECK CONSTRAINT [FK_QuanAo_ChiTietBanHang]
GO
ALTER TABLE [dbo].[HinhQA]  WITH CHECK ADD  CONSTRAINT [FK_QuanAo_HinhQuanAo] FOREIGN KEY([ID_QA])
REFERENCES [dbo].[QuanAo] ([ID_QA])
GO
ALTER TABLE [dbo].[HinhQA] CHECK CONSTRAINT [FK_QuanAo_HinhQuanAo]
GO
ALTER TABLE [dbo].[QuanAo]  WITH CHECK ADD  CONSTRAINT [FK_LoaiQA_QuanAo] FOREIGN KEY([ID_LQA])
REFERENCES [dbo].[LoaiQA] ([ID_LQA])
GO
ALTER TABLE [dbo].[QuanAo] CHECK CONSTRAINT [FK_LoaiQA_QuanAo]
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_BanHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- HỦY ĐƠN HÀNG
CREATE PROCEDURE [dbo].[sp_delete_BanHang]
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
/****** Object:  StoredProcedure [dbo].[sp_insert_BanHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_BanHang_by_ID 1
-- GO

CREATE PROCEDURE [dbo].[sp_insert_BanHang]
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
/****** Object:  StoredProcedure [dbo].[sp_insert_BanHang_ChuaThanhToan]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SELECT * FROM BanHang

-- EXEC sp_select_BanHang_ChuaThanhToan_By_KhachHang 2
-- GO

-- TẠO ĐƠN HÀNG MỚI, CHƯA ĐƯỢC THANH TOÁN
CREATE PROCEDURE [dbo].[sp_insert_BanHang_ChuaThanhToan]
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
/****** Object:  StoredProcedure [dbo].[sp_insert_ChiTietBanHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_insert_ChiTietBanHang]
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
/****** Object:  StoredProcedure [dbo].[sp_insert_LoaiQuanAo]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_LoaiQuanAo_by_Name 'ao'
-- GO

CREATE PROCEDURE [dbo].[sp_insert_LoaiQuanAo]
@Ten_LQA NVARCHAR(30)
AS
BEGIN
	IF (NOT EXISTS (SELECT * FROM dbo.LoaiQA WHERE Ten_LQA = @Ten_LQA))
		INSERT INTO dbo.LoaiQA (Ten_LQA) VALUES (@Ten_LQA)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_QuanAo]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_QuanAo_by_ID_LQA 1
-- GO

CREATE PROCEDURE [dbo].[sp_insert_QuanAo]
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
/****** Object:  StoredProcedure [dbo].[sp_select_Account_By_UserName]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_Account_By_UserName]
@username NVARCHAR(100)
AS
BEGIN
	SELECT * FROM QuanTriVien WHERE @username = TenDangNhap
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_BanHang_All]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_BanHang_All]
AS
	BEGIN		
		SELECT ID_BH, ID_GD, HoTen, SDT, NgayBanHang, Discount
		FROM dbo.BanHang
		JOIN KhachHang ON BanHang.ID_KH = KhachHang.ID_KH
		WHERE ID_GD IS NOT NULL
	END	
GO
/****** Object:  StoredProcedure [dbo].[sp_select_BanHang_by_ID]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_BanHang_All
-- GO

CREATE PROCEDURE [dbo].[sp_select_BanHang_by_ID]
@ID_BH INT
AS
	BEGIN
		SELECT  ID_BH, ID_GD, NgayBanHang, Discount, HoTen, SDT
		FROM dbo.BanHang
		JOIN KhachHang ON BanHang.ID_KH = KhachHang.ID_KH
		WHERE BanHang.ID_BH = @ID_BH AND ID_GD IS NOT NULL
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_BanHang_By_KhacHang_ID]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_banHang_FromDateToDate '20201201', '20201231'
-- GO

-- tinh so luong don hang cua 1 khach hang
CREATE PROCEDURE [dbo].[sp_select_BanHang_By_KhacHang_ID]
@ID_KH INT
AS
BEGIN
	SELECT COUNT(*) FROM BanHang WHERE ID_KH = @ID_KH AND ID_GD IS NOT NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_BanHang_By_KhachHang_SDT]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_BanHang_By_KhacHang_ID 2
-- GO

CREATE PROCEDURE [dbo].[sp_select_BanHang_By_KhachHang_SDT]
@SDT NVARCHAR(100) 
AS
BEGIN
	SELECT COUNT(*) FROM BanHang
	JOIN KhachHang ON KhachHang.ID_KH = BanHang.ID_KH
	WHERE SDT = @SDT AND ID_GD IS NOT NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_BanHang_ChuaThanhToan_By_KhachHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SELECT * FROM BanHang
-- SELECT * FROM KhachHang

-- EXEC sp_insert_BanHang '202002120105', 10, 'Nguyen Trong Hieu', '0374408253', 'Da Lat'
-- EXEC sp_insert_BanHang '202002120106', 10, N'Phạm Thị Hồng Nhung', '0374408256', 'Da Lat'
-- GO

-- BÁN HÀNG --
-- MỖI KHÁCH HÀNG CÓ DUY NHẤT 1 ĐƠN HÀNG CHƯA ĐƯỢC THANH TOÁN

-- LẤY ĐƠN HÀNG CHƯA ĐƯỢC THANH TOÁN CỦA 1 KHÁCH HÀNG
CREATE PROCEDURE [dbo].[sp_select_BanHang_ChuaThanhToan_By_KhachHang]
@ID_KH INT
AS
BEGIN
	SELECT *
	FROM BanHang
	WHERE ID_KH = 4 AND ID_GD IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_banHang_FromDateToDate]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- them proc tim don hang theo ngay
CREATE PROC [dbo].[sp_select_banHang_FromDateToDate]
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
/****** Object:  StoredProcedure [dbo].[sp_select_ChiTietBanHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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

CREATE PROCEDURE [dbo].[sp_select_ChiTietBanHang]
@ID_BH INT
AS
BEGIN
	SELECT Ten_QA, GiaBan, SoLuongSanPham
	FROM ChiTietBanHang 
	INNER JOIN QuanAo ON QuanAo.ID_QA = ChiTietBanHang.ID_QA
	WHERE ID_BH = @ID_BH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_DangNhapAdmin]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_DangNhapAdmin]
@TenDangNhap NVARCHAR(50),
@MatKhau NVARCHAR(50)
AS
BEGIN
	SELECT TenDangNhap, MatKhau
	FROM QuanTriVien
	WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_HinhSanPham_By_ID]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_HinhSanPham_By_ID]
@ID_HQA INT
AS
BEGIN
	SELECT *
	FROM HinhQA
	WHERE ID_HQA = @ID_HQA
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_HinhSanPham_By_ID_QA]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_HinhSanPham_By_ID 1
-- GO

CREATE PROCEDURE [dbo].[sp_select_HinhSanPham_By_ID_QA]
@ID_QA INT
AS
BEGIN
	SELECT TOP 1 * FROM HinhQA WHERE ID_QA = @ID_QA
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_KhachHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--them proc xem khach hang
CREATE PROCEDURE [dbo].[sp_select_KhachHang]
AS SELECT * FROM KhachHang
GO
/****** Object:  StoredProcedure [dbo].[sp_select_KhachHang_By_ID]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_KhachHang
-- GO

CREATE PROCEDURE [dbo].[sp_select_KhachHang_By_ID]
@id INT
AS
BEGIN
	SELECT * FROM KhachHang WHERE ID_KH = @id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_KhachHang_By_KeyWord]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_KhachHang_By_KeyWord]
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
/****** Object:  StoredProcedure [dbo].[sp_select_LoaiQuanAo_All]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_LoaiQuanAo_All]
AS
	BEGIN
		SELECT * FROM dbo.LoaiQA
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_LoaiQuanAo_by_ID]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_LoaiQuanAo_All
-- GO

CREATE PROCEDURE [dbo].[sp_select_LoaiQuanAo_by_ID]
@ID_LQA INT
AS
	BEGIN
		SELECT * FROM dbo.LoaiQA WHERE [ID_LQA] = @ID_LQA
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_LoaiQuanAo_by_Name]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_LoaiQuanAo_by_ID 1
-- GO

CREATE PROCEDURE [dbo].[sp_select_LoaiQuanAo_by_Name]
@Name NVARCHAR(200)
AS
BEGIN
	SELECT * FROM LoaiQA
	WHERE dbo.fuConvertToUnsign1(Ten_LQA) LIKE '%' + dbo.fuConvertToUnsign1(@Name) + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_Master_LoaiQA]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- SELECT * FROM LoaiQA

-- EXEC sp_update_LoaiQuanAo 9, N'Áo sơ mi'
-- GO

-- EXEC sp_select_LoaiQuanAo_by_ID 1
-- GO

CREATE PROCEDURE [dbo].[sp_select_Master_LoaiQA]
AS
BEGIN
	SELECT LoaiQA.ID_LQA, COUNT(QuanAo.ID_LQA)  AS SoLuongSanPham, Ten_LQA
	FROM QuanAo JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.ID_LQA = LoaiQA.ID_LQA
	GROUP BY LoaiQA.ID_LQA,Ten_LQA
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_QuanAo_All]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_QuanAo_All]
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
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_QuanAo_by_ID]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_QuanAo_All
-- GO

CREATE PROCEDURE [dbo].[sp_select_QuanAo_by_ID]
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
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE QuanAo.ID_QA = @ID_QA
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_QuanAo_by_ID_LQA]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_QuanAo_by_ID 1
-- GO

CREATE PROCEDURE [dbo].[sp_select_QuanAo_by_ID_LQA]
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
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE LoaiQA.ID_LQA = @ID_LQA
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_QuanAo_By_Keyword]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_select_QuanAo_By_Keyword]
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
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE
		dbo.fuConvertToUnsign1(Ten_QA) LIKE '%' + dbo.fuConvertToUnsign1(@TieuChuanTim) + '%' OR
		QuanAo.ID_QA LIKE '%' + @TieuChuanTim + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_QuanAo_By_Price]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_QuanAo_By_Keyword N'vay'
-- GO

CREATE PROCEDURE [dbo].[sp_select_QuanAo_By_Price]
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
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE (@GiaBanThap <= GiaBan AND GiaBan <= @GiaBanCao)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_select_search_QuanAo_GiaCa]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_QuanAo_By_Price 150000, 200000
-- GO

CREATE PROCEDURE [dbo].[sp_select_search_QuanAo_GiaCa]
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
		END AS [GhiChu], 
		LoaiQA.ID_LQA, 
		Ten_LQA
	FROM QuanAo
	JOIN LoaiQA ON QuanAo.ID_LQA = LoaiQA.ID_LQA
	WHERE
		dbo.fuConvertToUnsign1(Ten_QA) LIKE '%' + dbo.fuConvertToUnsign1(@ten) + '%' AND
		(@GiaBanThap <= GiaBan AND GiaBan <= @GiaBanCao)
		
END
GO
/****** Object:  StoredProcedure [dbo].[sp_selectKhachHang_By_SDT]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_select_KhachHang_By_ID 1
-- GO

CREATE PROCEDURE [dbo].[sp_selectKhachHang_By_SDT]
@sdt NVARCHAR(50)
AS
BEGIN
	SELECT * FROM KhachHang WHERE SDT = @sdt
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThanhToanBanHang]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_insert_BanHang_ChuaThanhToan N'Nguyễn Trọng Hiếu', N'0374408253', N'Đà Lạt';
-- GO

-- SELECT * FROM KhachHang

-- EXEC sp_select_BanHang_ChuaThanhToan_By_KhachHang 1

-- SELECT * FROM BanHang;
-- GO

-- THANH TOÁN ĐƠN HÀNG
CREATE PROCEDURE [dbo].[sp_ThanhToanBanHang]
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
/****** Object:  StoredProcedure [dbo].[sp_update_LoaiQuanAo]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_insert_LoaiQuanAo N'Áo sơ mi'
-- GO
-- SELECT * FROM LoaiQA
-- GO

CREATE PROCEDURE [dbo].[sp_update_LoaiQuanAo]
@ID_LQA INT, @Ten_LQA NVARCHAR(30)
AS
BEGIN
	UPDATE dbo.LoaiQA
	SET
		[Ten_LQA] = @Ten_LQA
	WHERE ID_LQA = @ID_LQA
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_QuanAo]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_insert_QuanAo N'Quan ao moi', 'M', 20000, 10, 'ghi chu', 1, null, null
-- GO

CREATE PROCEDURE [dbo].[sp_update_QuanAo]
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
	WHERE ID_QA = @ID_QA

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
/****** Object:  StoredProcedure [dbo].[USP_HaOcCho]    Script Date: 12/7/2020 8:30:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- EXEC sp_delete_BanHang 8
-- GO

CREATE PROC [dbo].[USP_HaOcCho]
@message NVARCHAR(100)
AS
BEGIN
	DECLARE @ngaySinh DATETIME = '20002010';

	
END
GO
USE [master]
GO
ALTER DATABASE [QL_ShopQuanAo] SET  READ_WRITE 
GO
