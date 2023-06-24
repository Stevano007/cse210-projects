public class Scriptures{
   private Reference _reference;
   private List<Word> _words= new List<Word>();

   public Scriptures(Reference reference, string text){
      _reference= reference;
      List<string> textList= text.Split(" ").ToList();
      foreach(string word in textList){
         Word words = new Word(word);
         _words.Add(words);
   }
   }
   public void HideRandomWords(int numberToHide){
      Random rnd = new Random();
      for (int i=0; i<numberToHide; i++){
         int index= rnd.Next(0, _words.Count);
         _words[index].Hide();

      }
   
   }
   public string GetDisplayText(){
      string displayText="";
      foreach(Word word in _words){
         displayText+=word.GetDisplayText()+" ";
      }
      return displayText;

   }
   public bool IsCompletelyHidden(){
      foreach(Word word in _words){
         if (word.IsHidden()==false){
            return false;
         }
      }
      return true;
   }






}