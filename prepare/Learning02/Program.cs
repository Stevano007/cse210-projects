using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1= new Job();
        job1._jobTitle = "Doctor";
        job1._companyName= "Phizer";
        job1._startYear= 1999;
        job1._endYear= 2020;

        Job job2= new Job();
        job2._jobTitle = "Software Engineer";
        job2._companyName= "Google";
        job2._startYear= 2002;
        job2._endYear= 2019;

        Resume resume1= new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name= "Stephen David";
        
       
        resume1.DisplayResume();


    }
}