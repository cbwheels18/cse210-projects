using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What grade percentage do you have in the class? ");
        string customer_input = Console.ReadLine();
        int percentage = int.Parse(customer_input);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            letter = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";           
        }
        Console.WriteLine($"You have an {letter}!");

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed! Congrats");
        }
        else
        {
            Console.WriteLine("Failed, Try again!");
        }

    }
}