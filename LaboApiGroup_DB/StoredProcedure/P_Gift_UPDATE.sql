CREATE PROCEDURE [dbo].[P_Gift_UPDATE]
	@Id_Gift int, 
	@Gift_Type VARCHAR(50),
	@Landing INT
AS	
BEGIN
	UPDATE Gift
	SET Gift_Type = @Gift_Type, Landing = @Landing
	WHERE Id_Gift = @Id_Gift
END
