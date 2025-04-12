public class EternalGoal : Goal
{

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        int points = GetPoints();
        Console.WriteLine($"Eternal goal '{GetName()}' recorded! You earned {points} points.");
        return points;
    }


    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }

    public override string GetDisplayString()
    {
        return $"[∞] {GetDetailsString()}";
    }

}