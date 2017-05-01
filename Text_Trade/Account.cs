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
    protected Email eMail;
    protected string firstName;
    protected string lastName;
    protected int trader_id;
    protected bool moderator;
    #endregion

    #region Property fields

    public string Username  //can't change username
    {
        set
        {
            this.username = value;
        }

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
            return eMail;  // as of now this wont return anything you need 
                        //to call _Email.email to return the string containing the email 
                        //The above comment results in: cannot convert type string to Email -Seth
                        /* it gives you the error becuase the .email is of type string, if you want you can change this property to a string type or i can create a tostring
                         method for the email class  - Eric*/ 
        }
    }                   //To string would probably be easier, because the alternative wouldn't have an email object associated with the account anymore - Seth

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

    public int Trader_id
    {
        get
        {
            return this.trader_id;
        }
        set
        {
            this.trader_id = value;
        }
    }

    #endregion

    #region methods
    public Account()    //default constructor
	{
	}

    //Constructor - only uses username and password to create account object for login process
    public Account(string username, string password)
    {
        this.username = username;
        this.password = password;
    }

    //Constructor used for creating new accounts
    public Account(string uName, string pWord, string fName, string lName, string email)
    {
        this.username = uName;
        this.password = pWord;
        this.firstName = fName;
        this.lastName = lName;
        this.eMail = new Email(email);
        this.trader_id = -1;
        this.moderator = false;
    }

    //Constructor used for creating account object from database info
    public Account(string uName, string pWord, string fName, string lName, string eMail, int traderid, bool mod = false)
	{
        this.username = uName;
        this.password = pWord;
        this.firstName = fName;
        this.lastName = lName;
        this.eMail = new Email(eMail);  //Changed the parameter in the constructor to string so that email can be added from Create_Account form
        this.trader_id = traderid;
        this.moderator = mod;           //Determines whether account is moderator or not
	}

	public void ChangePassword(string pass)  

	{
        this.password = pass;
	}

    public bool isModerator()
    {
        return this.moderator;
    }
    #endregion
}

