using System;

public class Job
{
    public string _company = "";
    public string _title = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }
}