using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        first = first.Substring(0, 1).ToUpper() + first.Substring(1).ToLower();
        
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        last = last.Substring(0, 1).ToUpper() + last.Substring(1).ToLower();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}