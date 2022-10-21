CREATE PROCEDURE [dbo].[P_Gift_INSERT]
	@Gift_Type VARCHAR(50),
	@Landing int
AS
BEGIN

	INSERT INTO Gift (Gift_Type, Landing)
	VALUES(@Gift_Type, @Landing)

END
