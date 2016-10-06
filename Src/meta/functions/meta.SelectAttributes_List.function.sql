
/****** Object:  UserDefinedFunction [meta].[SelectAttributes]    Script Date: 9/28/2014 2:10:33 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[meta].[SelectAttribute_List]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [meta].[SelectAttribute_List]
GO


-- ========================================================================
-- Author:		RWhitten
-- Create date: 09/28/2014
-- Description:	Function of Table Attributes NAmes for meta-programming
-- TEST: SELECT * FROM [meta].[SelectAttribute_List](NULL)
-- =========================================================================
CREATE FUNCTION [meta].[SelectAttribute_List]
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
		,STUFF((SELECT ' ,[' + MA.NAME + '] '
							   FROM   [meta].[attributes] MA 
							   WHERE  
									  (MA.objecttitle = O.title OR MA.ObjectTitle = 'Base')
									  AND MA.active = 1
							   FOR XML PATH('')), 1, 1, '') AS [Object_Attributes]
		,STUFF((SELECT ' ,@' + MA.NAME + ''
							   FROM   [meta].[attributes] MA 
							   WHERE  
									  (MA.objecttitle = O.title OR MA.ObjectTitle = 'Base')
									  AND MA.active = 1
							   FOR XML PATH('')), 1, 1, '') AS [Object_Attributes]
	FROM   [meta].[objects] O 
	WHERE  
	    (( O.active = 1 )) 
	 AND 
		(@ObjectTitle IS NULL OR O.Title = @ObjectTitle)
)
GO
