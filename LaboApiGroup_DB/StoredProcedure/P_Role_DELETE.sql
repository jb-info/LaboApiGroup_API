CREATE PROCEDURE [dbo].[P_Role_DELETE]
	@Id_Role INT	
AS
BEGIN
	DELETE FROM [Role]
	WHERE Id_Role = @Id_Role
END
