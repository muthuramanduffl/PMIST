

Create table tblCMSDeptpo(Sno int identity(1,1),Department int,Introduction nvarchar(200),SectionName nvarchar(100),Content nvarchar(Max),PDFName nvarchar(200),Addeddate datetime,Updateddate datetime)



alter table tblCMSDeptpo alter column PDFName nvarchar(Max)

alter table tblCMSDeptpo add curriculum nvarchar(max)

truncate table tblCMSDeptpo

select * from tblCMSDeptpo

sp_help tblCMSDeptpo


Create procedure AddCMSCoursesProgrammedoffered
@DeptID int,
@Sectionname nvarchar(50),
@Content nvarchar(max),
@Addeddate datetime
as
begin

Insert into tblCMSDeptpo(Department,SectionName,Content,Addeddate) Values(@DeptID,@SectionName,@Content,@Addeddate)
End






Create procedure AddCMSCoursesPo
@DeptID int,
@Sectionname nvarchar(50),
@Introduction nvarchar(Max),
@Content nvarchar(max),
@Addeddate datetime
as
begin
Insert into tblCMSDeptpo(Department,SectionName,Introduction,Content,Addeddate) Values(@DeptID,@SectionName,@Introduction,@Content,@Addeddate)
End

Create procedure AddCMSCoursesPDF
@DeptID int,
@Sectionname nvarchar(50),
@PDFName nvarchar(Max),
@curriculum  nvarchar(max),
@Addeddate datetime
as
begin
Insert into tblCMSDeptpo(Department,SectionName,curriculum,PDFName,Addeddate) Values(@DeptID,@SectionName,@curriculum,@PDFName,@Addeddate)
End





