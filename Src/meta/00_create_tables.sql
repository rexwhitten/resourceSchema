
USE [ContentDb]
GO

PRINT 'CREATING META SCHEMA'
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'meta')
BEGIN 

	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Objects]') AND type in (N'U'))
	BEGIN 
		DROP TABLE [meta].[Objects]
	END

	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Attributes]') AND type in (N'U'))
	BEGIN 
		DROP TABLE [meta].[Attributes]
	END 
	
	IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Relations]') AND type in (N'U'))
	BEGIN 
		DROP TABLE [meta].[Relations]
	END 

	DROP SCHEMA [meta]
	END 
GO 

CREATE SCHEMA [meta]
GO

PRINT 'CREATING META OBJECTS TABLE'
CREATE TABLE [meta].[Objects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](150) NOT NULL,
	[Path] [varchar](512) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Objects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

PRINT 'CREATING META RELATIONS TABLE'
CREATE TABLE [meta].[Relations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Parent] [varchar](50) NOT NULL,
	[Child] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Relations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

PRINT 'CREATING META ATTRIBUTES TABLE'
CREATE TABLE [meta].[Attributes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ObjectTitle] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[DataType] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Attributes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

