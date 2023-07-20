public class Lectures:Events{
    private string _speaker;
    private int _capacity;

    public Lectures(string type, string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity):base(type,title, description, date, time, address){
        _speaker=speaker;
        _capacity=capacity;
    }
    public string GetSpeaker(){
        return _speaker;
    }
    public override string FullDetails(){
        return StandardDetails()+$"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}