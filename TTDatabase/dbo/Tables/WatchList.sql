CREATE TABLE [dbo].[WatchList]
(
	[watchlist_id] INT NOT NULL PRIMARY KEY, 
    [listing_id] INT NOT NULL, 
    [trader_id] INT NOT NULL, 
    CONSTRAINT [FK_WatchList_TraderList] FOREIGN KEY ([trader_id]) REFERENCES [dbo].[TraderList] ([trader_id]), 
    CONSTRAINT [FK_WatchList_Listings] FOREIGN KEY ([listing_id]) REFERENCES [dbo].[Listings] ([listing_id])
)
