public class ChecklistGoals : Goals
{
    protected int _target;
    protected int _bonus;
    protected int _amountCompleted;

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public ChecklistGoals(string shortName, string description, int points, int bonus, int target) : base(shortName, description, points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted != _target)
        {
            Console.WriteLine($"Congratulations you have earned {_points} points ");
        }
        else
        {

            Console.WriteLine($"Congratulations you have earned {_points} points and a bonus of {_bonus} points");
            _points = _points + _bonus;
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
        string checkbox = "[ ]";
        if (IsComplete() == true)
        {
            checkbox = "[X]";
        };
        return $"{checkbox} {_shortName}, ({_description})---Currently Completed: {_amountCompleted}/{_target}";

    }

    public override string GetStringRepresentation()
    {
        string goalString = $"CheckListGoal, {_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";

        return goalString;
    }
}