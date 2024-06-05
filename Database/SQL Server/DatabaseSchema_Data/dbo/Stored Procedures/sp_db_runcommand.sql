-- =============================================
-- Author:      ardhagp
-- Create Date: 04-jun-2024
-- Description: this stored procedure is to help regularly save last ammount of storage in table
-- =============================================
CREATE PROCEDURE sp_db_runcommand
(
    -- Add the parameters for the stored procedure here
    @CommandName varchar(255),
    @RunInDatabase varchar(255),
	@VariableName varchar(255),
	@VariableValue varchar(255)
)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

			DECLARE @DatabaseName sysname
			SET @DatabaseName = @RunInDatabase
			DECLARE @Drive table(DriveName char, FreeSpaceInMegabytes int) insert @Drive execute xp_fixeddrives 
			DECLARE @IsExist int	
		
			SET @IsExist = (select count(sv.var_name) from dbo.[[sys]]variables] sv where sv.var_name = @VariableName)

		IF @IsExist > 0
			BEGIN
				SET @VariableValue = (SELECT drv.FreeSpaceInMegabytes as [freespace] from sys.master_files mas left join @Drive drv on left(mas.physical_name, 1) = drv.DriveName where database_id = db_id(@DatabaseName) and mas.type_desc='ROWS') 
				update dbo.[[sys]]variables] set var_value = @VariableValue where var_name = @VariableName
			END
		ELSE
			BEGIN
				SET @VariableValue = (SELECT drv.FreeSpaceInMegabytes as [freespace] from sys.master_files mas left join @Drive drv on left(mas.physical_name, 1) = drv.DriveName where database_id = db_id(@DatabaseName) and mas.type_desc='ROWS')
				insert into dbo.[[sys]]variables](var_id, var_name, var_value) values('-',@VariableName, @VariableValue)
			END
END