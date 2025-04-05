using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Menu menu = new Menu();
        string activity = menu.MenuActivities();
    }
}