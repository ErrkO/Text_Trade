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
    #region data fields
   // each Trader is an Account, but has a class shedule, a watch list - list of listings of interest, and a sell list - list of listings posted for sale
    private ClassSchedule class_schedule;
    private WatchList watch_list;
    private SellList sell_list;
    private int warnings;
    #endregion

    #region Property fields

    public ClassSchedule Class_Schedule   
    {
		get
        {
            return this.class_schedule;
        }

        set { this.class_schedule = value; }
	}

    public int Warnings
    {

        get { return this.warnings; }

        set { this.warnings = value; }

    }

	public WatchList Watch_List
	{
		get
        {
            return this.watch_list;
        }
	}

    public SellList Sell_List
    {
        get
        {
            return this.sell_list;
        }
    }
    #endregion

    #region methods
    
    public Trader() : base()    //default constructor
    {

    }

    public Trader(string uName, string pWord) : base(uName, pWord)
    {
        ClassSchedule class_schedule = new ClassSchedule();
        ListingList watch_list = new ListingList();
        ListingList sell_list = new ListingList();
    }

    //constructor
    public Trader(string uName, string pWord, string fName, string lName, string eMail, int traderid = -1) : base(uName, pWord, fName, lName, eMail, traderid)
    {
        ClassSchedule class_schedule = new ClassSchedule();
        ListingList watch_list = new ListingList();
        ListingList sell_list = new ListingList();
    }

    public void CreateListing(/*string listingTitle,*/ string title, string author, string edition, string isbn,  Course class_course, Condition condition, double price)
	{
        Listing a_listing = new Listing(/*listingTitle,*/ title, author, edition, isbn, class_course, condition, price);
        this.sell_list.AddToSellList(a_listing);
	}

	public void AddToWatchList(Listing a_listing) //add a listing of interest into Watch List
	{
            this.watch_list.AddToWatchList(a_listing); 
	}

    public virtual void AddClass(string cC, string cL) //keyword "virtual" since the method will be redefined in ClassSchedule class?
    {
        Course a_course = new Course(cC, cL);
        if (!this.class_schedule.schedule.Contains(a_course))
            this.class_schedule.AddClass(cC, cL);    //This will call the ClassSchedule AddClass method
    }

	public virtual void RemoveClass(Course a_course)      //Changed from EditSchedule()
	{
        this.class_schedule.RemoveClass(a_course);
	}

    public void RemoveListing(Listing a_listing)
    {                                                     // it shouldnt be virtual only the base class function needs to be virtual for inheritance and both trader and mod
        this.sell_list.RemoveFromSellList(a_listing);     // inherit from account
    }

    public virtual void RemoveFromWatchList(Listing a_listing)
	{
       this.watch_list.RemoveFromWatchList(a_listing);
    }

    public void ReportListing(Listing a_listing)
	{
		//need to have an array-like structure to store the reported listings. perhaps should be passed by reference. 
        //the Moderator shall have access to this structure
	}

    public void ReportUser(Trader trader)
    {
        //need to have an array-like structure to store the trader.UserName entries sent by Traders
        //the Moderator shall have access to this structure
    }
    #endregion
}

