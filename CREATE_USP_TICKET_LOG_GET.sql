IF EXISTS (SELECT * FROM sysobjects WHERE name = 'CREATE_USP_Ticket_Log_GET')
	DROP PROCEDURE [dbo].CREATE_USP_Ticket_Log_GET
GO
CREATE PROCEDURE [dbo].CREATE_USP_Ticket_Log_GET
AS
	SET NOCOUNT ON;
SELECT * from Ticket_Log
GO