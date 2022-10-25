﻿CREATE TABLE [dbo].[Users]
(
   Id_User		UNIQUEIDENTIFIER	NOT NULL DEFAULT NEWSEQUENTIALID(),
   Nickname		VARCHAR(100)		NOT NULL,
   email		VARCHAR(100)		NOT NULL,
   Pwd			INT,
   Birthdate	DATE				NOT NULL,
   [Salt]		NVARCHAR(100)		NOT NULL,
   IsAdmin		bit default(0)		NOT NULL,
   IsActive		bit default(1)		NOT NULL

   PRIMARY KEY(Id_User),
   UNIQUE(email)
)
