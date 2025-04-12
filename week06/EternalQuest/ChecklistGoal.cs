public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int pointsEarned = GetPoints();

            if (_amountCompleted == _target)
            {
                pointsEarned += _bonus;
                Console.WriteLine($"Congratulations! You have completed the checklist goal and earned {_bonus} bonus points!");
            }

            Console.WriteLine($"You earned {pointsEarned} points.");
            Console.WriteLine($"Checklist goal '{GetStringRepresentation()}' has been updated. Completed: {_amountCompleted}/{_target}");
            return pointsEarned;
        }
        else
        {
            Console.WriteLine("This checklist goal is already completed.");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} - Completed: {_amountCompleted}/{_target}";
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public override string GetDisplayString()
    {
        string goalReturn = (_amountCompleted == _target) ? "[X]" : "[ ]";
        return $"{goalReturn} {GetDetailsString()}";
    }

}