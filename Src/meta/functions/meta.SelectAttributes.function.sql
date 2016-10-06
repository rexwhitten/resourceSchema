
/****** Object:  UserDefinedFunction [meta].[SelectAttributes]    Script Date: 9/28/2014 2:15:27 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[SelectAttributes]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [meta].[SelectAttributes]
GO


-- ========================================================================
-- Author:		RWhitten
-- Create date: 09/28/2014
-- Description:	Function of Table Attributes for meta-programming
-- =========================================================================
CREATE FUNCTION [meta].[SelectAttributes]
(	
	@ObjectTitle VARCHAR(50) = NULL
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT 
	     O.Id		AS [Object_Id]
		,O.Title	AS [Object_Title]
		,STUFF((SELECT ' ,[' + MA.NAME + '] ' + MA.datatype + 
									  ' NOT NULL ' 
							   FROM   [meta].[attributes] MA 
							   WHERE  
									  (MA.objecttitle = O.title OR MA.ObjectTitle = 'Base')
									  AND MA.active = 1
							   FOR XML PATH('')), 1, 1, '') AS [Object_Attributes]
	FROM   [meta].[objects] O 
	WHERE  (( O.active = 1 )) 
	 AND ( @ObjectTitle IS NULL OR O.Title = @ObjectTitle)
)
GO
