CREATE PROCEDURE [dbo].[P_Transaction_UPDATE]
	@Id int,
	@Id_Project int,
	@Id_User int,
	@Amount int,
	@Date_Transaction date
AS
BEGIN
	UPDATE [dbo].[Transaction]
	SET [Id_Project] = @Id_Project,[Id_User] = @Id_User,[Amount]=@Amount ,
		[Date_Transaction] =@Date_Transaction 
	WHERE Id = @Id
END