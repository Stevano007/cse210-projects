public class Running:Exercise{
    private double _distance;

    public Running(DateTime date,string type, double length, double distance):base(date,type, length){
        _distance=distance;
    }

    public override double CalculateSpeed(){
        return (_distance/GetLength())*60;

    }
    public override double CalculateDistance(){
        return _distance;
    }
    public override double CalculatePace(){
        return (GetLength()/_distance);
    }

}