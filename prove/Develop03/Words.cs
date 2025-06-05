using System;

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------


public class Word
{
    private string _text;
    private bool _isHidden;

    // The word's text is read-only after creation.
    public string Text
    {
        get { return _text; }
    }

    // Check if the word is currently hidden.
    public bool IsHidden
    {
        get { return _isHidden; }
    }

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // A new word starts out visible.
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string GetRenderedText()
    {
        // If the word is hidden, return underscores; otherwise, return the word itself.
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}