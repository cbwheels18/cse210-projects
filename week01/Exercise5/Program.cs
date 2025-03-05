using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName("");
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(string userName)
    {
        Console.Write("What is your username? ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        return userNumber;
    }

    static int SquareNumber(int squareNumber)
    {
        squareNumber = squareNumber * squareNumber;
        return squareNumber;
    }

    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }
}