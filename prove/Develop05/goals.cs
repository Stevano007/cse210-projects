public abstract class Goals
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public string GetShortName()
    {
        return _shortName;
    }
    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete() == true)
        {
            checkbox = "[X]";
        };

        return $"{checkbox} {_shortName}, {_description}";
    }
    public abstract string GetStringRepresentation();




    public Goals(string shortName, string description, int points)
    {

        _shortName = shortName;
        _description = description;
        _points = points;
    }

}