using System;

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------


public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // --- we are adding this layer of seperation to allow greater control on what gets plugged in versus what
    // gets spat out ---

    public Reference(string book, int chapter, int verse, int endVerse)
    // allows to plug in the info
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public Reference(string book, int chapter, int verse)
    // this allows them to not need to manually enter 0 when entering the verse
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0; // indicates not a range see the if/else later in the code
    }

    public string GetDisplayText()
    // what the class will spit out
    {
        if (_endVerse > 0 && _endVerse > _verse) // checks for the range
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}