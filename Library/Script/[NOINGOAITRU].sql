set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go

ALTER FUNCTION [dbo].[NOINGOAITRU](@noingoaitru [tinyint])
RETURNS [nvarchar](10)   
AS 
BEGIN
	-- Declare the return variable here
	DECLARE @Noitru NVARCHAR(10)

    SET @Noitru=(CASE WHEN @noingoaitru=0 THEN N'NGOẠI TRÚ'
				WHEN @noingoaitru=1 THEN N'NỘI TRÚ'
				WHEN @noingoaitru=2 THEN N'KHÁC'
			  end		
              ) 
   RETURN @Noitru           
END
------------
