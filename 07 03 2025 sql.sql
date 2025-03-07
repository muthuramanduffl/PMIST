


sp_helptext UpdateResearchForResearches

  
alter Procedure UpdateResearchForResearches  
@RFID int ,  
@TitleContent nvarchar(200),
@ResearchType Nvarchar(100),  
@URL_AND_Notes nvarchar(200),  
@CStatus BIT,  
@UpdatedBy nvarchar(200),  
@UpdatedDate datetime  
As  
Begin  
Update tblResearchRFR set URL_AND_Notes=@URL_AND_Notes,TitleContent=@TitleContent, ResearchType=@ResearchType,CStatus=@CStatus,UpdatedBy=@UpdatedBy,UpdatedDate=@UpdatedDate where RFID=@RFID  
END

SELECT * FROM tblResearchRFR


sp_help tblResearchRFR



sp_helptext AddResearchForResearches


Alter Procedure AddResearchForResearches  
@ResearchType Nvarchar(100),  
@TitleContent nvarchar(200),
@URL_AND_Notes nvarchar(200),  
@CStatus BIT,  
@AddedBy nvarchar(100),  
@Addedate Datetime  
As  
Begin  
Insert into tblResearchRFR (ResearchType,TitleContent,URL_AND_Notes,CStatus,AddedBy,Addedate) Values(@ResearchType,@TitleContent,@URL_AND_Notes,@CStatus,@AddedBy,@Addedate)  
ENd  




sp_helptext viewAllcentrecontenttype1


Create Procedure viewAllcentrecontenttype1  
@CentreID nvarchar(60),  
@DisplayStatus Bit,  
@TCCID int  
As  
Begin  
  
  
   SET NOCOUNT ON;                   
        
    DECLARE @SQL NVARCHAR(MAX);                  
    DECLARE @ParameterDef NVARCHAR(MAX);                      
    SET @ParameterDef = '@CentreID nvarchar(60),@DisplayStatus Bit,@TCCID int';                  
        
    SET @SQL = 'SELECT * FROM tblcentrecontenttype1 WHERE 1=1';                              
        
    -- Add conditions dynamically        
    IF @TCCID IS NOT NULL AND  @TCCID <>''                 
        SET @SQL = @SQL + ' AND TCCID = @TCCID' ;                  
        
    IF @DisplayStatus IS NOT NULL          
        SET @SQL = @SQL + ' AND DisplayStatus = @DisplayStatus';                  
        
    IF @CentreID IS NOT NULL AND @CentreID <> ''                  
        SET @SQL = @SQL + ' AND CentreID = @CentreID';                  
        
    SET @SQL = @SQL + ' ORDER BY AddedDate DESC, TCCID DESC';                  
                  
    -- Execute the dynamic SQL query with parameters        
    EXEC sp_executesql         
        @SQL,                 
        @ParameterDef,                 
        @CentreID = @CentreID,        
        @TCCID = @TCCID,        
        @DisplayStatus = @DisplayStatus;      
  
ENd


sp_helptext viewAlltblcentrenames

  
CREATE procedure viewAlltblcentrenames  
As  
Begin  
select * from tblcentrenames where Centrestatus=1  
ENd


use PmistDbApplication

sp_help tblcentrecontenttype1