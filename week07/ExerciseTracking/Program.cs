using System;

class Program
{
    static void Main(string[] args)
    {
        Running run = new Running("4/14/2025", 30, 5);
        Swimming swim = new Swimming("4/14/2025", 40, 20);
        StationaryBicycles bike = new StationaryBicycles("4/14/2025", 15, 30);

        List<Activity> activities = new List<Activity>();
        activities.Add(run);
        activities.Add(swim);
        activities.Add(bike);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}