CREATE TABLE [dbo].[Marketplace]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [listing_id] INT NOT NULL, 
    CONSTRAINT [FK_Marketplace_Listings] FOREIGN KEY ([listing_id]) REFERENCES [dbo].[Listings] ([listing_id])
)
