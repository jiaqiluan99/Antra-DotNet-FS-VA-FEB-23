using System;
namespace Assignment03
{
	public interface ICourseService
	{
        //Will have list of enrolled students
        Student[] EnrolledStudents();
        void AddStudent(Student s);
        void RemoveStudent(Student s);
    }
}

