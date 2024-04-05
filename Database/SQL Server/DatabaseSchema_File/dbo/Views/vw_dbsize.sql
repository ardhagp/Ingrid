CREATE VIEW [dbo].[vw_dbsize] AS 
SELECT DB_NAME() AS DataBaseName,name AS LogicalName
,physical_name,(size*8)/1024 AS SizeMB,max_size
FROM sys.database_files