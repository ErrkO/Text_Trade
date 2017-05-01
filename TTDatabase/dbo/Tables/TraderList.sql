CREATE TABLE [dbo].[TraderList]
(
	[trader_id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [username] VARCHAR(100) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [deleted] BINARY(1) NOT NULL DEFAULT 0, 
    [classSchedule] VARCHAR(100) NULL, 
    [warnings] INT NOT NULL DEFAULT 0
)