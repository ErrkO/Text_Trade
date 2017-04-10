CREATE TABLE [dbo].[ListingList]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [title] VARCHAR(100) NOT NULL, 
    [author] VARCHAR(100) NOT NULL, 
    [edition] VARCHAR(100) NOT NULL, 
    [isbn] VARCHAR(13) NOT NULL, 
    [courseCode] VARCHAR(4) NOT NULL, 
    [courseLevel] VARCHAR(4) NOT NULL, 
    [lastUsed] VARCHAR(50) NULL, 
    [condition] VARCHAR(50) NOT NULL, 
    [description] VARCHAR(1000) NULL, 
    [deleted] BINARY(1) NOT NULL
)
