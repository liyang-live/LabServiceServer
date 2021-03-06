ALTER FUNCTION [dbo].GetPrintStatus(@patientId INT)
RETURNS INT
AS 
BEGIN
	DECLARE @totalTest INT
	DECLARE @printedTest INT
	
	Select @totalTest = COUNT(tti.Test_ID)
	FROM T_TEST_INFO tti
	WHERE tti.Patient_ID = @patientId
	
	Select @printedTest = COUNT(tti.Test_ID)
	FROM T_TEST_INFO tti
	WHERE tti.Patient_ID = @patientId AND tti.Printstatus = 1
	
	RETURN 1
END
--------------------------------------------------------------------------------


