USE [TEST]
GO

PRINT 'CREATING Content Table'

CREATE TABLE [dbo].[RoleContent](
	[SysId]		[int] IDENTITY(1,1) NOT NULL,
	[PublicId]	[uniqueidentifier] NOT NULL,
	[RoleSysId] [int] NOT NULL,
	[Path]		[varchar](1024) NOT NULL,
	[Content]	[xml] NOT NULL,
	[Active]	[bit] NOT NULL,
 CONSTRAINT [PK_RoleContent] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[RoleContent]  WITH CHECK ADD  CONSTRAINT [FK_RoleContent_Roles] FOREIGN KEY([RoleSysId])
REFERENCES [dbo].[Roles] ([SysId])
GO

ALTER TABLE [dbo].[RoleContent] CHECK CONSTRAINT [FK_RoleContent_Roles]
GO


PRINT 'CREATING DataSet Table'

CREATE TABLE [dbo].[RoleDataSet](
	[SysId]		[int] IDENTITY(1,1) NOT NULL,
	[PublicId]	[uniqueidentifier] NOT NULL,
	[RoleSysId] [int] NOT NULL,
	[Path]		[varchar](1024) NOT NULL,
	[DataSet]	[xml] NOT NULL,
	[Active]	[bit] NOT NULL,
 CONSTRAINT [PK_RoleDataSet] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[RoleDataSet]  WITH CHECK ADD  CONSTRAINT [FK_RoleDataSet_Roles] FOREIGN KEY([RoleSysId])
REFERENCES [dbo].[Roles] ([SysId])
GO

ALTER TABLE [dbo].[RoleDataSet] CHECK CONSTRAINT [FK_RoleDataSet_Roles]
GO