﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trader : Account
{
	public virtual ClassSchedule classSchedule
	{
		get;
		set;
	}

	public virtual Account account
	{
		get;
		set;
	}

	public virtual ClassSchedule <<Struct>> ClassSchedule
	{
		get;
		set;
	}

	public virtual TraderView TraderView
	{
		get;
		set;
	}

	public virtual UserList UserList
	{
		get;
		set;
	}

	public virtual WatchList WatchList
	{
		get;
		set;
	}

	public virtual IEnumerable<Listing> Listing
	{
		get;
		set;
	}

	public virtual Search Search
	{
		get;
		set;
	}

	public virtual void CreateListing(string title, string author, string edition, string isbn, string cC, string cL, string condition, double price)
	{
		throw new System.NotImplementedException();
	}

	public virtual void AddToWatchList(Listing listing)
	{
		throw new System.NotImplementedException();
	}

	public virtual void ChangePassword(string pass)
	{
		throw new System.NotImplementedException();
	}

	public virtual void RemoveListing(Listing listing)
	{
		throw new System.NotImplementedException();
	}

	public virtual void AddToSellList(Listing lsiting)
	{
		throw new System.NotImplementedException();
	}

	public virtual void ReportUser(Listing listing)
	{
		throw new System.NotImplementedException();
	}

	public virtual void CreateClassSchedule()
	{
		throw new System.NotImplementedException();
	}

	public virtual void AddClass(string cC, string cL)
	{
		throw new System.NotImplementedException();
	}

	public virtual void EditSchedule()
	{
		throw new System.NotImplementedException();
	}

	public virtual void RemoveFromWatchList(Listing listing)
	{
		throw new System.NotImplementedException();
	}

	public virtual void ReportListing(Listing listing)
	{
		throw new System.NotImplementedException();
	}

}
