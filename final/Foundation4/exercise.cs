public abstract class Exercise{
    private DateTime _date;
    private string _type;
    private double _length;

    public Exercise(DateTime date,string type, double length){
        _date=date;
        _type=type;
        _length=length;
    }
    public DateTime GetDate(){
        return _date;
    }
    public double GetLength(){
        return _length;
    }

    public abstract double CalculateSpeed();
    public abstract double CalculateDistance();
    public abstract double CalculatePace();
    public virtual string Summary(){
        double speed = CalculateSpeed();
        double distance = CalculateDistance();
        double pace = CalculatePace();
        string summary= $"{_date.ToShortDateString()} {_type}({_length} min)-Distance {distance} miles, Speed {speed} mph, Pace {pace} min per mile";
        return summary;
    }
}