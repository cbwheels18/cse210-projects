public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal '{GetStringRepresentation()}' has been recorded.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetDetailsString()} - Eternal Goal";
    }
}