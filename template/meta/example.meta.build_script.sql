
-- ------------------------------------------------------------------------------
-- BUILD OBJECTS
-- ------------------------------------------------------------------------------
TRUNCATE TABLE [meta].[Objects]

INSERT INTO [meta].[Objects] SELECT 'User','/user',1
INSERT INTO [meta].[Objects] SELECT 'Binder','/binder',1
INSERT INTO [meta].[Objects] SELECT 'Resource','/Resource',1

-- ------------------------------------------------------------------------------
-- BUILD RELATIONSHIPS
-- ------------------------------------------------------------------------------
TRUNCATE TABLE [meta].[Relations]

INSERT INTO [meta].[Relations] SELECT 'User','Binder',1
INSERT INTO [meta].[Relations] SELECT 'Binder','Resource',1

-- ------------------------------------------------------------------------------
-- BUILD ATTRIBUTES
-- ------------------------------------------------------------------------------
TRUNCATE TABLE [meta].[Attributes]

INSERT INTO [meta].[Attributes] SELECT 'User', 'Email', 'varchar(128)',1
INSERT INTO [meta].[Attributes] SELECT 'User', 'Title', 'varchar(128)',1
INSERT INTO [meta].[Attributes] SELECT 'User', 'password', 'varchar(128)',1
INSERT INTO [meta].[Attributes] SELECT 'User', 'UserCreateDate', 'DateTime',1
INSERT INTO [meta].[Attributes] SELECT 'User', 'Approved', 'bit',1

INSERT INTO [meta].[Attributes] SELECT 'Binder', 'Title', 'varchar(128)',1
INSERT INTO [meta].[Attributes] SELECT 'Binder', 'Description', 'varchar(MAX)',1
INSERT INTO [meta].[Attributes] SELECT 'Binder', 'Icon', 'varchar(128)',1

INSERT INTO [meta].[Attributes] SELECT 'Resource', 'Title', 'varchar(128)',1
INSERT INTO [meta].[Attributes] SELECT 'Resource', 'Description', 'varchar(MAX)',1



-- ------------------------------------------------------------------------------
-- CREATE DATABASE MODE
-- ------------------------------------------------------------------------------
EXEC [meta].[Pre_build]
GO 

EXEC [meta].[Create_Masters]
GO

EXEC [meta].[Create_Relations]
GO

EXEC [meta].[Create_Attributes]
GO

-- ------------------------------------------------------------------------------
-- COMPLETE
-- ------------------------------------------------------------------------------