CREATE PROCEDURE [dbo].[P_GiftOfProject_INSERT]
	@Id int ,
	@Id_Project int,
	@Id_Gift int
AS
BEGIN
	INSERT INTO GiftOfProject(Id,Id_Project,Id_Gift)
	Values (@Id,@Id_Project,@Id_Gift)

END
