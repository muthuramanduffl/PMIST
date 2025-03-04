

sp_helptext SpViewCMSDeptCoursesByID


Create Procedure SpViewCMSDeptCoursesByDeptandSectionName 
@Dept Int ,
@SectionName nvarchar(50)
As   
Begin  
select * from tblCMSDeptpo  where Department=@Dept and  SectionName=@SectionName
End  


sp_helptext SpviewAllCMSDeptCourses

select * from tblCMSDeptpo

sp_help tblCMSDeptpo


sp_helptext SpviewAllCMSDeptCourses


alter PROCEDURE SpviewAllCMSDeptCourses  
    @Department INT = NULL,  
    @FromDate NVARCHAR(50) = NULL,  
    @ToDate NVARCHAR(50) = NULL  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    DECLARE @SQL NVARCHAR(MAX);  
    DECLARE @ParameterDef NVARCHAR(500);  
  
    SET @ParameterDef = '@Department INT, @FromDate NVARCHAR(50), @ToDate NVARCHAR(50)';  
  
    -- Base query  
    SET @SQL = 'SELECT * FROM tblCMSDeptpo WHERE 1 = 1';  
  
    -- Add filters dynamically  
    IF (@Department IS NOT NULL)  
    BEGIN  
        SET @SQL = @SQL + ' AND Department = @Department';  
    END  
  
    IF (@FromDate IS NOT NULL AND @ToDate IS NOT NULL)  
    BEGIN  
        SET @SQL = @SQL + ' AND CAST(Addeddate AS DATE) >= @FromDate AND CAST(Addeddate AS DATE) <= @ToDate';  
    END  
  

    @SQL=@SQL +' ORDER BY Department, Addeddate' 

    -- Execute the dynamic query  
    EXEC sp_executesql @SQL, @ParameterDef, @Department = @Department, @FromDate = @FromDate, @ToDate = @ToDate;  
END  



ALTER PROCEDURE SpviewAllCMSDeptCourses  
    @Department INT = NULL,  
    @FromDate NVARCHAR(50) = NULL,  
    @ToDate NVARCHAR(50) = NULL  
AS  
BEGIN  
    SET NOCOUNT ON;  
  
    DECLARE @SQL NVARCHAR(MAX);  
    DECLARE @ParameterDef NVARCHAR(500);  
  
    SET @ParameterDef = '@Department INT, @FromDate NVARCHAR(50), @ToDate NVARCHAR(50)';  
  
    -- Base query  
    SET @SQL = 'SELECT * FROM tblCMSDeptpo WHERE 1 = 1';  
  
    -- Add filters dynamically  
    IF (@Department IS NOT NULL)  
    BEGIN  
        SET @SQL = @SQL + ' AND Department = @Department';  
    END  
  
    IF (@FromDate IS NOT NULL AND @ToDate IS NOT NULL)  
    BEGIN  
        SET @SQL = @SQL + ' AND CAST(Addeddate AS DATE) >= @FromDate AND CAST(Addeddate AS DATE) <= @ToDate';  
    END  
  
    -- Add ORDER BY clause  
    SET @SQL = @SQL + ' ORDER BY Department, Addeddate';  
  
    -- Execute the dynamic query  
    EXEC sp_executesql @SQL, @ParameterDef, @Department = @Department, @FromDate = @FromDate, @ToDate = @ToDate;  
END  



SELECT * 
FROM tblCMSDeptpo 
WHERE 1 = 1 
ORDER BY Department;


select * from sys.tables


tblCMSDepartmentName

