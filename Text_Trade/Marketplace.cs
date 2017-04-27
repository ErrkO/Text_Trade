﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Eric TODO

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class Marketplace
{

    public const int LISTINGLIFE = 30;

    private int listingLifetime;
    private List<Listing> listings;
    private DataBase db = new DataBase();

	public int ListingLifeTime
	{

		get { return this.listingLifetime; }
		set { this.listingLifetime = value; }

    }

	public List<Listing> Listing
	{

		get { return this.listings; }

    }

	public virtual void RenewListing(Listing listing)
	{

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            conn.Open();

            string sql;

            if (listing.Listing_id == -1)
            {

                sql = "UPDATE [UserList] "
                        + "SET listinglife = 30"
                        + "WHERE listing_id = @lid";

            }

            else
            {

                sql = "UPDATE [UserList] "
                        + "SET listinglife = 30"
                        + "WHERE listing_id = @lid";

            }

            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("lid", listing.Listing_id);

            command.ExecuteNonQuery();

        }

	}

	public virtual void AddListing(Listing listing,int trader_id)
	{

        listing.CreateListing(trader_id);

	}

	public virtual void RemoveListing(Listing listing)
	{
        db.Delete("listings", "listing_id", listing.Listing_id);
	}

	public virtual void FilterResults()
	{
		throw new System.NotImplementedException();
	}

	public List<Listing> SearchAll()
	{

        List<Listing> listings;

        listings = db.SearchFor();

        return listings;

	}

	public List<Listing> SearchByAuthor(string author)
	{

        List<Listing> listings;

        listings = db.SearchFor("author",author);

        return listings;

    }

	public List<Listing> SearchByCourse(string cC, string cL)
	{

        List<Listing> listings;

        listings = db.SearchFor("courseCode",cC,"courseLevel",cL);

        return listings;

    }

	public List<Listing> SearchByISBN(string isbn)
	{

        List<Listing> listings;

        listings = db.SearchFor("isbn",isbn);

        return listings;

    }

	public List<Listing> SearchFromSchedule(ClassSchedule classSchedule)
	{

        List<Listing> listings;

        listings = db.SearchFor();

        return listings;

    }

}

