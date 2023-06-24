public class Reference{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;


public Reference(string book, int chaptr, int verses){
    _book=book;
    _chapter=chaptr;
    _verse=verses;
    
}

public Reference(string book, int chaptr, int verses, int endverse){
    _book=book;
    _chapter=chaptr;
    _verse=verses;
    _endverse=endverse;
}
public string GetDisplayText(){
    
   Reference myPassage= new Reference(_book, _chapter, _verse, _endverse);
   if (_endverse==0){
    return $"{_book} {_chapter}:{_verse}";
    }
   else return $"{_book} {_chapter}:{_verse}-{_endverse}";
}
}