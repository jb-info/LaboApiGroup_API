﻿CREATE PROCEDURE [dbo].[P_RoleOfUser_DELETE]
	@id INT
	
AS
BEGIN
	DELETE FROM [RoleOfUser]
	WHERE Id = @Id
END
