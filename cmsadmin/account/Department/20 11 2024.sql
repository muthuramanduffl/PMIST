select * from sys.tables


sp_helptext SpCMSAdminLogin








create PROCEDURE [dbo].[SpCMSAdminLogin]   
 -- Add the parameters for the stored procedure here  
 @Username nvarchar(50),  
 @Password nvarchar(50)  
   
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
 SELECT * from tblAdminLogin where UserName=@Username and Password=@Password and Status=1  
END


select * from tblCMSFacultyName
select * from tblCMSDepartmentName


sp_help tblCMSDepartmentName
sp_help tblCMSFacultyName


ALTER TABLE tblCMSDepartmentName DROP COLUMN DepartmentID;
 
 drop table tblCMSDepartmentName

CREATE TABLE tblCMSDepartmentName (
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
    FacultyID INT,
    DepartmentName NVARCHAR(100),
    Status NVARCHAR(50),
    AddedDate DATETIME
);


alter table tblCMSDepartmentName add  UpdatedDAte datetime


Create Procedure AddCMSDepartment
 @FacultyID int,
 @Status nvarchar(50),
 @DepartmentName nvarchar(100),
 @AddedDate datetime
as
begin
Insert into tblCMSDepartmentName (FacultyID,DepartmentName,Status,AddedDate) Values (@FacultyID,@DepartmentName,@Status,@AddedDate)
End

Create Procedure UpdateCMSDepartment
@DepartmentID int,
 @FacultyID int,
 @Status nvarchar(50),
 @DepartmentName nvarchar(100),
 @UpdatedDAte datetime
as
begin
Update tblCMSDepartmentName set FacultyID=@FacultyID,DepartmentName=@DepartmentName,Status=@Status,UpdatedDAte=@UpdatedDAte where DepartmentID=@DepartmentID
End



alter Procedure ViewAllCMSDepartment
as
begin
select TDN.*,TFN.* from tblCMSDepartmentName TDN inner join tblCMSFacultyName TFN on TDN.FacultyID=TFN.FacultyID  
End

Create Procedure ViewCMSDepartmentByID
@DepartmentID int
as
begin
select * from tblCMSDepartmentName where DepartmentID=@DepartmentID
End

Create Procedure CMSAlreadyExistDepartment
 @FacultyID int,
 @DepartmentName nvarchar(100)
as
begin
select * from tblCMSDepartmentName where FacultyID=FacultyID and DepartmentName=@DepartmentName
End


Create procedure UpdateStatusCMSDepartment
@DepartmentID int,
 @Status nvarchar(50)
as
Begin
Update tblCMSDepartmentName set Status=@Status where DepartmentID=@DepartmentID
End


create procedure ViewAllCMSFaculty
as
Begin
select * from tblCMSFacultyName
End
