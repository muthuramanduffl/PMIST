






sp_helptext addcentrecontenttype1


CREATE procedure addcentrecontenttype1  
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
@AddedBy nvarchar(60),  
@AddedDate Datetime  
As  
Begin  
Insert into tblcentrecontenttype1(CentreID,Title,Content,DisplayStatus,Cname_one,Designamtion_one,Mobilenumber_one,EmailID_one,Cname_two,Designamtion_two,Mobilenumber_two,EmailID_two,Cname_three,Designamtion_three,Mobilenumber_three,EmailID_three,Imges,Pa
geType,AddedBy,AddedDate)Values(@CentreID,@Title,@Content,@DisplayStatus,@Cname_one,@Designamtion_one,@Mobilenumber_one,@EmailID_one,@Cname_two,@Designamtion_two,@Mobilenumber_two,@EmailID_two,@Cname_three,@Designamtion_three,@Mobilenumber_three,@EmailID_
three,@Imges,@PageType,@AddedBy,@AddedDate)  
End


sp_helptext viewAllcentrecontenttype1


select * from tblcentrecontenttype1


update tblcentrecontenttype1 set 


update tblcentrecontenttype1  set imges='3TluU.jpg,3AL6Q.jpg,Dj9l.jpg,opgF.jpg'




sp_helptext viewAlltblcentrenames


  
CREATE procedure viewAlltblcentrenames  
As  
Begin  
select * from tblcentrenames where Centrestatus=1  
ENd


truncate table tblcentrenames

insert into tblcentrenames (Centrename,Pagetype,Centrestatus,addedBy,Addeddate)Values('Centre name 1','type 1','1','admin',getdate()),('Centre name 2','type 2','1','admin',getdate()),('Centre name 3','type 3','1','admin',getdate())