using System;
using System.Collections;
namespace Assignment03
{
	public abstract class Person
	{
		private string name;
		private DateTime birthday;
        private string[] addresses;

        public Person(string n, ref DateTime dob, ref string[] adds)
		{
			name = n;
			birthday = dob;
			addresses = adds;
		}

		//Calculate Age of the Person
		public int GetAge() {
			return (DateTime.Today - birthday).Days/365;
		}

		//Calculate the Salary of the person, Use decimal for salary
		//Salary cannot be negative number
		public abstract decimal GetSalary();

		//Can have multiple Addresses, should have method to get addresses
		public string[] GetAddresses() {
			return addresses;
		}
		public void UpdateAddresses(string[] adds) {
			addresses = adds;
		}
    }
}

