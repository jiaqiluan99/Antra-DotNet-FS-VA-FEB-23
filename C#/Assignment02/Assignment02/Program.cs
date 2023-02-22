// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using Assignment02;

Solutions solution = new Solutions();


// Practice Arrays
//1. Copying an Array
int[] a = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
int[] b = new int[a.Length];
b = solution.CreateCopy(ref a);
Console.WriteLine($"{{{string.Join(", ", b)}}}");

//2. Write a simple program that lets the user manage a list of elements. 
solution.ManageItems();

//3. Write a method that calculates all prime numbers in given range and returns them as array of integers
int[] primes = solution.FindPrimesInRange(10, 20);
Console.WriteLine($"{{{string.Join(", ", primes)}}}");

//4. Write a program to read an array of n integers (space separated on a single line) and an
//integer k, rotate the array right k times and sum the obtained arrays after each rotation as
//shown below.
int[] ra = { 3, 2, 4, -1 };
int[] rb = { 1, 2, 3, 4, 5 };
int[] rar = solution.RotatedSum(ref ra, 2);
int[] rbr = solution.RotatedSum(ref rb, 3);
Console.WriteLine($"{{{string.Join(", ", rar)}}}");
Console.WriteLine($"{{{string.Join(", ", rbr)}}}");

//5.Write a program that finds the longest sequence of equal elements in an array of integers.
//If several longest sequences exist, print the leftmost one.
int[] als = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
int[] bls = { 1, 1, 1, 2, 3, 1, 3, 3 };
int[] cls = { 4, 4, 4, 4};
int[] dls = { 0, 1, 1, 5, 2, 2, 6, 3, 3};
int[] alsr = solution.FindLongestSequence(ref als);
int[] blsr = solution.FindLongestSequence(ref bls);
int[] clsr = solution.FindLongestSequence(ref cls);
int[] dlsr = solution.FindLongestSequence(ref dls);
Console.WriteLine($"{{{string.Join(", ", alsr)}}}");
Console.WriteLine($"{{{string.Join(", ", blsr)}}}");
Console.WriteLine($"{{{string.Join(", ", clsr)}}}");
Console.WriteLine($"{{{string.Join(", ", dlsr)}}}");

//7. Write a program that finds the most frequent number in a given sequence of numbers.
int[] af = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
int[] bf = { 2, 7, 7, 0, 7, 2, 2, 0, 10, 10, 10 };
solution.FindMostFrequent(ref af);
solution.FindMostFrequent(ref bf);

//Practice Strings
//1. Write a program that reads a string from the console, reverses its letters and prints the
//result back at the console.
//Convert the string to char array, reverse it, then convert it to string again
solution.ReverseString();
//Print the letters of the string in back direction (from the last to the first) in a for-loop
solution.ReverseString2();

//2.Write a program that reverses the words in a given sentence without changing the
//punctuation and spaces
solution.ReverseSentence();

//Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
//and prints them on the console on a single line, separated by comma and space.Print all
//unique palindromes (no duplicates), sorted
solution.ExtractPalindromes();




//4.Write a program that parses an URL given in the following format
solution.ParseURL();






