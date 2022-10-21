CREATE PROCEDURE [dbo].[P_Gift_DELETE]
	@Id_Gift int 	
AS	
BEGIN
	DELETE FROM Gift
	WHERE Id_Gift = @Id_Gift
END