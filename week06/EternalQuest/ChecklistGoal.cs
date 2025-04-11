public class ChecklistGoal : Goal
{
    private int _amountcompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _amountcompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return _amountcompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetDetailsString()} - Checklist Goal - Completed: {_amountcompleted}/{_target} - Bonus: {_bonus} points";
    }
}