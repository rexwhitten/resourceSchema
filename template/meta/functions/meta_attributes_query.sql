-- Meta Attributes Query ( used to make functions for object creation ) 

SELECT STUFF((SELECT ' ,[' + MA.NAME + '] ' + MA.datatype + 
                              ' NOT NULL ' 
                       FROM   [meta].[attributes] MA 
                       WHERE  
						      (MA.objecttitle = O.title OR MA.ObjectTitle = 'Base')
                              AND MA.active = 1
                       FOR XML PATH('')), 1, 1, ''), O.Title
FROM   [meta].[objects] O 
WHERE  (( O.active = 1 )) 