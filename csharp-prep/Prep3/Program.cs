using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random rand = new Random();
        int number = rand.Next(1, 101);
        Console.WriteLine($"Guess a number between 1 and 100.");
        string guess= Console.ReadLine();
        int guessInt = int.Parse(guess);
        int guessCount = 1;
        while (guessInt != number){
            if (guessInt > number){
                Console.WriteLine($"Your guess of {guessInt} is too high. Guess again.");
                guess= Console.ReadLine();
                guessInt = int.Parse(guess);
                guessCount++;
            }
            else if (guessInt < number){
                Console.WriteLine($"Your guess of {guessInt} is too low. Guess again.");
                guess= Console.ReadLine();
                guessInt = int.Parse(guess);
                guessCount++;
            }
        }
        Console.WriteLine($"It took you {guessCount} guesses.");
        Console.WriteLine($"Your guess of {guessInt} is correct!");


    }
}