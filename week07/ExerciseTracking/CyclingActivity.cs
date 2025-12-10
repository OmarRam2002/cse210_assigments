class CyclingActivity: Activity
{
    private double _speed;

    public CyclingActivity(string date, int time, double speed):base(date, time)
    {
        _speed = speed;
        _activityName = "Cycling";
    }

    public override double CalculateDistance()
    {
        return _speed * _time;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }
}