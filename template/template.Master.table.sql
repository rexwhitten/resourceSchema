USE [ALMCube]
GO

-- -------------------------------------------------------------------
-- Master , Status, and Types 
-- -------------------------------------------------------------------
PRINT 'CREATING TYPES TABLE'

CREATE TABLE [dbo].[UserTypes](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


PRINT 'CREATING STATUS TABLE'
CREATE TABLE [dbo].[UserStatus](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_UserStatus] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



PRINT 'CREATING MASTER TABLE'


CREATE TABLE [dbo].[Users] (
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[UserStatusSysId] [int] NOT NULL,
	[UserTypeSysId] [int] NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Is_ReadOnly] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserStatusSysId] FOREIGN KEY([UserStatusSysId])
REFERENCES [dbo].[UserStatus] ([SysId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserStatusSysId]
GO


ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserTypeSysId] FOREIGN KEY([UserTypeSysId])
REFERENCES [dbo].[UserTypes] ([SysId])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserTypeSysId]
GO


PRINT 'CREATING MASTER FUNCTIONS '
GO 

-- =============================================
-- Get Team Record By PublicId
-- =============================================
CREATE FUNCTION [dbo].[GetUser]
(	
	@PublicId UNIQUEIDENTIFIER
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT 
	-- Table Columns
	*
	FROM [dbo].[Users]
	WHERE PublicId = @PublicId
		
)
GO