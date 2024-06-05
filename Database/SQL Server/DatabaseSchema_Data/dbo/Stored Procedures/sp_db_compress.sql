-- =============================================
-- Author	  : ArdhaGp
-- Create date: 03-aug-2018
-- Description:	Stored Procedure to compress database
-- =============================================
CREATE PROCEDURE sp_db_compress

AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Insert statements for procedure here
 DBCC SHRINKFILE (2, TRUNCATEONLY)
END