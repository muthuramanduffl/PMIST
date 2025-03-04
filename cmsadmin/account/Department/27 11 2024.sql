select * from tblCMSdeptpo

truncate table tblCMSdeptpo

sp_help tblCMSdeptpo

select * from sys.tables tblCMSDepartments



sp_help tblCMSdeptpo


Department of Computer Science and Engineering
Department of Architecture
Department of Aerospace Engineering
Department of Mechanical Engineering
Department of Bio-Technology
Research
General
General
Department of Computer Science and Engineering
Department of Computer Science and Engineering
Department of Software Engineering
Department of Architecture
Department of Bio-Technology
Department of Bio-Technology
Department of Aerospace Engineering
Department of Aerospace Engineering
Department of Electronics and Communication Engineering
Department of Electronics and Communication Engineering
Department of Electronics and Communication Engineering
Department of Electrical and Electronics Engineering
Department of Electrical and Electronics Engineering
Department of Electrical and Electronics Engineering
Department of Political Science
Department of Political Science
Department of Civil Engineering
Department of Civil Engineering
Department of Mechanical Engineering
Department of Mechanical Engineering
Department of Computer Science & Application
Department of Computer Science & Application
Department of Computer Science & Application
Department of Software Engineering
Department of Software Engineering
Department of Education
Department of Education
Department of Education
Department of Management Studies
Department of Management Studies
Department of Management Studies
Department of Commerce
Department of Commerce
Department of Commerce
Department of Social Work
Department of English
Department of English
Department of English
Department of Mathematics
Department of Mathematics
Department of Chemistry
Department of Computer Science and Engineering

sp_helptext AddCMSDepartment



Insert into tblCMSDepartmentName (FacultyID,DepartmentName,Status,AddedDate) Values ('4','Department of Management Studies','1',GETDATE())  

truncate table tblCMSDepartmentName


update tblCMSDepartmentName set FacultyID='5' where DepartmentID in ('22','16','17','18','19','3','20','21')
update tblCMSDepartmentName set FacultyID='1' where DepartmentID in ('1','4','5','6')
update tblCMSDepartmentName set FacultyID='6' where DepartmentID in ('7','8','9','10','11','12','13')
update tblCMSDepartmentName set FacultyID='3' where DepartmentID in ('14')
update tblCMSDepartmentName set FacultyID='2' where DepartmentID in ('2')




select * from tblCMSDepartmentName
select * from tblDepartmentCareers

insert into 

  
Create Procedure AddCMSDepartment  
 @FacultyID int,  
 @Status nvarchar(50),  
 @DepartmentName nvarchar(100),  
 @AddedDate datetime  
as  
begin  
Insert into tblCMSDepartmentName (FacultyID,DepartmentName,Status,AddedDate) Values (@FacultyID,@DepartmentName,@Status,@AddedDate)  
End


sp_helptext ViewAllCMSFaculty

select * from tblCMSFacultyName  



AddCMSCoursesProgrammedoffered


  
  
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




sp_helptext AddCMSCoursesPo

sp_helptext AddCMSCoursesPDF


alter procedure AddCMSCoursesPDF  
@DeptID int,  
@Sectionname nvarchar(50),  
@PDFName nvarchar(Max),  
@Content nvarchar(max), 
@Addeddate datetime  
as  
begin  
Insert into tblCMSDeptpo(Department,SectionName,Content,PDFName,Addeddate) Values(@DeptID,@SectionName,@Content,@PDFName,@Addeddate)  
End



sp_helptext UpdateCMSDEpartmentCoursesWithcurriculum

alter Procedure UpdateCMSDEpartmentCoursesWithcurriculum  
@Sno int,   
@PDFName nvarchar(Max),  
@Content nvarchar(max), 
@Updateddate datetime  
As  
Begin  
Update tblCMSDeptpo set PDFName=@PDFName,Content=@Content,Updateddate=@Updateddate where Sno=@Sno   
End


alter table tblCMSDeptpo drop column curriculum



sp_helptext ViewAllCMSDepartment

alter Procedure ViewAllCMSDepartment  
as  
begin  
select top 22 TDN.*,TFN.* from tblCMSDepartmentName TDN inner join tblCMSFacultyName TFN on TDN.FacultyID=TFN.FacultyID     ORDER BY   TDN.DepartmentID;
End

 SELECT TOP 22
        TDN.DepartmentID, 
        TDN.DepartmentName
    FROM 
        tblCMSDepartmentName TDN
    ORDER BY 
        TDN.DepartmentID;



        select * from tblCMSDepartmentName