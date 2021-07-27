IF EXISTS (SELECT * FROM sysobjects WHERE name = 'CREATE_USP_Ticket_Log_DELETE')
	DROP PROCEDURE [dbo].CREATE_USP_Ticket_Log_DELETE
GO

CREATE PROCEDURE [dbo].CREATE_USP_Ticket_Log_DELETE
(
	@Ticket_Id bigint
)
AS
	SET NOCOUNT OFF;
DELETE FROM [Ticket_Log] WHERE ([Ticket_Id] = @Ticket_Id)
GO

