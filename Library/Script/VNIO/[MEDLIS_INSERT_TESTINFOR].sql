set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go



ALTER PROCEDURE [dbo].[MEDLIS_INSERT_TESTINFOR]
(
    @TestType_ID  INT
   ,@Patient_ID   INT
   ,@Barcode      NVARCHAR(50)
   ,@Test_Date    NVARCHAR(10)
   ,@TestID       INT OUTPUT
)
AS
	DECLARE @pTest_Date DATETIME; 
	SET @pTest_Date = CONVERT(DATETIME ,@Test_Date ,103)
	
	IF NOT EXISTS(
	       SELECT Test_Id
	       FROM   T_TEST_INFO
	       WHERE  Patient_ID = @Patient_ID
	              AND TestType_ID = @TestType_ID
	              AND TEST_DATE = @pTest_Date
	   )
	BEGIN
	    INSERT INTO T_TEST_INFO
	      (
	        TestType_ID
	       ,Patient_ID
	       ,Barcode
	       ,Test_Date
	       ,Require_Date
	       ,Test_Status
	      )
	    VALUES
	      (
	        @TestType_ID
	       ,@Patient_ID
	       ,@Barcode
	       ,@pTest_Date
	       ,@pTest_Date
	       ,0
	      )
	    SELECT @TestID = @@IDENTITY
	END
	ELSE
	BEGIN
	    UPDATE T_TEST_INFO
	    SET    Barcode = @Barcode
	    WHERE  Patient_ID = @Patient_ID
	           AND TestType_ID = @TestType_ID
	           AND TEST_DATE = @pTest_Date 
	    
	    SELECT @TestID = 
	    (SELECT TOP 1 tti.Test_ID
	    FROM   T_TEST_INFO tti
	    WHERE  Patient_ID = @Patient_ID
	           AND TestType_ID = @TestType_ID
	           AND TEST_DATE = @pTest_Date
	           )
	END
	   



