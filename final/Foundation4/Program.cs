using System;

class Program
{
    static void Main(string[] args)
    {
        List<Exercise> exercises = new List<Exercise>();

        exercises.Add(new Running(new DateTime(2023, 07, 21),"Running",30, 5));
        exercises.Add(new Cycling(new DateTime(2023, 07, 22),"Cycling", 45,10 ));
        exercises.Add(new Swimming(new DateTime(2023,07, 23),"Swimming", 5, 20));

        foreach (Exercise exercise in exercises)
        {
            string summary = exercise.Summary();
            Console.WriteLine(summary);
        }
    }
}

