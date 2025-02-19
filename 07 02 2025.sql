
select * from sys.tables

Create table tblPmistCMSLogin(LID int identity(1,1) primary key,Username nvarchar(100),Password Nvarchar(100),Status Bit,EmailID nvarchar(256),Role Nvarchar(100),AddedBy nvarchar(80),AddeDatetime Datetime,UpdatedBy nvarchar(80),UpdatedDatetime Datetime,)


select * from tblPmistCMSLogin

Create Procedure CheckPmistCMSLogin
@Username nvarchar(100),
@Password Nvarchar(100)
As
Begin
select * from tblPmistCMSLogin where Username=@Username and Password=@Password
End

exec CheckPmistCMSLogin
@Username='AdminCms2025',
@Password='Xvc2LxgFqz95zHkaPa3ghQ=='

truncate table tblPmistCMSLogin

update tblPmistCMSLogin set Status=1

insert into tblPmistCMSLogin (Username,Password,Status,AddeDatetime) Values('AdminCms2025','Q21zQFBhc3N3b3JkMjAyNQ==','1',GETDATE())



sp_helptext ViewAllFAQs

    
CREATE PROCEDURE ViewAllFAQs            
    @Department NVARCHAR(50),    
    @FAQID INT = NULL,    
    @QStatus BIT = NULL    
AS            
BEGIN              
    SET NOCOUNT ON;               
    
    DECLARE @SQL NVARCHAR(MAX);              
    DECLARE @ParameterDef NVARCHAR(MAX);                  
    SET @ParameterDef = '@Department NVARCHAR(50), @FAQID INT, @QStatus BIT';              
    
    SET @SQL = 'SELECT * FROM tblPMISTFAQ WHERE 1=1';                          
    
    -- Add conditions dynamically    
    IF @FAQID IS NOT NULL AND  @FAQID <>''             
        SET @SQL = @SQL + ' AND FAQID = @FAQID' ;              
    
    IF @QStatus IS NOT NULL      
        SET @SQL = @SQL + ' AND QStatus = @QStatus';              
    
    IF @Department IS NOT NULL AND @Department <> ''              
        SET @SQL = @SQL + ' AND Department = @Department';              
    
    SET @SQL = @SQL + ' ORDER BY AddedDate DESC, FAQID DESC';              
              
    -- Execute the dynamic SQL query with parameters    
    EXEC sp_executesql     
        @SQL,             
        @ParameterDef,             
        @Department = @Department,    
        @FAQID = @FAQID,    
        @QStatus = @QStatus;    
END;    