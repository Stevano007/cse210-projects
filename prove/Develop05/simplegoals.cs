public class SimpleGoals : Goals
{
    private bool _isComplete;

    public bool GetIsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public SimpleGoals(string shortName, string description, int points) : base(shortName, description, points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations you have earned {_points} points ");

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"SimpleGoal, {_shortName},{_description},{_points},{_isComplete}";

        return goalString;
    }
}