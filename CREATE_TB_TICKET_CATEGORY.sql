IF NOT EXISTS (SELECT 1 FROM SYS.tables WHERE NAME = 'Ticket_Category' )
BEGIN

CREATE TABLE Ticket_Category (
Id [BIGINT] PRIMARY KEY IDENTITY NOT NULL ,
Category_Name [VARCHAR](50) NOT NULL 
) ON [PRIMARY] END