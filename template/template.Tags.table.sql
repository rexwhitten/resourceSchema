
/****** Object:  Table [dbo].[RoleTags]    Script Date: 9/11/2014 9:49:59 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[RoleTags](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[RoleSysId] [int] NOT NULL,
	[Tag] [varchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_RoleTags] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[RoleTags]  WITH CHECK ADD  CONSTRAINT [FK_RoleTags_Roles] FOREIGN KEY([SysId])
REFERENCES [dbo].[Roles] ([SysId])
GO

ALTER TABLE [dbo].[RoleTags] CHECK CONSTRAINT [FK_RoleTags_Roles]
GO


