/*------------------------------------------------------------------------------
Class that represents a course by holding a course code and course level
Course is used by the ClassSchedule class
------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Course
{
    #region data fields
    public string courseCode;
    public string courseLevel;
    #endregion

    #region Properties

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
        /*private*/ set
        {
            this.courseLevel = value;
        }
    }
    #endregion

    #region methods

    public Course() //default constructor
	{
        this.courseCode = "";
        this.courseLevel = "";
	}

	public Course(string cC, string cL) //constructor with 2 args
	{
        this.courseCode = cC;
        this.courseLevel = cL;
	}

	public void UpdateCourseCode(string cC)
	{
        this.courseCode = cC;
	}

	public void UpdateCourseLevel(string cL)
	{
        this.courseLevel = cL;
	}

    #endregion

}
// Can't overload assignment operator in C#? 