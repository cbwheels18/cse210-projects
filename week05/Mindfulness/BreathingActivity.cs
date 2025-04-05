public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription, int activityDuration) : base(activityName, activityDescription, activityDuration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int breath = GetDuration();

        Console.WriteLine("Get ready to breathe in and out.");
        ShowSpinner(3);

        while (breath > 0)
        {
            Console.Clear();
            BreatheInAnimation();
            ShowCountDown(3);
            
            Console.Clear();
            BreatheOutAnimation();
            ShowCountDown(5);
            
            breath -= 8;
        }

        ShowSpinner(3);
        DisplayEndingMessage();
    }

    private void BreatheInAnimation()
    {
        int maxSpaces = 10;

        for (int i = 0; i <= maxSpaces; i++)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', i)); 
            Console.Write("Breathe in...");
            Thread.Sleep(150);
        }
    }

    private void BreatheOutAnimation()
    {
        int maxSpaces = 10; 

        for (int i = maxSpaces; i >= 0; i--)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', i));
            Console.Write("Breathe out...");
            Thread.Sleep(200);
        }
    }
}
