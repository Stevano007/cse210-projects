public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }


    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Get Ready....");
        ShowSpinner(3);

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            Console.Write("Breathe in....");
            ShowCountdown(3);
            Console.WriteLine("");
            Console.Write("Now Breathe out....");
            ShowCountdown(4);
            Console.WriteLine("");
        }
        DisplayEndingMessage();

    }
}
