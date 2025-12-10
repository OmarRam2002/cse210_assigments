abstract class Activity
{
    protected string _date;
    protected int _time;
    protected string _activityName;

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;

    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    public string GetSummary()
    {
        return $"{_date} {_activityName} ({_time} min)- Distance {CalculateDistance().ToString("0.0")} miles, Speed {CalculateSpeed().ToString("0.0")} mph, Pace {CalculatePace().ToString("0.0")} min per mile.";
    }
}