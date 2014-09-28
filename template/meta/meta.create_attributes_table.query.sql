
-- REPLACE(REPLACE(@sql,'&#x0D;',''),'#x0D;','')
SELECT 
 REPLACE(REPLACE(N'CREATE TABLE [ALM].[dbo].['+ O.Title +'Attributes](
		[SysId] [int] IDENTITY(1,1) NOT NULL
		,[CreateDate] [datetime] NOT NULL
		,[LastModifiedDate] [datetime] NOT NULL
		' +
 STUFF((	 SELECT
				 N'
					,[' + MA.Name + '] ' + MA.DataType + ' NOT NULL
					'
              FROM [meta].[Attributes] MA
                        WHERE
							MA.ObjectTitle = O.Title
						 AND MA.Active = 1
                        FOR XML PATH('')
                        ), 1, 1, ' ' )
			+
			'CONSTRAINT [PK_'+O.Title+'Attributes] PRIMARY KEY CLUSTERED 
					(
						[SysId] ASC
					)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
					) ON [PRIMARY]','&#x0D;',''),'#x0D;','') AS [Sql3]
FROM [meta].[Objects] O
	
WHERE 
	((O.Active = 1))

