select * from sys.tables
select * from tblcentrecontenttype1



sp_help tblcentrecontenttype1


sp_helptext viewAlltblcentrenames


  
CREATE procedure viewAlltblcentrenames  
As  
Begin  
select * from tblcentrenames where Centrestatus=1   
ENd  

CREATE procedure viewcentrenamesByID
@ID nvarchar(60)
As  
Begin  
select * from tblcentrenames where Centrestatus=1  and centreID=@ID 
ENd


sp_help tblcentrenames


select * from tblcentrecontenttype1


Create procedure UpdateimagesByID
@TCCID int,
@Imges Nvarchar(256) 
As
Begin
Update tblcentrecontenttype1 set Imges=@Imges where TCCID=@TCCID
End




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
    UpdatedBy = @UpdatedBy,  
    updatedDate = @updatedDate  
WHERE   
TCCID=@TCCID  
End