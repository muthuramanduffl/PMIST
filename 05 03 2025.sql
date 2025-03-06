



SP_HELPTEXT UpdateFAQ


  
Alter Procedure UpdateFAQ  
@FAQID int,  
@Department nvarchar(50),  
@QStatus Bit,  
@Quetion nvarchar(max),  
@Answer nvarchar(max),  
@UpdatedDate Datetime,  
@UpdatedBy nvarchar(50)  
As  
Begin  
Update tblPMISTFAQ set Department=@Department,QStatus=@QStatus,Quetion=@Quetion,Answer=@Answer,UpdatedDate=@UpdatedDate,UpdatedBy=@UpdatedBy where FAQID=@FAQID  
End


SELECT * FROM tblPMISTFAQ


sp_help tblPMISTFAQ




sp_helptext UpdateStatusCMSDepartment


Create procedure UpdateStatusCMSDepartment  
@DepartmentID int,  
 @Status nvarchar(50)  
as  
Begin  
Update tblCMSDepartmentName set Status=@Status where DepartmentID=@DepartmentID  
End  



select * from tblCMSDepartmentName


Update tblCMSDepartmentName set DepartmentName='department-of-Informatics' where DepartmentID='4'
Update tblCMSDepartmentName set DepartmentName='Department-of-Electronics-And-Communication' where DepartmentID='11'






sp_helptext Deletecentrecontenttype1ByID


Create procedure Deletecentrecontenttype1ByID  
@TCCID int  
As  
Begin  
Delete tblcentrecontenttype1 where TCCID=@TCCID  
End


select * from tblcentrecontenttype1



select * from sys.tables

sp_helptext viewAlltblcentrenames



Insert into tblname (cloumn1,column2) Values('value1','value2')
  
CREATE procedure viewAlltblcentrenames  
As  
Begin  
select * from tblcentrenames where Centrestatus=1  
ENd


sp_helptext Updatecentrecontenttype1


  
CREATE procedure Updatecentrecontenttype1    
@TCCID int,    
@CentreID nvarchar(60),    
@Title nvarchar(260),@Content nvarchar(max),    
@DisplayStatus Bit,@Cname_one nvarchar(200),    
@Designamtion_one nvarchar(200),    
@Mobilenumber_one nvarchar(200),    
@EmailID_one nvarchar(256),    
@Cname_two nvarchar(200),    
@Designamtion_two nvarchar(200),    
@Mobilenumber_two nvarchar(200),    
@EmailID_two nvarchar(256),    
@Cname_three nvarchar(200),    
@Designamtion_three nvarchar(200),    
@Mobilenumber_three nvarchar(200),    
@EmailID_three nvarchar(256),    
@Imges Nvarchar(256),    
@PageType nvarchar(256),    
@Address_one nvarchar(200),  
@Address_two nvarchar(200),  
@Address_three nvarchar(200),  
@UpdatedBy nvarchar(60),    
@updatedDate Datetime    
As    
Begin    
UPDATE tblcentrecontenttype1    
SET    
    CentreID = @CentreID,    
    Title = @Title,    
    Content = @Content,    
    DisplayStatus = @DisplayStatus,    
    Cname_one = @Cname_one,    
    Designamtion_one = @Designamtion_one,    
    Mobilenumber_one = @Mobilenumber_one,    
    EmailID_one = @EmailID_one,    
    Cname_two = @Cname_two,    
    Designamtion_two = @Designamtion_two,    
    Mobilenumber_two = @Mobilenumber_two,    
    EmailID_two = @EmailID_two,    
    Cname_three = @Cname_three,    
    Designamtion_three = @Designamtion_three,    
    Mobilenumber_three = @Mobilenumber_three,    
    EmailID_three = @EmailID_three,    
    Imges = @Imges,    
    PageType = @PageType,   
    Address_one=@Address_one,  
Address_two=@Address_two,  
Address_three=@Address_three,  
    UpdatedBy = @UpdatedBy,    
    updatedDate = @updatedDate    
WHERE     
TCCID=@TCCID    
End


select * from tblcentrecontenttype1











sp_helptext Updatecentrecontenttype1

    
CREATE Procedure AddPMISTplacements    
@Department Nvarchar(60),    
@Content nvarchar(max),    
@PStatus BIT,  
@PageName nvarchar(200)=null,  
@AddedDate datetime,    
@AddedBy nvarchar(60)    
As    
Begin    
Insert into tblPMISTPlacement (Department,Content,PageName,Pstatus,Addeddate,Addedby) Values(@Department,@Content,@PageName,@Pstatus,@Addeddate,@Addedby)    
End


select * from tblPMISTPlacement






sp_helptext AddDepartmentActivities


CREATE Procedure AddDepartmentActivities    
@Department nvarchar(100),    
@Title nvarchar(200),    
@ActivitiyStatus Bit,    
@PdfFilename nvarchar(256),    
@Content nvarchar(max),  
@AVI BIT,  
@AddedBy nvarchar(60),    
@Addedate Datetime    
As    
Begin    
Insert Into tblDepartmentActivities(Department,Title,ActivitiyStatus,PdfFilename,Content,AVI,AddedBy,Addedate) Values(@Department,@Title,@ActivitiyStatus,@PdfFilename,@Content,@AVI,@AddedBy,@Addedate)    
End 



select * from tblDepartmentActivities



  
CREATE procedure Updatecentrecontenttype1    
@TCCID int,    
@CentreID nvarchar(60),    
@Title nvarchar(260),@Content nvarchar(max),    
@DisplayStatus Bit,@Cname_one nvarchar(200),    
@Designamtion_one nvarchar(200),    
@Mobilenumber_one nvarchar(200),    
@EmailID_one nvarchar(256),    
@Cname_two nvarchar(200),    
@Designamtion_two nvarchar(200),    
@Mobilenumber_two nvarchar(200),    
@EmailID_two nvarchar(256),    
@Cname_three nvarchar(200),    
@Designamtion_three nvarchar(200),    
@Mobilenumber_three nvarchar(200),    
@EmailID_three nvarchar(256),    
@Imges Nvarchar(256),    
@PageType nvarchar(256),    
@Address_one nvarchar(200),  
@Address_two nvarchar(200),  
@Address_three nvarchar(200),  
@UpdatedBy nvarchar(60),    
@updatedDate Datetime    
As    
Begin    
UPDATE tblcentrecontenttype1    
SET    
    CentreID = @CentreID,    
    Title = @Title,    
    Content = @Content,    
    DisplayStatus = @DisplayStatus,    
    Cname_one = @Cname_one,    
    Designamtion_one = @Designamtion_one,    
    Mobilenumber_one = @Mobilenumber_one,    
    EmailID_one = @EmailID_one,    
    Cname_two = @Cname_two,    
    Designamtion_two = @Designamtion_two,    
    Mobilenumber_two = @Mobilenumber_two,    
    EmailID_two = @EmailID_two,    
    Cname_three = @Cname_three,    
    Designamtion_three = @Designamtion_three,    
    Mobilenumber_three = @Mobilenumber_three,    
    EmailID_three = @EmailID_three,    
    Imges = @Imges,    
    PageType = @PageType,   
    Address_one=@Address_one,  
Address_two=@Address_two,  
Address_three=@Address_three,  
    UpdatedBy = @UpdatedBy,    
    updatedDate = @updatedDate    
WHERE     
TCCID=@TCCID    
End




select * from tblcentrecontenttype1