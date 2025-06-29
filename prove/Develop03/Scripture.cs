using System;



public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;
    
    public Reference Reference
    {
        get { return _reference; }
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();


        string[] rawWords = text.Split(new char[] { ' ', '\t', '\n', '\r' });

   
        foreach (string rawWord in rawWords)
        {
            _words.Add(new Word(rawWord));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden).ToList();

        if (unhiddenWords.Count == 0 || count <= 0)
        {
            return;
        }

        int wordsToHide = Math.Min(count, unhiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(0, unhiddenWords.Count);
            Word wordToHide = unhiddenWords[randomIndex];

            wordToHide.Hide();

            unhiddenWords.RemoveAt(randomIndex);
        }
    }

    public string GetHiddenText()
    {

        System.Text.StringBuilder hiddenText = new System.Text.StringBuilder();

        foreach (Word word in _words)
        {
            hiddenText.Append(word.GetHiddenText());
            hiddenText.Append(" "); 
        }

        return hiddenText.ToString().Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}