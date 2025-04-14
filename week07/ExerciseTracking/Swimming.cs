public class Swimming : Activity 
{
    private int _laps;


    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        return (_laps * 50 / 1000.0) * 0.62;
    }

    public override double Speed()
    {
        return (Distance() / Duration()) * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}