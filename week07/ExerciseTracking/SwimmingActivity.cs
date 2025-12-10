class SwimmingActivity: Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(string date, int time, int numberOfLaps): base (date, time)
    {
        _numberOfLaps = numberOfLaps;
        _activityName = "Swimming";

    }

    public override double CalculateDistance()
    {
        return _numberOfLaps * 50;
    }

    public override double CalculatePace()
    {
        return _time / CalculateDistance() * 100;
    }

    public override double CalculateSpeed()
    {
        return (_numberOfLaps * 50) / _time;
    }
}