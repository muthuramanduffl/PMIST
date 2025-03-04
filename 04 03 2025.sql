


sp_helptext AddPMISTplacements

  
Alter Procedure AddPMISTplacements  
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


Alter table tblPMISTPlacement add PageName nvarchar(200)



sp_helptext UpdatePMISTplacements


Alter Procedure UpdatePMISTplacements  
@PID int,  
@Department Nvarchar(60),  
@Content nvarchar(max),  
@PageName nvarchar(200)=null,
@PStatus BIT,  
@UpdatedDate datetime,  
@UpdatedBy nvarchar(60)  
As  
Begin  
Update  tblPMISTPlacement set Department=@Department,Content=@Content,Pstatus=@Pstatus,PageName=@PageName,UpdatedDate=@UpdatedDate,UpdatedBy=@UpdatedBy where PID=@PID   
End




sp_helptext ViewAllPlacements


Alter Procedure ViewAllPlacements  
@PID int,  
@Department Nvarchar(60),  
@PStatus BIT ,
@PageName nvarchar(200)

AS              
BEGIN                
    SET NOCOUNT ON;                 
      
    DECLARE @SQL NVARCHAR(MAX);                
    DECLARE @ParameterDef NVARCHAR(MAX);                    
    SET @ParameterDef = '@Department NVARCHAR(60), @PID INT, @PStatus BIT,@PageName nvarchar(200)';                
      
    SET @SQL = 'SELECT * FROM tblPMISTPlacement WHERE 1=1';                            
      
    -- Add conditions dynamically      
    IF @PID IS NOT NULL AND  @PID <>''               
        SET @SQL = @SQL + ' AND PID = @PID' ;                
      
    IF @PStatus IS NOT NULL        
        SET @SQL = @SQL + ' AND PStatus = @PStatus';                
      
    IF @Department IS NOT NULL AND @Department <> ''                
        SET @SQL = @SQL + ' AND Department = @Department'; 
        

         IF @PageName  IS NOT NULL AND @PageName <> ''                
        SET @SQL = @SQL + ' AND PageName  = @PageName';        
        
       
      
    SET @SQL = @SQL + ' ORDER BY AddedDate DESC, PID DESC';                
                
    -- Execute the dynamic SQL query with parameters      
    EXEC sp_executesql       
        @SQL,               
        @ParameterDef,               
        @Department = @Department,      
        @PID = @PID,     
        @PageName=@PageName,
        @PStatus = @PStatus;    
        End  


        exec ViewAllPlacements
         @Department = '',      
        @PID = '',     
        @PageName='',
        @PStatus = '1';




        Update tblPMISTPlacement set PageName='placement' where 




        sp_helptext AddCMSDepartment


          
Create Procedure AddCMSDepartment  
 @FacultyID int,  
 @Status nvarchar(50),  
 @DepartmentName nvarchar(100),  
 @AddedDate datetime  
as  
begin  
Insert into tblCMSDepartmentName (FacultyID,DepartmentName,Status,AddedDate) Values (@FacultyID,@DepartmentName,@Status,@AddedDate)  
End



select * from tblCMSDepartmentName