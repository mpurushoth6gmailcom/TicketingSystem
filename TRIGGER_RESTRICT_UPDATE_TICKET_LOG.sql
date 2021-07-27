CREATE TRIGGER [dbo].[RestrictDeletionTrigger]
       ON [dbo].[Ticket_Log]
INSTEAD OF DELETE
AS
BEGIN
 BEGIN TRY
       SET NOCOUNT ON;
 
       DECLARE @Ticket_Id BIGINT
	   DECLARE @Ticket_Title [VARCHAR](50) 
       DECLARE @Ticket_Description [VARCHAR](256) 
	   DECLARE @Ticket_Category [BIGINT]  
	   DECLARE @Create_Date [datetime] 
       DECLARE @Delete_Requested_Date  [datetime] 
 
		 SELECT @Ticket_Id = DELETED.Ticket_Id   
			FROM DELETED
	     SELECT @Ticket_Title = DELETED.Ticket_Title   
			FROM DELETED
	     SELECT @Ticket_Description = DELETED.Ticket_Description   
			FROM DELETED
	     SELECT @Ticket_Category = DELETED.Ticket_Category   
			FROM DELETED
		SELECT @Create_Date = DELETED.Create_Date   
			FROM DELETED
		SET @Delete_Requested_Date = GETDATE();


       BEGIN
              INSERT INTO Ticket_Deletion_Log
              VALUES(@Ticket_Id,@Ticket_Title,@Ticket_Description,@Ticket_Category,@Create_Date,@Delete_Requested_Date)
       END
	       END TRY
    BEGIN CATCH
	     ROLLBACK
      END CATCH
END


