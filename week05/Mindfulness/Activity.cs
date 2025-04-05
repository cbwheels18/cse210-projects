public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;

    private static int _activityCount = 0;

    public Activity(string activityName, string activityDescription, int activityDuration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _activityDuration = activityDuration;
    }

    public void DisplayStartingMessage()
    {
        _activityCount++;
        
        Console.WriteLine($"Welcome to the {_activityName}!\n");
        Console.WriteLine($"{_activityDescription}\n");
        Console.Write("How many seconds would you like to do this activity for? ");
        int duration = int.Parse(Console.ReadLine());
        _activityDuration = duration;
        Console.WriteLine($"\nThis activity will last for {_activityDuration} seconds.\n");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nCongratulations!");
        Thread.Sleep(5000);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName}.\n");
        Console.WriteLine($"\nTotal number of activities done so far: {_activityCount}");
        ShowSpinner(3);
        Menu menu = new Menu();
        menu.MenuActivities();

        
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Console.Write("\b");
            index = (index + 1) % spinner.Length;
            Thread.Sleep(500);
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "\b");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void SetDuration(int duration)
    {
        _activityDuration = duration;
    }

    public int GetDuration()
    {
        return _activityDuration;
    }
}