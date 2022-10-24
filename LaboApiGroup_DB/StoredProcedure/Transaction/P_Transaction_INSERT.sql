CREATE PROCEDURE [dbo].[P_Transaction_INSERT]
	@Id_Project int,
	@Id_User uniqueidentifier,
	@Amount int,
	@Date_Transaction date 
AS
BEGIN
	INSERT INTO [dbo].[Transaction] (Id_Project,Id_User,Amount,Date_Transaction)
	Values (@Id_Project,@Id_User,@Amount,@Date_Transaction)
END