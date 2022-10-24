CREATE PROCEDURE [dbo].[P_RoleOfUser_UPDATE]
	@Id int ,
	@Id_User uniqueidentifier,
	@Id_Role int
AS
BEGIN
	UPDATE RoleOfUser
	SET  [Id_User] = @Id_User,[Id_Role]=@Id_Role
	WHERE Id = @Id
END

