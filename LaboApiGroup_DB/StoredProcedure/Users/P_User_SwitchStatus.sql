CREATE PROCEDURE [dbo].[P_User_SwitchStatus]
	@Id int,
	@Status bit
AS
begin
	if(@Status = 1)
		begin
			update Users set IsActive = 0 where Id_User = @Id;
		end
	else
		begin
			update Users set IsActive = 1 where Id_User = @Id;
		end
end
