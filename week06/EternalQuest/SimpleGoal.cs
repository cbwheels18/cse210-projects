public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            int points = GetPoints();
            Console.WriteLine($"You earned {points} points for completing the simple goal.");
            return points;
        }
        else
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

    public override string GetDisplayString()
    {
        string goalReturn = (_isComplete) ? "[X]" : "[ ]";
        return $"{goalReturn} {GetDetailsString()}";
    }


}