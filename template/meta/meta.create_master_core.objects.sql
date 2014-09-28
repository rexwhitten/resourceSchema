USE [ALM]
GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Create_Masters]') AND type in (N'P', N'PC'))
DROP PROCEDURE [meta].[Create_Masters]
GO


-- =============================================
-- Author:		RWHITTEN
-- TEST: EXEC [meta].[Create_Masters]
-- =============================================
CREATE PROCEDURE [meta].[Create_Masters]
	
AS
BEGIN
	SET NOCOUNT ON;

    -- TEMPLATES 
	DECLARE @Master_Tag VARCHAR(10) = '##MASTER##'
	DECLARE @Master_TypesTable VARCHAR(MAX)
	SET @Master_TypesTable = N'CREATE TABLE [ALM].[dbo].[##MASTER##Types](
						[SysId] [int] IDENTITY(1,1) NOT NULL,
						[PublicId] [uniqueidentifier] NOT NULL,
						[Path] [varchar](1024) NOT NULL,
						[CreateDate] [datetime] NOT NULL,
						[LastModifiedDate] [datetime] NOT NULL,
						[Active] [bit] NOT NULL,
						CONSTRAINT [PK_##MASTER##Types] PRIMARY KEY CLUSTERED 
					(
						[SysId] ASC
					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
					) ON [PRIMARY]'

	DECLARE @Master_StatusTable VARCHAR(MAX)
	SET @Master_StatusTable = N'CREATE TABLE [ALM].[dbo].[##MASTER##Status] (
							[SysId] [int] IDENTITY(1,1) NOT NULL,
							[PublicId] [uniqueidentifier] NOT NULL,
							[Path] [varchar](1024) NOT NULL,
							[CreateDate] [datetime] NOT NULL,
							[LastModifiedDate] [datetime] NOT NULL,
							[Active] [bit] NOT NULL,
						 CONSTRAINT [PK_##MASTER##Status] PRIMARY KEY CLUSTERED 
						(
							[SysId] ASC
						)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
						) ON [PRIMARY]'

	DECLARE @Master_Table VARCHAR(MAX) 
	 SET @Master_Table = N'CREATE TABLE [ALM].[dbo].[##MASTER##s] (
	[SysId] [int] IDENTITY(1,1) NOT NULL,
	[##MASTER##StatusSysId] [int] NOT NULL,
	[##MASTER##TypeSysId] [int] NOT NULL,
	[PublicId] [uniqueidentifier] NOT NULL,
	[Path] [varchar](1024) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[Is_ReadOnly] [bit] NOT NULL,
	[Active] [bit] NOT NULL,
	 CONSTRAINT [PK_##MASTER##s] PRIMARY KEY CLUSTERED 
	(
		[SysId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]

	ALTER TABLE [dbo].[##MASTER##s]  WITH CHECK ADD  CONSTRAINT [FK_##MASTER##s_##MASTER##StatusSysId] FOREIGN KEY([##MASTER##StatusSysId])
	REFERENCES [dbo].[##MASTER##Status] ([SysId])

	ALTER TABLE [dbo].[##MASTER##s] CHECK CONSTRAINT [FK_##MASTER##s_##MASTER##StatusSysId]



	ALTER TABLE [dbo].[##MASTER##s]  WITH CHECK ADD  CONSTRAINT [FK_##MASTER##s_##MASTER##TypeSysId] FOREIGN KEY([##MASTER##TypeSysId])
	REFERENCES [dbo].[##MASTER##Types] ([SysId])

	ALTER TABLE [dbo].[##MASTER##s] CHECK CONSTRAINT [FK_##MASTER##s_##MASTER##TypeSysId]
	'

	DECLARE @Master_Function VARCHAR(MAX)
	 SET @Master_Function = N'-- =============================================
							-- Get ##MASTER## Record By PublicId
							-- =============================================
							CREATE FUNCTION [dbo].[Get##MASTER##]
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
								FROM [dbo].[##MASTER##s]
								WHERE PublicId = @PublicId
		
							)
							'


     -- ----------------------------------------------------------------------------
	 -- Links 
	 -- ----------------------------------------------------------------------------
	 DECLARE @Links_Table VARCHAR(MAX)
	 SET @Links_Table = N'CREATE TABLE [dbo].[##MASTER##Links](
					[SysId] [int] IDENTITY(1,1) NOT NULL,
					[PublicId] [uniqueidentifier] NOT NULL,
					[Parent##MASTER##SysId] [int] NOT NULL,
					[Child##MASTER##SysId] [int] NOT NULL,
					[LinkPath] [varchar](512) NOT NULL,
					[CreateDate] [datetime] NOT NULL,
					[LastModifiedDate] [datetime] NOT NULL,
					[Active] [bit] NOT NULL,
				 CONSTRAINT [PK_##MASTER##Links] PRIMARY KEY CLUSTERED 
				(
					[SysId] ASC
				)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
				) ON [PRIMARY]


				ALTER TABLE [dbo].[##MASTER##Links]  WITH CHECK ADD  CONSTRAINT [FK_##MASTER##Links_##MASTER##s] FOREIGN KEY([Parent##MASTER##SysId])
				REFERENCES [dbo].[##MASTER##s] ([SysId])


				ALTER TABLE [dbo].[##MASTER##Links] CHECK CONSTRAINT [FK_##MASTER##Links_##MASTER##s]


				ALTER TABLE [dbo].[##MASTER##Links]  WITH CHECK ADD  CONSTRAINT [FK_##MASTER##Links_##MASTER##s1] FOREIGN KEY([Child##MASTER##SysId])
				REFERENCES [dbo].[##MASTER##s] ([SysId])

				ALTER TABLE [dbo].[##MASTER##Links] CHECK CONSTRAINT [FK_##MASTER##Links_##MASTER##s1]'


	 -- ----------------------------------------------------------------------------
	 -- MetaData 
	 -- ----------------------------------------------------------------------------
	 DECLARE @MetaData_Table VARCHAR(MAX) 
	 SET @MetaData_Table = N'CREATE TABLE [dbo].[##MASTER##MetaData](
								[SysId] [int] IDENTITY(1,1) NOT NULL,
								[PublicId] [uniqueidentifier] NOT NULL,
								[##MASTER##SysId] [int] NOT NULL,
								[KeyPath] [varchar](256) NOT NULL,
								[KeyValue] [varchar](512) NOT NULL,
								[Active] [bit] NOT NULL,
							 CONSTRAINT [PK_##MASTER##MetaDataData] PRIMARY KEY CLUSTERED 
							(
								[SysId] ASC
							)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
							) ON [PRIMARY]

							ALTER TABLE [dbo].[##MASTER##MetaData]  WITH CHECK ADD  CONSTRAINT [FK_##MASTER##MetaData_##MASTER##s] FOREIGN KEY([##MASTER##SysId])
							REFERENCES [dbo].[##MASTER##s] ([SysId])

							ALTER TABLE [dbo].[##MASTER##MetaData] CHECK CONSTRAINT [FK_##MASTER##MetaData_##MASTER##s]
							'

     
	 DECLARE @Tags_Table VARCHAR(MAX) 
	 SET @Tags_Table = N'CREATE TABLE [dbo].[##MASTER##Tags](
						[SysId] [int] IDENTITY(1,1) NOT NULL,
						[##MASTER##SysId] [int] NOT NULL,
						[Tag] [varchar](50) NOT NULL,
						[CreateDate] [datetime] NOT NULL,
						[Active] [bit] NOT NULL,
					 CONSTRAINT [PK_##MASTER##Tags] PRIMARY KEY CLUSTERED 
					(
						[SysId] ASC
					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
					) ON [PRIMARY]

					ALTER TABLE [dbo].[##MASTER##Tags]  WITH CHECK ADD  CONSTRAINT [FK_##MASTER##Tags_##MASTER##s] FOREIGN KEY([SysId])
					REFERENCES [dbo].[##MASTER##s] ([SysId])

					ALTER TABLE [dbo].[##MASTER##Tags] CHECK CONSTRAINT [FK_##MASTER##Tags_##MASTER##s]
					'




	-- ----------------------------------------------------------------------------
	-- ITERATE 
	-- ----------------------------------------------------------------------------

	DECLARE @Index INT 
	DECLARE @Count INT 

	SELECT 
		@Index = 1,
		@Count = MAX([id])
	FROM [meta].[Objects]

	WHILE (@Index <= @Count)
	BEGIN 
		DECLARE @ObjectName VARCHAR(50)

		SELECT 
			@ObjectName = Title
		FROM [meta].[Objects] 
		WHERE [Id] = @Index

		IF(LEN(@ObjectName) > 1)
		BEGIN 
			PRINT 'CREATING ' + @ObjectName
			-- DROP -----------------------------------------------
			DECLARE @DropSQL VARCHAR(MAX)
			SET @DropSQl = N'

				IF OBJECT_ID($$##MASTER##Links$$, $$U$$) IS NOT NULL
				BEGIN 
					DROP TABLE [dbo].[##MASTER##Links]
				END 

				IF OBJECT_ID($$##MASTER##Tags$$, $$U$$) IS NOT NULL
				BEGIN 
					DROP TABLE [dbo].[##MASTER##Tags]
				END

				IF OBJECT_ID($$##MASTER##MetaData$$, $$U$$) IS NOT NULL
				BEGIN 
					DROP TABLE [dbo].[##MASTER##MetaData]
				END

				IF OBJECT_ID($$##MASTER##s$$, $$U$$) IS NOT NULL
				BEGIN 
						DROP TABLE [dbo].[##MASTER##s]
				END

				IF OBJECT_ID($$##MASTER##Status$$, $$U$$) IS NOT NULL
				BEGIN 
						DROP TABLE [dbo].[##MASTER##Status]
				END

				IF OBJECT_ID($$##MASTER##Types$$, $$U$$) IS NOT NULL
				BEGIN 
						DROP TABLE [dbo].[##MASTER##Types]
				END
		
				IF OBJECT_ID($$Get##MASTER##$$, $$FN$$) IS NOT NULL
				BEGIN 
						DROP FUNCTION [dbo].[Get##MASTER##]
				END
			';

			SELECT @DropSQL = REPLACE(@DropSql,@Master_Tag, @ObjectName)
			SELECT @DropSQL = REPLACE(@DropSql,'$$', '''')
			EXEC (@DropSql)

			-- CREATE -----------------------------------------------
			DECLARE @Sql VARCHAR(MAX)

			SELECT @Sql = REPLACE(@Master_TypesTable,@Master_Tag,@ObjectName)
			EXEC (@Sql)

			SELECT @Sql = REPLACE(@Master_StatusTable, @Master_Tag, @ObjectName)
			EXEC (@Sql)

			SELECT @Sql = REPLACE(@Master_Table,@Master_Tag,@ObjectName)
			EXEC (@Sql)

			SELECT @Sql = REPLACE(@Master_Function,@Master_Tag,@ObjectName)
			EXEC (@Sql)

			SELECT @Sql = REPLACE(@Links_Table,@Master_Tag,@ObjectName)
			EXEC (@Sql)

			SELECT @Sql = REPLACE(@MetaData_Table,@Master_Tag,@ObjectName)
			EXEC (@Sql)

			SELECT @Sql = REPLACE(@Tags_Table,@Master_Tag,@ObjectName)
			EXEC (@Sql)
		END 
		SELECT @Index = @Index + 1;
	END 

	-- EXECUTE Relations 
	--EXEC [meta].[Create_Relations]

END





GO


