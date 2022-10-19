CREATE PROCEDURE [dbo].[P_Transaction_INSERT]
	@Id int ,
	@Id_Project int,
	@Id_User int,
	@Amount int,
	@Date_Transaction date 
AS
BEGIN
	INSERT INTO [dbo].[Transaction] (Id,Id_Project,Id_User,Amount,Date_Transaction)
	Values (@Id,@Id_Project,@Id_User,@Amount,@Date_Transaction)
END