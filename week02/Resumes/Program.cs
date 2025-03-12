using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company = "Google";
        job1._title = "Software Engineer";
        job1._startYear = 1995;
        job1._endYear = 1999;
        

        Job job2 = new Job();
        job2._company = "Amazon";
        job2._title = "Architect";
        job2._startYear = 2001;
        job2._endYear = 2015;
        

        Resume resume = new Resume();
        resume._name = "John Doe";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeDetails();
    }
}