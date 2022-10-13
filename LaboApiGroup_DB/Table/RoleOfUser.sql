﻿CREATE TABLE [dbo].[RoleOfUser]
(
	Id INT IDENTITY(1,1),
	Id_User INT,
	Id_Role INT,   
	PRIMARY KEY(Id),
	FOREIGN KEY(Id_User) REFERENCES Users(Id_User),
	FOREIGN KEY(Id_Role) REFERENCES Role(Id_Role)

)
