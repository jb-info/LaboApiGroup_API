﻿CREATE PROCEDURE [dbo].[P_GiftOfProject_DELETE]
	@Id INT
	
AS
BEGIN
	DELETE FROM [GiftOfProject]
	WHERE Id=@Id
END