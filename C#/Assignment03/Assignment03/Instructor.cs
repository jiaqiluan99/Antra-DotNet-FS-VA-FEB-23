using System;
using System.Buffers.Text;

namespace Assignment03
{
	public class Instructor : Person
	{
        private decimal salary;
        private DateTime joinDate;
        private const decimal percentBonus = .05m;
        private bool head = false;
        public Instructor(string n, ref DateTime dob, ref string[] adds, decimal s, DateTime jd) : base(n, ref dob, ref adds)
        {
            salary = s;
            joinDate = jd;
        }

        //Belongs to one Department and he can be Head of the Department
        //Instructor will have added bonus salary based on his experience,
        //calculate his years of experience based on Join Date

        public bool IsHead() {
            return head;
        }

        public void BecomeHead() {
            head = true;
        }

        public void NoLongerHead() {
            head = false;
        }

        public int YearsOfExperience() {
            return (DateTime.Today - joinDate).Days / 365;
        }

        public decimal GetBonus() {
            return salary * percentBonus * YearsOfExperience();
        }

        public override decimal GetSalary()
        {
            return salary + GetBonus();
        }



    }
}

