CREATE TABLE [dbo].[Listings]
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
    [deleted] BINARY(1) NOT NULL, 
    [price] SMALLINT NOT NULL, 
    [listinglife] DATETIME NOT NULL, 
    [trader_id] INT NOT NULL, 
    CONSTRAINT [FK_Listings_TraderList] FOREIGN KEY ([trader_id]) REFERENCES [dbo].[TraderList] (trader_id)
)
