
/****** Object:  Table [dbo].[ProjectIterations]    Script Date: 9/11/2014 9:39:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProjectIterations](
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[ProjectSysId] [int] NOT NULL,
	[IterationsysId] [int] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_ProjectIterations] PRIMARY KEY CLUSTERED 
(
	[SysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[ProjectIterations]  WITH CHECK ADD  CONSTRAINT [FK_ProjectIterations_Projects] FOREIGN KEY([ProjectSysId])
REFERENCES [dbo].[Projects] ([SysId])
GO

ALTER TABLE [dbo].[ProjectIterations] CHECK CONSTRAINT [FK_ProjectIterations_Projects]
GO

ALTER TABLE [dbo].[ProjectIterations]  WITH CHECK ADD  CONSTRAINT [FK_ProjectIterations_Iterations] FOREIGN KEY([IterationsysId])
REFERENCES [dbo].[Iterations] ([SysId])
GO

ALTER TABLE [dbo].[ProjectIterations] CHECK CONSTRAINT [FK_ProjectIterations_Iterations]
GO


