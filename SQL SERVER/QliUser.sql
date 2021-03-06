USE [master]
GO
/****** Object:  Database [qliUser]    Script Date: 12/28/2021 5:07:04 PM ******/
CREATE DATABASE [qliUser]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qliUser', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUYSQLSERVER\MSSQL\DATA\qliUser.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qliUser_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.DUYSQLSERVER\MSSQL\DATA\qliUser_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [qliUser] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qliUser].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qliUser] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qliUser] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qliUser] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qliUser] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qliUser] SET ARITHABORT OFF 
GO
ALTER DATABASE [qliUser] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qliUser] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qliUser] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qliUser] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qliUser] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qliUser] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qliUser] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qliUser] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qliUser] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qliUser] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qliUser] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qliUser] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qliUser] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qliUser] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qliUser] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qliUser] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qliUser] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qliUser] SET RECOVERY FULL 
GO
ALTER DATABASE [qliUser] SET  MULTI_USER 
GO
ALTER DATABASE [qliUser] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qliUser] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qliUser] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qliUser] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qliUser] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qliUser] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'qliUser', N'ON'
GO
ALTER DATABASE [qliUser] SET QUERY_STORE = OFF
GO
USE [qliUser]
GO
/****** Object:  Table [dbo].[HoaDonn]    Script Date: 12/28/2021 5:07:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonn](
	[Mahoadon] [bigint] IDENTITY(1,1) NOT NULL,
	[Manha] [nvarchar](50) NULL,
	[Loainha] [nvarchar](50) NULL,
	[Soluong] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Ngaymua] [nvarchar](50) NULL,
	[Gia] [nvarchar](50) NULL,
	[Dientich] [nvarchar](50) NULL,
	[Thanhtien] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoaDonn] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhathue]    Script Date: 12/28/2021 5:07:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhathue](
	[Manha] [nvarchar](50) NOT NULL,
	[Loainha] [nvarchar](50) NULL,
	[Soluong] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Dientich] [nvarchar](50) NULL,
	[Gia] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nhathue] PRIMARY KEY CLUSTERED 
(
	[Manha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/28/2021 5:07:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [nvarchar](50) NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HoaDonn] ON 

INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (1, N'n04', N'Nhà chung cu', N'1', N'56 Lê Quý Ðôn ', N'12/26/2021 7:12:53 PM', N'5400000', N'60m2', N'5400000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (2, N'n04', N'Nhà chung cu', N'1', N'56 Lê Quý Ðôn ', N'12/26/2021 7:13:50 PM', N'5400000', N'60m2', N'5400000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (9, N'n05', N'Nhà cao cấp', N'1', N'45 Lê Thánh Tôn', N'12/26/2021 7:40:03 PM', N'1200000', N'34m2', N'1200000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (19, N'n06', N'Nhà tranh', N'1', N'12 Bao Vinh, Huế', N'12/26/2021 11:12:22 PM', N'1200000', N'20m2', N'1200000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (23, N'n05', N'Nhà cao cấp', N'1', N'80 An Phúc, Huế', N'12/26/2021 11:31:24 PM', N'1200000', N'40m2', N'1200000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (24, N'n06', N'Nhà tranh', N'1', N'12 Bao Vinh, Huế', N'12/26/2021 11:59:48 PM', N'1200000', N'20m2', N'1200000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (25, N'n05', N'Nhà cao cấp', N'1', N'45 Lê Thánh Tôn', N'12/27/2021 12:01:13 AM', N'1200000', N'34m2', N'1200000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (26, N'n03', N'Nhà 4 tầng', N'1', N'10 Ðịa Linh, Huế', N'12/27/2021 12:09:37 AM', N'4500000', N'100m2', N'4500000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (42, N'n08', N'Nhà cao cấp 2', N'2', N'50 Chi Lăng, Huế', N'12/27/2021 4:33:53 PM', N'13000000', N'140m2', N'26000000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (43, N'n04', N'Nhà chung cu', N'1', N'56 Lê Quý Ðôn ', N'12/27/2021 4:39:17 PM', N'5400000', N'60m2', N'5400000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (44, N'n01', N'Nhà cấp bốn', N'1', N'80 An Phúc, Huế', N'12/27/2021 4:46:07 PM', N'5000000', N'40m2', N'5000000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (45, N'n04', N'Nhà chung cu', N'1', N'56 Lê Quý Ðôn ', N'12/27/2021 6:57:58 PM', N'5400000', N'60m2', N'5400000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (46, N'n03', N'Nhà 4 tầng', N'1', N'10 Ðịa Linh, Huế', N'12/27/2021 6:57:58 PM', N'4500000', N'100m2', N'4500000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (47, N'n01', N'Nhà cấp bốn', N'2', N'80 An Phúc, Huế', N'12/27/2021 9:10:41 PM', N'5000000', N'40m2', N'10000000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (48, N'n08', N'Nhà cao cấp 2', N'2', N'50 Chi Lăng, Huế', N'12/28/2021 5:03:04 PM', N'13000000', N'140m2', N'26000000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (49, N'n02', N'Nhà biệt thự', N'4', N'50 Ðinh Tiên Hoàng', N'12/28/2021 5:03:04 PM', N'12000000', N'150m2', N'48000000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (50, N'n10', N'Nhà chung cư 2', N'1', N'123 Phú Thuận', N'12/28/2021 5:03:04 PM', N'8000000', N'76m2', N'8000000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (51, N'n09', N'Nhà 4 tầng 2', N'5', N'87 Tăng Bạc Hổ', N'12/28/2021 5:03:59 PM', N'7000000', N'70m2', N'35000000')
INSERT [dbo].[HoaDonn] ([Mahoadon], [Manha], [Loainha], [Soluong], [Diachi], [Ngaymua], [Gia], [Dientich], [Thanhtien]) VALUES (52, N'n10', N'Nhà chung cư 2', N'1', N'123 Phú Thuận', N'12/28/2021 5:03:59 PM', N'8000000', N'76m2', N'8000000')
SET IDENTITY_INSERT [dbo].[HoaDonn] OFF
GO
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n01', N'Nhà cấp bốn', N'10', N'80 An Phúc, Huế', N'40m2', N'5000000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n02', N'Nhà biệt thự', N'16', N'50 Ðinh Tiên Hoàng', N'150m2', N'12000000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n03', N'Nhà 4 tầng', N'7', N'10 Ðịa Linh, Huế', N'100m2', N'4500000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n04', N'Nhà chung cu', N'4', N'56 Lê Quý Ðôn ', N'60m2', N'5400000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n05', N'Nhà cao cấp', N'7', N'45 Lê Thánh Tôn', N'34m2', N'1200000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n06', N'Nhà tranh', N'8', N'12 Bao Vinh, Huế', N'20m2', N'1200000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n07', N'Nhà biệt thự 2', N'7', N'40 Lê Duẩn', N'200m2', N'20000000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n08', N'Nhà cao cấp 2', N'14', N'50 Chi Lăng, Huế', N'140m2', N'13000000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n09', N'Nhà 4 tầng 2', N'5', N'87 Tăng Bạc Hổ', N'70m2', N'7000000')
INSERT [dbo].[Nhathue] ([Manha], [Loainha], [Soluong], [Diachi], [Dientich], [Gia]) VALUES (N'n10', N'Nhà chung cư 2', N'18', N'123 Phú Thuận', N'76m2', N'8000000')
GO
INSERT [dbo].[User] ([id], [username], [password]) VALUES (N'1', N'duy', N'duy')
INSERT [dbo].[User] ([id], [username], [password]) VALUES (N'2', N'duy1', N'duy1')
INSERT [dbo].[User] ([id], [username], [password]) VALUES (N'3', N'duy2', N'duy2')
GO
USE [master]
GO
ALTER DATABASE [qliUser] SET  READ_WRITE 
GO
