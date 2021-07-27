IF NOT EXISTS (SELECT 1 FROM SYS.tables WHERE NAME = 'Ticket_Deletion_Log' )
BEGIN

CREATE TABLE Ticket_Deletion_Log (
Ticket_Id  [BIGINT] NOT NULL ,
Ticket_Title [VARCHAR](50) NOT NULL ,
Ticket_Description [VARCHAR](256)  ,
Ticket_Category [BIGINT]   NOT NULL,
Create_Date [datetime]  NOT NULL ,
Delete_Requested_Date [datetime]  NOT NULL 
) ON [PRIMARY] 
END







