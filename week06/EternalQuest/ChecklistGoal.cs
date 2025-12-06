using System.Formats.Tar;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

public class ChecklistGoal: Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus): base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override string GetStringRepresentaion()
    {
         return $"ChecklistGoal,{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override bool isComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override int RecordEvent()
    {
        _amountCompleted +=1;
        int amount = int.Parse(_points);
        if (isComplete())
        {
            amount += _bonus;
        }
        return amount;
    }
     public override string GetDetailsString()
    {
        string ready = " ";
        if (isComplete())
        {
            ready = "X";
        }
        return $"[{ready}] {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }
}