CREATE VIEW [dbo].[vw_dbsize] AS 
SELECT DB_NAME() AS DataBaseName,Name AS LogicalName
,Physical_Name,(size*8)/1024 AS SizeMB,Max_Size 
FROM sys.database_files