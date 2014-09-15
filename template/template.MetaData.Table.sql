USE [ResourceIndex]
GO

/****** Object:  Table [dbo].[ResourceMetaData]    Script Date: 9/11/2014 9:29:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[LocationMetaData](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[LocationSysId] [int] NOT NULL,
	[KeyPath] [varchar](256) NOT NULL,
	[KeyValue] [varchar](512) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_LocationMetaDataData] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[LocationMetaData]  WITH CHECK ADD  CONSTRAINT [FK_LocationMetaData_Locations] FOREIGN KEY([LocationSysId])
REFERENCES [dbo].[Locations] ([SysId])
GO

ALTER TABLE [dbo].[LocationMetaData] CHECK CONSTRAINT [FK_LocationMetaData_Locations]
GO


