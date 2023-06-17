using System.IO;
public class Journal{
    List<string> _entries= new List<string>();
    public void Run(){
        Display();
        double _response= Convert.ToDouble(Console.ReadLine());
        if(_response==1){
            Write();
            Run();
        }
        else if(_response==2){
            DisplayAll();

            Run();
            }
        else if(_response==3){
            Load();
            Run();
        
        }
        else if(_response==4){
            Save();
            Run();
        }
        else if(_response==5){
            Console.WriteLine("Goodbye!");
        }
        else{
            Console.WriteLine("Invalid input, please try again.");
            Run();
        }
    }
    public void Display(){
        Console.WriteLine("Welcome to your Journal!");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1.Write an entry");
        Console.WriteLine("2.Display all entries");
        Console.WriteLine("3.Load a File");
        Console.WriteLine("4.Save to a File");
        Console.WriteLine("5.Exit");
        Console.WriteLine(" What would you like to do?");
       


    }

   public void Write(){
    Prompter prompter= new Prompter();
    string _prompt= prompter.Randomize();
    Console.WriteLine(_prompt);
    Console.Write("What is your response?");
    string _response= Console.ReadLine();
    DateTime theCurrentTime = DateTime.Now;
    string dateText = theCurrentTime.ToShortDateString();
    string _writeresponse= $"Date:{dateText}  Prompt: {_prompt} Response: {_response}";
    _entries.Add(_writeresponse);
    

   }
   public void DisplayAll(){
       Console.WriteLine("Displaying all entries.....");
       foreach(string entry in _entries){
           
           Console.WriteLine(entry);
       }
   }
   

   public void Save(){
       Console.WriteLine("What would you like to name your file?(.txt)");
       string _filename= Console.ReadLine();
       using(StreamWriter file= new StreamWriter(_filename)){
           foreach(string e in _entries){
               file.WriteLine(e);
           }
           Console.WriteLine("File saved!!");
       }
  
    }
    public void Load(){
        Console.WriteLine("What is your file name?");
        string _filename= Console.ReadLine();
        Console.WriteLine("Loading file....");
        using(StreamReader readfile = new StreamReader(_filename)){
            string _line;
            while((_line=readfile.ReadLine())!=null){
                Console.WriteLine(_line);
            }
        }


    }
       
}
