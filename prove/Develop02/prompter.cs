public class Prompter{
    List<string> _prompter;
    public Prompter(){
        _prompter= new List<string>{
            "What significant step did i take today?",
            "What challenge  did i face today and how did i deal with it?",
            "What mistake did i make today and what did i learn from it?",
            "What am i grateful for today?",
            "What did i have for breakfast, lunch and dinner today?",
            "What did i do to keep myself physically fit today?",
            "What did i do to keep myself mentally fit today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?"
        };
    }
    public string Randomize(){
        string _randomPrompt="";
        int index= new Random().Next(0,_prompter.Count);
        _randomPrompt=_prompter[index];
        return _randomPrompt;
    }
}