CREATE PROCEDURE [dbo].[P_Gift_INSERT]
	@Gift_Type VARCHAR(50),
	@landing int
AS
BEGIN

	INSERT INTO Gift (Gift_Type, landing)
	VALUES(@Gift_Type, @landing)

END
