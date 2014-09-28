
-- Tempalte : Get Team By PublicId
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Get Team Record By PublicId
-- =============================================
CREATE FUNCTION [dbo].[GetTeam]
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
	FROM [dbo].[Teams]
	WHERE PublicId = @PublicId
		
)
GO
