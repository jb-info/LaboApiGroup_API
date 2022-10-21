CREATE PROCEDURE [dbo].[P_Role_UPDATE]
	@Id_Role INT,
	@Name VARCHAR(50)
AS
BEGIN
	UPDATE Role
	SET [Name]= @Name		
	WHERE Id_Role = @Id_Role
END
