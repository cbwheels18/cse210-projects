using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Please Select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Pick the number for the action you would like to take:  ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput); 
            
            if (choice == 1)
            {   
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your Journal Entry: ");
                string entryText = Console.ReadLine();
                Console.Write("What is your current mood? ");
                string entryMood = Console.ReadLine();
                Console.Write("Are you currently at Home, Work, School, Bakery etc? ");
                string entryLocation = Console.ReadLine();
                Entry newEntry = new Entry(prompt, entryText, entryMood, entryLocation);
                journal.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the name of the file you are trying to load? ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (choice == 4)
            {
                Console.Write("What do you want to name your journal entry file? ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Come again soon! Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice, try again!");
            }
        }
    }
}