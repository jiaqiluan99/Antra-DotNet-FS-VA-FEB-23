using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment02
{
    public class Solutions
    {
        //1. Copying an Array
        public int[] CreateCopy(ref int[] a)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
            return b;
        }

        //2. Write a simple program that lets the user manage a list of elements.
        public void ManageItems()
        {
            var al = new ArrayList();
            String? request;
            String trigger;
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                request = Console.ReadLine();
                if (String.IsNullOrEmpty(request)) continue;
                trigger = request.Substring(0, 2);
                if (trigger == "--") al.Clear();
                else if (trigger == "- " || request.Length < 3)
                {
                    al.Remove(request.Substring(2));
                }
                else if (trigger == "+ " || request.Length < 3)
                {
                    al.Add(request.Substring(2));
                }
                Console.WriteLine("List:");
                foreach (String s in al) Console.WriteLine(s);
            }

        }

        //3 helper to find whether a number is a prime number
        private Boolean IsPrime(int n)
        {
            double sqrt = Math.Sqrt(n);
            if (n < 2) return false;
            for (int i = 2; i <= sqrt; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        //3. Write a method that calculates all prime numbers in given range and returns them as array of integers
        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            var al = new ArrayList();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i)) al.Add(i);
            }
            return al.OfType<int>().ToArray();
        }

        //4. Write a program to read an array of n integers (space separated on a single line) and an
        //integer k, rotate the array right k times and sum the obtained arrays after each rotation as
        //shown below.
        public int[] RotatedSum(ref int[] input, int k)
        {
            int[] result = new int[input.Length];
            for (int h = 0; h < result.Length; h++)
            {
                result[h] = 0;
            }
            for (int j = 1; j < k + 1; j++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    result[(i + j) % input.Length] += input[i];
                }
            }

            return result;
        }

        //5.Write a program that finds the longest sequence of equal elements in an array of integers.
        //If several longest sequences exist, print the leftmost one.
        public int[] FindLongestSequence(ref int[] input)
        {
            int start = 0;
            int len = 1;
            int tempS = 0;
            int tempL = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    tempL++;
                }
                else
                {
                    tempS = i;
                    tempL = 1;
                }
                if (tempL > len)
                {
                    start = tempS;
                    len = tempL;
                }
            }
            int[] result = new int[len];
            for (int j = 0; j < len; j++)
            {
                result[j] = input[start + j];
            }
            return result;
        }

        //7. Write a program that finds the most frequent number in a given sequence of numbers.
        public void FindMostFrequent(ref int[] input)
        {
            Dictionary<int, int> record = new Dictionary<int, int>();
            int highest = 0;
            foreach (int i in input)
            {
                if (record.ContainsKey(i)) record[i]++;
                else record[i] = 1;
                if (record[i] > highest) highest = record[i];
            }

            var highestOnes = new ArrayList();
            foreach (KeyValuePair<int, int> entry in record)
            {
                if (entry.Value >= highest) highestOnes.Add(entry.Key);
            }
            if (highestOnes.Count == 1)
            {
                Console.WriteLine($"The number {highestOnes[0]} is the most frequent (occurs {highest} times)");
                return;
            }
            Console.Write("The numbers ");
            for (int j = 0; j < highestOnes.Count; j++)
            {
                if (j + 2 == highestOnes.Count)
                {
                    Console.Write($"{highestOnes[j]} and ");
                }
                else if (j + 1 == highestOnes.Count)
                {
                    Console.Write($"{highestOnes[j]} ");
                }
                else Console.Write($"{highestOnes[j]}, ");
            }
            Console.Write($"have the same maximal frequence (each occurs {highest} times). The leftmost of them is ");
            foreach (int i in input)
            {
                if (highestOnes.Contains(i))
                {
                    Console.WriteLine($"{i}.");
                    return;
                }
            }
        }

        //1. Write a program that reads a string from the console, reverses its letters and prints the
        //result back at the console.
        //Convert the string to char array, reverse it, then convert it to string again
        public void ReverseString()
        {
            Console.WriteLine("Enter anything to reverse:");
            String? input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return;
            char[] cArray = input.ToCharArray();
            Array.Reverse(cArray);
            String output = new string(cArray);
            Console.WriteLine(output);

        }

        //Print the letters of the string in back direction(from the last to the first) in a for-loop
        public void ReverseString2()
        {
            Console.WriteLine("Enter anything to reverse:");
            String? input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return;
            for (int i = input.Length - 1; i > -1; i--) {
                Console.Write(input[i]);
            }
            Console.WriteLine();

        }

        //2.Write a program that reverses the words in a given sentence without changing the
        //punctuation and spaces
        public void ReverseSentence() {
            String sep = " .,:;=()&[]\"'\\/!?";
            Console.WriteLine("Enter anything to reverse:");
            String? input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return;
            Stack<String> words = new Stack<String>();
            Queue<String> seps = new Queue<String>();
            String temp = "";
            Boolean cond = true;
            for (int i = 0; i < input.Length; i++) {
                if (cond)
                {
                    if (sep.Contains(input[i]))
                    {
                        words.Push(temp);
                        temp = "" + input[i];
                        cond = false;
                    }
                    else temp += input[i];
                }
                else
                {
                    if (sep.Contains(input[i])) temp += input[i];
                    else
                    {
                        seps.Enqueue(temp);
                        temp = "" + input[i];
                        cond = true;
                    }
                }
            }

            seps.Enqueue(temp);
            cond = true;

            while (words.Count != 0 || seps.Count != 0) {
                if (cond)
                {
                    Console.Write(words.Pop());
                    cond = false;
                }
                else
                {
                    Console.Write(seps.Dequeue());
                    cond = true;
                }
            }
            Console.WriteLine();

        }

        //Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
        //and prints them on the console on a single line, separated by comma and space.Print all
        //unique palindromes (no duplicates), sorted
        public void ExtractPalindromes() {
            String sep = " .,:;=()&[]\"'\\/!?";
            Console.WriteLine("Give me a sentence and let's find the palindromes:");
            String? input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return;
            HashSet<String> words = new HashSet<String>();
            String temp = "";
            foreach (char c in input) {
                if (sep.Contains(c))
                {
                    if (temp != "") words.Add(temp);
                    temp = "";
                }
                else temp += c;
            }
            var result = new ArrayList();
            Boolean cond;
            foreach (String s in words) {
                temp = s;
                cond = true;
                while (temp.Length > 1) {
                    if (temp[0] != temp[temp.Length - 1]) {
                        cond = false;
                        break;
                    }
                    temp = temp.Substring(1, temp.Length - 2);
                }
                if (cond) result.Add(s);
            }
            result.Sort();
            if (result.Count > 1) {
                Console.WriteLine(string.Join(",", (string[])result.ToArray(Type.GetType("System.String"))));
            }


        }

        //4.Write a program that parses an URL given in the following format
        public void ParseURL() {
            Console.WriteLine("Give me an URL and I'll parse it for you:");
            String? input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return;
            Console.Write("[protocol] = \"");
            int temp1 = 0;
            if (input.Contains("://")) {
                temp1 = input.IndexOf("://");
                Console.Write(input.Substring(0, temp1));
                temp1 += 3;
            }
            Console.WriteLine("\"");
            Console.Write("[server] = \"");
            int temp2 = input.IndexOf('/', temp1);
            if (temp2 > 0) Console.Write(input.Substring(temp1, temp2 - temp1));
            else Console.Write(input.Substring(temp1));
            Console.WriteLine("\"");
            Console.Write("[resource] = \"");
            if (temp2 > 0) Console.Write(input.Substring(temp2+1));
            Console.WriteLine("\"");

        }


    }
}

