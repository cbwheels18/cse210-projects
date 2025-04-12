using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!\n");
        Console.WriteLine("Track goals and have fun while doing it by earning points, experience, and the rewards of completing them!\n");
        GoalManager goalManager = new GoalManager();
        goalManager.MenuEternalQuest();
    }
}