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

public class UserList : DataBase
{

    private DataBase db = new DataBase();

	public virtual void Add(Trader trader)
	{

        using (SqlConnection conn = new SqlConnection())
        {

            conn.ConnectionString = db.ConnString;
            conn.Open();

            string sql;
            sql = "INSERT into [UserList] (username, password, deleted, classschedule) " 
                + "VALUES ( @uname , @pword, 0, @CSched";


            +trader.UserName + ", " + trader.Password + ", 0, " + trader.Class_Schedule

        }

	}

	public virtual UserList SearchForUser()
	{
		throw new System.NotImplementedException();
	}

}

