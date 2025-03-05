using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != magicNumber)
        {   
            Console.Write("what is the magic number? ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Incorrect guess, try again. Guess a number between 1 and 100");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Correct, you guessed it!");
            }
        }
        
    }
}