set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER  PROCEDURE [dbo].[DeleteTestinforTResultTblYeucauXN]
(
@barcode NVARCHAR(20),
@testTypeId INT	
)
AS 
DELETE FROM T_TEST_INFO 
WHERE Barcode =@barcode AND TestType_ID =@testTypeId
 DELETE FROM T_RESULT_DETAIL
  WHERE Barcode =@barcode AND TestType_ID=@testTypeId
 DELETE FROM tblYeucauXetnghiem_VNIO 
 WHERE Barcode=@barcode AND TestType_ID=@testTypeId


