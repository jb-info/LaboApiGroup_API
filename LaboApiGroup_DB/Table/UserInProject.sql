CREATE TABLE [dbo].[UserInProject]
(
	   Id INT IDENTITY(1,1),
	   Id_Project INT ,
	   Id_User INT,
	   PRIMARY KEY(Id),
	   FOREIGN KEY(Id_Project) REFERENCES Project(Id_Project),
	   FOREIGN KEY(Id_User) REFERENCES Users(Id_User)

)
