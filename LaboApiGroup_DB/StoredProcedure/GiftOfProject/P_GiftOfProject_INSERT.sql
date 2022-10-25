CREATE PROCEDURE [dbo].[P_GiftOfProject_INSERT]
	@Id_Project int,
	@Id_Gift int
AS
BEGIN
	INSERT INTO GiftOfProject(Id_Project,Id_Gift)
	Values (@Id_Project,@Id_Gift)

END
