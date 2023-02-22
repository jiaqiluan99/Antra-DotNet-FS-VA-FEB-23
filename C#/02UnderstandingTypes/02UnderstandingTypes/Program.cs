using System.Text;
using _02UnderstandingTypes;


Solutions solution = new Solutions();


//Playing with Console App

solution.GenerateHackerName();

//Practice number sizes and ranges
//1. Create a console application project named /02UnderstandingTypes/ that outputs the
//number of bytes in memory that each of the following number types uses, and the
//minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
//ulong, float, double, and decimal.


solution.TypesProperties();

//2. Write program to enter an integer number of centuries and convert it to years, days, hours,
//minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
//type for every data conversion. 

solution.CenturiesToTimes(5);


//Practice loops and operators
//1. Fizzbuzz

solution.FizzBuzz(100);

//int max = 500;
//for (byte i = 0; i < max; i++)
//{
//    WriteLine(i);
//}
//I can add: Console.WriteLine("The following statement forgot to add Console. or other possible instance name or creating the corresponding method in this class");
//           break;
// before the WriteLine(i); statement

//2.Print-a-Pyramid
solution.Pyramid(10);

//3.Guess Number
solution.GuessNumber();

//4.How many days old
DateTime bday = new DateTime(1999, 12, 16);
solution.DaysOld(bday);

//5.Write a program that greets the user using the appropriate greeting for the time of day.
DateTime time = DateTime.Now;
solution.Greetings(time);

//6. Write a program that prints the result of counting up to 24 using four different increments.
solution.CountTo24();




