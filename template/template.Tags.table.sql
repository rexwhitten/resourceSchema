
/****** Object:  Table [dbo].[EventTags]    Script Date: 9/11/2014 9:49:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[EventTags](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[EventSysId] [int] NOT NULL,
	[Tag] [varchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_EventTags] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[EventTags]  WITH CHECK ADD  CONSTRAINT [FK_EventTags_Events] FOREIGN KEY([SysId])
REFERENCES [dbo].[Events] ([SysId])
GO

ALTER TABLE [dbo].[EventTags] CHECK CONSTRAINT [FK_EventTags_Events]
GO


