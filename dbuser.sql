USE [master]
GO
/****** Object:  Database [dbuser]    Script Date: 28/03/2024 9:19:53 a. m. ******/
CREATE DATABASE [dbuser]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbuser', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbuser.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbuser_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\dbuser_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbuser] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbuser].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbuser] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbuser] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbuser] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbuser] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbuser] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbuser] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbuser] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbuser] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbuser] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbuser] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbuser] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbuser] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbuser] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbuser] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbuser] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbuser] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbuser] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbuser] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbuser] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbuser] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbuser] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbuser] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbuser] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbuser] SET  MULTI_USER 
GO
ALTER DATABASE [dbuser] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbuser] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbuser] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbuser] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbuser] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbuser] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [dbuser] SET QUERY_STORE = OFF
GO
USE [dbuser]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28/03/2024 9:19:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28/03/2024 9:19:54 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [dbuser] SET  READ_WRITE 
GO
