USE [ALM]
GO

/****** Object:  Table [meta].[Relations]    Script Date: 9/24/2014 9:41:07 AM ******/
DROP TABLE [meta].[Relations]
GO

/****** Object:  Table [meta].[Relations]    Script Date: 9/24/2014 9:41:07 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
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

SET ANSI_PADDING OFF
GO


