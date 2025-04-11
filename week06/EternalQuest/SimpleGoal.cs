public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {

    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Simple goal '{GetStringRepresentation()}' has been completed.");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{GetDetailsString()} - Completed: {_isComplete}";
    }


}