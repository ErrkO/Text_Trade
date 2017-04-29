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

public enum Condition { New, LikeNew, Great, Good, Acceptable }

public class Listing
{
    #region data fields 
    private int listing_id;
    string listingTitle;    //newly added field - Linh
    string title;
    string author;
    string edition;
    string isbn;
    Course course;    
    Condition condition;
    string lastUsed;
    double price;
    Image picture;  //? image type?
    string description;
    int listinglife;    //listinglife is an int?
    int deleted;
    int trader_id;
    // we need to add a varaible to store the listing life maybe an int or a datetime object - Eric
    private DataBase db = new DataBase();
    #endregion

    #region Properties
    public int Listing_id
    {

        get { return this.listing_id; }

        set { this.listing_id = value; }

    }

    public string ListingTitle
    {
        get
        {
            return this.listingTitle;
        }
        set
        {
            this.listingTitle = value;
        }
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

	public Course _Course  //Hmm, Course has 2 fields, so should I explicitly return both fields or what? -Linh
	{
        get
        {
            return this.course;
        }
        set
        {
            this.course = value;
        }
	}

	/*public string CourseLevel
	{
        get
        {
            return this.courseLevel;
        }
        set
        {
            this.courseLevel = value;
        }
    }*/

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

	public Condition Condition
	{
        get
        {
            return this.condition;
        }
        set
        {
            this.condition = value;
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

    public int Deleted  //?? shouldnt it be bool?
    {

        get { return this.deleted; }

        set { this.deleted = value; }

    }

    public int Trader_id    //we use int for trader_id?
    {

        get { return this.trader_id; }

        set { this.trader_id = value; }

    }

    public int Listinglife  //int for listingLife?
    {

        get { return this.listinglife; }

        set { this.listinglife = value; }

    }

    #endregion

    #region methods
    public Listing()
	{
	}

    public Listing(string listingTitle, string title, string author, string edition, string isbn,Course class_course, Condition bookCondition, double price, string lastUsed = null, Image picture = null, string description = null)
    {
        this.listingTitle = listingTitle;
        this.title = title;
        this.author = author;
        this.edition = edition;
        this.isbn = isbn;
        this.course = class_course;
        this.condition = bookCondition;
        this.price = price;
        this.lastUsed = lastUsed;
        this.picture = picture;
        this.description = description;
    }

    public virtual void UpdateAll(string listingTitle, string title, string author, string edition, string isbn, Course class_course, Condition bookCondition, double price, string lastUsed, Image picture, string description)
	{
        this.listingTitle = listingTitle;
        this.title = title;
        this.author = author;
        this.edition = edition;
        this.isbn = isbn;
        this.course = class_course;
        this.condition = bookCondition;
        this.price = price;
        this.lastUsed = lastUsed;
        this.picture = picture;
        this.description = description;
    }

	public virtual void UpdateAuthor(string author)
	{
        this.author = author;
	}

	public virtual void UpdateCondition(Condition bookCondition)
	{
        this.condition = bookCondition;
	}

	public virtual void UpdateCourseCode(Course class_course)
	{
        this.course.CourseCode = class_course.CourseCode;
	}

	public virtual void UpdateCourseLevel(Course class_course)
	{
        this.course.CourseLevel = class_course.CourseLevel;
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

    public virtual void UpdateListingTitle(string listingTitle)
    {
        this.listingTitle = listingTitle;
    }
    public void CreateListing(int trader_id)
    {

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            conn.Open();

            string sql;

            if(this.listing_id == -1)
            {
                //Database stuff - ask Eric to add one more field for Listing - string listingTitle - Linh
                sql = "INSERT INTO Listings (title,author,edition,isbn,courseCode,courseLevel,lastUsed,condition,"
                        + " description,deleted,price,listinglife,trader_id)"
                        + " VALUES (@title,@author,@edition,@isbn,@courseCode,@courseLevel,@lastUsed,@condition,"
                        + " @description,0,@price,@trader_id"
                        + " SELECT cast(scope_identity() as int)";

            }

            else
            {

                sql = "UPDATE Listings "
                        + " SET title = @title, author = @author, edition = @edition, isbn = @isbn, courseCode = courseCode,"
                        + " courseLevel = @courseLevel, lastUsed = @lastUsed, condition = @condition, description = @description,"
                        + " deleted = 0, price = @price, listing_id = @trader_id"
                        + " WHERE listinglife = @listinglife";

            }

            SqlCommand command = new SqlCommand(sql, conn);

            command.Parameters.AddWithValue("title",this.title);
            command.Parameters.AddWithValue("author",this.author);
            command.Parameters.AddWithValue("edition",this.edition);
            command.Parameters.AddWithValue("isbn",this.isbn);
            command.Parameters.AddWithValue("courseCode",this.course.CourseCode);      //Also we implement Course object, instead of 2 strings
            command.Parameters.AddWithValue("courseLevel",this.course.CourseLevel);    //So update?
            command.Parameters.AddWithValue("lastUsed",this.lastUsed);
            command.Parameters.AddWithValue("condition",Convert.ToString(this.condition));
            command.Parameters.AddWithValue("description",this.description);
            command.Parameters.AddWithValue("price",this.price);
            command.Parameters.AddWithValue("trader_id",trader_id);

            if (listing_id == -1)
            {

                listing_id = (int)command.ExecuteScalar();

            }

            else
            {

                command.Parameters.AddWithValue("listing_id", this.listing_id);

                command.ExecuteNonQuery();

            }

        }

    }

    public Listing CreateListingObjFromDb(int listing_id)
    {

        Listing templisting = new Listing();

        using (SqlConnection conn = new SqlConnection(db.ConnString))
        {

            conn.Open();

            string sql = "SELECT * "
                        + "FROM Listings "
                        + "WHERE listing_id = @listing_id";

            using (SqlCommand command = new SqlCommand(sql, conn))
            {

                if (listing_id == -1)
                {

                    throw new ArgumentException("The listing does not exist");

                }

                using (SqlDataReader reader = command.ExecuteReader())
                {

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
                    templisting.Condition =conditionstring;
                    templisting.Description = reader.GetString(9);
                    templisting.Deleted = reader.GetInt32(10);
                    templisting.Price = reader.GetInt32(11);
                    templisting.Listinglife = reader.GetInt32(12);
                    templisting.Trader_id = reader.GetInt32(13);

                }

            }

        }

        return templisting;

    }

    #endregion
}

