using System;
using Microsoft.VisualBasic;

namespace Assignment03
{
	public class Course: ICourseService
	{
        public string name { get; set; }
        private HashSet<Student> enrolledStudents = new HashSet<Student>();
        private Department department;
		public Course(string n, Department d)
		{
            name = n;
            department = d;
		}

        public void AddStudent(Student s)
        {
            enrolledStudents.Add(s);
        }

        public Student[] EnrolledStudents()
        {
            Student[] students = new Student[enrolledStudents.Count];
            enrolledStudents.CopyTo(students);
            return students;
        }

        public void RemoveStudent(Student s)
        {
            enrolledStudents.Remove(s);
        }
    }
}

