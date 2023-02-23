using System;
using System.Collections;
namespace Assignment03
{
	public class Student: Person
	{
        private decimal salary = 0;
		public Student(string n, ref DateTime dob, ref string[] adds) : base(n, ref dob, ref adds)
        {

		}

        public Student(string n, ref DateTime dob, ref string[] adds, decimal s) : base(n, ref dob, ref adds)
        {
            salary = s;
        }


        public override decimal GetSalary()
        {
            return salary;
        }

        //Can take multiple courses
        //Each course will have grade from A to F
        private Dictionary<Course, Grade> courses = new Dictionary<Course, Grade>();
        public void AddCourse(Course c, Grade g) {
            courses.Add(c, g);
        }
        public void AddCourse(Course c) {
            AddCourse(c, Grade.Pending);
        }

        //Calculate student GPA based on grades for courses
        public decimal GetGPA() {
            decimal total = 0;
            int count = 0;
            foreach (KeyValuePair<Course, Grade> course in courses) {
                count++;
                switch (course.Value) {
                    case Grade.A:
                        total += 5.00m;
                        break;
                    case Grade.B:
                        total += 4.00m;
                        break;
                    case Grade.C:
                        total += 3.00m;
                        break;
                    case Grade.D:
                        total += 2.00m;
                        break;
                    case Grade.E:
                        total += 1.00m;
                        break;
                    case Grade.F:
                        total += 0m;
                        break;
                    default:
                        count--;
                        break;
                }
            }
            if (count < 1) return -1;
            return total / count;
        }

        
    }
}

