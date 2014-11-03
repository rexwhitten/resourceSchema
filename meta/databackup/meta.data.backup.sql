
-- Data Backup Process

-- [1] Load

INSERT INTO [meta].[DataBackup]
	SELECT
		'ActivityStatus',
		[Source].[SysId],
		BINARY_CHECKSUM(*),
		(SELECT * FROM [dbo].[ActivityStatus] ActivityStatus
		  WHERE ActivityStatus.SysId = [Source].[SysId]
		FOR XML AUTO)
	FROM [dbo].[ActivityStatus] [Source]



-- [2] Extract
select * FROM [meta].[DataBackup]

DELETE FROM [dbo].[ActivityStatus]
INSERT INTO [dbo].[ActivityStatus]
 SELECT 
   --[Source_Data].value('(/ActivityStatus/@SysId)[1]','int') [SysID],
   [Source_Data].value('(/ActivityStatus/@PublicId)[1]','uniqueidentifier') [PublicId],
   [Source_Data].value('(/ActivityStatus/@Path)[1]','varchar(1024)') [Path],
   [Source_Data].value('(/ActivityStatus/@CreateDate)[1]','datetime') [CreateDate],
   [Source_Data].value('(/ActivityStatus/@LastModifiedDate)[1]','datetime') [LastModifiedDate],
   [Source_Data].value('(/ActivityStatus/@Active)[1]','bit') [Active]
 FROM [meta].[DataBackup] DB
 WHERE DB.[Source_TableName] = 'ActivityStatus'

 SELECT 
	'(/' + O.Title + '/@' + A.Name + ')[1]',
	A.DataType

 FROM [meta].[Objects] O 
	 INNER JOIN [meta].[Attributes] A ON A.ObjectTitle = O.Title OR A.ObjectTitle = 'Base'

	 