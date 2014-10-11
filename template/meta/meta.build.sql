
-- ----------------------------------
-- BUILD OBJECTS
-- ----------------------------------
TRUNCATE TABLE [meta].[Objects]

INSERT INTO [meta].[Objects] SELECT 'User','/user',1
INSERT INTO [meta].[Objects] SELECT 'Team','/team',1
INSERT INTO [meta].[Objects] SELECT 'TeamMember','/team/member',1
INSERT INTO [meta].[Objects] SELECT 'Project','/project',1
INSERT INTO [meta].[Objects] SELECT 'Iteration','/project/iteration',1
INSERT INTO [meta].[Objects] SELECT 'Area','/area',1
INSERT INTO [meta].[Objects] SELECT 'Task','/project/iteration/task',1

-- ----------------------------------
-- BUILD RELATIONSHIPS
-- ----------------------------------
TRUNCATE TABLE [meta].[Relations]

INSERT INTO [meta].[Relations] SELECT 'User','TeamMember',1
INSERT INTO [meta].[Relations] SELECT 'Team','TeamMember',1
INSERT INTO [meta].[Relations] SELECT 'Task','TeamMember',1
INSERT INTO [meta].[Relations] SELECT 'Project','Iteration',1
INSERT INTO [meta].[Relations] SELECT 'Task','Iteration',1
INSERT INTO [meta].[Relations] SELECT 'Task','Area',1
INSERT INTO [meta].[Relations] SELECT 'Project','Team',1


SELECT * FROM [meta].[Objects]
SELECT * FROM [meta].[Relations]

-- CREATE DATABASE MODE

EXEC [meta].[Pre_build]
GO 

EXEC [meta].[Create_Masters]
GO

EXEC [meta].[Create_Relations]
GO

EXEC [meta].[Create_Attributes]
GO