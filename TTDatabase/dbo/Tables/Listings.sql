CREATE TABLE [dbo].[Listings]
(
	[listing_id] INT NOT NULL IDENTITY(1,1), 
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
    [price] INT NOT NULL, 
    [listinglife] INT NOT NULL, 
    [trader_id] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([listing_id] ASC), 
    CONSTRAINT [FK_Listings_TraderList] FOREIGN KEY ([trader_id]) REFERENCES [dbo].[TraderList] (trader_id)
)
