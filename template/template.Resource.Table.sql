USE [Core]
GO

/****** Object:  Table [dbo].[ResourceResource]    Script Date: 9/11/2014 9:29:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ContentResource](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[ContentSysId] [int] NOT NULL,
	[Path] [varchar](256) NOT NULL,
	[Resource] [xml] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_ContentResourceData] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[ContentResource]  WITH CHECK ADD  CONSTRAINT [FK_ContentResource_Contents] FOREIGN KEY([ContentSysId])
REFERENCES [dbo].[Contents] ([SysId])
GO

ALTER TABLE [dbo].[ContentResource] CHECK CONSTRAINT [FK_ContentResource_Contents]
GO


