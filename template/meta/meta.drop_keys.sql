
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