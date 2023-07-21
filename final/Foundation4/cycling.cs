public class Cycling: Exercise{
      private double _speed;
          
            public Cycling(DateTime date,string type, double length, double speed):base(date,type, length){
                _speed=speed;
            }
    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculateDistance(){
        return (_speed/60)*GetLength();
    }
    public override double CalculatePace(){
        return (60/_speed);
    }
}