using System;


public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string book, int chapter, int verse)
    
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; 
    }

    public string GetDisplayText()
    {
        if (_endVerse > 0 && _endVerse > _verse)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}