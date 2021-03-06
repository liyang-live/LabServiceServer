set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go





ALTER   PROCEDURE [dbo].[spInsertTestResult_DELETE]
    (
    	@pTestDetail_ID BIGINT,
      @pTEST_ID BIGINT ,
      @pPATIENT_ID BIGINT ,
      @pTestType_ID INT ,
      @pTestDate NVARCHAR(15) ,
      @pTestSeq NVARCHAR(50) ,
      @pDataSeq INT ,
      @pBarcode NVARCHAR(50) ,
      @pParaName NVARCHAR(100) ,
      @pTestResult NVARCHAR(100) ,
      @pMeasureUnit NVARCHAR(50) ,
      @pNormalLevel NVARCHAR(100) ,
      @pNormalLevelW NVARCHAR(100)
    )


--@T_Date Date;
AS 
BEGIN
	
	IF NOT EXISTS(
	SELECT * FROM 	T_RESULT_DETAIL_DELETED
	WHERE Test_ID=@pTEST_ID 
	)
    INSERT  INTO T_RESULT_DETAIL_DELETED
            ( TEST_ID ,
              PATIENT_ID ,
              TESTTYPE_ID ,
              TEST_DATE ,
              TEST_SEQUENCE ,
              DATA_SEQUENCE ,
              BARCODE ,
              TEST_RESULT ,
              PARA_NAME ,
              MEASURE_UNIT ,
              NORMAL_LEVEL ,
              NORMAL_LEVELW
            )
    VALUES  ( @pTEST_ID ,
              @pPATIENT_ID ,
              @pTestType_ID ,
              CONVERT(DATETIME, @pTestDate, 103) ,
              @pTestSeq ,
              @pDataSeq ,
              @pBarcode ,
              @pTestResult ,
              @pParaName ,
              @pMeasureUnit ,
              @pNormalLevel ,
              @pNormalLevelW
    )
    
    Update T_RESULT_DETAIL_DELETED 
Set TEST_RESULT = @pTestResult, UpdateNum = UpdateNum + 1
Where TESTDETAIL_ID = @pTestDetail_ID
AND BARCODE              = @pBarcode;
    END





