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

	public virtual void RemoveClass(Course course)
	{
        if (this.schedule.Count != 0)
            this.schedule.Remove(course);
	}
    #endregion
}

