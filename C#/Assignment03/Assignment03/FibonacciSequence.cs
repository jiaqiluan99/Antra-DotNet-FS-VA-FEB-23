using System;
namespace Assignment03
{
	public class FibonacciSequence
	{


		private int Fibonacci(int n) {
			if (n == 1 || n == 2) {
				return 1;
			}
			return Fibonacci(n-2) + Fibonacci(n-1);

        }

        //In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
        //sequence and print them out.
        public void run() {
			for (int i = 1; i <= 10; i++) {
				Console.WriteLine($"Fibonacci number {i} is {Fibonacci(i)}.");
			}
		}
	}
}

