CREATE FUNCTION [dbo].[md5]
( @param_value AS varchar(max) 
)
RETURNS varchar(32)
AS
BEGIN
  -- routine body goes here, e.g.
  -- SELECT 'Navicat for SQL Server'
DECLARE @param_result varchar(32);

set @param_result =  CONVERT(VARCHAR(32), HashBytes('MD5', @param_value), 2);

  RETURN @param_result
END