public class Running : Activity
{

    private int _distance;

    public Running(string date, int duration, int distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double Speed()
    {
        return (_distance / Duration()) * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

    public override double Distance()
    {
        return _distance;
    }
}