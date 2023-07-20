public class Events{
    private string _type;
    private string _title;
    private string _description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Events(string type ,string title, string description, DateTime date, TimeSpan time, Address address){
        _type=type;
        _title=title;
        _description=description;
        this.date=date;
        this.time=time;
        this.address=address;
    }
    public string StandardDetails(){
         return $"Event Title: {_title}\nEvent Description: {_description}\nEvent Date: {date.ToShortDateString()}\nEvent Time: {time.ToString()}\nEvent Address: {address.GetFullAddress()}";
    }   
    public virtual string FullDetails(){
        return StandardDetails();
    }

    public virtual string ShortDescription(){
          return $"Type: {_type}\nTitle: {_title}\nDate: {date.ToShortDateString()}";
    }
}