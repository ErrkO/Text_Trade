CREATE TABLE [dbo].[TraderList]
(
	[trader_id] INT NOT NULL IDENTITY(1,1), 
    [username] VARCHAR(100) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [deleted] INT NOT NULL DEFAULT 0, 
    [classSchedule] VARCHAR(100) NULL, 
    [warnings] INT NOT NULL DEFAULT 0
	PRIMARY KEY CLUSTERED ([trader_id] ASC), 
    [firstname] VARCHAR(50) NOT NULL, 
    [lastname] VARCHAR(50) NOT NULL, 
    [email] VARCHAR(50) NOT NULL

)