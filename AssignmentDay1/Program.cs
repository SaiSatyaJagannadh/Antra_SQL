// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World!");
// Assignment 1

// Playing with Console App - Custom Hacker Name
/*using System;
class Program {
    static void Main() {
        Console.WriteLine("Enter favorite color:"); string color = Console.ReadLine();
        Console.WriteLine("Enter astrology sign:"); string sign = Console.ReadLine();
        Console.WriteLine("Enter street address number:"); string num = Console.ReadLine();
        Console.WriteLine($"Your hacker name is {color}{sign}{num}");
        // Intentional error: Console.WriteLine(undefinedVariable); // Undefined variable
    }
}*/


// Practice number sizes and ranges
// 1. 02UnderstandingTypes
/*using System;
class Program {
    static void Main() {
        Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes, {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"byte: {sizeof(byte)} bytes, {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"short: {sizeof(short)} bytes, {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"ushort: {sizeof(ushort)} bytes, {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"int: {sizeof(int)} bytes, {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"uint: {sizeof(uint)} bytes, {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"long: {sizeof(long)} bytes, {long.MinValue} to {long.MaxValue}");
        Console.WriteLine($"ulong: {sizeof(ulong)} bytes, {ulong.MinValue} to {ulong.MaxValue}");
        Console.WriteLine($"float: {sizeof(float)} bytes, {float.MinValue} to {float.MaxValue}");
        Console.WriteLine($"double: {sizeof(double)} bytes, {double.MinValue} to {double.MaxValue}");
        Console.WriteLine($"decimal: {sizeof(decimal)} bytes, {decimal.MinValue} to {decimal.MaxValue}");
    }
}*/

// 2. Centuries Conversion
/*using System;
class Program {
    static void Main() {
        Console.WriteLine("Enter centuries:"); int centuries = int.Parse(Console.ReadLine());
        long years = centuries * 100L; long days = years * 36524 / 100; ulong hours = (ulong)days * 24;
        ulong minutes = hours * 60; ulong seconds = minutes * 60; ulong ms = seconds * 1000;
        decimal us = ms * 1000M; decimal ns = us * 1000M;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {ms} milliseconds = {us} microseconds = {ns} nanoseconds");
    }
}*/

// Practice loops and operators
// 1. FizzBuzz
/*using System;
class Program {
    static void Main() {
        for (int i = 1; i <= 100; i++) {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("fizzbuzz");
            else if (i % 3 == 0) Console.WriteLine("fizz");
            else if (i % 5 == 0) Console.WriteLine("buzz");
            else Console.WriteLine(i);
        }
    }
}*/

// Fix with warning for byte overflow
/*
using System;
class Program {
    static void Main() {
        int max = 500;
        for (byte i = 0; i < max; i++) {
            Console.WriteLine(i);
            if (i == byte.MaxValue) { Console.WriteLine("Warning: Byte overflow imminent!"); break; }
        }
    }
}
*/

// Random Number Guess
/*using System;
class Program {
    static void Main() {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess a number (1-3):"); int guess = int.Parse(Console.ReadLine());
        if (guess < 1 || guess > 3) Console.WriteLine("Out of range!");
        else if (guess < correctNumber) Console.WriteLine("Too low!");
        else if (guess > correctNumber) Console.WriteLine("Too high!");
        else Console.WriteLine("Correct!");
    }
}*/

// 2. Print-a-Pyramid
/*using System;
class Program {
    static void Main() {
        for (int i = 1; i <= 5; i++) {
            for (int j = 0; j < 5 - i; j++) Console.Write(" ");
            for (int k = 0; k < 2 * i - 1; k++) Console.Write("*");
            Console.WriteLine();
        }
    }
}*/

// 3. Random Number Guess (Repeated)
/*using System;
class Program {
    static void Main() {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess a number (1-3):"); int guess = int.Parse(Console.ReadLine());
        if (guess < 1 || guess > 3) Console.WriteLine("Out of range!");
        else if (guess < correctNumber) Console.WriteLine("Too low!");
        else if (guess > correctNumber) Console.WriteLine("Too high!");
        else Console.WriteLine("Correct!");
    }
}*/

// 4. Days Old with Anniversary
/*using System;
class Program {
    static void Main() {
        DateTime birthDate = new DateTime(1990, 1, 1); // Example birth date
        int daysOld = (DateTime.Now - birthDate).Days;
        Console.WriteLine($"You are {daysOld} days old.");
        int daysToNext = 10000 - (daysOld % 10000);
        DateTime nextAnniversary = DateTime.Now.AddDays(daysToNext);
        Console.WriteLine($"Next 10,000-day anniversary: {nextAnniversary:MMMM dd, yyyy}");
    }
}*/

// 5. Time-based Greeting
/*using System;
class Program {
    static void Main() {
        DateTime time = DateTime.Now; // Or test with new DateTime(2025, 3, 24, 15, 0, 0)
        if (time.Hour >= 5 && time.Hour < 12) Console.WriteLine("Good Morning");
        if (time.Hour >= 12 && time.Hour < 17) Console.WriteLine("Good Afternoon");
        if (time.Hour >= 17 && time.Hour < 21) Console.WriteLine("Good Evening");
        if (time.Hour >= 21 || time.Hour < 5) Console.WriteLine("Good Night");
    }
}*/

// 6. Counting with Increments
/*using System;
class Program {
    static void Main() {
        for (int step = 1; step <= 4; step++) {
            for (int i = 0; i <= 24; i += step) Console.Write(i + (i < 24 ? "," : ""));
            Console.WriteLine();
        }
    }
}*/





// Assignment 2
// 1. Copying an Array

/*
class Program
{

    static void Main()
    {
        // Create and initialize an array with 10 items
        int[] originalArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Create a copy of the array
        int[] copiedArray = new int[originalArray.Length];

        // Copy elements using a loop
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

        // Print both arrays
        Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
        Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));
    }
}
*/


// 2. To-Do List Program
/*
class Program
{
    static void Main()
    {
        List<string> todoList = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();

            if (input == "--")
            {
                todoList.Clear();
            }
            else if (input.StartsWith("+"))
            {
                todoList.Add(input.Substring(2)); // Remove "+ " and add item
            }
            else if (input.StartsWith("-"))
            {
                todoList.Remove(input.Substring(2)); // Remove "- " and delete item
            }

            // Display the current list
            Console.WriteLine("Current List: " + string.Join(", ", todoList));
        }
    }
}
*/


// 3. Find Prime Numbers in a Given Range
/*using System;
using System.Collections.Generic;*/

/*class Program
{
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int num = startNum; num <= endNum; num++)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }

        return primes.ToArray();
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        int[] primes = FindPrimesInRange(10, 50);
        Console.WriteLine("Primes: " + string.Join(", ", primes));
    }
}*/


// 4. Rotate Array and Sum

/*
using System;

class Program
{
    static void Main()
    {
        int[] array = { 1,2,3,4,5 };
        int k = 3;
        int[] sum = new int[array.Length];

        for (int r = 0; r < k; r++)
        {
            int last = array[^1]; // Get the last element
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = last;

            for (int i = 0; i < array.Length; i++)
            {
                sum[i] += array[i];
            }
        }

        Console.WriteLine("Sum after rotations: " + string.Join(", ", sum));
    }
}
*/


// 5.Find Longest Sequence of Equal Elements

/*
using System;

class Program
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int maxLength = 1, currentLength = 1, start = 0, bestStart = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
                currentLength++;
            else
                currentLength = 1;

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                bestStart = i - maxLength + 1;
            }
        }

        Console.WriteLine("Longest sequence: " + string.Join(", ", array[bestStart..(bestStart + maxLength)]));
    }
}
*/

// 6. Finds the most frequent number in a given sequence
/*using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter numbers separated by space: ");
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        int maxFrequency = 0;
        int mostFrequentNumber = numbers[0]; // Default to first element

        foreach (int num in numbers)
        {
            if (frequencyMap.ContainsKey(num))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;

            if (frequencyMap[num] > maxFrequency)
            {
                maxFrequency = frequencyMap[num];
                mostFrequentNumber = num; // Update most frequent number
            }
        }

        Console.WriteLine($"The number {mostFrequentNumber} is the most frequent (occurs {maxFrequency} times)");
    }
}*/

// 1. Reverse a String 
/*
using System;

class Program
{
    static void Main()
    {
        string input = "sample";
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }
}
*/

//2. Reverse Words in a Sentence (Keeping Punctuation)

/*
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string sentence = "C# is not C++, and PHP is not Delphi!";
        string pattern = @"[\w\+\-]+";  // Match words like "C++", "a+b"
        MatchCollection matches = Regex.Matches(sentence, pattern);
        
        string[] words = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
            words[i] = matches[i].Value;

        Array.Reverse(words);

        Console.WriteLine(string.Join(" ", words) + "!");
    }
}
*/


// 3. Extract Palindromes

/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
        var words = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        var palindromes = words.Where(word => word.SequenceEqual(word.Reverse())).Distinct().OrderBy(x => x);
        
        Console.WriteLine(string.Join(", ", palindromes));
    }
}*/

//4. Extract and display the protocol, server (domain), and resource (path) from a given valid URL

/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a URL: ");
        string url = Console.ReadLine();

        try
        {
            Uri uri = new Uri(url);
            Console.WriteLine($"[protocol] = {uri.Scheme}");
            Console.WriteLine($"[server] = {uri.Host}");
            Console.WriteLine($"[resource] = {uri.AbsolutePath}");
        }
        catch (UriFormatException)
        {
            Console.WriteLine("Invalid URL");
        }
    }
}
*/
