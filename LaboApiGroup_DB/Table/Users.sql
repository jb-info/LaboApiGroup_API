CREATE TABLE [dbo].[Users]
(
	Id_User INT IDENTITY(1,1),
   Nickname VARCHAR(100) NOT NULL,
   email VARCHAR(100) NOT NULL,
   Pwd INT,
   Birthdate DATE NOT NULL,
   PRIMARY KEY(Id_User),
   UNIQUE(email)
)
