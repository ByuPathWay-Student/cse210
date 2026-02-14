public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;   
    public CheckListGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points = $"{Convert.ToInt32(_points) + _bonus}";
        }
    }

    public override bool IsComplete()
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

    public override string GetDetailsString()
    {
        
        string checkBox = "[ ]";
        if (IsComplete())
        {
            checkBox = "[X]";
        }
        
        return $"{checkBox} {_shortName} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}