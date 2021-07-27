IF EXISTS (SELECT * FROM sysobjects WHERE name = 'CREATE_USP_Ticket_Log_UPDATE')
	DROP PROCEDURE [dbo].CREATE_USP_Ticket_Log_UPDATE
GO

CREATE PROCEDURE [dbo].CREATE_USP_Ticket_Log_UPDATE
(
	@Ticket_Title varchar(50),
	@Ticket_Description varchar(256),
	@Ticket_Category bigint,
	@Create_Date datetime,
	@Ticket_Id bigint
)
AS
	SET NOCOUNT OFF;
UPDATE [Ticket_Log] SET [Ticket_Title] = @Ticket_Title, [Ticket_Description] = @Ticket_Description, [Ticket_Category] = @Ticket_Category, [Create_Date] = @Create_Date 
WHERE [Ticket_Id] = @Ticket_Id;
	
