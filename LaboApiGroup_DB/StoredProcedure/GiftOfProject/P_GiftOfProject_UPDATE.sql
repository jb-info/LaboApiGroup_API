CREATE PROCEDURE [dbo].[P_GiftOfProject_UPDATE]
	@Id INT,
	@Id_Project INT,
	@Id_Gift INT
AS
BEGIN
	UPDATE GiftOfProject
	SET   [Id_Project] = @Id_Project, [Id_Gift] = @Id_Gift
	WHERE Id = @Id
END
