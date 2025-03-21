using System;

class Program
{
    static void Main(string[] args)
    {
        List<(string scriptureText, Reference reference)> scriptures = new List<(string, Reference)>
        {
            ("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", 
                new Reference("1 Nephi", 3, 7)),

            ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.", 
                new Reference("John", 3, 16)),

            ("I can do all things through Christ which strengtheneth me.", 
                new Reference("Philippians", 4, 13)),

            ("Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.", 
                new Reference("Proverbs", 3, 5, 6)),

            ("Judge not, that ye be not judged. For with what judgment ye judge, ye shall be judged: and with what measure ye mete, it shall be measured to you again.", 
                new Reference("Matthew", 7, 1, 2))
        };

        Random rand = new Random();
        int randomIndex = rand.Next(scriptures.Count);

        string selectedScripture = scriptures[randomIndex].scriptureText;
        Reference selectedReference = scriptures[randomIndex].reference;

        Scripture scripture = new Scripture(selectedReference, selectedScripture);

        Console.WriteLine("Hello and welcome to the Scripture Memorizer Program!");

        Console.WriteLine(selectedReference.GetDisplayText());
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
                Console.WriteLine(selectedReference.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
            }
        }
        
        Console.WriteLine("Congratulations! You have memorized the scripture!");
    }
}