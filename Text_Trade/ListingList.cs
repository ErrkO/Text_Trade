﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// Eric ToDo
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class ListingList
{

    public DataBase db = new DataBase();
    public List<Listing> listinglist = new List<Listing>();

    public List<Listing> listingList
	{

		get { return this.listingList; }
        set { this.listingList = value; }

	}

    public string connString
    {

        get { return this.connString; }
        set { this.connString = db.ConnString; }

    }

    public List<Listing> SearchForAllListingsFromTrader(int traderid)
    {

        //int listingId = listing.Listing_id;

        using (SqlConnection conn = new SqlConnection())
        {

            conn.ConnectionString = db.ConnString;
            conn.Open();

            string query = "SELECT * FROM Listings WHERE trader_id = @traderid";

            using (SqlCommand command = new SqlCommand(query, conn))
            {

                command.Parameters.AddWithValue("traderid", traderid);

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {

                        Listing templisting = new Listing();

                        templisting.Listing_id = reader.GetInt32(0);
                        templisting.Title = reader.GetString(1);
                        templisting.Author = reader.GetString(2);
                        templisting.Edition = reader.GetString(3);
                        templisting.Isbn = reader.GetString(4);
                        string CCode = reader.GetString(5);
                        string CLevel = reader.GetString(6);
                        templisting._Course = new Course(CCode, CLevel);
                        templisting.LastUsed = reader.GetString(7);
                        Condition conditionstring = (Condition)Enum.Parse(typeof(Condition), reader.GetString(8));
                        templisting.Condition = conditionstring;
                        templisting.Description = reader.GetString(9);
                        templisting.Deleted = reader.GetInt32(10);
                        templisting.Price = reader.GetInt32(11);
                        templisting.Listinglife = reader.GetInt32(12);
                        templisting.Trader_id = reader.GetInt32(13);

                        listinglist.Add(templisting);

                    }

                }

            }

        }

        return listinglist;

    }

    public void CreateList()
    {

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            conn.Open();

            string query = "SELECT listing_id FROM ListingList";

            using (SqlCommand command = new SqlCommand(query, conn))
            {

                using (SqlDataReader dbreader = command.ExecuteReader())
                {

                    while (dbreader.Read())
                    {

                        //listinglist.Add(Convert.ToInt32(dbreader.GetString(0)));

                    }

                }

            }

        }

    }

}

