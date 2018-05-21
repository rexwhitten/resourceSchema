




-- =============================================
-- Author:		RWHITTEN
-- TEST: EXEC [meta].[Drop_Masters]
-- =============================================
CREATE PROCEDURE [meta].[Drop_Masters]
	
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

				IF OBJECT_ID($$##MASTER##Attributes$$, $$U$$) IS NOT NULL
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






