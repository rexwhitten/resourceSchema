
/****** Object:  Table [dbo].[RoleLinks]    Script Date: 9/11/2014 9:30:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[RoleLinks](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[ParentRoleSysId] [int] NOT NULL,
	[ChildRoleSysId] [int] NOT NULL,
	[LinkPath] [varchar](512) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_RoleLinks] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[RoleLinks]  WITH CHECK ADD  CONSTRAINT [FK_RoleLinks_Roles] FOREIGN KEY([ParentRoleSysId])
REFERENCES [dbo].[Roles] ([SysId])
GO

ALTER TABLE [dbo].[RoleLinks] CHECK CONSTRAINT [FK_RoleLinks_Roles]
GO

ALTER TABLE [dbo].[RoleLinks]  WITH CHECK ADD  CONSTRAINT [FK_RoleLinks_Roles1] FOREIGN KEY([ChildRoleSysId])
REFERENCES [dbo].[Roles] ([SysId])
GO

ALTER TABLE [dbo].[RoleLinks] CHECK CONSTRAINT [FK_RoleLinks_Roles1]
GO


