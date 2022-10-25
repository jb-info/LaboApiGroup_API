CREATE TRIGGER [UserSoftDelete]
ON [dbo].[Users]
instead of delete
as 
begin 
	update Users set IsActive = 0 where Id_User = (select Id_User from deleted)
end
