
/****** Object:  StoredProcedure [meta].[Create_Relations]    Script Date: 9/27/2014 4:28:48 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Create_Relations]') AND type in (N'P', N'PC'))
DROP PROCEDURE [meta].[Create_Relations]
GO



-- =============================================
-- Author:		RWHITTEN
-- TEST: EXEC [meta].[Create_Relations]
-- =============================================
CREATE PROCEDURE [meta].[Create_Relations]
	
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Parent_Tag VARCHAR(10) = '##PARENT##'
	DECLARE @Child_Tag VARCHAR(10) = '##CHILD##'

    -- TEMPLATES 
	DECLARE @Relation_Table VARCHAR(MAX)
	SET @Relation_Table = N'
			CREATE TABLE [dbo].[##PARENT####CHILD##s](
				[SysId] [int] IDENTITY(1,1) NOT NULL,
				[PublicId] [uniqueidentifier] NOT NULL,
				[Path] [varchar](1024) NOT NULL,
				[##PARENT##SysId] [int] NOT NULL,
				[##CHILD##sysId] [int] NOT NULL,
				[CreateDate] [datetime] NOT NULL,
				[Active] [bit] NOT NULL,
			 CONSTRAINT [PK_##PARENT####CHILD##s] PRIMARY KEY CLUSTERED 
			(
				[SysId] ASC
			)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
			) ON [PRIMARY]

			ALTER TABLE [dbo].[##PARENT####CHILD##s]  WITH CHECK ADD  CONSTRAINT [FK_##PARENT####CHILD##s_##PARENT##s] FOREIGN KEY([##PARENT##SysId])
			REFERENCES [dbo].[##PARENT##s] ([SysId])

			ALTER TABLE [dbo].[##PARENT####CHILD##s] CHECK CONSTRAINT [FK_##PARENT####CHILD##s_##PARENT##s]

			ALTER TABLE [dbo].[##PARENT####CHILD##s]  WITH CHECK ADD  CONSTRAINT [FK_##PARENT####CHILD##s_##CHILD##s] FOREIGN KEY([##CHILD##sysId])
			REFERENCES [dbo].[##CHILD##s] ([SysId])

			ALTER TABLE [dbo].[##PARENT####CHILD##s] CHECK CONSTRAINT [FK_##PARENT####CHILD##s_##CHILD##s]
			'




	-- ----------------------------------------------------------------------------
	-- ITERATE 
	-- ----------------------------------------------------------------------------

	DECLARE @Index INT 
	DECLARE @Count INT 

	SELECT 
		@Index = 1,
		@Count = COUNT(*)
	FROM [meta].[Relations]

	WHILE (@Index <= @Count)
	BEGIN 
		DECLARE @Parent VARCHAR(50)
		DECLARE @Child VARCHAR(50)
		SELECT 
			@Parent = Parent,
			@Child = Child
		FROM [meta].[Relations]
		WHERE [Id] = @Index

		-- DROP ------------------------------------------------
		DECLARE @DropSql VARCHAR(MAX)
		SET @DropSql = N'
		 DROP TABLE [dbo].[##Parent####Child##s]
		'
		SELECT @DropSql = REPLACE (@DropSql,@Parent_Tag,@Parent)
		SELECT @DropSql = REPLACE (@DropSql,@Child_Tag,@Child)
		EXEC (@DropSql)

		-- CREATE ------------------------------------------------
		DECLARE @Sql VARCHAR(MAX)

		SELECT @Sql = REPLACE(@Relation_Table,@Parent_Tag,@Parent)
		SELECT @Sql = REPLACE(@Sql, @Child_Tag, @Child)
		EXEC (@Sql)


		SELECT @Index = @Index + 1;
	END 

END
GO
