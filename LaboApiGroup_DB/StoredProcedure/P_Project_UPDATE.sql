CREATE PROCEDURE [dbo].[P_Project_UPDATE]
	@Id_Project INT,
	@Start_Date DATE, 
	@End_Date DATE,
	@Description VARCHAR(500), 
	@Tittle VARCHAR(50),
	@Financial_Targets INT,
	@Earn_Money INT
AS
BEGIN
	UPDATE Project
	SET [Start_Date] = @Start_Date, End_Date = @End_Date, [Description] = @Description,
		Tittle = @Tittle, Financial_Targets = @Financial_Targets, Earn_Money =@Earn_Money 
	WHERE Id_Project = @Id_Project
END
