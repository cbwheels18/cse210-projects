public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who is someone that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "What are some things you are grateful for today?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string activityName, string activityDescription, int activityDuration) : base(activityName, activityDescription, activityDuration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.WriteLine("Get ready to list your thoughts.");
        ShowSpinner(3);
        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomPromptIndex];
        Console.WriteLine($"\n--- Prompt ---\n{prompt}\n");
        ShowCountDown(5);
        Console.WriteLine($"List as many items as you can in {duration} seconds.\n");
        DateTime startTime = DateTime.Now;
        int itemCount = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write($"> ");
            string userInput = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(userInput))
            {
                itemCount++;
            }
        }
        Console.WriteLine($"\nTime's up! You listed {itemCount} items.");

        ShowSpinner(3);
        DisplayEndingMessage();
    }
}
