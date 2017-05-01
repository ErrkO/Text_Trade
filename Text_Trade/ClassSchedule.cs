/*------------------------------------------------------------------------------
 Class that holds a list of Course objects for each account
------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ClassSchedule
{
    #region data fields
    public List<Course> schedule;
    #endregion

    #region Properties
    public List<Course> Schedule
    {

        get
        {
            return this.schedule;
        }

        set { this.schedule = value; }

    }
    #endregion

    #region methods
    public ClassSchedule()  //constructor
	{
        schedule = new List<Course>();
        schedule.Add(new Course());
	}

    public ClassSchedule(string str)  //constructor
    {

        Course tempcourse = new Course();

        List<string> tempcc = new List<string>();
        List<string> tempcl = new List<string>();

        char seperator = ',';

        string[] substr = str.Split(seperator);

        for (int i = 0; i < substr.Length; i++)
        {

            if (i % 2 == 1)
            {

                tempcc.Add(substr[i]);

            }

            else
            {

                tempcl.Add(substr[i]);

            }

        }

        for (int i = 0; i < substr.Length; i++)
        {

            tempcourse = new Course(tempcc[i], tempcl[i]);

            AddClass(tempcourse);

        }

    }

    public virtual void AddClass(string cC, string cL)
	{
        this.schedule.Add(new Course(cC, cL));
	}

    public void AddClass(Course course)
    {

        this.schedule.Add(course);

    }

	public virtual void RemoveClass(Course course)
	{
            this.schedule.Remove(course);
	}

    public ClassSchedule FromString(string str)
    {

        ClassSchedule tempsched = new ClassSchedule();
        Course tempcourse = new Course();

        List<string> tempcc = new List<string>();
        List<string> tempcl = new List<string>();

        char seperator = ',';

        string[] substr = str.Split(seperator);

        for (int i = 0; i < substr.Length; i++)
        {

            if (i % 2 == 1)
            {

                tempcc.Add(substr[i]);

            }

            else
            {

                tempcl.Add(substr[i]);

            }

        }

        for (int i = 0; i < substr.Length; i++)
        {

            tempcourse = new Course(tempcc[i], tempcl[i]);

            tempsched.AddClass(tempcourse);

        }

        return tempsched;

    }

    public override string ToString()
    {

        string schedstr = "";

        foreach (Course course in schedule)
        {

            schedstr += course.courseCode + "," + course.courseLevel + " ";

        }

        return schedstr;

    }

    #endregion
}

