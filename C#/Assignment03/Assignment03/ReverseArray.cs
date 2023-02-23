using System;
using Microsoft.VisualBasic;

namespace Assignment03
{
    //1. Let’s take an array and reverse the contents of it.
    public class ReverseArray
	{
        /*
         The GenerateNumbers method should return an array of 10 numbers. (For bonus points,
        change the method to allow the desired length to be passed in, instead of just always
        being 10.)
        */
        private int[] GenerateNumbers(int len) {
            int[] result = new int[len];
            for (int i = 0; i < len; ) {
                result[i] = ++i;
            }
            return result;
        }

        /*
         The Reverse method will be the hardest. Give it a try and see what you can make
        happen.
        */
        private void Reverse(ref int[] numbers) {
            int[] helper = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) {
                helper[helper.Length - 1 - i] = numbers[i];
            }
            numbers = helper;
        }

        /*
         The PrintNumbersmethod should use a for or foreachloop to print out each item in the
        array.
         */
        private void PrintNumbers(ref int[] numbers) {
            for (int i = 0; i < numbers.Length-1; i++) {
                Console.Write($"{numbers[i]}, ");
            }
            Console.WriteLine($"{numbers[numbers.Length-1]}.");
        }

        public void run() {
            int[] numbers = GenerateNumbers(10);
            Reverse(ref numbers);
            PrintNumbers(ref numbers);
        }
		
	}
}

