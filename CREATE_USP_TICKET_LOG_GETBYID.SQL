IF EXISTS (SELECT * FROM sysobjects WHERE name = 'CREATE_USP_Ticket_Log_GET_BY_ID')
	DROP PROCEDURE [dbo].CREATE_USP_Ticket_Log_GET_BY_ID
GO
CREATE PROCEDURE [dbo].CREATE_USP_Ticket_Log_GET_BY_ID(
@Id bigint)
AS
	SET NOCOUNT ON;
SELECT * from Ticket_Log WHERE Ticket_Id = @Id 
GO
