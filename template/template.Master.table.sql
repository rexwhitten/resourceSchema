USE [Nebula]
GO

-- -------------------------------------------------------------------
-- Master , Status, and Types 
-- -------------------------------------------------------------------
PRINT 'CREATING TYPES TABLE'

CREATE TABLE [dbo].[RoleTypes](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_RoleTypes] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


PRINT 'CREATING STATUS TABLE'
CREATE TABLE [dbo].[RoleStatus](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_RoleStatus] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



PRINT 'CREATING MASTER TABLE'


CREATE TABLE [dbo].[Roles] (
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[RoleStatusSysId] [int] NOT NULL,
	[RoleTypeSysId] [int] NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Is_ReadOnly] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Roles]  WITH CHECK ADD  CONSTRAINT [FK_Roles_RoleStatusSysId] FOREIGN KEY([RoleStatusSysId])
REFERENCES [dbo].[RoleStatus] ([SysId])
GO
ALTER TABLE [dbo].[Roles] CHECK CONSTRAINT [FK_Roles_RoleStatusSysId]
GO


ALTER TABLE [dbo].[Roles]  WITH CHECK ADD  CONSTRAINT [FK_Roles_RoleTypeSysId] FOREIGN KEY([RoleTypeSysId])
REFERENCES [dbo].[RoleTypes] ([SysId])
GO
ALTER TABLE [dbo].[Roles] CHECK CONSTRAINT [FK_Roles_RoleTypeSysId]
GO


