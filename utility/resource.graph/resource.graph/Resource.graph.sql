
DECLARE @ResourceIndex AS TABLE( SysID INT IDENTITY(1,1),
						 PublicId UNIQUEIDENTIFIER NOT NULL UNIQUE,
						 Path	VARCHAR(512) NOT NULL UNIQUE,
						 Active BIT NOT NULL,
						 Created DATETIME,
						 LastModified DATETIME);

DECLARE @ResourceContent TABLE( SysID INT IDENTITY(1,1),
								ResourceIndexSysId INT NOT NULL,
								Content XML NOT NULL )

DECLARE @ResourceAttributes TABLE ( SysID INT IDENTITY(1,1),
									ResourceIndexSysID INT NOT NULL,
									Path VARCHAR(512) NOT NULL,
									Value VARCHAR(512) NULL
									)


DECLARE @ResourceMetrics TABLE ( SysId INT IDENTITY(1,1),
								 ResourceIndexSysId INT NOT NULL,
								 Path VARCHAR(512) NOT NULL,
								 X INT,
								 Y INT,
								 Z INT);

DECLARE @ResourceMetricP TABLE ( SysId INT IDENTITY(1,1),
								 ResourceIndexSysId INT NOT NULL,
								 Path VARCHAR(512) NOT NULL,
								 X INT,
								 Y INT,
								 Z INT);


SELECT 
	RI.Path,
	RI.PublicId,
    -- REST API PATH 
	(RI.Path + '?PublicId=' + CONVERT(VARCHAR(128), RI.PublicId)) AS [REST_ResourcePath]
FROM @ResourceIndex RI
	INNER JOIN @ResourceContent RC ON RC.ResourceIndexSysId = RI.SysID
WHERE 
 (RI.Active = 1) -- Active Index

ORDER BY RI.Path
