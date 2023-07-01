public class ListingActivity:Activity{

    protected int _count;
    protected List<string> _prompt;
    public ListingActivity(string name, string description, int duration):base(name, description, duration){
        _name=name;
        _description=description;
        _duration=duration;
    }
    
    public string GetRandomPrompt(){
        _prompt=new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        string randomPrompt="";
        int index= new Random().Next(0,_prompt.Count());
        randomPrompt= _prompt[index];
        return randomPrompt;
    }

    public  void DisplayPrompt(){
        Console.WriteLine(GetRandomPrompt());
        Console.Write("Think About What you want to list, List in 5 seconds: ");
        ShowCountdown(5);
        
    }
    public void GetListFromUser(){
        DateTime currentTime= DateTime.Now;
        DateTime endTime= currentTime.AddSeconds(_duration);
       List<string> response = new List<string>();
        while(currentTime<endTime){
            currentTime=DateTime.Now;
            Console.Write("Enter item: ");
            string item= Console.ReadLine();
            response.Add(item);
            _count++;
        }
        Console.WriteLine($"You have listed {_count} items");
        Console.WriteLine($"Your list is:  ");
        foreach(string item in response){
          Console.WriteLine(item);
        }
        
 }

  public void Run(){
    DisplayStartingMessage();
    Console.Write("Get Ready....");
    ShowSpinner(5);
    Console.Clear();
    DisplayPrompt();
    GetListFromUser();

    DisplayEndingMessage();
        

    }
    
    }
   

