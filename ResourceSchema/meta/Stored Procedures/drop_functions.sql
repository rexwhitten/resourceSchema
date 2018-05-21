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

