public  abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _description = description;
        _points = points;
        _shortName = name;
    }

    public abstract int RecordEvent();
    public abstract bool isComplete();
    public abstract string GetStringRepresentaion();
    public abstract string GetDetailsString();
    
    public string GetGoalname()
    {
        return _shortName;
    }
}