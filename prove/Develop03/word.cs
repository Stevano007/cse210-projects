public class Word{
  private string _text;
  private bool _isHidden;

  public Word(string text){
    _text= text;
  }
  public string GetDisplayText(){
    if (_text=="______"){
      return "______";
    }
    else return _text;

  }
  public void Hide(){
    _text= "______";
  }

  public void Show(){
    Console.WriteLine(_text);
  }
  public bool IsHidden(){
    if (_text=="______"){
      return true;
    }
    else return false;
    
  }






}