using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Please Enter a number, Enter 0 when you're done.");
        string strNumber = Console.ReadLine();
        int number= int.Parse(strNumber);
        List<int> numList= new List<int>();
        while (number !=0){
            numList.Add(number);
            Console.WriteLine("Please Enter a number, Enter 0 when you're done.");
            strNumber = Console.ReadLine();
            number= int.Parse(strNumber);


        }
        int sum = 0;
        foreach (int num in numList){
            sum += num;
        
        }
        int average= sum/numList.Count;
        int max= numList[0];
        foreach(int num in numList){
            if(num > max){
                max=num;
            }
        }
        List<int> newList= new List<int>();
        foreach (int num in numList){
            if(num>=0){
                
                newList.Add(num);
            }
        }    
        int smallest = newList[0];
        foreach (int newL in newList){
                    if(newL<smallest){
                        smallest= newL;
                    }
                
            };

       

        
        

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The max is: {max}.");
        Console.WriteLine($"The smallest positive number is: {smallest}.");

        List<int> sortedList= new List<int>();
        sortedList= numList;
        sortedList.Sort();
        Console.WriteLine("the sorted list is: ");
        foreach (int sort in sortedList){
           
            Console.WriteLine(sort);

            
        }
       
        



    }
}