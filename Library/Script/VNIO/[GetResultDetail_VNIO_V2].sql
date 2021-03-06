set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
go


ALTER PROCEDURE [dbo].[GetResultDetail_VNIO_V2]
	@psophieu VARCHAR(50),
	@pName NVARCHAR(100),
	@psex INT,
	@pfromdatetime DATETIME,
	@ptoDatetime DATETIME,
	@pcheck BIT,
	@ptestTypeId INT,
	@pHastest INT
AS
	IF (@pcheck='TRUE')
	BEGIN
	   
	   SELECT DISTINCT 1 AS CHON,(
           SELECT TOP 1 t.maBenhNhan
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS maBenhNhan
      ,(
           SELECT TOP 1 t.bacSyDieuTri
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS bacSyDieuTri
      ,(
           SELECT TOP 1 t.buong
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS buong
        ,(
           SELECT TOP 1 t.tenBenhNhan
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS tenBenhNhan
      ,(
           SELECT TOP 1 t.diaChi
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS diaChi
     	          ,(
	               SELECT TOP 1 dbo.PatientSex(t.gioiTinh)
	               FROM   tblHisLis_PatientInfo_VNIO t
	               WHERE  v.maBenhNhan = t.maBenhNhan
	           ) AS Sex_name
      ,(
           SELECT TOP 1 t.giuong
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS giuong
      ,                  (
                      SELECT TOP 1 t.khoa
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS khoa
                  ,
                  (
                      SELECT TOP 1 t.noiTru
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS noiTru
                  ,
                  (
                      SELECT TOP 1 t.phong
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS phong
                  ,
                  (
                      SELECT TOP 1 t.tuoi
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS tuoi
                  ,
                  (
                      SELECT TOP 1 t.test_date
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS test_date
     FROM   tblHisLis_PatientInfo_VNIO t
       LEFT JOIN tblYeucauXetnghiem_VNIO v
            ON  v.maBenhNhan = t.maBenhNhan
 WHERE  (t.maBenhNhan=@psophieu OR t.tenBenhNhan=@pName)
 -- and (t.test_date=@pfromdatetime or t.test_date=@ptoDatetime)
	           AND (
	                   CONVERT(DATETIME ,CONVERT(NVARCHAR(10) ,t.test_date ,103) ,103) 
	                   BETWEEN CONVERT(DATETIME ,@pfromdatetime ,103)
	                   
	                   AND
	                   CONVERT(DATETIME ,@ptoDatetime ,103)
	               )
	          -- AND (ISNULL(tb.datra ,0)=@pHastest OR @pHastest=-1)
	    --	     AND  tb.test_date=@pfromdatetime  --AND tyxv.TestType_ID=@testTypeId
	    --	    AND tb.test_date=@ptoDatetime
	    SELECT DISTINCT tti.*
	           --,t.Id
	          ,t.maBenhNhan
	           -- ,t.sophieu
	          ,(
	               SELECT TOP 1 tttl.TestType_Name
	               FROM   T_TEST_TYPE_LIST tttl
	               WHERE  tttl.TestType_ID = tti.TestType_ID
	           ) AS TestType_Name
	    FROM   T_TEST_INFO tti
	          ,tblYeucauXetnghiem_VNIO T
	    WHERE  (T.maBenhNhan=@psophieu)
	           AND (tti.TestType_ID=@ptestTypeId)
	           OR (tti.Barcode=T.Barcode AND t.TestType_ID=tti.TestType_ID)
	           AND (
	                   tti.test_date=@pfromdatetime    AND tti.test_date=@ptoDatetime
	               )
	           AND EXISTS(
--	                   SELECT 1
--	                   FROM   tblHisLis_PatientInfo_VNIO V
--	                   WHERE  T.maBenhNhan = ISNULL(V.maBenhNhan ,0)
--	                          AND (V.datra=@pHastest OR @pHastest=-1)
SELECT 1
	               FROM   T_TEST_INFO  V
	               WHERE  V.TestType_ID = t.TestType_ID
	                      AND (ISNULL(t.SendStatus ,1)=@pHastest OR @pHastest=-1)
	               )
	    
	    SELECT DISTINCT 1 AS CHON
	          ,t1.*
	          ,(
	               SELECT TOP 1 trd.Test_Result
	               FROM   T_RESULT_DETAIL trd
	               WHERE  (trd.Barcode=t1.Barcode)
	                      AND (trd.Para_Name=t2.Lis_ParaName)
	           ) AS result
	          ,(
	               SELECT TOP 1 trd.Test_ID
	               FROM   T_RESULT_DETAIL trd
	               WHERE  (trd.Barcode=t1.Barcode)
	                      AND (trd.Para_Name=t2.Lis_ParaName)
	           ) AS Test_ID
	          ,(
	               SELECT trd.Normal_levelW
	               FROM   T_RESULT_DETAIL trd
	               WHERE  (trd.Barcode=t1.Barcode)
	                      AND (trd.Para_Name=t2.Lis_ParaName)
	           ) AS Normal_levelW
	          ,(
	               SELECT TOP 1 trd.Measure_Unit
	               FROM   T_RESULT_DETAIL trd
	               WHERE  (trd.Barcode=t1.Barcode)
	                      AND (trd.Para_Name=t2.Lis_ParaName)
	           ) AS Measure_Unit
	          ,(
	               SELECT TOP 1 trd.Normal_Level
	               FROM   T_RESULT_DETAIL trd
	               WHERE  (trd.Barcode=t1.Barcode)
	                      AND (trd.Para_Name=t2.Lis_ParaName)
	           ) AS Normal_Level
	          ,(
	               SELECT TOP 1 trd.Para_Name
	               FROM   T_RESULT_DETAIL trd
	               WHERE  (trd.Barcode=t1.Barcode)
	                      AND (trd.Para_Name=t2.Lis_ParaName)
	           ) AS Para_Name
 ,(
	           SELECT TOP 1 trd.PrintData
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS PrintStatus
	            ,(
	           SELECT  TOP 1 tti.Device_ID
	           FROM  T_TEST_INFO tti
	            WHERE  (tti.Barcode=t1.Barcode) --AND (tti.Device_ID IS NOT NULL AND t2.Device_ID IS NOT NULL) AND (tti.Device_ID=t2.Device_ID)
	       ) AS Device_ID 
	    FROM   tblYeucauXetnghiem_VNIO t1
	           LEFT JOIN tbl_ParamMapping t2
	                ON  t2.Med_ParamID = t1.idCanLamSangThucHien
	    WHERE  t1.maBenhNhan = @psophieu
	           AND (t1.TestType_ID=@ptestTypeId OR @ptestTypeId=-100)
	           AND (
	                   CONVERT(DATETIME ,CONVERT(NVARCHAR(10) ,Test_Date ,103) ,103) 
	                   BETWEEN CONVERT(DATETIME ,@pfromdatetime ,103)
	                   
	                   AND
	                   CONVERT(DATETIME ,@ptoDatetime ,103)
	               )
	           AND EXISTS(
	                   SELECT 1
	                   FROM   tblHisLis_PatientInfo_VNIO V
	                   WHERE  V.maBenhNhan = t1.maBenhNhan
	                          AND @pHastest = -1
	               )
	END
	ELSE
	   SELECT DISTINCT 1 AS CHON,(
           SELECT TOP 1 t.maBenhNhan
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS maBenhNhan
      ,(
           SELECT TOP 1 t.bacSyDieuTri
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS bacSyDieuTri
      ,(
           SELECT TOP 1 t.buong
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS buong
        ,(
           SELECT TOP 1 t.tenBenhNhan
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS tenBenhNhan
      ,(
           SELECT TOP 1 t.diaChi
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS diaChi
     	          ,(
	               SELECT TOP 1 dbo.PatientSex(t.gioiTinh)
	               FROM   tblHisLis_PatientInfo_VNIO t
	               WHERE  v.maBenhNhan = t.maBenhNhan
	           ) AS Sex_name
      ,(
           SELECT TOP 1 t.giuong
           FROM   tblHisLis_PatientInfo_VNIO t
           WHERE  v.maBenhNhan = t.maBenhNhan
       ) AS giuong
      ,                  (
                      SELECT TOP 1 t.khoa
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS khoa
                  ,
                  (
                      SELECT TOP 1 t.noiTru
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS noiTru
                  ,
                  (
                      SELECT TOP 1 t.phong
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS phong
                  ,
                  (
                      SELECT TOP 1 t.tuoi
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS tuoi
                  ,
                  (
                      SELECT TOP 1 t.test_date
                      FROM   tblHisLis_PatientInfo_VNIO t
                      WHERE  v.maBenhNhan = t.maBenhNhan
                  ) AS test_date
     FROM   tblHisLis_PatientInfo_VNIO t
       LEFT JOIN tblYeucauXetnghiem_VNIO v
            ON  v.maBenhNhan = t.maBenhNhan
	   WHERE (t.maBenhnhan LIKE '%'+@psophieu+'%' OR  t.tenBenhNhan LIKE '%'+@pName+'%') AND (v.TestType_ID=@ptestTypeId)
	--  AND (t.test_date=@pfromdatetime or t.test_date=@ptoDatetime)
	   AND  (
	               CONVERT(DATETIME ,CONVERT(NVARCHAR(10) ,t.TEST_DATE ,103) ,103) 
	               BETWEEN CONVERT(DATETIME ,@pfromdatetime ,103)
	               
	               AND
	               CONVERT(DATETIME ,@ptoDatetime ,103)
	           )

	
	SELECT DISTINCT tti.*
	       --,t.Id
	      ,t.maBenhNhan
	      ,(
	           SELECT TOP 1 tttl.TestType_Name
	           FROM   T_TEST_TYPE_LIST tttl
	           WHERE  tttl.TestType_ID = tti.TestType_ID
	       ) AS TestType_Name
	FROM   T_TEST_INFO tti
	       JOIN tblYeucauXetnghiem_VNIO T
	            ON  tti.Barcode = T.Barcode
	WHERE  (tti.Barcode=T.Barcode AND t.TestType_ID=tti.TestType_ID)
	       AND (tti.TestType_ID=@ptestTypeId)
	       AND (T.maBenhNhan LIKE '%'+@psophieu+'%')
	       AND (t.test_date=@pfromdatetime OR t.test_date=@ptoDatetime)
	       AND EXISTS(
--	               SELECT 1
--	               FROM   tblHisLis_PatientInfo_VNIO V
--	               WHERE  T.maBenhNhan = V.maBenhNhan
--	                      AND (ISNULL(V.datra ,0)=@pHastest OR @pHastest=-1)
					SELECT 1
	               FROM   T_TEST_INFO  V
	               WHERE  V.TestType_ID = t.TestType_ID
	                      AND (ISNULL(t.SendStatus ,1)=@pHastest OR @pHastest=-1)
	           )
	
	SELECT DISTINCT 1 AS CHON
	      ,t1.*
	      ,(
	           SELECT TOP 1 trd.Test_Result
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS result
	      ,(
	           SELECT TOP 1 trd.Test_ID
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS Test_ID
	      ,(
	           SELECT TOP 1 trd.Normal_levelW
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS Normal_levelW
	      ,(
	           SELECT TOP 1 trd.Measure_Unit
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS Measure_Unit
	      ,(
	           SELECT TOP 1 trd.Normal_Level
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS Normal_Level
	      ,(
	           SELECT TOP 1 trd.PrintData
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS PrintStatus
,(
	           SELECT TOP 1 trd.Para_Name
	           FROM   T_RESULT_DETAIL trd
	           WHERE  (trd.Barcode=t1.Barcode)
	                  AND (trd.Para_Name=t2.Lis_ParaName)
	       ) AS Para_Name
	   ,(
	           SELECT  TOP 1 tti.Device_ID
	           FROM  T_TEST_INFO tti
	            WHERE  (tti.Barcode=t1.Barcode) --AND (tti.Device_ID IS NOT NULL AND t2.Device_ID IS NOT NULL) AND (tti.Device_ID=t2.Device_ID)
	       ) AS Device_ID 
	FROM   tblYeucauXetnghiem_VNIO t1
	       JOIN tbl_ParamMapping t2
	            ON  t2.Med_ParamID = t1.idCanLamSangThucHien -- JOIN tblHisLis_PatientInfo_VNIO tb ON tb.maBenhNhan=t1.maBenhNhan
	WHERE  (
	           CONVERT(DATETIME ,CONVERT(NVARCHAR(10) ,Test_Date ,103) ,103) 
	           BETWEEN CONVERT(DATETIME ,@pfromdatetime ,103) AND
	           CONVERT(DATETIME ,@ptoDatetime ,103)
	       )
	       --AND  t1.maBenhNhan = @psophieu
	       --  t1.maBenhNhan LIKE '%'+@psophieu+'%'
	       AND (t1.TestType_ID=@ptestTypeId)
	       AND EXISTS(
	               SELECT 1
	               FROM   T_TEST_INFO  V
	               WHERE  V.TestType_ID = t1.TestType_ID
	                      AND (ISNULL(t1.SendStatus ,1)=@pHastest OR @pHastest=-1)
	           )


