/*------------------------------------------------------------------------------
Class that represents a user's account with TextTrade. Contains information
pertaining to the user's account such as Email, username, and password.
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// modified by Linh 
public class Account
{
    //make all the data fields protected just in case, since Account class has children
    #region data fields 
    protected string username;
    protected string password;
    protected Email email;
    protected string firstName;
    protected string lastName;
    #endregion

    #region Property fields

    public string UserName  //can't change username
    {
        get
        {
            return this.username;
        }
    }

    public string Password
    {
        get
        {
            return this.password;
        }
        set //can change password
        {
            password = value;  
        }
    }

    public Email _Email
    {
        get    //cant change registered email
        {
            return email;  // as of now this wont return anything you need 
                        //to call _Email.email to return the string containing the email 
                        //The above comment results in: cannot convert type string to Email -Seth
        }
    }

    public string FirstName //cant change name
    {
        get
        {
            return this.firstName;
        }
    }

    public string LastName  //cant change name
    {
        get
        {
            return this.lastName;
        }
    }

    #endregion

    #region methods
    public Account()    //default constructor
	{
	}

    // can you add this. before all the variables again here

	public Account(string uName, string pWord, string fName, string lName, Email eMail) //constructor
	{
        username = uName;
        password = pWord;
        firstName = fName;
        lastName = lName;
        email = eMail;
	}

	public void ChangePassword(string pass)  

	{
        password = pass;
	}
    #endregion
}

