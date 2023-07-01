public class Reflecting : Activity
{
    protected List<string> _prompts = new List<string>();
    protected List<string> _questions = new List<string>();

    public Reflecting(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public string GetRandomPrompt()
    {
        _prompts = new List<string>{
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };
        string randomPrompt = "";
        int index = new Random().Next(0, _prompts.Count());
        randomPrompt = _prompts[index];
        return randomPrompt;
    }

    public string GetRandomQuestion()
    {

        _questions = new List<string>{
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"
        };
        string getRandomQuestion = "";
        int index = new Random().Next(0, _questions.Count());
        getRandomQuestion = _questions[index];
        return getRandomQuestion;
    }


    public void DisplayRandomPrompt()
    {
        Console.WriteLine(" Consider the following prompt:");
        Console.WriteLine(" ");

        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine(" When you have something in mind press 'Enter' to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experirence");
        Console.Write("You may begin in: ");


    }
    public void DisplayRandomQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public void Run()
    {

        DisplayStartingMessage();
        Console.WriteLine("Get Ready....");
        ShowSpinner(10);
        Console.WriteLine(" ");
        DisplayRandomPrompt();
        ShowCountdown(3);
        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            DisplayRandomQuestions();
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }

}




