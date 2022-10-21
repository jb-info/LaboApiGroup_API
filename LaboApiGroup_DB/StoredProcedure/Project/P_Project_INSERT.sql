CREATE PROCEDURE [dbo].[P_Project_INSERT]
	   @Start_Date DATE,
	   @End_Date DATE,
	   @Description VARCHAR(500),
	   @Tittle VARCHAR(50),
	   @Financial_Targets INT,
	   @Earn_Money INT
AS
BEGIN

	INSERT INTO Project(Start_Date, End_Date,Description, Tittle, Financial_Targets, Earn_Money) 
	VALUES (@Start_Date, @End_Date, @Description, @Tittle, @Financial_Targets, @Earn_Money)

END
