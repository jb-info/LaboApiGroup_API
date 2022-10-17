CREATE PROCEDURE [dbo].[P_Project_DELETE]
	@Id_Project INT
AS	
BEGIN
	DELETE FROM Project
	WHERE Id_Project = @Id_Project
END
