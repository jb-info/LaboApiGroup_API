CREATE TABLE [dbo].[Project]
(
	   Id_Project INT IDENTITY(1,1),
	   Start_Date DATE,
	   End_Date DATE,
	   Description VARCHAR(500) NOT NULL,
	   Tittle VARCHAR(50) NOT NULL,
	   Financial_Targets INT,
	   Earn_Money INT,
	   PRIMARY KEY(Id_Project)

)
