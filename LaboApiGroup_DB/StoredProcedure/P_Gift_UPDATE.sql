CREATE PROCEDURE [dbo].[P_Gift_UPDATE]
	@Id_Gift int, 
	@Gift_Type VARCHAR(50),
	@landing INT
AS	
BEGIN
	UPDATE Gift
	SET Gift_Type = @Gift_Type, landing = @landing
	WHERE Id_Gift = @Id_Gift
END
