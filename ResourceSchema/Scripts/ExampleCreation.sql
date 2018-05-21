-- -------------------------------------------------------
-- Account Hub [Build Script]
-- -------------------------------------------------------

TRUNCATE TABLE [meta].[Objects] 
TRUNCATE TABLE [meta].[Attributes]
TRUNCATE TABLE [meta].[Relations] 

-- Objects
INSERT INTO [meta].[Objects] SELECT 'Account','/party/account', 1
INSERT INTO [meta].[Attributes] SELECT 'Account','PartyUri','varchar(256)',1

-- Build
EXEC [meta].[Pre_build]
EXEC [meta].[Create_Masters]
EXEC [meta].[Create_Attributes]
EXEC [meta].[Create_Relations]