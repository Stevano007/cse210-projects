using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference myPassage= new Reference("John", 3, 16);
        Scriptures newScripture= new Scriptures(myPassage , "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        

        while (newScripture.IsCompletelyHidden()==false){
            Console.Write(myPassage.GetDisplayText());
            Console.Write(" ");
            Console.WriteLine(newScripture.GetDisplayText());
            newScripture.HideRandomWords(3);
            Console.WriteLine("Press enter to remove more words or type 'quit' to exit.");
            string _response= Console.ReadLine();
            
            if (_response=="quit"){
                break;
            }
            Console.Clear();

    

 }
    }
    }