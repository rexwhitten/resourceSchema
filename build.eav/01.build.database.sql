/****** Object:  Database [EVA]    Script Date: 10/7/2014 11:24:55 AM ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'EVA')
DROP DATABASE [EVA]
GO

/****** Object:  Database [EVA]    Script Date: 10/7/2014 11:24:55 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'EVA')
BEGIN
CREATE DATABASE [EVA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EVA', FILENAME = N'E:\MSSQL\MSSQL12.SQLEXPRESS\MSSQL\DATA\EVA.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EVA_log', FILENAME = N'E:\MSSQL\MSSQL12.SQLEXPRESS\MSSQL\DATA\EVA_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO

ALTER DATABASE [EVA] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EVA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EVA] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EVA] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EVA] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EVA] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EVA] SET ARITHABORT OFF 
GO

ALTER DATABASE [EVA] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EVA] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EVA] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EVA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EVA] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EVA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EVA] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EVA] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EVA] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EVA] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EVA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EVA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EVA] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EVA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EVA] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EVA] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EVA] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EVA] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EVA] SET  MULTI_USER 
GO

ALTER DATABASE [EVA] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EVA] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EVA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EVA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [EVA] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EVA] SET  READ_WRITE 
GO

