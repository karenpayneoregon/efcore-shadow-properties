USE [master]
GO
/****** Object:  Database [ShadowEntityCore]    Script Date: 3/3/2020 7:53:25 AM ******/
CREATE DATABASE [ShadowEntityCore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShadowEntityCore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ShadowEntityCore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ShadowEntityCore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ShadowEntityCore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShadowEntityCore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShadowEntityCore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShadowEntityCore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShadowEntityCore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShadowEntityCore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShadowEntityCore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShadowEntityCore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET RECOVERY FULL 
GO
ALTER DATABASE [ShadowEntityCore] SET  MULTI_USER 
GO
ALTER DATABASE [ShadowEntityCore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShadowEntityCore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShadowEntityCore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShadowEntityCore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ShadowEntityCore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ShadowEntityCore] SET QUERY_STORE = OFF
GO
USE [ShadowEntityCore]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 3/3/2020 7:53:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[LastUpdated] [datetime2](7) NULL,
	[LastUser] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact1]    Script Date: 3/3/2020 7:53:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact1](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[LastUpdated] [datetime2](7) NULL,
	[LastUser] [nvarchar](max) NULL,
	[CreatedAt] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contact1] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([ContactId], [FirstName], [LastName], [LastUpdated], [LastUser]) VALUES (1, N'Karen', N'Payne', CAST(N'2020-03-02T13:40:28.5583563' AS DateTime2), N'Karens')
SET IDENTITY_INSERT [dbo].[Contact] OFF
SET IDENTITY_INSERT [dbo].[Contact1] ON 

INSERT [dbo].[Contact1] ([ContactId], [FirstName], [LastName], [LastUpdated], [LastUser], [CreatedAt], [CreatedBy]) VALUES (1, N'Anne', N'Payne', CAST(N'2020-03-03T07:50:12.7050735' AS DateTime2), N'paynek', CAST(N'2020-03-03T07:49:57.7069578' AS DateTime2), N'paynek')
SET IDENTITY_INSERT [dbo].[Contact1] OFF
USE [master]
GO
ALTER DATABASE [ShadowEntityCore] SET  READ_WRITE 
GO
