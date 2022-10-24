CREATE PROCEDURE [dbo].[P_RoleOfUser_INSERT]
	@Id_User uniqueidentifier,
	@Id_Role int
AS
BEGIN
	INSERT INTO RoleOfUser(Id_User,Id_Role)
	Values (@Id_User,@Id_Role)

END
