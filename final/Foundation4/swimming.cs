public class Swimming:Exercise{
      private double _laps;

        public Swimming(DateTime date,string type, double length, double laps):base(date,type, length){
            _laps=laps;
        }
    public override double CalculateDistance()
    {
        return ((_laps*50)/1000)*0.62;
    }
    public override double CalculateSpeed(){
        return (CalculateDistance()/GetLength())*60;
    }
    public override double CalculatePace(){
        return (GetLength()/CalculateDistance());
    }

}