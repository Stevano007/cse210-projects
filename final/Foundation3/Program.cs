using System;

class Program
{
    static void Main(string[] args)
    {
        List<Events> Events = new List<Events>();
        Address address1 = new Address("Ozumba Way", "Lekki", "Lagos", "Nigeria");
        Address address2 = new Address("Elm St", "Sao Paulo", "Sao Paulo", "Brazil");
        Address address3 = new Address("Ocean Drive", "Miami", "Florida", "USA");

        Lectures lecture = new Lectures("Lecture", "C#","Introduction to C#", new DateTime(2023, 7, 25), new TimeSpan(14, 0, 0), address1, "Elon Musk", 50);
        Reception reception = new Reception("Reception","Networking Event", "Meet and Greet", new DateTime(2023, 8, 1), new TimeSpan(18, 30, 0), address2, "rsvp@example.com");
        Outdoor outdoorGathering = new Outdoor("Outdoor","Football Match", "Team Gravy vs Team Snow" ,new DateTime(2023, 8, 15), new TimeSpan(12, 0, 0), address3, "Freezing Cold");
        Events.Add(lecture);
        Events.Add(reception);
        Events.Add(outdoorGathering);

        foreach(Events Event in Events){
            Console.WriteLine(Event.StandardDetails());
            Console.WriteLine();
            Console.WriteLine(Event.FullDetails());
            Console.WriteLine();
            Console.WriteLine(Event.ShortDescription());

        }
        
    }
}