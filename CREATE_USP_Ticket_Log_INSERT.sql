IF EXISTS (SELECT * FROM sysobjects WHERE name = 'CREATE_USP_Ticket_Log_INSERT')
	DROP PROCEDURE [dbo].CREATE_USP_Ticket_Log_INSERT
GO

CREATE PROCEDURE [dbo].CREATE_USP_Ticket_Log_INSERT
(
	@Ticket_Title varchar(50),
	@Ticket_Description varchar(256),
	@Ticket_Category bigint,
	@Create_Date datetime
)
AS
	SET NOCOUNT OFF;
INSERT INTO [Ticket_Log] ([Ticket_Title], [Ticket_Description], [Ticket_Category], [Create_Date]) VALUES (@Ticket_Title, @Ticket_Description, @Ticket_Category, @Create_Date);
	