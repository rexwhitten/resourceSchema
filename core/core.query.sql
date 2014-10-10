

SELECT 
	P.Id,
	R.Name AS [Controller],
	A.Name AS [Action],
	O.Name AS [Model],
	STUFF((
		SELECT 
			AT.AttributeName AS "@name",
			AT.DataType AS "@type"
		FROM [dbo].Attributes AT 
		WHERE AT.ObjectName = P.ObjectName 
		FOR XML PATH('Attributes'), root ('Attributes')
	),1,1,'<') AS [Model]

FROM [dbo].[Permissions] P
		INNER JOIN [dbo].[Role] R ON R.Name = P.RoleName
		INNER JOIN [dbo].[Actions] A ON A.Name = P.ActionName
		INNER JOIN [dbo].[Objects] O ON O.Name = P.ObjectName 
		
		