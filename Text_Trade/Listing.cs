/*------------------------------------------------------------------------------
Class that represents a listing posted by a user. Contains all relevant
information about the book in the listing
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;

public enum condition { New, LikeNew, Great, Good, Acceptable }

public class Listing
{
    #region data fields 
    private int listing_id;
    string title;
    string author;
    string edition;
    string isbn;
    string courseCode;      //Why don't we just use a Course object here? "I agree we should just use a course object here" -Eric
    string courseLevel;     //-------------------------------------------
    condition bookCondition;
    string lastUsed;
    double price;
    Image picture;  //? image type?
    string description;
    int listinglife;
    // we need to add a varaible to store the listing life maybe an int or a datetime object - Eric
    private DataBase db = new DataBase();
    #endregion

    #region Properties
    public int Listing_id
    {

        get { return this.listing_id; }

        private set { this.listing_id = value; }

    }

    public string Title
	{
		get
        {
            return this.title;
        }
		set
        {
            this.title = value;
        }
	}

	public string Author
	{
        get
        {
            return this.author;
        }
        set
        {
            this.author = value;
        }
    }

	public string Edition
	{
        get
        {
            return this.edition;
        }
        set
        {
            this.edition = value;
        }
    }

	public string Isbn
	{
        get
        {
            return this.isbn;
        }
        set
        {
            this.isbn = value;
        }
    }

	public string CourseCode
	{
        get
        {
            return this.courseCode;
        }
        set
        {
            this.courseCode = value;
        }
	}

	public string CourseLevel
	{
        get
        {
            return this.courseLevel;
        }
        set
        {
            this.courseLevel = value;
        }
    }

	public string LastUsed
	{
        get
        {
            return this.lastUsed;
        }
        set
        {
            this.lastUsed = value;
        }
    }

	public condition BookCondition
	{
        get
        {
            return this.bookCondition;
        }
        private set
        {
            this.bookCondition = value;
        }
	}

	public double Price
	{
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
        }
    }

	public Image Picture //Not sure how to implement this
	{
		get;
		set;
	}

	public string Description
	{
        get
        {
            return this.description;
        }
        set
        {
            this.description = value;
        }
    }
    #endregion

    #region methods
    public Listing()
	{
	}

    public Listing(string title, string author, string edition, string isbn, string cC, string cL, condition bookCondition, double price, string lastUsed = null, Image picture = null, string description = null)
    {
        this.title = title;
        this.author = author;
        this.edition = edition;
        this.isbn = isbn;
        this.courseCode = cC;
        this.courseLevel = cL;
        this.bookCondition = bookCondition;
        this.price = price;
        this.lastUsed = lastUsed;
        this.picture = picture;
        this.description = description;
    }

    public virtual void UpdateAll(string title, string author, string edition, string isbn, string cC, string cL, condition bookCondition, double price, string lastUsed, Image picture, string description)
	{
        this.title = title;
        this.author = author;
        this.edition = edition;
        this.isbn = isbn;
        this.courseCode = cC;
        this.courseLevel = cL;
        this.bookCondition = bookCondition;
        this.price = price;
        this.lastUsed = lastUsed;
        this.picture = picture;
        this.description = description;
    }

	public virtual void UpdateAuthor(string author)
	{
        this.author = author;
	}

	public virtual void UpdateCondition(condition bookCondition)
	{
        this.bookCondition = bookCondition;
	}

	public virtual void UpdateCourseCode(string cC)
	{
        this.courseCode = cC;
	}

	public virtual void UpdateCourseLevel(string cL)
	{
        this.courseLevel = cL;
	}

	public virtual void UpdateDescription(string description)
	{
        this.description = description;
	}

	public virtual void UpdateEdition(string edition)
	{
        this.edition = edition;
	}

	public virtual void UpdateISBN(string isbn)
	{
        this.isbn = isbn;
	}

	public virtual void UpdateLastUsed(string lastUsed)
	{
        this.lastUsed = lastUsed;
	}

	public virtual void UpdatePicture(Image picture)
	{
        this.picture = picture;
	}

	public virtual void UpdatePrice(double price)
	{
        this.price = price;
	}

	public virtual void UpdateTitle(string title)
	{
        this.title = title;
	}

    public void CreateListing()
    {

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {



        }

    }

    #endregion
}

