using System;
using System.Collections.Generic;

namespace Assignment03
{
	public interface IDepartmentService
	{
        //Will have one Instructor as head
        Instructor GetHead();
        HashSet<Instructor> GetMembers();
        //Will have Budget for school year(start and end Date Time)
        decimal GetBudget();
        DateTime GetStartDate();
        DateTime GetEndDate();
        //Will offer list of courses
        List<Course> CourseList();
    }
}

