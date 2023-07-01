using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        void Menu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1.Start breathing activity");
            Console.WriteLine("    2.Start reflecting activity");
            Console.WriteLine("    3.Start listing activity");
            Console.WriteLine("    4.Quit");
            Console.WriteLine("Select a choice from the menu?");
            int response = Convert.ToInt32(Console.ReadLine());



            if (response == 1)
            {
                Console.Write("How long would you like to do this activity for? (seconds)");
                int duration = Convert.ToInt32(Console.ReadLine());
                string name = "breathing";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
                BreathingActivity breathingActivity1 = new BreathingActivity(name, description, duration);
                breathingActivity1.Run();
            }
            else if (response == 2)
            {
                Console.Write("How long would you like to do this activity for? (seconds)");
                int duration = Convert.ToInt32(Console.ReadLine());
                string name = "reflecting";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Reflecting reflectingActivity1 = new Reflecting(name, description, duration);
                reflectingActivity1.Run();


            }
            else if (response == 3)
            {
                Console.Write("How long would you like to do this activity for? (seconds)");
                int duration = Convert.ToInt32(Console.ReadLine());
                string name = "listing";
                string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
                ListingActivity listingActivity1 = new ListingActivity(name, description, duration);
                listingActivity1.Run();
            }
            else if (response == 4)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                Menu();
            }
        }



        Menu();
    }

}
