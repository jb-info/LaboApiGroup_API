CREATE PROCEDURE [dbo].[P_Users_Delete]
	@Id uniqueidentifier
AS
begin
	delete Users where Id_User = @Id;
end
