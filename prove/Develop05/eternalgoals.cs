public class EternalGoals : Goals
{


    public EternalGoals(string shortName, string description, int points) : base(shortName, description, points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;

    }

    public override void RecordEvent()
    {

        Console.WriteLine($"Congratulations you have earned {_points} points ");

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"EternalGoal, {_shortName},{_description},{_points}";

        return goalString;
    }
}