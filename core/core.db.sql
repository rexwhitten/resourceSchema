USE [MetaBase]
GO
/****** Object:  Table [dbo].[Spaces]    Script Date: 10/9/2014 9:44:51 PM ******/
DROP TABLE [dbo].[Spaces]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/9/2014 9:44:51 PM ******/
DROP TABLE [dbo].[Role]
GO
/****** Object:  Table [dbo].[Relations]    Script Date: 10/9/2014 9:44:51 PM ******/
DROP TABLE [dbo].[Relations]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 10/9/2014 9:44:51 PM ******/
DROP TABLE [dbo].[Permissions]
GO
/****** Object:  Table [dbo].[Objects]    Script Date: 10/9/2014 9:44:51 PM ******/
DROP TABLE [dbo].[Objects]
GO
/****** Object:  Table [dbo].[Attributes]    Script Date: 10/9/2014 9:44:51 PM ******/
DROP TABLE [dbo].[Attributes]
GO
/****** Object:  Table [dbo].[Actions]    Script Date: 10/9/2014 9:44:51 PM ******/
DROP TABLE [dbo].[Actions]
GO
/****** Object:  Table [dbo].[Actions]    Script Date: 10/9/2014 9:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Actions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Actions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Attributes]    Script Date: 10/9/2014 9:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Attributes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ObjectName] [varchar](256) NOT NULL,
	[AttributeName] [varchar](128) NOT NULL,
	[DataType] [varchar](100) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Attributes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Objects]    Script Date: 10/9/2014 9:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Objects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SpaceName] [varchar](256) NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Objects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 10/9/2014 9:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](256) NOT NULL,
	[ActionName] [varchar](256) NOT NULL,
	[ObjectName] [varchar](256) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Relations]    Script Date: 10/9/2014 9:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Relations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentObjectName] [varchar](256) NOT NULL,
	[ChildObjectName] [varchar](256) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Relations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Role]    Script Date: 10/9/2014 9:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Spaces]    Script Date: 10/9/2014 9:44:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Spaces](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](256) NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Spaces] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Actions] ON 

INSERT [dbo].[Actions] ([Id], [Name], [Active]) VALUES (1, N'Create', 1)
INSERT [dbo].[Actions] ([Id], [Name], [Active]) VALUES (2, N'Modify', 1)
INSERT [dbo].[Actions] ([Id], [Name], [Active]) VALUES (3, N'Delete', 1)
INSERT [dbo].[Actions] ([Id], [Name], [Active]) VALUES (4, N'Copy', 1)
INSERT [dbo].[Actions] ([Id], [Name], [Active]) VALUES (5, N'Export', 1)
INSERT [dbo].[Actions] ([Id], [Name], [Active]) VALUES (6, N'Import', 1)
SET IDENTITY_INSERT [dbo].[Actions] OFF
SET IDENTITY_INSERT [dbo].[Attributes] ON 

INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (1, N'Project', N'Title', N'varchar(128)', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (2, N'Project', N'Description', N'varchar(max)', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (3, N'Iteration', N'Title', N'varchar(128)', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (4, N'Iteration', N'Ordinal', N'int', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (5, N'Iteration', N'StartDate', N'datetime', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (6, N'Iteration', N'EndDate', N'datetime', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (7, N'Task', N'Title', N'varchar(256)', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (8, N'Task', N'Description', N'varchar(max)', 1)
INSERT [dbo].[Attributes] ([Id], [ObjectName], [AttributeName], [DataType], [Active]) VALUES (9, N'Task', N'Estimate', N'int', 1)
SET IDENTITY_INSERT [dbo].[Attributes] OFF
SET IDENTITY_INSERT [dbo].[Objects] ON 

INSERT [dbo].[Objects] ([Id], [SpaceName], [Name], [Path], [Active]) VALUES (1, N'All', N'Project', N'/project', 1)
INSERT [dbo].[Objects] ([Id], [SpaceName], [Name], [Path], [Active]) VALUES (2, N'All', N'Task', N'/task', 1)
INSERT [dbo].[Objects] ([Id], [SpaceName], [Name], [Path], [Active]) VALUES (3, N'All', N'Iteration', N'/iteration', 1)
SET IDENTITY_INSERT [dbo].[Objects] OFF
SET IDENTITY_INSERT [dbo].[Permissions] ON 

INSERT [dbo].[Permissions] ([Id], [RoleName], [ActionName], [ObjectName], [Active]) VALUES (1, N'Admin', N'Create', N'Project', 1)
INSERT [dbo].[Permissions] ([Id], [RoleName], [ActionName], [ObjectName], [Active]) VALUES (2, N'Admin', N'Create', N'Iteration', 1)
INSERT [dbo].[Permissions] ([Id], [RoleName], [ActionName], [ObjectName], [Active]) VALUES (3, N'Admin', N'Create', N'Task', 1)
INSERT [dbo].[Permissions] ([Id], [RoleName], [ActionName], [ObjectName], [Active]) VALUES (4, N'Admin', N'Modify', N'Project', 1)
SET IDENTITY_INSERT [dbo].[Permissions] OFF
SET IDENTITY_INSERT [dbo].[Relations] ON 

INSERT [dbo].[Relations] ([Id], [ParentObjectName], [ChildObjectName], [Active]) VALUES (1, N'Project', N'Iteration', 1)
INSERT [dbo].[Relations] ([Id], [ParentObjectName], [ChildObjectName], [Active]) VALUES (2, N'Iteration', N'Task', 1)
SET IDENTITY_INSERT [dbo].[Relations] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Id], [Name], [Active]) VALUES (1, N'Admin', 1)
INSERT [dbo].[Role] ([Id], [Name], [Active]) VALUES (2, N'Project Manager', 1)
INSERT [dbo].[Role] ([Id], [Name], [Active]) VALUES (3, N'Developer', 1)
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Spaces] ON 

INSERT [dbo].[Spaces] ([Id], [Name], [Path], [Active]) VALUES (1, N'All', N'/', 1)
SET IDENTITY_INSERT [dbo].[Spaces] OFF
