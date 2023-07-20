public class Outdoor:Events{
    private string _weatherForcast;

    public Outdoor (string type, string title, string description, DateTime date, TimeSpan time, Address address, string weatherForcast):base(type,title, description, date, time, address){
        _weatherForcast=weatherForcast;
    }
    public override string FullDetails(){
        return StandardDetails()+$"\nWeather Forcast: {_weatherForcast}";
    }
}