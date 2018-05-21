


-- =============================================
-- TEST: EXEC [meta].[Pre_build]
-- =============================================
CREATE PROCEDURE [meta].[Pre_build]

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




