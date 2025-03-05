using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int number = -1;
        List<int> numberList = new List<int>();

        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numberList.Add(number);
            }
        }
        
        int sum = numberList.Sum();
        double average = numberList.Average();
        int max = numberList.Max();
        Console.WriteLine($"The Sum is {sum}");
        Console.WriteLine($"The Average is {average}");
        Console.WriteLine($"The Max is {max}");
    }
}