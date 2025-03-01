


sp_helptext addcentrecontenttype1


Alter procedure addcentrecontenttype1  
@CentreID nvarchar(60),  
@Title nvarchar(260),  
@Content nvarchar(max),  
@DisplayStatus Bit,  
@Cname_one nvarchar(200),  
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
@AddedBy nvarchar(60),  
@AddedDate Datetime  
As  
Begin  
Insert into tblcentrecontenttype1(CentreID,Title,Content,DisplayStatus,Cname_one,Designamtion_one,Mobilenumber_one,EmailID_one,Cname_two,Designamtion_two,Mobilenumber_two,EmailID_two,Cname_three,Designamtion_three,Mobilenumber_three,EmailID_three,Imges,PageType,Address_one,Address_two,Address_three,AddedBy,AddedDate)Values(@CentreID,@Title,@Content,@DisplayStatus,@Cname_one,@Designamtion_one,@Mobilenumber_one,@EmailID_one,@Cname_two,@Designamtion_two,@Mobilenumber_two,@EmailID_two,@Cname_three,@Designamtion_three,@Mobilenumber_three,@EmailID_three,@Imges,@PageType,@Address_one,@Address_two,@Address_three,@AddedBy,@AddedDate)  
End


sp_helptext Updatecentrecontenttype1


Alter procedure Updatecentrecontenttype1  
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

sp_help tblcentrecontenttype1


Create Procedure ExistcentreIsalreadyexistByCentreID
@TCCID int,
@CentreID nvarchar(60)
As
Begin

SELECT *  
            FROM tblcentrecontenttype1  
            WHERE @CentreID = @CentreID  
            AND (@TCCID IS NULL OR TCCID !=@TCCID)
End


exec ExistcentreIsalreadyexistByCentreID
@TCCID =null,
@CentreID ='3'





sp_helptext AddDepartmentActivities


Alter Procedure AddDepartmentActivities  
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

truncate table tblDepartmentActivities


alter table tblDepartmentActivities add AVI BIT




sp_helptext UpdateDepartmentActivities


  
Alter Procedure UpdateDepartmentActivities  
@ACTID Int,  
@Department nvarchar(100),  
@Title nvarchar(200),  
@ActivitiyStatus Bit,  
@PdfFilename nvarchar(256),  
@Content nvarchar(max),
@UpdatedBy nvarchar(60),  
@UpdatedDate Datetime  
As  
Begin  
  
Update tblDepartmentActivities set Department=@Department,Title=@Title,ActivitiyStatus=@ActivitiyStatus,PdfFilename=@PdfFilename,Content=@Content,UpdatedBy=@UpdatedBy,UpdatedDate=@UpdatedDate  where ACTID=@ACTID  
  
End 


select * from tblDepartmentActivities