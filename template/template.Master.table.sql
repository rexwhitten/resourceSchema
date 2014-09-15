USE [ResourceIndex]
GO

-- -------------------------------------------------------------------
-- Master , Status, and Types 
-- -------------------------------------------------------------------
PRINT 'CREATING TYPES TABLE'

CREATE TABLE [dbo].[EventTypes](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_EventTypes] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


PRINT 'CREATING STATUS TABLE'
CREATE TABLE [dbo].[EventStatus](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_EventStatus] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



PRINT 'CREATING MASTER TABLE'


CREATE TABLE [dbo].[Events] (
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[EventStatusSysId] [int] NOT NULL,
	[EventTypeSysId] [int] NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Is_ReadOnly] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_EventStatusSysId] FOREIGN KEY([EventStatusSysId])
REFERENCES [dbo].[EventStatus] ([SysId])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_EventStatusSysId]
GO


ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_EventTypeSysId] FOREIGN KEY([EventTypeSysId])
REFERENCES [dbo].[EventType] ([SysId])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_EventTypeSysId]
GO


