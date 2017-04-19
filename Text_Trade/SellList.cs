//------------------------------------------------------------------------------
//A class representing a list of listings that the associated Trader account
//has posted
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SellList
{
	public List<Listing> sell_list
	{
		get
        {
            return this. sell_list;
        }
		set
        {
            this.sell_list = value;
        }
	}

	public virtual void AddToSellList(Listing listing)
	{
        if (!this.sell_list.Contains(listing))
            this.sell_list.Add(listing);
	}

	public virtual void RemoveFromSellList(Listing listing)
	{
        this.sell_list.Remove(listing);
	}

}

