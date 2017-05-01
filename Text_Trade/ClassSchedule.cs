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

    // you would probably need to create a predicate and search the list for the course
    // then you would call the remove function (it might be called something different)
    // and you could either remove it based on the predicate call (imagine a function in
    // in a function) or you could set an iterator based on what the predicate returns
    // and remove the position in the list

    //testing in a separate project shows that the Remove() function will remove the first
    //occurence of the value that it is passed without the need for a predicate or iterator

    // that is good to hear, I vaguely remember needing one for a similar project i was doing, but if we dont need one then great - Eric

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

            schedstr += course.courseCode + "," + course.courseLevel;

        }

        return schedstr;

    }

    #endregion
}

