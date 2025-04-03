using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Matthew Jonhson", "math");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("John Doey", "Math", "Section 5.2", "Problems 1-10");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Jackson Dew", "History", "The Great War");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}