CREATE PROCEDURE [dbo].[P_Admin_UserAdd]
	@Email NVARCHAR(250),
	@NickName nvarchar(50),
	@Birthdate datetime2,
	@Password NVARCHAR(50),
	@IsAdmin bit,
	@IsActive bit
AS
BEGIN
	set nocount on;
	-- Generation du Salt
	DECLARE @Salt NVARCHAR(100);
	SET @Salt = CONCAT(NEWID(),NEWID(),NEWID());

	-- Recuperation de la valeur secrete
	DECLARE @Secret NVARCHAR(50);
	SET @Secret = [dbo].GetSecretKey();

	-- Hashage du mot de passe avec le salt
	DECLARE @Password_hash VARBINARY(64);
	SET @Password_hash = HASHBYTES('SHA2_512', CONCAT(@Salt, @Password, @Secret, @Salt));

	-- Ajout de l'utilisateur dans la DB avec le mot de passe hashé
	INSERT INTO [dbo].[Users] ([email], [Nickname], [Birthdate], [Pwd], [Salt], IsAdmin, IsActive)
	 OUTPUT [inserted].[Id_User]
	 VALUES (@Email, @NickName,  @Birthdate ,@Password_hash, @Salt, @IsAdmin, @IsActive);
END
