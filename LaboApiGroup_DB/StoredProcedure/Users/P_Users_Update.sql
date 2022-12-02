CREATE PROCEDURE [dbo].[P_Users_Update]
	@id uniqueidentifier,
	@Email NVARCHAR(250),
	@NickName nvarchar(50),
	@Birthdate datetime2,
	@Password NVARCHAR(50)
AS
begin 
		-- Generation du Salt
		DECLARE @Salt NVARCHAR(100);
		SET @Salt = CONCAT(NEWID(),NEWID(),NEWID());
		-- Recuperation de la valeur secrete
		DECLARE @Secret NVARCHAR(50);
		SET @Secret = [dbo].GetSecretKey();

		-- Hashage du mot de passe avec le salt
		DECLARE @Password_hash VARBINARY(64);
		SET @Password_hash = HASHBYTES('SHA2_512', CONCAT(@Salt, @Password, @Secret, @Salt));

		update Users set email = @Email, Nickname = @NickName, Pwd = @Password_hash
		where Id_User = @id
end
