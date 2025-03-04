Alter Procedure SpviewAllCMSDeptCourses
As
Begin
select * from tblCMSDeptpo 
End


select * FROM SYS.tables



Create Procedure SpViewCMSDeptCoursesByID
@ID Int
As 
Begin
select * from tblCMSDeptpo  where Sno=@ID
End


truncate table tblCMSDeptpo

drop procedure SpViewCMSDeptNameByID

sp_helptext ViewCMSDepartmentByID

sp_help   tblCMSDeptpo


select * from tblCMSDepartmentName where DepartmentID=@DepartmentID  


select DepartmentName from tblCMSDepartmentName


Create Procedure UpdateCMSDEpartmentCourses
@Sno int, 
@Introduction nvarchar(Max),
@Content nvarchar(max),
@Updateddate datetime
As
Begin
Update tblCMSDeptpo set Introduction=@Introduction,Content=@Content where Sno=@Sno	
End

Alter Procedure UpdateCMSDEpartmentCoursesWithcurriculum
@Sno int, 
@PDFName nvarchar(Max),
@curriculum nvarchar(max),
@Updateddate datetime
As
Begin
Update tblCMSDeptpo set PDFName=@PDFName,curriculum=@curriculum,Updateddate=@Updateddate where Sno=@Sno	
End




Create Procedure DeleteCMSDepartmentCoursesBySno
@Sno int
as
Begin
Delete tblCMSDeptpo where Sno=@Sno
End




Sp_helptext SpviewAllCMSDeptCourses 


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

    -- Execute the dynamic query
    EXEC sp_executesql @SQL, @ParameterDef, @Department = @Department, @FromDate = @FromDate, @ToDate = @ToDate;
END
