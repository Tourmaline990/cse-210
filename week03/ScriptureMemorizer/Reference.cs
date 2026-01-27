using System.Data.SqlTypes;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _endverse;

    public Reference(string book,int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endverse = verse;
    }
    public Reference(string book,int chapter,int startverse,int endverse )
    {
        _book = book;
        _chapter = chapter;
        _verse = startverse;
        _endverse = endverse;
    }
    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}-{_endverse}";
    }

}