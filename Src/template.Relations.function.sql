
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ====================================================
-- Resource Template : Functions for Relation Tables
-- Example : Get Tasks (Taskren) BY Iteration (Iteration)
-- Get Task By Iteration
-- =====================================================
CREATE FUNCTION [dbo].[GetTask_ByIteration] 
(	
	@Iteration_PublicId UNIQUEIDENTIFIER
)
RETURNS TABLE 
AS
RETURN 
(	
	SELECT 
		Task.*
	FROM [dbo].[IterationTask] Relation 
		 INNER JOIN [dbo].[Iterations] Iteration ON Iteration.SysId = Relation.IterationSysID
		 INNER JOIN [dbo].[Tasks]  Task ON Task.SysId   = Relation.TaskSysID
	WHERE 
		Iteration.PublicId = @Iteration_PublicId
		
)
GO
