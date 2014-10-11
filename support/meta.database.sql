-- ----------------------------------------------------------------------------
-- META Database Generator Script
-- ----------------------------------------------------------------------------
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'{0}')
BEGIN
CREATE DATABASE [{0}]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'{0}', FILENAME = N'E:\MSSQL\MSSQL12.SQLEXPRESS\MSSQL\DATA\{0}.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'{0}_log', FILENAME = N'E:\MSSQL\MSSQL12.SQLEXPRESS\MSSQL\DATA\{0}_log.ldf' , SIZE = 1280KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO

ALTER DATABASE [{0}] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [{0}].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [{0}] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [{0}] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [{0}] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [{0}] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [{0}] SET ARITHABORT OFF 
GO

ALTER DATABASE [{0}] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [{0}] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [{0}] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [{0}] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [{0}] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [{0}] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [{0}] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [{0}] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [{0}] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [{0}] SET  DISABLE_BROKER 
GO

ALTER DATABASE [{0}] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [{0}] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [{0}] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [{0}] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [{0}] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [{0}] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [{0}] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [{0}] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [{0}] SET  MULTI_USER 
GO

ALTER DATABASE [{0}] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [{0}] SET DB_CHAINING OFF 
GO

ALTER DATABASE [{0}] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [{0}] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [{0}] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [{0}] SET  READ_WRITE 
GO

