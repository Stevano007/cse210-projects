using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What was your grade percentage? ");
        string gradePercent= Console.ReadLine();
        int gradePercentInt = int.Parse(gradePercent);
        string letter ="";
        if (gradePercentInt >= 90)
        {
            letter= "A";
        }
        else if (gradePercentInt >= 80)
        {
             letter= "B";
        }
        else if (gradePercentInt >= 70)
        {
             letter= "C";
        }
        else if (gradePercentInt >= 60)
        {
             letter= "D";
        }
        else
        {
             letter= "F";
        }
        Console.WriteLine($"Your grade is {letter}.");
        if (gradePercentInt >= 70){
            Console.WriteLine("Congratulations, You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed but you can only get better!");
        }

    }
}