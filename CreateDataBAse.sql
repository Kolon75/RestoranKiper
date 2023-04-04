USE [master]
GO
/****** Object:  Database [Kulynar]    Script Date: 04.04.2023 13:29:58 ******/
CREATE DATABASE [Kulynar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Kulynar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER_305\MSSQL\DATA\Kulynar.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Kulynar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER_305\MSSQL\DATA\Kulynar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Kulynar] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Kulynar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Kulynar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Kulynar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Kulynar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Kulynar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Kulynar] SET ARITHABORT OFF 
GO
ALTER DATABASE [Kulynar] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Kulynar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Kulynar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Kulynar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Kulynar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Kulynar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Kulynar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Kulynar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Kulynar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Kulynar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Kulynar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Kulynar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Kulynar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Kulynar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Kulynar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Kulynar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Kulynar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Kulynar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Kulynar] SET  MULTI_USER 
GO
ALTER DATABASE [Kulynar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Kulynar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Kulynar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Kulynar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Kulynar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Kulynar] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Kulynar] SET QUERY_STORE = OFF
GO
USE [Kulynar]
GO
/****** Object:  User [test10]    Script Date: 04.04.2023 13:29:58 ******/
CREATE USER [test10] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Bluda]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bluda](
	[id_bluda] [int] IDENTITY(1,1) NOT NULL,
	[Bluda] [varchar](30) NULL,
	[ShortName] [varchar](2) NOT NULL,
	[Osnova] [varchar](10) NULL,
	[Chena] [int] NULL,
	[Image] [nvarchar](50) NULL,
 CONSTRAINT [PK__Bluda__AD5623CC64967439] PRIMARY KEY CLUSTERED 
(
	[id_bluda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataUser]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataUser](
	[User_id] [int] NOT NULL,
	[Email] [varchar](100) NULL,
	[SeriaPas] [int] NULL,
	[NumPas] [int] NULL,
	[Vidan] [varchar](200) NULL,
	[DataVidachi] [datetime] NULL,
 CONSTRAINT [PK__DataUser__206A9DF8024E3D6B] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrOduckt]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrOduckt](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[produckt] [varchar](30) NULL,
	[belky] [int] NULL,
	[Jiri] [int] NULL,
	[Ugle] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resepticky]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resepticky](
	[id_bluda] [int] IDENTITY(1,1) NOT NULL,
	[Resept] [varchar](70) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bluda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Role_id] [float] NOT NULL,
	[RoleName] [nvarchar](255) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sostqav_Bluda]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sostqav_Bluda](
	[id_bluda] [int] NOT NULL,
	[id_produckt] [int] NOT NULL,
	[Ves] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_bluda] ASC,
	[id_produckt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_id] [int] IDENTITY(1,1) NOT NULL,
	[FirsName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Patronymic] [nvarchar](255) NULL,
	[DateOfBirthday] [datetime] NULL,
	[Login] [nvarchar](255) NULL,
	[Password] [nvarchar](255) NULL,
	[Phone] [float] NULL,
	[Adress] [nvarchar](255) NULL,
	[Role_id] [float] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vid_Bluda]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vid_Bluda](
	[ShortName] [varchar](2) NOT NULL,
	[FullName] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShortName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bluda] ON 
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (1, N'Salat letniy', N'5', N'Ovoschi', 200, N'..\..\Images\салат летний.jpg')
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (2, N'Salat myaSnoy', N'5', N'MyaSo', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (3, N'Salat vitaminniy', N'5', N'Ovoschi', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (4, N'Salat ribniy', N'5', N'Riba', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (5, N'Pashtet iz ribi', N'5', N'Riba', 120, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (6, N'MyaSo S garnirom', N'5', N'MyaSo', 250, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (7, N'Smetana', N'5', N'Moloko', 140, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (8, N'Tvorog', N'5', N'Moloko', 140, N'..\..\Images\творог.jpg')
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (9, N'Sup harcho', N'4', N'MyaSo', 500, N'..\..\Images\харчо.jpg')
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (10, N'Sup-pure iz ribi', N'4', N'Riba', 500, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (11, N'Uha iz Sudaka', N'4', N'Riba', 500, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (12, N'Sup molochniy', N'4', N'Moloko', 500, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (13, N'BaSturma', N'2', N'MyaSo', 300, N'..\..\Images\бастурма.jpg')
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (14, N'BeefStroganov', N'2', N'MyaSo', 210, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (15, N'Sudak po-polSki', N'2', N'Riba', 160, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (16, N'Drachena', N'2', N'YAyca', 180, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (17, N'Morkov S riSom', N'2', N'Ovoschi', 260, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (18, N'Sirniki', N'2', N'Moloko', 220, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (19, N'Omlet S lukom', N'2', N'YAyca', 200, N'..\..\Images\омлет с луком.jpg')
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (20, N'Kasha riSovaya', N'2', N'Krupa', 210, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (21, N'Puding riSoviy', N'2', N'Krupa', 160, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (22, N'Vareniki lenivie', N'2', N'Moloko', 220, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (23, N'Pomidori S lukom', N'2', N'Ovoschi', 260, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (24, N'Sufle iz tvoroga', N'2', N'Moloko', 280, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (25, N'Rulet S yablokami', N'1', N'Frukti', 200, N'..\..\Images\рулет с яблоками.jpg')
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (26, N'YAbloki pechenie', N'1', N'Frukti', 160, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (27, N'Sufle yablochnoe', N'1', N'Frukti', 220, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (28, N'Krem tvorozhniy', N'1', N'Moloko', 160, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (29, N'"Utro"', N'3', N'Frukti', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (30, N'Kompot', N'3', N'Frukti', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (31, N'Molochniy napitok', N'3', N'Moloko', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (32, N'Kofe cherniy', N'3', N'Kofe', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (33, N'Kofe na moloke', N'3', N'Kofe', 200, NULL)
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (34, N'beshbarmak', N'2', N'MyaSo', 400, N'..\..\Images\beshbarmak-na-kostre.jpg')
GO
INSERT [dbo].[Bluda] ([id_bluda], [Bluda], [ShortName], [Osnova], [Chena], [Image]) VALUES (35, N'Parfe', N'1', N'Moloko', 150, N'..\..\Images\par.jpeg')
GO
SET IDENTITY_INSERT [dbo].[Bluda] OFF
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (1, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (2, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (3, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (4, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (5, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (6, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (7, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (8, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (11, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (12, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (13, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (14, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (15, N' ', 0, 0, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (16, N'evg@gmail.com', 317, 228282, N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[DataUser] ([User_id], [Email], [SeriaPas], [NumPas], [Vidan], [DataVidachi]) VALUES (17, N'1234', 0, 0, N' ', CAST(N'2023-02-22T00:00:00.000' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[PrOduckt] ON 
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (1, N'Govyadina', 189, 124, 0)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (2, N'Sudak', 190, 80, 0)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (3, N'Maslo', 60, 825, 90)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (4, N'Mayonez', 31, 670, 26)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (5, N'Yaica', 127, 115, 7)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (6, N'Smetana', 26, 300, 28)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (7, N'Moloko', 28, 32, 47)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (8, N'Tvorog', 167, 90, 13)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (9, N'Morkov', 13, 1, 70)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (10, N'Luk', 17, 0, 95)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (11, N'Pomidori', 6, 0, 42)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (12, N'Zelen', 9, 0, 20)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (13, N'Ris', 70, 6, 773)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (14, N'Myka', 106, 13, 732)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (15, N'Yabloki', 4, 0, 113)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (16, N'Saxap', 0, 0, 998)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (17, N'Kofe', 127, 36, 9)
GO
INSERT [dbo].[PrOduckt] ([id], [produckt], [belky], [Jiri], [Ugle]) VALUES (19, N'gegeg', 23, 25, 124)
GO
SET IDENTITY_INSERT [dbo].[PrOduckt] OFF
GO
SET IDENTITY_INSERT [dbo].[Resepticky] ON 
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (1, N'Помидоры…')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (2, N'Вареное…')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (3, N'Зелень ме...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (4, N'Вареные р...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (5, N'Филе суда...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (6, N'Мясо варе...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (7, N'Сметану п...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (8, N'Протертый ..')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (9, N'Грудинку ...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (10, N'Филе суда...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (11, N'Судак очи...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (12, N'Промытый ...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (13, N'Мясо наре...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (14, N'Говядину ...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (15, N'Подготовл...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (16, N'Сырые яйц...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (17, N'Нарезать ...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (18, N'В протерт...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (19, N'К свежим ...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (20, N'Рис свари...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (21, N'Готовую р...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (22, N'В протерт...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (23, N'Спассеров...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (24, N'В протерт...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (25, N'Очистить ...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (26, N'Не прорез...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (27, N'Запеченны...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (28, N'Яйца разм...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (29, N'Очищенную ..')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (30, N'Яблоки оч...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (31, N'Яблоки на...')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (32, N'Кофеварку ..')
GO
INSERT [dbo].[Resepticky] ([id_bluda], [Resept]) VALUES (33, N'Сварить ч...')
GO
SET IDENTITY_INSERT [dbo].[Resepticky] OFF
GO
INSERT [dbo].[Role] ([Role_id], [RoleName]) VALUES (1, N'Администратор')
GO
INSERT [dbo].[Role] ([Role_id], [RoleName]) VALUES (2, N'Менеджер')
GO
INSERT [dbo].[Role] ([Role_id], [RoleName]) VALUES (3, N'Шеф-повар')
GO
INSERT [dbo].[Role] ([Role_id], [RoleName]) VALUES (4, N'Без прав')
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (1, 4, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (1, 11, 100)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (1, 12, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (1, 15, 80)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (2, 1, 65)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (2, 4, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (2, 5, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (2, 9, 40)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (2, 11, 35)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (2, 12, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (3, 6, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (3, 10, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (3, 11, 55)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (3, 12, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (3, 15, 55)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (3, 16, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (4, 2, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (4, 4, 40)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (4, 5, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (4, 9, 35)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (4, 11, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (4, 12, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (5, 2, 80)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (5, 3, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (5, 9, 40)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (5, 12, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (6, 1, 80)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (6, 4, 30)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (6, 11, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (6, 12, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (7, 6, 125)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (7, 16, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (8, 6, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (8, 8, 75)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (8, 16, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (9, 1, 80)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (9, 3, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (9, 10, 30)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (9, 11, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (9, 12, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (9, 13, 35)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (10, 2, 70)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (10, 3, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (10, 7, 250)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (10, 12, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (10, 14, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (11, 2, 100)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (11, 3, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (11, 9, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (11, 10, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (11, 12, 2)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (12, 3, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (12, 7, 350)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (12, 13, 35)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (12, 16, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (13, 1, 180)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (13, 3, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (13, 10, 40)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (13, 11, 100)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (13, 12, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (14, 1, 90)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (14, 3, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (14, 6, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (14, 7, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (14, 10, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (14, 12, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (14, 14, 3)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (15, 2, 100)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (15, 3, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (15, 5, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (15, 9, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (15, 10, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (15, 12, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (16, 3, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (16, 5, 120)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (16, 6, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (16, 7, 35)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (16, 14, 9)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (17, 3, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (17, 7, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (17, 9, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (17, 12, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (17, 13, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (17, 14, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (18, 5, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (18, 6, 30)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (18, 8, 140)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (18, 14, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (18, 16, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (19, 3, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (19, 5, 120)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (19, 7, 45)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (19, 10, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (20, 3, 5)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (20, 7, 75)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (20, 13, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (20, 15, 75)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (20, 16, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (21, 3, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (21, 5, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (21, 6, 30)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (21, 13, 70)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (21, 16, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (22, 5, 8)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (22, 6, 30)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (22, 8, 140)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (22, 14, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (22, 16, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (23, 3, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (23, 10, 65)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (23, 11, 250)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (24, 3, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (24, 5, 40)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (24, 6, 30)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (24, 7, 100)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (24, 8, 80)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (24, 14, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (24, 16, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (25, 3, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (25, 8, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (25, 14, 30)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (25, 15, 120)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (25, 16, 35)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (26, 3, 2)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (26, 15, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (26, 16, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (27, 3, 2)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (27, 5, 80)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (27, 7, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (27, 15, 50)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (27, 16, 35)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (28, 3, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (28, 5, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (28, 6, 20)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (28, 8, 100)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (28, 16, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (29, 9, 200)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (29, 15, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (29, 16, 15)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (30, 15, 70)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (30, 16, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (31, 7, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (31, 15, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (31, 16, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (32, 17, 8)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (33, 7, 75)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (33, 16, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (33, 17, 8)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (34, 1, 150)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (34, 3, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (34, 5, 40)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (34, 12, 10)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (34, 14, 70)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (35, 6, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (35, 7, 75)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (35, 15, 25)
GO
INSERT [dbo].[Sostqav_Bluda] ([id_bluda], [id_produckt], [Ves]) VALUES (35, 16, 25)
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (1, N'Пётр', N'Петров', N'Петрович', CAST(N'1997-01-12T00:00:00.000' AS DateTime), N'vp', N'500eda2ef2e24cbe303842619261ff675966cc01eae266e949cc81731578cb4faa2cc05985333b8b9d02563b118558efdfe990ad3565aa553dae665dad7e7bea', 9217894562, N'СПб', 2)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (2, N'Геннадий', N'Крокодиловa', N'Иванович', CAST(N'1999-02-15T00:00:00.000' AS DateTime), N'GK', N'fa8d3dcafc067b5f46b3f175315a104ebb4c3e2ab14d90474cc41bf2ec94382789a3d82dc7be3addb094b7a2749bc37a67d7d8e9f927582af6b6f42a65e9281c', 9112365056, N'СПб', 1)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (3, N'Андрей', N'Иванов', N'Сидорович', CAST(N'2001-03-20T00:00:00.000' AS DateTime), N'AI', N'e09cc2272237ec8c6e7bfdafc39b2b4e88d7e33e44a4c7ffacfea6ade0c961258896c08f118c1b891170affc77406f19fc5ccc7e326a80aa54187f97fa4cc3a8', 9111234565, N'СПб', 2)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (4, N'Клавдий', N'Плюшкин', N'Андреевич', CAST(N'2000-05-25T00:00:00.000' AS DateTime), N'KP', N'feb13f2bbea8580b6c840b1868b987411852cb9b203afcd787a807bf4f06a7a518c91f30a3579c99b2af384e1d1a627b2267cb558357a0da17523b1370c8eb26', 9817854261, N'СПб', 3)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (5, N'Герасичев', N'Денис', NULL, NULL, N'5baf16fc47881f33bb5e79829c4eb1aacd73749803d1f0e894e69426c6061a85b21e3de34b05f56ecfacecfa16e639f5d8ad2e1e6083f63ae6fe471950564a7d', N'qwe123', NULL, NULL, 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (6, N'Герасичев', N'Денис', N'Александрович', CAST(N'2005-01-24T14:37:38.000' AS DateTime), N'GD', N'cf83e1357eefb8bdf1542850d66d8007d620e4050b5715dc83f4a921d36ce9ce47d0d13c5d85f2b0ff8318d2877eec2f63b931bd47417a81a538327af927da3e', 0, N'', 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (7, N'aaaaaa', N'aaa', NULL, NULL, N' AD', N'a14699e6fdc5bac821fd65e363fa9b408a93624eea869cfb3f808c0095035c5371024b3dd47e2036443f38abd6d9419e9536ded84a81541b5a4cb3b7d093fae1', NULL, NULL, 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (8, N'Эмиль', N'Гумбатов', NULL, NULL, N'eg', N'9958d3fb357637e89237d9b40380cc0ed570c87c95525b5895768b77618bb10af566de07b905aa1fd8a0b99fe431696e7269f2cdb3bb2ea9b9227468ff69b30d', NULL, NULL, 1)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (11, N'Гамидов', N'АбдулБари', N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime), N'ga', N'85544e5a8d38b6a44f2625163fe864052eceb05183c6ebf314d87fb202e267a9e7d50266cfbba1d662a44876fedd2c9ca61eb2f57b931e8d5b29715bc6182c4c', 0, N' ', 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (12, N'bbbbb', N'bbb', N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime), N'BD', N'9105ecb6c536b68ba5324e1272d649dff31a761e653d46eaefe9b0b42814cc4d80bdf3c07e1b6f0d26495c57f59bcaa5e11a682b95214b1238368b61d1b9a1fe', 0, N' ', 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (13, N'Бирюк', N'Никита', N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime), N'bn', N'fd36c4b1703afd36e141d7b2890a04800068283959063ef943c844456919ed40458f1ab283ba4aa41530e8c903dd5c7fe53204db85a9b1cc83cf553d2126b851', 0, N' ', 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (14, N'b', N'b', N'b', NULL, N'bb', N'bb', 0, N'SPB', 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (15, N'ccccc', N'ccc', N' ', CAST(N'2023-02-16T00:00:00.000' AS DateTime), N'CD', N'a4a3c69931e0ea2501f5ea147d4ca90058ffebc5479161649eaf17aaa650c0dca34e8f8625abc87544bfa64e1aedb0cc8a8c2aa7696189cf72d1d5ab1707528a', 0, N' ', 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (16, N'Колесников', N'Евгений', N'Evgen', CAST(N'2023-02-16T00:00:00.000' AS DateTime), N'ke', N'0cf726f27d5a8fc6597ca348dea69a90a091fdf9a83036d5bc43d43d9d79dcf48b0ea69d13569037025602687ec8aa9ee16d7e5078c9574c611e87859e30ab79', 0, N'SPB', 4)
GO
INSERT [dbo].[Users] ([User_id], [FirsName], [LastName], [Patronymic], [DateOfBirthday], [Login], [Password], [Phone], [Adress], [Role_id]) VALUES (17, N'ff', N'f', N'FFFF', CAST(N'2023-02-22T00:00:00.000' AS DateTime), N'Ff', N'8739f711de3b397c2bdd5dc9ac6163914e2a031f416b002108542cc084494a3114604e7dee3faf7d4274300a6cbb0bc7f0fb012293ba9aa5b49bcb68ea71cb67', 0, N' ', 4)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
INSERT [dbo].[Vid_Bluda] ([ShortName], [FullName]) VALUES (N'1', N'Desert')
GO
INSERT [dbo].[Vid_Bluda] ([ShortName], [FullName]) VALUES (N'2', N'Goryachee')
GO
INSERT [dbo].[Vid_Bluda] ([ShortName], [FullName]) VALUES (N'3', N'Napitok')
GO
INSERT [dbo].[Vid_Bluda] ([ShortName], [FullName]) VALUES (N'4', N'Syp')
GO
INSERT [dbo].[Vid_Bluda] ([ShortName], [FullName]) VALUES (N'5', N'Zakyski')
GO
ALTER TABLE [dbo].[Bluda]  WITH CHECK ADD  CONSTRAINT [FK_Bluda_Vid_Bluda] FOREIGN KEY([ShortName])
REFERENCES [dbo].[Vid_Bluda] ([ShortName])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bluda] CHECK CONSTRAINT [FK_Bluda_Vid_Bluda]
GO
ALTER TABLE [dbo].[DataUser]  WITH CHECK ADD  CONSTRAINT [FK__DataUser__User_i__3C34F16F] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[DataUser] CHECK CONSTRAINT [FK__DataUser__User_i__3C34F16F]
GO
ALTER TABLE [dbo].[Resepticky]  WITH CHECK ADD  CONSTRAINT [FK__Reseptick__id_bl__5DCAEF64] FOREIGN KEY([id_bluda])
REFERENCES [dbo].[Bluda] ([id_bluda])
GO
ALTER TABLE [dbo].[Resepticky] CHECK CONSTRAINT [FK__Reseptick__id_bl__5DCAEF64]
GO
ALTER TABLE [dbo].[Sostqav_Bluda]  WITH CHECK ADD  CONSTRAINT [FK__Sostqav_B__id_bl__59FA5E80] FOREIGN KEY([id_bluda])
REFERENCES [dbo].[Bluda] ([id_bluda])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sostqav_Bluda] CHECK CONSTRAINT [FK__Sostqav_B__id_bl__59FA5E80]
GO
ALTER TABLE [dbo].[Sostqav_Bluda]  WITH CHECK ADD FOREIGN KEY([id_produckt])
REFERENCES [dbo].[PrOduckt] ([id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Role] FOREIGN KEY([Role_id])
REFERENCES [dbo].[Role] ([Role_id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Role]
GO
/****** Object:  StoredProcedure [dbo].[addBluda]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[addBluda]
@SN varchar(2), @FN varchar(30)
as
if exists(select * from [dbo].[Vid_Bluda] where [ShortName]=@SN)
print 'Неправильно, обнарудено повторение ShortName'
else if exists(select * from [dbo].[Vid_Bluda] where [FullName]=@FN)
print 'Неправильно, обнарудено повторение FullName'
else
begin
insert [dbo].[Vid_Bluda] values (@SN,@FN)
print 'Данные внесены успешно'
end
GO
/****** Object:  StoredProcedure [dbo].[MassB]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[MassB] as select [Bluda],sum([Ves]) Vesik
from [dbo].[Bluda] b join [dbo].[Sostqav_Bluda] s
on b.[id_bluda] = s.[id_bluda]
group by [Bluda]
order by sum([Ves]) desc
GO
/****** Object:  StoredProcedure [dbo].[pipipupupapa]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[pipipupupapa]
@pipa varchar(10)
as
select [Bluda],[Osnova],sum([Ves]) Vesik
from [dbo].[Bluda] b join [dbo].[Sostqav_Bluda] s
on b.[id_bluda] = s.[id_bluda]
where [Osnova] = @pipa
group by [Bluda],[Osnova]
order by sum([Ves]) desc
GO
/****** Object:  StoredProcedure [dbo].[upus]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[upus]
@ui int,@FN nvarchar(255),@LN nvarchar(255),@Pat nvarchar(255),@DOB datetime,@log nvarchar(255),@ph float,
@add nvarchar(255),@email varchar(100),@spas int,@npas int,@vid varchar(200),@DV date
as
begin
update [dbo].[Users]
set [FirsName] = @FN,
[LastName] = @LN,
[Patronymic] = @Pat,
[DateOfBirthday] = @DOB,
[Login] = @log,
[Phone] = @ph,
[Adress] = @add
where [User_id] = @ui;
update [dbo].[DataUser]
set [Email] = @email,
[SeriaPas] = @spas,
[NumPas] = @npas,
[Vidan] = @vid,
[DataVidachi] = @DV
where [User_id] = @ui
end
GO
/****** Object:  StoredProcedure [dbo].[upus2]    Script Date: 04.04.2023 13:29:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[upus2]
@ui int, @FN nvarchar(255), @LN nvarchar(255), @Pat nvarchar(255), @DOB datetime, @log nvarchar(255), @ph float, @Add nvarchar(255)
as
begin
update [dbo].[Users]
set [FirsName] = @FN,
[LastName] = @LN,
[Patronymic] = @Pat,
[DateOfBirthday] = @DOB,
[Login] = @log,
[Phone] = @ph,
[Adress] = @Add
where [User_id] = @ui
end
GO
USE [master]
GO
ALTER DATABASE [Kulynar] SET  READ_WRITE 
GO
