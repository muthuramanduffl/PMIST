


select * from sys.tables
select * from sys.procedures





Create table tblPMISTPlacement  (PID int identity(1,1),Department Nvarchar(60),Content nvarchar(max),PStatus BIT,AddedDate datetime,AddedBy nvarchar(60),UpdatedDate datetime,UpdatedBy nvarchar(60))
drop table tblPMISTPlacement


select * from tblPMISTPlacement




Create Procedure AddPMISTplacements
@Department Nvarchar(60),
@Content nvarchar(max),
@PStatus BIT,
@AddedDate datetime,
@AddedBy nvarchar(60)
As
Begin
Insert into tblPMISTPlacement (Department,Content,Pstatus,Addeddate,Addedby) Values(@Department,@Content,@Pstatus,@Addeddate,@Addedby)
End



Create Procedure UpdatePMISTplacements
@PID int,
@Department Nvarchar(60),
@Content nvarchar(max),
@PStatus BIT,
@UpdatedDate datetime,
@UpdatedBy nvarchar(60)
As
Begin
Update  tblPMISTPlacement set Department=@Department,Content=@Content,Pstatus=@Pstatus,UpdatedDate=@UpdatedDate,UpdatedBy=@UpdatedBy where PID=@PID 
End



Create procedure DeletePMISTPlacementsByID
@PID int
As
Begin
Delete  tblPMISTPlacement where PID=@PID
End




Create Procedure ViewAllPlacements
@PID int,
@Department Nvarchar(60),
@PStatus BIT
AS            
BEGIN              
    SET NOCOUNT ON;               
    
    DECLARE @SQL NVARCHAR(MAX);              
    DECLARE @ParameterDef NVARCHAR(MAX);                  
    SET @ParameterDef = '@Department NVARCHAR(60), @PID INT, @PStatus BIT';              
    
    SET @SQL = 'SELECT * FROM tblPMISTPlacement WHERE 1=1';                          
    
    -- Add conditions dynamically    
    IF @PID IS NOT NULL AND  @PID <>''             
        SET @SQL = @SQL + ' AND PID = @PID' ;              
    
    IF @PStatus IS NOT NULL      
        SET @SQL = @SQL + ' AND PStatus = @PStatus';              
    
    IF @Department IS NOT NULL AND @Department <> ''              
        SET @SQL = @SQL + ' AND Department = @Department';              
    
    SET @SQL = @SQL + ' ORDER BY AddedDate DESC, PID DESC';              
              
    -- Execute the dynamic SQL query with parameters    
    EXEC sp_executesql     
        @SQL,             
        @ParameterDef,             
        @Department = @Department,    
        @PID = @PID,    
        @PStatus = @PStatus;  
        End




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