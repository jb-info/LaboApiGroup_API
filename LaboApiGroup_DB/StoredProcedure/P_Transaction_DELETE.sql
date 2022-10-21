CREATE PROCEDURE [dbo].[P_Transaction_DELETE]
	@Id INT 
	
AS
BEGIN
	DELETE FROM [Transaction]
	WHERE Id = @Id 
END
