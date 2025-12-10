class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int time, double distance) : base(date, time)
    {
        _distance = distance;
        _activityName ="Running";
    }

    public override double CalculateDistance()
    {
        return _distance;
    }

    public override double CalculatePace()
    {
        return _time / _distance;
    }

    public override double CalculateSpeed()
    {
        return (_distance / _time) * 60;
    }
}