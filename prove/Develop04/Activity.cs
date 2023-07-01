public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration){
        _name=name;
        _description=description;
        _duration=duration;
    }
    

    public void DisplayStartingMessage(){
        Console.WriteLine($"welcome to the {_name} activity");
        Console.WriteLine($"{_description}");
    
    }
    

    public void DisplayEndingMessage(){
        Console.WriteLine("Welldone!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} activity");

    }

    public void ShowSpinner(int seconds){
        List<string> spinner= new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        int i=0;
        int index=0;
        while(i<=seconds)
            {
            
            Console.Write(spinner[index]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            index++;
            if(index==spinner.Count()){
                index=0;
            }
        }
}

    public void ShowCountdown(int seconds){
        for(int i=seconds; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    

}