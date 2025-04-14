public class StationaryBicycles : Activity
{
    private int _speed;

    public StationaryBicycles(string date, int duration, int speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return (_speed / 60.0) * Duration();
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }

}