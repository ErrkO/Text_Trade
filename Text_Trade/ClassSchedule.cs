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
    }
    #endregion

    #region methods
    public ClassSchedule()  //constructor
	{
	}

	public virtual void AddClass(string cC, string cL)
	{
        this.schedule.Add(new Course(cC, cL));
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
    #endregion
}

