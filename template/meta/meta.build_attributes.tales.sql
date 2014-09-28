
-- =============================================
-- TEST : EXEC [dbo].[Create_Attributes]
-- =============================================
ALTER PROCEDURE [dbo].[Create_Attributes]
AS 
BEGIN
	DECLARE @AttributeSql TABLE (ID INT IDENTITY(1,1),
								 [TableSql] VARCHAR(MAX),
								 [DropSql] VARCHAR(MAX))

	INSERT INTO @AttributeSql
	SELECT DISTINCT
		 REPLACE(REPLACE(N'CREATE TABLE [ALM].[dbo].['+ O.Title +'Attributes](
				[SysId] [int] IDENTITY(1,1) NOT NULL
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
							) ON [PRIMARY]','&#x0D;',''),'#x0D;','') AS [TableSql],
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
