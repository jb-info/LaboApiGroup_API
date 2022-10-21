CREATE PROCEDURE [dbo].[P_RoleOfUser_INSERT]
	@Id int,
	@Id_User int,
	@Id_Role int
AS
BEGIN
	INSERT INTO RoleOfUser(Id,Id_User,Id_Role)
	Values (@Id,@Id_User,@Id_Role)

END
