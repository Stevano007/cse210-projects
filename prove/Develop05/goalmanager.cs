public class GoalManagr
{
    List<Goals> _goals = new List<Goals>();
    private int _score;
    public void Start()
    {


        DisplayPlayerInfo();
        Console.WriteLine("Menu Options:  ");
        Console.WriteLine("1.Create New Goal");
        Console.WriteLine("2.List Goals");
        Console.WriteLine("3.Save Goals");
        Console.WriteLine("4.Load Goals");
        Console.WriteLine("5.Record Event");
        Console.WriteLine("6.Quit");
        Console.WriteLine("Select a Choice from the menu ");
        int response = Convert.ToInt32(Console.ReadLine());
        if (response == 1)
        {
            Console.Clear();
            Console.WriteLine("The type of Goals are:");
            Console.WriteLine("1.Simple Goal");
            Console.WriteLine("2.Eternal Goal");
            Console.WriteLine("3.Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create?");
            CreateGoal();
            Start();
        }
        else if (response == 2)
        {
            Console.Clear();
            ListGoalDetails();
            Start();
        }
        else if (response == 3)
        {
            Console.Clear();
            SaveGoals();
            Console.WriteLine("Goals have been saved");
            Start();
        }
        else if (response == 4)
        {
            Console.Clear();
            LoadGoalsFile();
            Console.WriteLine("Goals have been loaded");
            Start();
        }



        else if (response == 5)
        {
            Console.Clear();
            RecordEvent();
            Start();
        }

        else if (response == 6)
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid input, please try again.");
            Start();
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goals goal in _goals)
        {
            Console.Write($"{index}. ");
            Console.WriteLine(goal.GetShortName());
            index++;
        }

    }
    public void ListGoalDetails()
    {
        int index = 1;
        foreach (Goals goal in _goals)
        {
            Console.Write($"{index}. ");
            Console.WriteLine(goal.GetDetailsString());
            index++;
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("My Goals List: ");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        int response3 = Convert.ToInt32(Console.ReadLine());
        int index = response3 - 1;
        _goals[index].RecordEvent();
        _score += _goals[index].GetPoints();


    }
    public void CreateGoal()
    {
        int response2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the name of your goal");
        string shortName = Console.ReadLine();
        Console.WriteLine("What is the description of your goal");
        string description = Console.ReadLine();
        Console.WriteLine("what is the amount of points associated with this goal?");
        int points = Convert.ToInt32(Console.ReadLine());
        if (response2 == 1)
        {
            SimpleGoals simpleGoals = new SimpleGoals(shortName, description, points);
            _goals.Add(simpleGoals);

        }
        else if (response2 == 2)
        {
            EternalGoals eternalGoals = new EternalGoals(shortName, description, points);
            _goals.Add(eternalGoals);

        }
        else if (response2 == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished to meet the target?");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the bonus point on completion?");
            int bonus = Convert.ToInt32(Console.ReadLine());
            ChecklistGoals checklistGoals = new ChecklistGoals(shortName, description, points, bonus, target);
            _goals.Add(checklistGoals);
        }
        Console.WriteLine("Your goal has been created");

    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the name of the file you would like to save to?");
        string fileName = Console.ReadLine();
        StreamWriter writer = new StreamWriter(fileName);

        foreach (Goals goal in _goals)
        {
            writer.WriteLine(goal.GetStringRepresentation());

        }

        writer.Close();
    }
    public void LoadGoalsFile()
    {
        Console.WriteLine("What is the name of the file you would like to load?");
        string fileName = Console.ReadLine();
        StreamReader reader = new StreamReader(fileName);
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            string[] values = line.Split(',');
            string type = values[0];
            string shortName = values[1];
            string description = values[2];
            int points = Convert.ToInt32(values[3]);

            if (type == "SimpleGoal")
            {

                SimpleGoals simpleGoals = new SimpleGoals(shortName, description, points);
                simpleGoals.SetIsComplete(Convert.ToBoolean(values[4]));

                _goals.Add(simpleGoals);
            }
            else if (type == "EternalGoal")
            {
                EternalGoals eternalGoals = new EternalGoals(shortName, description, points);
                _goals.Add(eternalGoals);
            }
            else if (type == "CheckListGoal")
            {
                int bonus = Convert.ToInt32(values[4]);
                int target = Convert.ToInt32(values[5]);
                ChecklistGoals checklistGoals = new ChecklistGoals(shortName, description, points, bonus, target);
                checklistGoals.SetAmountCompleted(Convert.ToInt32(values[6]));
                _goals.Add(checklistGoals);
            }

        }
    }
}
