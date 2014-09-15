
/****** Object:  Table [dbo].[UserEvents]    Script Date: 9/11/2014 9:39:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[UserEvents](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[UserSysId] [int] NOT NULL,
	[EventsysId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_UserEvents] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[UserEvents]  WITH CHECK ADD  CONSTRAINT [FK_UserEvents_Users] FOREIGN KEY([UserSysId])
REFERENCES [dbo].[Users] ([SysId])
GO

ALTER TABLE [dbo].[UserEvents] CHECK CONSTRAINT [FK_UserEvents_Users]
GO

ALTER TABLE [dbo].[UserEvents]  WITH CHECK ADD  CONSTRAINT [FK_UserEvents_Events] FOREIGN KEY([EventsysId])
REFERENCES [dbo].[Events] ([SysId])
GO

ALTER TABLE [dbo].[UserEvents] CHECK CONSTRAINT [FK_UserEvents_Events]
GO


