CREATE PROCEDURE [dbo].[P_Users_Login]
	@Email nvarchar(250),
	@Password nvarchar(50)
AS
begin

	declare @Salt nvarchar(100);
	select @Salt = Salt from dbo.Users where [email] = @Email;

	if(@Salt is not null)
	begin
		Declare @secret nvarchar(50)
		set @secret = dbo.GetSecretKey();

		declare @Password_Hash varbinary(64);
		set @Password_Hash = HASHBYTES('SHA2_512', CONCAT(@Salt, @Password, @Secret, @Salt));

		Declare @UserId uniqueidentifier;
		select @UserId = Id_User from dbo.Users where email like @Email and [Pwd] = @Password_Hash
		--if()
		--begin
		--end
		--if()
		--begin
		--end
		select * from [Users] where Id_User = @UserId;
	end
end
