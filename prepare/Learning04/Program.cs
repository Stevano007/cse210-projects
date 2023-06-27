using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment myAssignment= new Assignment("Jane", "Math");
        string myAssgn= myAssignment.GetSummary();
        Console.WriteLine(myAssgn);
        WritingAssignment myWritingAssignment= new WritingAssignment("Joseph", "Art", "The Mona Lisa");
        string myWritingAssgn= myWritingAssignment.GetWritingInformation();
        Console.WriteLine(myWritingAssgn);

    }    
}