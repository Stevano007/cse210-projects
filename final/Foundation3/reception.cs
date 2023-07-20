public class Reception:Events{
   private string _rsvpEmail;

    public Reception(string type, string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail):base(type,title, description, date, time, address){
         _rsvpEmail=rsvpEmail;
    }
    public override string FullDetails(){
        return StandardDetails()+$"\nRSVP Email: {_rsvpEmail}";
    }
}