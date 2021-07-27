IF NOT EXISTS (SELECT 1 FROM SYS.tables WHERE NAME = 'Ticket_Log' )
BEGIN

CREATE TABLE Ticket_Log (
Ticket_Id  [BIGINT] PRIMARY KEY IDENTITY NOT NULL ,
Ticket_Title [VARCHAR](50) NOT NULL ,
Ticket_Description [VARCHAR](256)  ,
Ticket_Category [BIGINT]   NOT NULL,
Create_Date [datetime]  NOT NULL 
CONSTRAINT FK_Ticket_Log_Ticket_Category FOREIGN KEY (Ticket_Category)
        REFERENCES DBO.Ticket_Category(Id) 
) ON [PRIMARY] 
END



