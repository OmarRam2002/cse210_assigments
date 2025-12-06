public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, string points): base(name,description, points){  }

    public override string GetStringRepresentaion()
    {
         return $"EternalGoal,{_shortName},{_description},{_points}";
    }

    public override bool isComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return int.Parse(_points);
    }
    
     public override string GetDetailsString()
    {
        string ready = " ";
        if (isComplete())
        {
            ready = "X";
        }
        return $"[{ready}] {_shortName} ({_description})";
    }
}