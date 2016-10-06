USE [ContentDb]
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
	SET @Master_TypesTable = N'CREATE TABLE [ContentDb].[dbo].[##MASTER##Types](
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
	SET @Master_StatusTable = N'CREATE TABLE [ContentDb].[dbo].[##MASTER##Status] (
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
	 SET @Master_Table = N'CREATE TABLE [ContentDb].[dbo].[##MASTER##s] (
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


/****** Object:  StoredProcedure [meta].[Create_Attributes]    Script Date: 9/28/2014 1:56:36 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Create_Attributes]') AND type in (N'P', N'PC'))
DROP PROCEDURE [meta].[Create_Attributes]
GO


-- =============================================
-- TEST : EXEC [dbo].[Create_Attributes]
-- =============================================
CREATE PROCEDURE [meta].[Create_Attributes]
AS 
BEGIN
	DECLARE @AttributeSql TABLE (ID INT IDENTITY(1,1),
								 [TableSql] VARCHAR(MAX),
								 [DropSql] VARCHAR(MAX))

	INSERT INTO @AttributeSql
	SELECT DISTINCT
		 REPLACE(REPLACE(N'CREATE TABLE [ALM].[dbo].['+ O.Title +'Attributes](
				[SysId] [int] IDENTITY(1,1) NOT NULL
				,[' + O.Title +'SysId] [int] NOT NULL
				,[CreateDate] [datetime] NOT NULL
				,[LastModifiedDate] [datetime] NOT NULL
				' +
		 STUFF((	 SELECT
						 N'
							,[' + MA.Name + '] ' + MA.DataType + ' NOT NULL
							'
					  FROM [meta].[Attributes] MA
								WHERE
									MA.ObjectTitle = O.Title
								 AND MA.Active = 1
								FOR XML PATH('')
								), 1, 1, ' ' )
					+
					'CONSTRAINT [PK_'+O.Title+'Attributes] PRIMARY KEY CLUSTERED 
							(
								[SysId] ASC
							)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
							) ON [PRIMARY] 
				
							ALTER TABLE [dbo].['+ O.Title +'Attributes]  WITH CHECK ADD  CONSTRAINT [FK_'+ O.Title +'Attributes_' + O.Title + '] FOREIGN KEY([' + O.Title +'SysId])
							REFERENCES [dbo].['+ O.Title +'s] ([SysId])
							
							
							','&#x0D;',''),'#x0D;','') AS [TableSql],
							'DROP TABLE [dbo].[' + O.Title + 'Attributes]' AS [DropSql]
		FROM [meta].[Objects] O
	
		WHERE 
			((O.Active = 1))

	-- Clear Nulls
	DELETE FROM @AttributeSql WHERE [TableSql] = NULL 

	SELECT * FROM @AttributeSql
	-- ----------------------------------------------------------------------------
	-- ITERATE 
	-- ----------------------------------------------------------------------------

	DECLARE @Index INT 
	DECLARE @Count INT 

	-- SELECT OBJECTS
	SELECT 
		@Index = 1,
		@Count = MAX([id])
	FROM @AttributeSql

	WHILE (@Index <= @Count)
	BEGIN 
			-- Variables
			DECLARE @AttributeIndex INT = 1;
			DECLARE @AttributeCount INT = 0;
			DECLARE @Sql VARCHAR(MAX);
			DECLARE @DropSql VARCHAR(MAX);

			-- Get objct name
			SELECT 
				@Sql = ISNULL(TableSql,''),
				@DropSql = ISNULL(DropSql,'')
			FROM @AttributeSql
			WHERE [Id] = @Index

			IF(LEN(@Sql) > 1)
			BEGIN 
			PRINT @Sql
					IF(LEN(@DropSql) > 1)
					BEGIN 
						EXEC (@DropSql)
						EXEC (@Sql)
					END 
			END

		SELECT @Index = @Index + 1;
		END 

END
GO

/****** Object:  StoredProcedure [meta].[Pre_build]    Script Date: 9/25/2014 8:20:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Pre_build]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [meta].[Pre_build] AS' 
END
GO



-- =============================================
-- TEST: EXEC [meta].[Pre_build]
-- =============================================
ALTER PROCEDURE [meta].[Pre_build]

AS
BEGIN
	SET NOCOUNT ON;

	-- Drop Relation Tables
	EXEC  [meta].[Drop_keys]
	EXEC  [meta].[Drop_Masters]
	EXEC  [meta].[Drop_Functions]

	-- ----------------------------------------------------------------------------
	-- ITERATE 
	-- ----------------------------------------------------------------------------

	DECLARE @Index INT 
	DECLARE @Count INT 
	DECLARE @Parent_Tag VARCHAR(10) = '##PARENT##'
	DECLARE @Child_Tag VARCHAR(10) = '##CHILD##'

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
			IF OBJECT_ID($$##Parent####Child##s$$, $$U$$) IS NOT NULL
			BEGIN 
			 DROP TABLE [dbo].[##Parent####Child##s]
			END 
		'
		SELECT @DropSql = REPLACE (@DropSql,@Parent_Tag,@Parent)
		SELECT @DropSql = REPLACE (@DropSql,@Child_Tag,@Child)
		SELECT @DropSql = REPLACE (@DropSql,'$$','''')
		EXEC (@DropSql)
		PRINT @DropSql
		SELECT @Index = @Index + 1;
	END 

END



GO

/****** Object:  StoredProcedure [meta].[Drop_Masters]    Script Date: 9/25/2014 8:19:18 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Drop_Masters]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [meta].[Drop_Masters] AS' 
END
GO





-- =============================================
-- Author:		RWHITTEN
-- TEST: EXEC [meta].[Drop_Masters]
-- =============================================
ALTER PROCEDURE [meta].[Drop_Masters]
	
AS
BEGIN
	SET NOCOUNT ON;

    -- TEMPLATES 
	DECLARE @Master_Tag VARCHAR(10) = '##MASTER##'
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
			@ObjectName = ISNULL(Title,NULL)
		FROM [meta].[Objects] 
		WHERE [Id] = @Index
		PRINT 'ObJECT '  + ISNULL(@ObjectName, 'NULL NAME')
		IF(LEN(@ObjectName) > 1)
		BEGIN 
			PRINT 'DROPPING ' + @ObjectName
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
			';

			SELECT @DropSQL = REPLACE(@DropSql,@Master_Tag, @ObjectName)
			SELECT @DropSQL = REPLACE(@DropSql,'$$', '''')
			PRINT @DropSql
			EXEC (@DropSql)
		END 


		SELECT @Index = @Index + 1;
	END 



	-- EXECUTE Relations 
	--EXEC [meta].[Create_Relations]

END





GO




/****** Object:  StoredProcedure [meta].[Drop_keys]    Script Date: 10/11/2014 11:39:52 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[Drop_keys]') AND type in (N'P', N'PC'))
DROP PROCEDURE [meta].[Drop_keys]
GO



-- =============================================
-- EXEC [meta].[Drop_keys]
-- =============================================
CREATE PROCEDURE [meta].[Drop_keys]

AS
BEGIN
	While(exists(select 1 from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_TYPE='FOREIGN KEY'))
		begin
			declare @sql nvarchar(2000)
			SELECT TOP 1 @sql=('ALTER TABLE ' + TABLE_SCHEMA + '.[' + TABLE_NAME
			+ '] DROP CONSTRAINT [' + CONSTRAINT_NAME + ']')
			FROM information_schema.table_constraints
			WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
			exec (@sql)
		end
END
GO


/****** Object:  StoredProcedure [meta].[drop_functions]    Script Date: 10/11/2014 11:39:36 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[drop_functions]') AND type in (N'P', N'PC'))
DROP PROCEDURE [meta].[drop_functions]
GO


-- =============================================
-- Author:		RWhiteten
-- EXEC [meta].[drop_functions]
-- =============================================
CREATE PROCEDURE [meta].[drop_functions]

AS
BEGIN
	SET NOCOUNT ON;

    -- TEMPLATES 
	DECLARE @Master_Tag VARCHAR(10) = '##MASTER##'
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
			@ObjectName = ISNULL(Title,NULL)
		FROM [meta].[Objects] 
		WHERE [Id] = @Index
		PRINT 'OBJECT '  + ISNULL(@ObjectName, 'NULL NAME')
		IF(LEN(@ObjectName) > 1)
		BEGIN 
			PRINT 'DROPPING FUNCTIONS FOR ' + @ObjectName
			-- DROP -----------------------------------------------
			DECLARE @DropSQL VARCHAR(MAX)
			SET @DropSQl = N'
				
			IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID($$Get##MASTER##$$) AND type in (N$$FN$$, N$$IF$$, N$$TF$$, N$$FS$$, N$$FT$$))
			DROP FUNCTION [dbo].[Get##MASTER##]
			';

			SELECT @DropSQL = REPLACE(@DropSql,@Master_Tag, @ObjectName)
			SELECT @DropSQL = REPLACE(@DropSql,'$$', '''')
			PRINT @DropSql
			EXEC (@DropSql)
		END 


		SELECT @Index = @Index + 1;
	END 

	-- EXECUTE Relations 
	--EXEC [meta].[Create_Relations]




	PRINT 'FUNCTIONS HAVE BEEN DROPPED'
END
GO





