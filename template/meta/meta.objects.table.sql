


/*
CREATE SCHEMA [meta]
GO
*/

-- DROPS 
DROP TABLE [meta].[Relations]
GO
DROP TABLE [meta].[Objects]
GO
DROP TABLE [meta].[Attributes]
GO


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

