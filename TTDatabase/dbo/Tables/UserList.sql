﻿CREATE TABLE [dbo].[UserList]
(
	[user_Id] INT NOT NULL PRIMARY KEY, 
    [username] NVARCHAR(100) NOT NULL, 
    [password] VARCHAR(50) NOT NULL, 
    [deleted] BINARY(1) NOT NULL, 
    [classSchedule] NCHAR(10) NULL
)