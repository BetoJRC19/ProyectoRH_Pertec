USE [master]
GO

/****** Object:  Database [RH]    Script Date: 26/06/2022 23:43:46 ******/
CREATE DATABASE [RH]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RH', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RH.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RH_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\RH_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RH].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [RH] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [RH] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [RH] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [RH] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [RH] SET ARITHABORT OFF 
GO

ALTER DATABASE [RH] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [RH] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [RH] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [RH] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [RH] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [RH] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [RH] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [RH] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [RH] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [RH] SET  DISABLE_BROKER 
GO

ALTER DATABASE [RH] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [RH] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [RH] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [RH] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [RH] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [RH] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [RH] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [RH] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [RH] SET  MULTI_USER 
GO

ALTER DATABASE [RH] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [RH] SET DB_CHAINING OFF 
GO

ALTER DATABASE [RH] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [RH] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [RH] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [RH] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [RH] SET QUERY_STORE = OFF
GO

ALTER DATABASE [RH] SET  READ_WRITE 
GO


