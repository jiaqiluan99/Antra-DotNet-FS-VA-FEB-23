using System;

namespace _02UnderstandingTypes
{
	public class Solutions
	{
        public void GenerateHackerName()
        {
            String? color;
            String? astro;
            String? addr;
            Console.WriteLine("Let's generate your hacker name!");
            Console.WriteLine("What is your favorite color?");
            color = Console.ReadLine();
            Console.WriteLine("What is your astrology sign?");
            astro = Console.ReadLine();
            Console.WriteLine("What is your street address number?");
            addr = Console.ReadLine();
            Console.WriteLine($"Your hacker name is {color + astro + addr}.");
        }

        /*
        Create a console application project named /02UnderstandingTypes/ that outputs the
        number of bytes in memory that each of the following number types uses, and the
        minimum and maximum values they can have: sbyte, byte, short, ushort, int, uint, long,
        ulong, float, double, and decimal.
        */
        public void TypesProperties() {
            Console.WriteLine($"sbyte:   memory = {sizeof(sbyte)}, min = {sbyte.MinValue}, max = {sbyte.MaxValue}");
            Console.WriteLine($"byte:    memory = {sizeof(byte)}, min = {byte.MinValue}, max = {byte.MaxValue}");
            Console.WriteLine($"short:   memory = {sizeof(short)}, min = {short.MinValue}, max = {short.MaxValue}");
            Console.WriteLine($"ushort:  memory = {sizeof(ushort)}, min = {ushort.MinValue}, max = {ushort.MaxValue}");
            Console.WriteLine($"int:     memory = {sizeof(int)}, min = {int.MinValue}, max = {int.MaxValue}");
            Console.WriteLine($"uint:    memory = {sizeof(uint)}, min = {uint.MinValue}, max = {uint.MaxValue}");
            Console.WriteLine($"long:    memory = {sizeof(long)}, min = {long.MinValue}, max = {long.MaxValue}");
            Console.WriteLine($"ulong:   memory = {sizeof(ulong)}, min = {ulong.MinValue}, max = {ulong.MaxValue}");
            Console.WriteLine($"float:   memory = {sizeof(float)}, min = {float.MinValue}, max = {float.MaxValue}");
            Console.WriteLine($"double:  memory = {sizeof(double)}, min = {double.MinValue}, max = {double.MaxValue}");
            Console.WriteLine($"decimal: memory = {sizeof(decimal)}, min = {decimal.MinValue}, max = {decimal.MaxValue}");
        }

        /*
        Write program to enter an integer number of centuries and convert it to years, days, hours,
        minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
        type for every data conversion. 
        */
        public void CenturiesToTimes(ushort centuries) {
            uint years = Convert.ToUInt32(centuries) * 100;
            uint days = years * 365 + Convert.ToUInt32(centuries) * 24;
            if (centuries >= 4) days++;
            uint hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            ulong microseconds = milliseconds * 1000;
            ulong nanoseconds = microseconds * 1000;
            Console.WriteLine($"Input: {centuries}");
            Console.WriteLine($"Output: {centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }

        /*
        FizzBuzz With 100 rounds
        */
        public void FizzBuzz(int n) {
            Console.WriteLine($"Let's play fizzbuzz and count to {n}!");
            for (int i = 1; i < n+1; i++) {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("GG!");
        }

        /*
         3. Guess Number
         */
        public void GuessNumber() {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("New Game! Guess what is the correct number between 1-3!");
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("You win!");
            }
            else if (guessedNumber > 3 || guessedNumber < 1)
            {
                Console.WriteLine("Answer out of range!");
            }
            else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("High!");
            }
            else
            {
                Console.WriteLine("Low...");
            }
        }

        /*
         2.Print-a-Pyramid
         */
        public void Pyramid(int rows) {
            Console.WriteLine($"Let's print a pyramid with {rows} rows!");
            for (int i = 0; i < rows; i++) {
                for (int j = 1; j < rows - i; j++) {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++) {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
        }

        /*
         4.How many days old
         */
        public void DaysOld(DateTime birthday) {
            int days = (DateTime.Today - birthday).Days;
            Console.WriteLine($"You are {days} days old!");
            Console.WriteLine($"There are {10000 - (days % 10000)} days until your next 10,000 day (about 27 years) anniversary.");
        }

        /*
         5.Write a program that greets the user using the appropriate greeting for the time of day.
         */
        public void Greetings(DateTime now) {
            if (now.Hour < 6)
            {
                Console.WriteLine("Good Night");
                return;
            }
            if (now.Hour < 12)
            {
                Console.WriteLine("Good Morning");
                return;
            }
            if (now.Hour < 18)
            {
                Console.WriteLine("Good Afternoon");
                return;
            }
            Console.WriteLine("Good Evening");
        }

        /*
         6. Write a program that prints the result of counting up to 24 using four different increments.
         */
        public void CountTo24() {
            for (int i = 1; i < 5; i++) {
                for (int j = 0; j < 25; j += i) {
                    Console.Write(j);
                    if (j < 24) Console.Write(", ");
                    else Console.WriteLine();
                }
            }
        }

    }
}

