/****** Object:  Table [dbo].[ProcedureLog]	Script Date: 03/10/2011 10:06:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[ProcedureLog](
    [LogDate] [smalldatetime] NOT NULL,
    [DatabaseName] [varchar](50) NULL,
    [ProcedureName] [nvarchar](400) NULL,
    [AdditionalInfo] [nvarchar](max) NULL
) ON [PRIMARY]

GO


CREATE TABLE [dbo].[ProcedureLogDetail](
    [ID] [bigint] IDENTITY(1,1) NOT NULL,
    [DBName] [nvarchar](128) NULL,
    [SchemaName] [nvarchar](128) NULL,
    [StoredProcedure] [nvarchar](128) NULL,
    [client_net_address] [varchar](48) NULL,
    [last_execution_time] [datetime] NULL,
    [execution_count] [bigint] NULL,
    [total_worker_time] [bigint] NULL,
    [min_worker_time] [bigint] NULL,
    [max_worker_time] [bigint] NULL,
    [program_name] [nvarchar](128) NULL,
    [login_name] [nvarchar](128) NULL,
    [dbid] [smallint] NULL,
    [objectid] [int] NULL,
    [number] [smallint] NULL,
    [encrypted] [bit] NULL,
    [text] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProcedureLogDetail] PRIMARY KEY CLUSTERED
(
    [ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



CREATE VIEW [dbo].[StoredProcedureInfo]
AS


SELECT
    Db_name(st.dbid)                  	DBName,
    Object_schema_name(st.objectid, dbid) SchemaName,
    ISNULL(Object_name(st.objectid, dbid),'DynamicSQL')    	StoredProcedure,
    c.client_net_address,
    qs.last_execution_time,
    qs.execution_count,
    qs.total_worker_time,
    qs.min_worker_time,
    qs.max_worker_time,
    s.program_name,
    s.login_name,
    st.*
    --qs.*
FROM sys.dm_exec_query_stats qs
   	 CROSS APPLY sys.Dm_exec_sql_text(qs.plan_handle) st
   	 left JOIN  sys.dm_exec_connections c on c.most_recent_sql_handle = qs.sql_handle
   	 left JOIN  sys.dm_exec_sessions s on s.session_id = c.session_id
WHERE
    text NOT LIKE '%microsoft_database_tools_support%'
 AND
	text NOT LIKE '%sys.%'
 AND
	 text NOT LIKE '%sysindexes%'
 AND
	text NOT LIKE '%sys.%'
 AND
	text NOT LIKE '%schema_name%'
 AND
	text NOT LIKE '%sysobjects%'
 AND
	text NOT LIKE '%Serverproperty%'
 AND
	text NOT LIKE '%msdb%'
 AND
    Db_name(st.dbid) <> 'distribution'
    
GO


PRINT 'CREATING ProduceLog Stored Procedure' 
GO

CREATE PROCEDURE [dbo].[Log_ProcedureCall]
 @ProcedureName   	NVARCHAR(400),
 @DatabaseName   	   VARCHAR(50)    = NULL,
 @AdditionalInfo      NVARCHAR(MAX) = NULL
 
 
AS
BEGIN
 SET NOCOUNT ON;
 -- --------------------------------------------------------------
 -- [1] Log Procedure Log Header
 -- --------------------------------------------------------------
   	  INSERT INTO [dbo].[ProcedureLog]
   				([LogDate]
   				,[DatabaseName]
   				,[ProcedureName]
   				,[AdditionalInfo])
   		  VALUES
   				(GETDATE()
   				,@DatabaseName
   				,@ProcedureName
   				,@AdditionalInfo)
   	   
  -- --------------------------------------------------------------
  -- [2] Log Procedure Log Detail
  -- --------------------------------------------------------------
       	INSERT INTO [dbo].[ProcedureLogDetail]
   			  SELECT [DBName]
   				   ,[SchemaName]
   				   ,[StoredProcedure]
   				   ,[client_net_address]
   				   ,[last_execution_time]
   				   ,[execution_count]
   				   ,[total_worker_time]
   				   ,[min_worker_time]
   				   ,[max_worker_time]
   				   ,[program_name]
   				   ,[login_name]
   				   ,[dbid]
   				   ,[objectid]
   				   ,[number]
   				   ,[encrypted]
   				   ,[text]
   			   FROM
   					[dbo].[StoredProcedureInfo]
   			   WHERE
   					[StoredProcedure] =     @ProcedureName
   				 AND
   					[DBName]   		  =    @DatabaseName
   	 -- -------------------------------------------------------------   			  		 

 END


GO
