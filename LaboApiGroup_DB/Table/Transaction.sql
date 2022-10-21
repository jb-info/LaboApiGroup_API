CREATE TABLE [dbo].[Transaction]
(
		[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	   Id_Project INT,
	   Id_User UNIQUEIDENTIFIER NOT NULL DEFAULT NEWSEQUENTIALID(),
	   Amount INT,
	   Date_Transaction DATE,
	   FOREIGN KEY(Id_Project) REFERENCES Project(Id_Project),
	   FOREIGN KEY(Id_User) REFERENCES Users(Id_User)

)
