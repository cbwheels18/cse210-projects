public abstract class Activity
{
    private string _date;
    private int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string Date()
    {
        return _date;
    }

    public int Duration()
    {
        return _duration;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public virtual string GetSummary()
    {
        return $"{Date()} ({Duration()} min): Distance {Distance():0.00} miles, Speed {Speed():0.0} mph, Pace: {Pace():0.0} min/mile";
    }
}