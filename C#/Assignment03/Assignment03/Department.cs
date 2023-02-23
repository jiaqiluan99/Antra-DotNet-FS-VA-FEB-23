using System;
using System.Collections.Generic;

namespace Assignment03
{
	public class Department : IDepartmentService
	{
        //Will have one Instructor as head
        //Will have Budget for school year(start and end Date Time)
        //Will offer list of courses

        private string name;
        private Instructor head;
        private HashSet<Instructor> members = new HashSet<Instructor>();
        private decimal budget = 0;
        private DateTime start = new DateTime();
        private DateTime end = new DateTime();
        private List<Course> courses = new List<Course>();

        public Department(string departmentName, Instructor departmentHead)
		{
            name = departmentName;
            head = departmentHead;
		}

        public void NewYear(DateTime yearStart, DateTime yearEnd, decimal departmentBudget) {
            courses.Clear();
            start = yearStart;
            end = yearEnd;
            budget = departmentBudget;
        }

        public List<Course> CourseList()
        {
            return courses;
        }

        public void AddCourse(Course c) {
            courses.Add(c);
        }

        public void RemoveCourse(Course c) {
            courses.Remove(c);
        }

        public decimal GetBudget()
        {
            return budget;
        }

        public DateTime GetEndDate()
        {
            return end;
        }

        public Instructor GetHead()
        {
            return head;
        }

        public void ChangeHead(Instructor newHead){
            head = newHead;
        }

        public HashSet<Instructor> GetMembers()
        {
            return members;
        }

        public void AddMember(Instructor newMember) {
            members.Add(newMember);
        }

        public void RemoveMember(Instructor m) {
            members.Remove(m);
        }

        public DateTime GetStartDate()
        {
            return start;
        }
    }
}

