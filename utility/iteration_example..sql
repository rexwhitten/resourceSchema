
-- Execute Audit Trail for every Master Tables 
DECLARE @List TABLE (ID INT IDENTITY(1,1), name VARCHAR(50))

INSERT INTO @List
SELECT 
 T.name
FROM sys.tables T 
	WHERE
		(T.name NOT LIKE '%Links')
	 AND
	    (T.name NOT LIKE '%MetaData') 
	AND
	    (T.name NOT LIKE '%Tags') 
	AND 
		(T.name NOT LIKE 'sysdiagrams')
	AND 
		(T.name NOT LIKE 'SqlErrors')

DECLARE @Index INT = 1;
DECLARE @Count INT 

SELECT @Count = COUNT(*) FROM @List

WHILE(@Index <= (@Count)) 
BEGIN 
	DECLARE @TableName NVARCHAR(255)

	SELECT @TableName = [name] FROM @list WHERE ID = @Index

	-- act on the table

	SELECT @Index = @Index + 1;
END 