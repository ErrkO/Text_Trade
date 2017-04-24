//------------------------------------------------------------------------------
//A class representing a list of listings that the associated Trader account
//has saved for later viewing
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WatchList : DataBase
{
	public List<Listing> watch_list
    {
        get
        {
            return this.watch_list;
        }
        set
        {
            this.watch_list = value;
        }
	}

	public void AddToWatchList(Listing listing)
	{
        if (!this.watch_list.Contains(listing))
            this.watch_list.Add(listing);
	}

	public void RemoveFromWatchList(Listing listing)
	{
        this.watch_list.Remove(listing);
	}

}

