# meta database 

## Recipe 

1. Create a new Sql Database in SQL Management Studio  Give it a Name. 
2. Your new name was [NewEmptyDatabase] (atleast for the time being)
3. Open the script build.meta.database.sql , and follow the instructions in the top header comments. (Find replace instructions)
4. One you have your [NewEmptyDatabase] built, 
5. Insert Records into the meta.Objects table, 
6. Insert Records into the meta.Attributes table,
7. Insert Records into the meta.Relations table, 

### Example 
```
INSERT INTO [meta].[Objects] SELECT 'Organization', '/core/organization', 1
INSERT INTO [meta].[Objects] SELECT 'Identity', '/core/identity', 1

-- attributes core to your architecture
INSERT INTO [meta].[Attributes] SELECT 'Organization', 'Description', 'NVARCHAR(256)',1
INSERT INTO [meta].[Attributes] SELECT 'Organization', 'FoundedOn', 'DATETIME',1
INSERT INTO [meta].[Attributes] SELECT 'Identity', 'Username', 'NVARCHAR(128)',1
INSERT INTO [meta].[Attributes] SELECT 'Identity', 'Description', 'NVARCHAR(256)',1

-- relations
INSERT INTO [meta].[Relations] SELECT 'Organization','Identity', 1
```

This will load your meta schema. Now to build it, execute the following Stored Procedures

```
EXEC [meta].[Pre_build] 
GO
EXEC [meta].[Create_Masters] 
GO
EXEC [meta].[Create_Attributes] 
GO
EXEC [meta].[Create_Relations] 
GO

```

Now your meta schema has built out into a physical schema. Each object that you entered has a cluster of common tables :

1. Type table
2. Status table
3. Master table
4. Attributes table
5. Tags table
6. MetaData Table 
7. Links Table 

Each [meta].[Attribute] row that you entered, was added to Attributes tables, as the column defenitions.

Each [meta].[Relation] that you entered, was turned into [PArentChild] FK Tables.


