USE [master]
GO
/****** Object:  Database [ShopLiteDb]    Script Date: 3/17/2021 4:56:51 PM ******/
CREATE DATABASE [ShopLiteDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopLiteDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.WSERVER\MSSQL\DATA\ShopLiteDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopLiteDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.WSERVER\MSSQL\DATA\ShopLiteDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopLiteDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopLiteDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopLiteDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopLiteDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopLiteDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopLiteDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopLiteDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ShopLiteDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopLiteDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopLiteDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopLiteDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopLiteDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopLiteDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopLiteDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopLiteDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopLiteDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ShopLiteDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopLiteDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopLiteDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopLiteDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopLiteDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopLiteDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopLiteDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopLiteDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopLiteDb] SET  MULTI_USER 
GO
ALTER DATABASE [ShopLiteDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopLiteDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopLiteDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopLiteDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShopLiteDb] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ShopLiteDb]
GO
/****** Object:  User [user]    Script Date: 3/17/2021 4:56:51 PM ******/
CREATE USER [user] FOR LOGIN [user1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [user]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [user]
GO
/****** Object:  Table [dbo].[GrnDetails]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrnDetails](
	[GrnSrNo] [int] NULL,
	[ProdCd] [nvarchar](50) NULL,
	[ProdNm] [nvarchar](250) NULL,
	[UnitCd] [nvarchar](50) NULL,
	[Quantity] [decimal](18, 4) NULL,
	[CostPrice] [decimal](18, 2) NULL,
	[LineNetAmt] [decimal](18, 2) NULL,
	[LineVatAmt] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GrnMaster]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrnMaster](
	[SrNo] [int] IDENTITY(1,1) NOT NULL,
	[SuppCd] [nvarchar](50) NULL,
	[SuppNm] [nvarchar](150) NULL,
	[InvoiceNumber] [nvarchar](150) NULL,
	[UserName] [nvarchar](100) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[VatAmount] [decimal](18, 2) NULL,
	[GrnDate] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[SrNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Table]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBLBRNCH]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLBRNCH](
	[BRNCHCD] [nvarchar](50) NOT NULL,
	[BRNCHNM] [nvarchar](150) NOT NULL,
	[CMPNYCD] [nvarchar](50) NOT NULL,
	[BRNCHLOCATION] [nvarchar](150) NULL,
	[BRNCHTELEPHONE] [nvarchar](50) NULL,
	[BRNCHIP] [nvarchar](50) NULL,
	[BRNCHINSTANCE] [nvarchar](50) NULL,
	[BRNCHPWD] [nvarchar](50) NULL,
	[ISCHILD] [bit] NOT NULL DEFAULT ((1)),
	[ISPARENT] [bit] NOT NULL DEFAULT ((0)),
	[CREATEDBY] [nvarchar](50) NULL,
	[CREATEDON] [datetime] NULL DEFAULT (getdate()),
	[UPLOADFLG] [nchar](10) NOT NULL DEFAULT ('Y'),
PRIMARY KEY CLUSTERED 
(
	[BRNCHCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBLCMPNY]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLCMPNY](
	[CMPNYCD] [nvarchar](20) NOT NULL,
	[CMPNYNM] [nvarchar](150) NOT NULL,
	[CMPNYADDR] [nvarchar](50) NULL,
	[CMPNYTEL] [nvarchar](50) NULL,
	[CMPNYTAXPIN] [nvarchar](50) NULL,
	[CMPNYREGNO] [nvarchar](50) NULL,
	[CREATEDBY] [nvarchar](50) NULL,
	[CREATEDON] [datetime] NULL DEFAULT (getdate()),
	[UPLOADFLG] [nvarchar](1) NOT NULL DEFAULT ('Y'),
PRIMARY KEY CLUSTERED 
(
	[CMPNYCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBLCPHIST]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLCPHIST](
	[PROD_CD] [nvarchar](50) NOT NULL,
	[INT_CP] [decimal](18, 2) NULL,
	[NW_CP] [decimal](18, 2) NULL,
	[USR_NM] [nvarchar](50) NULL,
	[CHG_DT] [datetime] NULL DEFAULT (getdate()),
	[BRCH_CD] [nvarchar](50) NULL,
	[CMPY_CD] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDept]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDept](
	[DeptCd] [nvarchar](20) NOT NULL,
	[DeptNm] [nvarchar](150) NOT NULL,
	[Createdby] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[DeptCd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBLPOLICIES]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLPOLICIES](
	[GROUPCODE] [nvarchar](50) NOT NULL,
	[CANADDSTOCK] [bit] NULL,
	[CANVIEWSTOCK] [bit] NULL,
	[CANISSUESTOCK] [bit] NULL,
	[CANMANAGEUSERS] [bit] NULL,
	[CANADJUSTSTOCK] [bit] NULL,
	[CREATEDON] [datetime] NULL,
	[UPLOADFLG] [varchar](1) NULL,
	[ISACTIVE] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[GROUPCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblProd]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TblProd](
	[ProdCd] [nvarchar](20) NOT NULL,
	[ProdNm] [nvarchar](150) NOT NULL,
	[UnitCd] [nvarchar](10) NULL,
	[DeptCd] [nvarchar](10) NULL,
	[SuppCd] [nvarchar](20) NULL,
	[Cp] [decimal](18, 2) NULL,
	[Sp] [decimal](18, 2) NULL,
	[QtyOnOrder] [decimal](18, 2) NULL DEFAULT ((0)),
	[QtyAvble] [decimal](18, 2) NULL DEFAULT ((0)),
	[Isactive] [bit] NULL DEFAULT ((1)),
	[VatCd] [nvarchar](5) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL DEFAULT (getdate()),
	[UploadFlag] [varchar](1) NULL DEFAULT ('Y'),
PRIMARY KEY CLUSTERED 
(
	[ProdCd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TblProdHist]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblProdHist](
	[PROD_CD] [nvarchar](50) NOT NULL,
	[TXN_TYPE] [nvarchar](30) NULL,
	[DOC_NO] [int] NULL,
	[INT_QTY] [decimal](18, 2) NULL,
	[NW_QTY] [decimal](18, 2) NULL,
	[QTY] [decimal](18, 3) NULL,
	[BRCH_CD] [nvarchar](50) NULL,
	[CMPY_CD] [nvarchar](50) NULL,
	[TXN_DATE] [datetime] NULL DEFAULT (getdate()),
	[PROD_CP] [decimal](18, 2) NULL,
	[PROD_SP] [decimal](18, 2) NULL,
	[USR_NM] [nvarchar](50) NULL,
	[INV_NO] [nvarchar](250) NULL,
	[ACCOUNT_NO] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblScnCd]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblScnCd](
	[ScanCode] [nvarchar](25) NOT NULL,
	[ProdCd] [nvarchar](50) NULL,
	[UnitCd] [nvarchar](50) NULL,
	[Upload_Flg] [nchar](1) NOT NULL DEFAULT ('Y'),
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[ScanCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBLSPHIST]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBLSPHIST](
	[PROD_CD] [nvarchar](50) NOT NULL,
	[INT_SP] [decimal](18, 2) NULL,
	[NW_SP] [decimal](18, 2) NULL,
	[USR_NM] [nvarchar](50) NULL,
	[CHG_DT] [datetime] NULL DEFAULT (getdate()),
	[BRCH_CD] [nvarchar](50) NULL,
	[CMPY_CD] [nvarchar](50) NULL,
	[Sr_No] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Sr_No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblSupp]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSupp](
	[SuppCd] [nvarchar](20) NOT NULL,
	[SuppNm] [nvarchar](150) NOT NULL,
	[SuppBox] [nvarchar](150) NULL,
	[SuppCity] [nvarchar](50) NULL,
	[SuppLocation] [nvarchar](100) NULL,
	[SuppTel] [nvarchar](100) NULL,
	[SuppPinCode] [nvarchar](100) NULL,
	[SuppEmail] [nvarchar](100) NULL,
	[SuppFax] [nvarchar](100) NULL,
	[SuppCreditLimit] [decimal](18, 0) NULL,
	[SuppMobile] [nvarchar](100) NULL,
	[SuppPaymentTerms] [nvarchar](100) NULL,
	[SuppLimitDays] [int] NULL,
	[SuppVatNo] [nvarchar](100) NULL,
	[CreatedBy] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SuppCd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblUnit]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUnit](
	[UnitCd] [nvarchar](20) NOT NULL,
	[UnitNm] [nvarchar](150) NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL DEFAULT (getdate()),
	[UploadFlag] [nvarchar](1) NULL DEFAULT ('Y'),
PRIMARY KEY CLUSTERED 
(
	[UnitCd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TBLUSERGROUPS]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLUSERGROUPS](
	[GROUPCODE] [nvarchar](50) NOT NULL,
	[GROUPNAME] [nvarchar](100) NOT NULL,
	[CANADDSTOCK] [bit] NOT NULL DEFAULT ((0)),
	[CANVIEWSTOCK] [bit] NOT NULL DEFAULT ((0)),
	[CANISSUESTOCK] [bit] NOT NULL DEFAULT ((0)),
	[CANMANAGEUSERS] [bit] NOT NULL DEFAULT ((0)),
	[CANCHANGECP] [bit] NOT NULL DEFAULT ((0)),
	[CANCHANGESP] [bit] NOT NULL DEFAULT ((0)),
	[CANADJUSTSTOCK] [bit] NOT NULL DEFAULT ((0)),
	[CREATEDBY] [nvarchar](50) NULL,
	[CREATEDON] [datetime] NULL DEFAULT (getdate()),
	[UPLOADFLG] [varchar](1) NULL DEFAULT ('Y'),
	[ISACTIVE] [bit] NULL DEFAULT ((1))
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLUSERROLE]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[TBLUSERROLE](
	[USERNAME] [nvarchar](50) NOT NULL,
	[GROUPCODE] [nvarchar](50) NULL,
	[CREATEDON] [datetime] NULL,
	[UPLOADFLG] [varchar](1) NULL,
	[ISACTIVE] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TBLUSERS]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBLUSERS](
	[USERNAME] [nvarchar](50) NOT NULL,
	[FULLNAME] [nvarchar](100) NOT NULL,
	[PASSWORD] [nvarchar](250) NULL,
	[GROUPCODE] [nvarchar](50) NULL,
	[CREATEDBY] [nvarchar](50) NULL,
	[CREATEDON] [datetime] NULL DEFAULT (getdate()),
	[UPLOADFLG] [varchar](1) NULL DEFAULT ('Y'),
	[ISACTIVE] [bit] NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblVat]    Script Date: 3/17/2021 4:56:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblVat](
	[VatCd] [nvarchar](5) NOT NULL,
	[VatPercentage] [decimal](18, 0) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedOn] [datetime] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[VatCd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (6, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(166.00 AS Decimal(18, 2)), CAST(26.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (6, N'1002', N'TEST ITEM 2', N'PCS', CAST(12.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (7, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(166.00 AS Decimal(18, 2)), CAST(26.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (7, N'1002', N'TEST ITEM 2', N'PCS', CAST(12.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (8, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(166.00 AS Decimal(18, 2)), CAST(26.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (8, N'1002', N'TEST ITEM 2', N'PCS', CAST(12.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (9, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(166.00 AS Decimal(18, 2)), CAST(26.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (9, N'1002', N'TEST ITEM 2', N'PCS', CAST(12.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (10, N'1002', N'TEST ITEM 2', N'PCS', CAST(12.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (10, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(166.00 AS Decimal(18, 2)), CAST(26.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (11, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(16.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(221.00 AS Decimal(18, 2)), CAST(35.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (11, N'1002', N'TEST ITEM 2', N'PCS', CAST(25.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(3125.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (12, N'1002', N'TEST ITEM 2', N'PCS', CAST(14.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1750.00 AS Decimal(18, 2)), CAST(280.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (12, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(14.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(193.00 AS Decimal(18, 2)), CAST(31.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (13, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(165.52 AS Decimal(18, 2)), CAST(26.48 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (13, N'1002', N'TEST ITEM 2', N'PCS', CAST(11.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1375.00 AS Decimal(18, 2)), CAST(220.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (13, N'1022', N'YHHFECBCSHHCVSHV', N'PCS', CAST(14.0000 AS Decimal(18, 4)), CAST(120.00 AS Decimal(18, 2)), CAST(1448.28 AS Decimal(18, 2)), CAST(231.72 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (14, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(14.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(193.10 AS Decimal(18, 2)), CAST(30.90 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (14, N'1002', N'TEST ITEM 2', N'PCS', CAST(12.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1500.00 AS Decimal(18, 2)), CAST(240.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (14, N'1004', N'TESHDHHH', N'PCS', CAST(10.0000 AS Decimal(18, 4)), CAST(10.00 AS Decimal(18, 2)), CAST(86.21 AS Decimal(18, 2)), CAST(13.79 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (14, N'1022', N'YHHFECBCSHHCVSHV', N'PCS', CAST(16.0000 AS Decimal(18, 4)), CAST(120.00 AS Decimal(18, 2)), CAST(1655.17 AS Decimal(18, 2)), CAST(264.83 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (14, N'10500001', N'ARIMIS MILKING JELLY 72*50G', N'PCS', CAST(14.0000 AS Decimal(18, 4)), CAST(53.00 AS Decimal(18, 2)), CAST(639.66 AS Decimal(18, 2)), CAST(102.34 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (15, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(165.52 AS Decimal(18, 2)), CAST(26.48 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (16, N'1001', N'TEST ITEM 1', N'PCSFGHG', CAST(12.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(165.52 AS Decimal(18, 2)), CAST(26.48 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (16, N'1002', N'TEST ITEM 2', N'PCS', CAST(14.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1750.00 AS Decimal(18, 2)), CAST(280.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (16, N'1022', N'YHHFECBCSHHCVSHV', N'PCS', CAST(40.0000 AS Decimal(18, 4)), CAST(120.00 AS Decimal(18, 2)), CAST(4137.93 AS Decimal(18, 2)), CAST(662.07 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (16, N'10500001', N'ARIMIS MILKING JELLY 72*50G', N'PCS', CAST(12.0000 AS Decimal(18, 4)), CAST(53.00 AS Decimal(18, 2)), CAST(548.28 AS Decimal(18, 2)), CAST(87.72 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (1016, N'1001', N'TEST ITEM 1', N'PCS', CAST(15.0000 AS Decimal(18, 4)), CAST(16.00 AS Decimal(18, 2)), CAST(206.90 AS Decimal(18, 2)), CAST(33.10 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (1016, N'1002', N'TEST ITEM 2', N'PCS', CAST(15.0000 AS Decimal(18, 4)), CAST(145.00 AS Decimal(18, 2)), CAST(1875.00 AS Decimal(18, 2)), CAST(300.00 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (1016, N'1004', N'TESHDHHH', N'PCS', CAST(14.0000 AS Decimal(18, 4)), CAST(10.00 AS Decimal(18, 2)), CAST(120.69 AS Decimal(18, 2)), CAST(19.31 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (1016, N'1022', N'YHHFECBCSHHCVSHV', N'PCS', CAST(14.0000 AS Decimal(18, 4)), CAST(120.00 AS Decimal(18, 2)), CAST(1448.28 AS Decimal(18, 2)), CAST(231.72 AS Decimal(18, 2)))
INSERT [dbo].[GrnDetails] ([GrnSrNo], [ProdCd], [ProdNm], [UnitCd], [Quantity], [CostPrice], [LineNetAmt], [LineVatAmt]) VALUES (1016, N'10500001', N'ARIMIS MILKING JELLY 72*50G', N'PCS', CAST(10.0000 AS Decimal(18, 4)), CAST(53.00 AS Decimal(18, 2)), CAST(456.90 AS Decimal(18, 2)), CAST(73.10 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[GrnMaster] ON 

INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (6, N'TST', N'TEST SUPPLIER', N'2152454', N'TEST', CAST(1666.00 AS Decimal(18, 2)), CAST(266.00 AS Decimal(18, 2)), CAST(N'2021-03-07 08:58:26.780' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (7, N'TST', N'TEST SUPPLIER', N'TST INVOICE', N'TEST', CAST(1666.00 AS Decimal(18, 2)), CAST(266.00 AS Decimal(18, 2)), CAST(N'2021-03-13 11:40:12.150' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (8, N'TST', N'TEST SUPPLIER', N'TST INVOICE', N'TEST', CAST(1666.00 AS Decimal(18, 2)), CAST(266.00 AS Decimal(18, 2)), CAST(N'2021-03-13 12:09:04.157' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (9, N'TST', N'TEST SUPPLIER', N'TST INVOICE', N'TEST', CAST(1666.00 AS Decimal(18, 2)), CAST(266.00 AS Decimal(18, 2)), CAST(N'2021-03-13 12:09:33.860' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (10, N'TST', N'TEST SUPPLIER', N'HDB', N'TEST', CAST(1666.00 AS Decimal(18, 2)), CAST(266.00 AS Decimal(18, 2)), CAST(N'2021-03-13 12:12:50.870' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (11, N'TST', N'TEST SUPPLIER', N'1245', N'TEST', CAST(3346.00 AS Decimal(18, 2)), CAST(535.00 AS Decimal(18, 2)), CAST(N'2021-03-13 13:18:35.660' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (12, N'TST', N'TEST SUPPLIER', N'01124', N'TEST', CAST(1943.00 AS Decimal(18, 2)), CAST(311.00 AS Decimal(18, 2)), CAST(N'2021-03-13 13:21:01.290' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (13, N'TST', N'TEST SUPPLIER', N'BOOKS', N'TEST', CAST(2988.80 AS Decimal(18, 2)), CAST(478.20 AS Decimal(18, 2)), CAST(N'2021-03-14 08:56:14.543' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (14, N'TST', N'TEST SUPPLIER', N'TEST', N'TEST', CAST(4074.14 AS Decimal(18, 2)), CAST(651.86 AS Decimal(18, 2)), CAST(N'2021-03-14 13:56:45.533' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (15, N'TST', N'TEST SUPPLIER', N'01234', N'TEST', CAST(165.52 AS Decimal(18, 2)), CAST(26.48 AS Decimal(18, 2)), CAST(N'2021-03-15 07:57:12.357' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (16, N'TST', N'TEST SUPPLIER', N'123', N'TEST', CAST(6601.73 AS Decimal(18, 2)), CAST(1056.27 AS Decimal(18, 2)), CAST(N'2021-03-15 08:56:41.040' AS DateTime))
INSERT [dbo].[GrnMaster] ([SrNo], [SuppCd], [SuppNm], [InvoiceNumber], [UserName], [TotalAmount], [VatAmount], [GrnDate]) VALUES (1016, N'TEST', N'TEST SUPP', N'TEST', N'TEST', CAST(4107.77 AS Decimal(18, 2)), CAST(657.23 AS Decimal(18, 2)), CAST(N'2021-03-17 14:41:00.763' AS DateTime))
SET IDENTITY_INSERT [dbo].[GrnMaster] OFF
INSERT [dbo].[TBLBRNCH] ([BRNCHCD], [BRNCHNM], [CMPNYCD], [BRNCHLOCATION], [BRNCHTELEPHONE], [BRNCHIP], [BRNCHINSTANCE], [BRNCHPWD], [ISCHILD], [ISPARENT], [CREATEDBY], [CREATEDON], [UPLOADFLG]) VALUES (N'01', N'THUITAS NAROK', N'TN001', N'NAROK', N'0702157779', N'192.168.8.104', N'WSERVER', NULL, 0, 1, N'ADMIN', CAST(N'2021-01-19 09:36:35.037' AS DateTime), N'Y         ')
INSERT [dbo].[TBLCMPNY] ([CMPNYCD], [CMPNYNM], [CMPNYADDR], [CMPNYTEL], [CMPNYTAXPIN], [CMPNYREGNO], [CREATEDBY], [CREATEDON], [UPLOADFLG]) VALUES (N'TN001', N'THUITAS', N'144', N'0702157779', N'A000212', N'BGA01254', N'ADMIN', CAST(N'2021-01-19 09:35:37.867' AS DateTime), N'Y')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1021', CAST(545.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 19:58:10.830' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(0.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 20:07:27.897' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(12.00 AS Decimal(18, 2)), CAST(13.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 20:09:30.077' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(13.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 20:11:21.580' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(12.00 AS Decimal(18, 2)), CAST(145.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 20:13:20.990' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(145.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 20:16:08.550' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(12.00 AS Decimal(18, 2)), CAST(12.53 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 20:21:00.990' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(13.00 AS Decimal(18, 2)), CAST(14.52 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-07 20:23:44.533' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1001', CAST(14.52 AS Decimal(18, 2)), CAST(16.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-19 17:55:51.093' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'10500001', CAST(14.23 AS Decimal(18, 2)), CAST(53.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-02-28 17:08:11.433' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1004', CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-03-01 10:06:39.520' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1002', CAST(0.00 AS Decimal(18, 2)), CAST(150.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-03-05 19:34:32.133' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1002', CAST(150.00 AS Decimal(18, 2)), CAST(1502.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-03-06 10:43:13.083' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[TBLCPHIST] ([PROD_CD], [INT_CP], [NW_CP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD]) VALUES (N'1002', CAST(1502.00 AS Decimal(18, 2)), CAST(145.00 AS Decimal(18, 2)), N'TEST', CAST(N'2021-03-06 10:53:56.703' AS DateTime), N'NRK', N'TT')
INSERT [dbo].[tblDept] ([DeptCd], [DeptNm], [Createdby], [CreatedOn]) VALUES (N'DEPT1', N'DEPARTMENT tested', N'Test', CAST(N'2020-12-11 07:19:30.797' AS DateTime))
INSERT [dbo].[TblProd] ([ProdCd], [ProdNm], [UnitCd], [DeptCd], [SuppCd], [Cp], [Sp], [QtyOnOrder], [QtyAvble], [Isactive], [VatCd], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'1001', N'TEST ITEM 1', N'PCS', N'dept1', N'tst', CAST(16.00 AS Decimal(18, 2)), CAST(54.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(155.00 AS Decimal(18, 2)), 1, N'A', N'Admin', CAST(N'2020-12-31 18:28:15.957' AS DateTime), N'Y')
INSERT [dbo].[TblProd] ([ProdCd], [ProdNm], [UnitCd], [DeptCd], [SuppCd], [Cp], [Sp], [QtyOnOrder], [QtyAvble], [Isactive], [VatCd], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'1002', N'TEST ITEM 2', N'PCS', N'dept1', N'tst', CAST(145.00 AS Decimal(18, 2)), CAST(235.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(151.00 AS Decimal(18, 2)), 1, N'A', N'ADMIN', CAST(N'2021-01-01 12:04:08.747' AS DateTime), N'Y')
INSERT [dbo].[TblProd] ([ProdCd], [ProdNm], [UnitCd], [DeptCd], [SuppCd], [Cp], [Sp], [QtyOnOrder], [QtyAvble], [Isactive], [VatCd], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'1004', N'TESHDHHH', N'PCS', N'dept1', N'tst', CAST(10.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), 1, N'A', N'ADMIN', CAST(N'2021-01-01 12:11:53.117' AS DateTime), N'Y')
INSERT [dbo].[TblProd] ([ProdCd], [ProdNm], [UnitCd], [DeptCd], [SuppCd], [Cp], [Sp], [QtyOnOrder], [QtyAvble], [Isactive], [VatCd], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'1022', N'YHHFECBCSHHCVSHV', N'PCS', N'dept1', N'tst', CAST(120.00 AS Decimal(18, 2)), CAST(1452.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(84.00 AS Decimal(18, 2)), 1, N'A', N'ADMIN', CAST(N'2021-01-05 10:59:21.467' AS DateTime), N'Y')
INSERT [dbo].[TblProd] ([ProdCd], [ProdNm], [UnitCd], [DeptCd], [SuppCd], [Cp], [Sp], [QtyOnOrder], [QtyAvble], [Isactive], [VatCd], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'10500001', N'ARIMIS MILKING JELLY 72*50G', N'PCS', N'dept1', N'tst', CAST(53.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), 1, N'A', N'ADMIN', CAST(N'2021-01-10 12:18:35.060' AS DateTime), N'Y')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 6, CAST(0.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-07 08:58:33.890' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'2152454', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 6, CAST(0.00 AS Decimal(18, 2)), CAST(12.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-07 08:58:48.800' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'2152454', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 7, CAST(12.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 11:40:27.257' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'TST INVOICE', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 7, CAST(12.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 11:40:37.587' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'TST INVOICE', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 8, CAST(24.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 12:09:15.750' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'TST INVOICE', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 8, CAST(24.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 12:09:15.770' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'TST INVOICE', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 9, CAST(36.00 AS Decimal(18, 2)), CAST(48.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 12:09:33.867' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'TST INVOICE', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 9, CAST(36.00 AS Decimal(18, 2)), CAST(48.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 12:09:33.870' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'TST INVOICE', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 10, CAST(48.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 12:12:50.903' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'HDB', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 10, CAST(48.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 12:12:50.927' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'HDB', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 11, CAST(60.00 AS Decimal(18, 2)), CAST(76.00 AS Decimal(18, 2)), CAST(16.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 13:18:35.720' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'1245', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 11, CAST(60.00 AS Decimal(18, 2)), CAST(85.00 AS Decimal(18, 2)), CAST(25.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 13:18:35.733' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'1245', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 12, CAST(85.00 AS Decimal(18, 2)), CAST(99.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 13:21:01.313' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'01124', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 12, CAST(76.00 AS Decimal(18, 2)), CAST(90.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-13 13:21:01.323' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'01124', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 13, CAST(90.00 AS Decimal(18, 2)), CAST(102.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 08:56:14.593' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'BOOKS', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 13, CAST(99.00 AS Decimal(18, 2)), CAST(110.00 AS Decimal(18, 2)), CAST(11.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 08:56:14.607' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'BOOKS', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1022', N'GRN', 13, CAST(0.00 AS Decimal(18, 2)), CAST(14.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 08:56:14.757' AS DateTime), CAST(120.00 AS Decimal(18, 2)), NULL, N'TEST', N'BOOKS', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 14, CAST(102.00 AS Decimal(18, 2)), CAST(116.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 13:56:45.750' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 14, CAST(110.00 AS Decimal(18, 2)), CAST(122.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 13:56:45.780' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1004', N'GRN', 14, CAST(0.00 AS Decimal(18, 2)), CAST(10.00 AS Decimal(18, 2)), CAST(10.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 13:56:45.810' AS DateTime), CAST(10.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1022', N'GRN', 14, CAST(14.00 AS Decimal(18, 2)), CAST(30.00 AS Decimal(18, 2)), CAST(16.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 13:56:45.820' AS DateTime), CAST(120.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'10500001', N'GRN', 14, CAST(0.00 AS Decimal(18, 2)), CAST(14.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-14 13:56:45.840' AS DateTime), CAST(53.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 15, CAST(116.00 AS Decimal(18, 2)), CAST(128.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-15 07:57:12.427' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'01234', NULL)
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 16, CAST(128.00 AS Decimal(18, 2)), CAST(140.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-15 08:56:41.097' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'123', N'TEST SUPPLIER')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 16, CAST(122.00 AS Decimal(18, 2)), CAST(136.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-15 08:56:41.110' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'123', N'TEST SUPPLIER')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1022', N'GRN', 16, CAST(30.00 AS Decimal(18, 2)), CAST(70.00 AS Decimal(18, 2)), CAST(40.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-15 08:56:41.120' AS DateTime), CAST(120.00 AS Decimal(18, 2)), NULL, N'TEST', N'123', N'TEST SUPPLIER')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'10500001', N'GRN', 16, CAST(14.00 AS Decimal(18, 2)), CAST(26.00 AS Decimal(18, 2)), CAST(12.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-15 08:56:41.133' AS DateTime), CAST(53.00 AS Decimal(18, 2)), NULL, N'TEST', N'123', N'TEST SUPPLIER')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1001', N'GRN', 1016, CAST(140.00 AS Decimal(18, 2)), CAST(155.00 AS Decimal(18, 2)), CAST(15.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-17 14:41:00.837' AS DateTime), CAST(16.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', N'TEST SUPP')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1002', N'GRN', 1016, CAST(136.00 AS Decimal(18, 2)), CAST(151.00 AS Decimal(18, 2)), CAST(15.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-17 14:41:00.847' AS DateTime), CAST(145.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', N'TEST SUPP')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1004', N'GRN', 1016, CAST(10.00 AS Decimal(18, 2)), CAST(24.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-17 14:41:00.857' AS DateTime), CAST(10.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', N'TEST SUPP')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'1022', N'GRN', 1016, CAST(70.00 AS Decimal(18, 2)), CAST(84.00 AS Decimal(18, 2)), CAST(14.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-17 14:41:00.870' AS DateTime), CAST(120.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', N'TEST SUPP')
INSERT [dbo].[TblProdHist] ([PROD_CD], [TXN_TYPE], [DOC_NO], [INT_QTY], [NW_QTY], [QTY], [BRCH_CD], [CMPY_CD], [TXN_DATE], [PROD_CP], [PROD_SP], [USR_NM], [INV_NO], [ACCOUNT_NO]) VALUES (N'10500001', N'GRN', 1016, CAST(26.00 AS Decimal(18, 2)), CAST(36.00 AS Decimal(18, 2)), CAST(10.000 AS Decimal(18, 3)), NULL, NULL, CAST(N'2021-03-17 14:41:00.880' AS DateTime), CAST(53.00 AS Decimal(18, 2)), NULL, N'TEST', N'TEST', N'TEST SUPP')
INSERT [dbo].[TblScnCd] ([ScanCode], [ProdCd], [UnitCd], [Upload_Flg], [CreatedBy], [CreatedOn]) VALUES (N'123456', N'1001', N'PCSFGHG', N'Y', N'ADMIN', CAST(N'2021-02-15 08:30:15.320' AS DateTime))
INSERT [dbo].[TblScnCd] ([ScanCode], [ProdCd], [UnitCd], [Upload_Flg], [CreatedBy], [CreatedOn]) VALUES (N'1452', N'10500001', N'PCS', N'Y', N'ADMIN', CAST(N'2021-01-10 13:52:46.890' AS DateTime))
INSERT [dbo].[TblScnCd] ([ScanCode], [ProdCd], [UnitCd], [Upload_Flg], [CreatedBy], [CreatedOn]) VALUES (N'6008677000549', N'10500001', N'PCS', N'Y', N'ADMIN', CAST(N'2021-03-06 10:04:20.320' AS DateTime))
SET IDENTITY_INSERT [dbo].[TBLSPHIST] ON 

INSERT [dbo].[TBLSPHIST] ([PROD_CD], [INT_SP], [NW_SP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD], [Sr_No]) VALUES (N'1001', CAST(14.56 AS Decimal(18, 2)), CAST(20.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-09 19:47:41.477' AS DateTime), N'NRK', N'TT', 1)
INSERT [dbo].[TBLSPHIST] ([PROD_CD], [INT_SP], [NW_SP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD], [Sr_No]) VALUES (N'1001', CAST(20.00 AS Decimal(18, 2)), CAST(145.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-01-19 17:55:35.140' AS DateTime), N'NRK', N'TT', 2)
INSERT [dbo].[TBLSPHIST] ([PROD_CD], [INT_SP], [NW_SP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD], [Sr_No]) VALUES (N'1001', CAST(145.00 AS Decimal(18, 2)), CAST(54.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-02-04 10:58:52.763' AS DateTime), N'NRK', N'TT', 3)
INSERT [dbo].[TBLSPHIST] ([PROD_CD], [INT_SP], [NW_SP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD], [Sr_No]) VALUES (N'10500001', CAST(25.00 AS Decimal(18, 2)), CAST(60.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-02-28 17:07:57.680' AS DateTime), N'NRK', N'TT', 4)
INSERT [dbo].[TBLSPHIST] ([PROD_CD], [INT_SP], [NW_SP], [USR_NM], [CHG_DT], [BRCH_CD], [CMPY_CD], [Sr_No]) VALUES (N'1002', CAST(0.00 AS Decimal(18, 2)), CAST(235.00 AS Decimal(18, 2)), N'ADMIN', CAST(N'2021-03-05 19:34:41.900' AS DateTime), N'NRK', N'TT', 5)
SET IDENTITY_INSERT [dbo].[TBLSPHIST] OFF
INSERT [dbo].[TblSupp] ([SuppCd], [SuppNm], [SuppBox], [SuppCity], [SuppLocation], [SuppTel], [SuppPinCode], [SuppEmail], [SuppFax], [SuppCreditLimit], [SuppMobile], [SuppPaymentTerms], [SuppLimitDays], [SuppVatNo], [CreatedBy]) VALUES (N'TEST', N'TEST SUPP', N'140', N'MOLO', N'MOLO', N'0702157779', N'A00023235B', N'mahdhhdhahh', N'10246646464646', CAST(1450 AS Decimal(18, 0)), N'0702157779', N'CHEQUE', 40, N'BSKKFSFHFH', N'Test')
INSERT [dbo].[TblSupp] ([SuppCd], [SuppNm], [SuppBox], [SuppCity], [SuppLocation], [SuppTel], [SuppPinCode], [SuppEmail], [SuppFax], [SuppCreditLimit], [SuppMobile], [SuppPaymentTerms], [SuppLimitDays], [SuppVatNo], [CreatedBy]) VALUES (N'TST', N'TEST SUPPLIER', N'140', N'NAROK', N'HOME SWEET', N'4575274', N'A002175845L', N'testsupplier@gmail.com', N'FSFSF', CAST(120 AS Decimal(18, 0)), N'0702157779', N'CHEQUE', 90, N'DSFSDFAS', N'Test')
INSERT [dbo].[tblUnit] ([UnitCd], [UnitNm], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'HSYATYDY', N'HUGSUATDU', N'Test', CAST(N'2020-12-13 17:36:25.497' AS DateTime), N'Y')
INSERT [dbo].[tblUnit] ([UnitCd], [UnitNm], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'PCS', N'PIECES', N'Test', CAST(N'2021-03-14 14:07:21.913' AS DateTime), N'Y')
INSERT [dbo].[tblUnit] ([UnitCd], [UnitNm], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'TESDT', N'GAHDHSFGHSFC', N'Test', CAST(N'2020-12-13 17:51:35.017' AS DateTime), N'Y')
INSERT [dbo].[tblUnit] ([UnitCd], [UnitNm], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'TEST UNIT', N'TEST UNIT DESCRIPTION', N'Test', CAST(N'2020-12-13 17:46:00.670' AS DateTime), N'Y')
INSERT [dbo].[tblUnit] ([UnitCd], [UnitNm], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'THSFH', N'JHDSJUSUFGESFUS', N'Test', CAST(N'2020-12-13 17:53:02.253' AS DateTime), N'Y')
INSERT [dbo].[tblUnit] ([UnitCd], [UnitNm], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'UNIT1', N'unit 1 edited ', N'Test', CAST(N'2020-12-12 13:05:59.590' AS DateTime), N'Y')
INSERT [dbo].[tblUnit] ([UnitCd], [UnitNm], [CreatedBy], [CreatedOn], [UploadFlag]) VALUES (N'UNIT2', N'UNIT 2', N'Test', CAST(N'2020-12-12 15:47:30.217' AS DateTime), N'Y')
INSERT [dbo].[TBLUSERGROUPS] ([GROUPCODE], [GROUPNAME], [CANADDSTOCK], [CANVIEWSTOCK], [CANISSUESTOCK], [CANMANAGEUSERS], [CANCHANGECP], [CANCHANGESP], [CANADJUSTSTOCK], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'ADMIN', N'ADMINISTRATORS', 1, 1, 1, 1, 1, 1, 1, N'TEST', CAST(N'2021-03-02 17:00:19.270' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERGROUPS] ([GROUPCODE], [GROUPNAME], [CANADDSTOCK], [CANVIEWSTOCK], [CANISSUESTOCK], [CANMANAGEUSERS], [CANCHANGECP], [CANCHANGESP], [CANADJUSTSTOCK], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'STOCKS', N'STOCK TEAM', 0, 1, 0, 0, 0, 0, 0, N'TEST', CAST(N'2021-03-02 17:04:33.310' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERGROUPS] ([GROUPCODE], [GROUPNAME], [CANADDSTOCK], [CANVIEWSTOCK], [CANISSUESTOCK], [CANMANAGEUSERS], [CANCHANGECP], [CANCHANGESP], [CANADJUSTSTOCK], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'USERS', N'BACKOFFICE USER', 1, 1, 1, 0, 1, 1, 0, N'TEST', CAST(N'2021-03-03 11:41:39.877' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERGROUPS] ([GROUPCODE], [GROUPNAME], [CANADDSTOCK], [CANVIEWSTOCK], [CANISSUESTOCK], [CANMANAGEUSERS], [CANCHANGECP], [CANCHANGESP], [CANADJUSTSTOCK], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'LABESL', N'BSSA', 0, 0, 0, 0, 0, 0, 0, N'JOHN', CAST(N'2021-03-04 19:47:47.637' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERGROUPS] ([GROUPCODE], [GROUPNAME], [CANADDSTOCK], [CANVIEWSTOCK], [CANISSUESTOCK], [CANMANAGEUSERS], [CANCHANGECP], [CANCHANGESP], [CANADJUSTSTOCK], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'CDSS', N'FDRRSRS', 0, 0, 0, 0, 0, 0, 0, N'JOHN', CAST(N'2021-03-04 19:49:33.690' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERGROUPS] ([GROUPCODE], [GROUPNAME], [CANADDSTOCK], [CANVIEWSTOCK], [CANISSUESTOCK], [CANMANAGEUSERS], [CANCHANGECP], [CANCHANGESP], [CANADJUSTSTOCK], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'CDS', N'44854', 0, 0, 0, 0, 0, 0, 0, N'MAINA', CAST(N'2021-03-04 19:51:39.233' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERS] ([USERNAME], [FULLNAME], [PASSWORD], [GROUPCODE], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'JOHN', N'ELTON JOHN', N'Z0hjbCyXKEM=', N'STOCKS', N'TEST', CAST(N'2021-03-04 19:46:26.767' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERS] ([USERNAME], [FULLNAME], [PASSWORD], [GROUPCODE], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'MAINA', N'MICHAEL MAINA 2', N'J/hyiFVnvOM=', N'STOCKS', N'test', CAST(N'2021-03-03 15:37:05.877' AS DateTime), N'Y', 1)
INSERT [dbo].[TBLUSERS] ([USERNAME], [FULLNAME], [PASSWORD], [GROUPCODE], [CREATEDBY], [CREATEDON], [UPLOADFLG], [ISACTIVE]) VALUES (N'TEST', N'MICHAEL MAINA', N'gG/qJRgy3/A=', N'ADMIN', N'admin', CAST(N'2021-01-16 17:21:17.013' AS DateTime), N'Y', 1)
INSERT [dbo].[tblVat] ([VatCd], [VatPercentage], [CreatedBy], [CreatedOn]) VALUES (N'A', CAST(16 AS Decimal(18, 0)), N'Admin', CAST(N'2020-12-16 11:35:57.433' AS DateTime))
INSERT [dbo].[tblVat] ([VatCd], [VatPercentage], [CreatedBy], [CreatedOn]) VALUES (N'Z', CAST(0 AS Decimal(18, 0)), N'Admin', CAST(N'2020-12-16 12:06:19.053' AS DateTime))
ALTER TABLE [dbo].[TBLPOLICIES] ADD  DEFAULT (getdate()) FOR [CREATEDON]
GO
ALTER TABLE [dbo].[TBLPOLICIES] ADD  DEFAULT ('Y') FOR [UPLOADFLG]
GO
ALTER TABLE [dbo].[TBLPOLICIES] ADD  DEFAULT ((1)) FOR [ISACTIVE]
GO
ALTER TABLE [dbo].[TBLUSERROLE] ADD  DEFAULT (getdate()) FOR [CREATEDON]
GO
ALTER TABLE [dbo].[TBLUSERROLE] ADD  DEFAULT ('Y') FOR [UPLOADFLG]
GO
ALTER TABLE [dbo].[TBLUSERROLE] ADD  DEFAULT ((1)) FOR [ISACTIVE]
GO
/****** Object:  StoredProcedure [dbo].[ADDUSERGROUP]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[ADDUSERGROUP]
@GroupCode nvarchar(50),
@GroupName nvarchar (100),
@canaddstock bit,
@canviewstock bit,
@canissuestock bit,
@canmanageusers bit,
@canchangecp bit,
@canchangesp bit,
@canadjuststock bit,
@createdby nvarchar(50)

as
begin
insert into TBLUSERGROUPS (groupcode,GROUPNAME,CANADDSTOCK,CANVIEWSTOCK,CANISSUESTOCK,CANMANAGEUSERS,CANCHANGECP,CANCHANGESP,CANADJUSTSTOCK,CREATEDBY) values 
(@GroupCode,@GroupName,@canaddstock,@canviewstock,@canissuestock,@canmanageusers,@canchangecp,@canchangesp,@canadjuststock,@createdby)
end

GO
/****** Object:  StoredProcedure [dbo].[EditSupp]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[EditSupp]
@SuppCd nvarchar (20) ,
	@SuppNm nvarchar (150),
	@SuppBox nvarchar (150),
	@SuppCity nvarchar(50),
	@SuppLocation nvarchar(100),
	@SuppTel nvarchar(100),
	@SuppPinCode nvarchar(100),
	@SuppEmail nvarchar(100),
	@SuppFax nvarchar(100),
	@SuppCreditLimit decimal ,
	@SuppMobile nvarchar(100),
	@SuppPaymentTerms nvarchar(100),
	@SuppLimitDays int,
	@SuppVatNo nvarchar(100)

	as
	begin
	update TblSupp
	set
	SuppNm =@SuppNm,
	SuppBox = @SuppBox,
	SuppCity = @suppcity,
	SuppLocation =@SuppLocation,
	SuppTel= @SuppTel,
	SuppPinCode = @SuppPinCode,
	SuppEmail =@SuppEmail,
	SuppFax =@suppfax,
	SuppCreditLimit =@SuppCreditLimit ,
	SuppMobile =@SuppMobile,
	SuppPaymentTerms =@SuppPaymentTerms,
	SuppLimitDays =@SuppLimitDays,
	SuppVatNo =@SuppVatNo
	where SuppCd=@SuppCd
	end
GO
/****** Object:  StoredProcedure [dbo].[EditUnit]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditUnit] 
@Unitcd nvarchar (20),
@unitnm nvarchar (50)
as 
begin
Update tblUnit
set 
UnitNm=@unitnm where UnitCd=@Unitcd
end
GO
/****** Object:  StoredProcedure [dbo].[EditVat]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditVat]
@VatCd nvarchar (20),
@VatPercentage decimal
as 
begin
update tblVat
set
VatPercentage=@VatPercentage where VatCd=@VatCd
end
GO
/****** Object:  StoredProcedure [dbo].[SPADDUSER]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SPADDUSER]
	@Uname nvarchar (50),
	@Fname nvarchar (150),
	@Pwd nvarchar (250),
	@GROUPCODE NVARCHAR (50),
	@Createdby nvarchar (50)
AS
	begin
	insert into TBLUSERS (USERNAME,FULLNAME,[PASSWORD],GROUPCODE,CREATEDBY) values (@Uname,@Fname,@Pwd,@GROUPCODE,@Createdby)
	end

GO
/****** Object:  StoredProcedure [dbo].[SPBRANCH]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SPBRANCH]
	@Cmpnycd nvarchar (50),
	@Brnchcd nvarchar (50),
	@Brnchnm nvarchar (150),
	@BrnchLocation nvarchar(150),
	@BrnchTelephone nvarchar (50),
	@BrnchIp nvarchar(50),
	@BrnchPwd nvarchar(50),
	@BrnchInstance nvarchar(50),
	@IsChild bit,
	@isParent bit,
	@CreatedBy nvarchar (50)
AS
	begin

	if exists (select * from TBLBRNCH where BRNCHCD=@Brnchcd)
	  update TBLBRNCH set 
	  CMPNYCD=@Cmpnycd,
	  BRNCHNM=@Brnchnm,
	  BRNCHLOCATION=@BrnchLocation,
	  BRNCHTELEPHONE=@BrnchTelephone,
	  BRNCHIP=@BrnchIp,
	  BRNCHINSTANCE=@BrnchInstance,
	  BRNCHPWD=@BrnchPwd,
	  ISCHILD=@IsChild,
	  ISPARENT=@isParent where BRNCHCD=@Brnchcd
	  else
	  insert into TBLBRNCH (CMPNYCD,BRNCHCD,BRNCHNM,BRNCHLOCATION,BRNCHTELEPHONE,BRNCHIP,BRNCHINSTANCE,BRNCHPWD,ISCHILD,ISPARENT) values
	  (@Cmpnycd,@Brnchcd,@Brnchnm,@BrnchLocation,@BrnchTelephone,@BrnchIp,@BrnchInstance,@BrnchPwd,@IsChild,@isParent)

	
	end
GO
/****** Object:  StoredProcedure [dbo].[spGetValues]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spGetValues]
as
begin
select top 1 CMPNYNM as [Company], BRNCHNM as [Branch] from TBLBRNCH join TBLCMPNY on TBLBRNCH.CMPNYCD=TBLCMPNY.CMPNYCD 
end
GO
/****** Object:  StoredProcedure [dbo].[SpStockCard]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SpStockCard] @fromProd nvarchar (50),@toProd nvarchar (50),@fromdt datetime,@todt datetime,@fromsupp nvarchar (50),@tosupp nvarchar (50),@fromdept nvarchar (50),@todept nvarchar (50)
as 
begin 
DROP TABLE IF EXISTS #tmpStockCard
create table #tmpStockCard
(
ProdCd nvarchar (50), 
ProdNm Nvarchar (150),
ProdSupplier Nvarchar (150),
ProdDepartment Nvarchar (150),
Cp decimal (18,2),
Sp decimal (18,2),
Vat int,
 ProdUnit nvarchar (150),
 QuantityAvailable decimal (18,4),
 Txn_Date datetime,
 Txn_Type nvarchar (50),
 Doc_No int, 
 Account_No nvarchar (150),
 Qty decimal (18,2),
 Balance decimal (18,2),
 Txn_Price decimal (18,2)
)
DROP TABLE IF EXISTS #TMPOP 
SELECT PH.INT_QTY,PH.PROD_CD,P.PRODNM,S.SuppNm,U.UnitNm,D.DeptNm,P.Cp,P.Sp,V.VatPercentage,P.QtyAvble,PH.INT_QTY AS QUANTITY,PH.TXN_DATE, row_number() over (partition by pH.PROD_CD order by PH.TXN_DATE ) as row_number INTO #TMPOP
 from TblProdHist ph LEFT OUTER join TblProd p on ph.PROD_CD=p.ProdCd LEFT OUTER join TblSupp s on p.SuppCd=s.SuppCd LEFT OUTER join tblDept d on p.DeptCd=d.DeptCd LEFT OUTER join tblVat v on p.VatCd=v.VatCd LEFT OUTER join tblUnit u on p.UnitCd= u.UnitCd
where p.ProdCd between @fromProd and @toProd AND s.SuppCd between @fromsupp and @tosupp and ph.TXN_DATE between @fromdt and @Todt and d.DeptCd between @fromdept and @todept
INSERT INTO #tmpStockCard
 (Qty,ProdCd,ProdNm,ProdUnit,ProdDepartment,ProdSupplier ,Cp,Sp,Vat,QuantityAvailable,Txn_Date,Account_No,balance,Txn_Type) 
 SELECT INT_QTY,PROD_CD,PRODNM,UnitNm,DeptNm,SuppNm,Cp,Sp,VatPercentage,QtyAvble,TXN_DATE,'OP_BAL',INT_QTY,'OP_BAL' FROM #TMPOP WHERE ROW_NUMBER=1
insert into #tmpStockCard
select ph.PROD_CD as ProdCd, p.prodnm as ProdNm,s.suppnm as ProdSupplier, d.DeptNm as ProdDepartment,p.cp as Cp,p.sp as Sp,V.VatPercentage 
as Vat,u.UnitNm as ProdUnit, p.QtyAvble as QuantityAvailable,ph.TXN_DATE,ph.TXN_TYPE,ph.DOC_NO,ph.ACCOUNT_NO,ph.QTY,ph.NW_QTY as Balance,ph.PROD_CP from TblProdHist ph join TblProd p on ph.PROD_CD=p.ProdCd join TblSupp s on p.SuppCd=s.SuppCd join tblDept d on p.DeptCd=d.DeptCd join tblVat v on p.VatCd=v.VatCd join tblUnit u on p.UnitCd= u.UnitCd
where p.ProdCd between @fromProd and @toProd AND s.SuppCd between @fromsupp and @tosupp and ph.TXN_DATE between @fromdt and @Todt and d.DeptCd between @fromdept and @todept
-- select data from the temporary table
select * from #tmpStockCard
end

GO
/****** Object:  StoredProcedure [dbo].[spUpdateDept]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spUpdateDept]
@DeptCd nvarchar (20),
@DeptNm nvarchar (150)
as
begin
if exists(select deptcd from tblDept)
begin
update tblDept
set 
DeptNm=@DeptNm where DeptCd=@DeptCd
end
end
GO
/****** Object:  StoredProcedure [dbo].[SPUPDATEUSER]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SPUPDATEUSER]
	@Uname nvarchar (50),
	@Fname nvarchar (150),
	@Pwd nvarchar (250),
	@GROUPCODE NVARCHAR (50)
	
AS
	begin
	UPDATE TBLUSERS
	SET FULLNAME=@Fname,
	[PASSWORD]=@Pwd,
	GROUPCODE=@GROUPCODE
	WHERE USERNAME=@UNAME
	
	end


GO
/****** Object:  StoredProcedure [dbo].[UPDATEUSERGROUP]    Script Date: 3/17/2021 4:56:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATEUSERGROUP]
@GroupCode nvarchar(50),
@GroupName nvarchar (100),
@canaddstock bit,
@canviewstock bit,
@canissuestock bit,
@canmanageusers bit,
@canchangecp bit,
@canchangesp bit,
@canadjuststock bit

as
begin
UPDATE TBLUSERGROUPS SET GROUPNAME=@GroupName,CANADDSTOCK=@canaddstock, 
CANVIEWSTOCK=@canviewstock,CANISSUESTOCK=@CANISSUESTOCK,CANMANAGEUSERS=@canmanageusers,
CANCHANGECP=@canchangecp,CANCHANGESP=@canchangesp,CANADJUSTSTOCK=@canadjuststock
WHERE GROUPCODE=@GroupCode
end
GO
USE [master]
GO
ALTER DATABASE [ShopLiteDb] SET  READ_WRITE 
GO
