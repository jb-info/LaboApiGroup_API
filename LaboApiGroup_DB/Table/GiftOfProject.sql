CREATE TABLE [dbo].[GiftOfProject]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Id_Project INT,
   Id_Gift INT,   
   FOREIGN KEY(Id_Project) REFERENCES Project(Id_Project),
   FOREIGN KEY(Id_Gift) REFERENCES Gift(Id_Gift)

)
