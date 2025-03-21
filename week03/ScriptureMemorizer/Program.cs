using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to the Scripture Memorizer Program!");
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Reference reference = new Reference("1 Nephi", 3, 7, 0);
        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());

        while (scripture.IsCompletelyHidden() == false)
        {   
            Console.WriteLine();
            Console.WriteLine("Try to memorize the scripture. Press Enter to continue or type 'quit' to exit...");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Exiting program...");
                return;
            } else 
            {
                Console.Clear();
                scripture.HideRandomWords(2);
                Console.WriteLine(reference.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
            }
        }
        
        Console.WriteLine("Congratulations! You have memorized the scripture!");
    }
}