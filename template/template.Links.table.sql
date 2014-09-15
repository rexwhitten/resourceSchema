
/****** Object:  Table [dbo].[LocationLinks]    Script Date: 9/11/2014 9:30:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[LocationLinks](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[ParentLocationSysId] [int] NOT NULL,
	[ChildLocationSysId] [int] NOT NULL,
	[LinkPath] [varchar](512) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_LocationLinks] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[LocationLinks]  WITH CHECK ADD  CONSTRAINT [FK_LocationLinks_Locations] FOREIGN KEY([ParentLocationSysId])
REFERENCES [dbo].[Locations] ([SysId])
GO

ALTER TABLE [dbo].[LocationLinks] CHECK CONSTRAINT [FK_LocationLinks_Locations]
GO

ALTER TABLE [dbo].[LocationLinks]  WITH CHECK ADD  CONSTRAINT [FK_LocationLinks_Locations1] FOREIGN KEY([ChildLocationSysId])
REFERENCES [dbo].[Locations] ([SysId])
GO

ALTER TABLE [dbo].[LocationLinks] CHECK CONSTRAINT [FK_LocationLinks_Locations1]
GO


