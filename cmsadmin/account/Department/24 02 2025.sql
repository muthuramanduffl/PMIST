


select * from tblDepartmentabout
select * from tblCMSDeptpo

truncate table tblDepartmentabout


Create Procedure ViewAllDepartmentAbout
As
Begin
select * from tblDepartmentabout
End


sp_help tblDepartmentabout



sp_helptext SpviewAlltblDepartmentabout


  
 PROCEDURE SpviewAlltblDepartmentabout      
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
    SET @SQL = 'SELECT * FROM tblDepartmentabout WHERE 1 = 1';      
      
    -- Add filters dynamically      
    IF (@Department IS NOT NULL and @Department <> '')      
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
  
  
  
  exec SpviewAlltblDepartmentabout
  @Department='',
  @FromDate=null,
  @ToDate=null


  
  



  sp_helptext SpViewCMSDeptCoursesByID

Create Procedure SpViewCMSDeptAboutByID  
@ID Int  
As   
Begin  
select * from tblDepartmentabout  where AID=@ID  
End  




Alter Procedure UpdateDepartmenntAbout
@AID Int, 
@SectionName nvarchar(100),  
@Content nvarchar(max),  
@UpdatedDate Datetime,  
@UpdatedBy nvarchar(80)  
As
Begin
Update tblDepartmentabout set SectionName=@SectionName,Content=@Content,UpdatedDate=@UpdatedDate,UpdatedBy=@UpdatedBy where AID=@AID
End



sp_helptext AddDepartmentabout


Create Procedure DeleteDepartmentAbout
@AID int
As
begin
Delete tblDepartmentabout where AID=@AID
end

  