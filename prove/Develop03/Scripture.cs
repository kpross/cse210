using System;
using System.Collections.Generic;
using System.Linq; // Needed for .Where() and .All()


// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------



public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // We keep the Reference immutable once set.
    public Reference Reference
    {
        get { return _reference; }
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the text into individual words, removing any empty entries.
        string[] rawWords = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Create a Word object for each raw word.
        foreach (string rawWord in rawWords)
        {
            _words.Add(new Word(rawWord));
        }
    }

    public void HideRandomWords(int count)
    {
        // Get all words that aren't hidden yet.
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden).ToList();

        // If there are no words to hide or the count is zero, just return.
        if (unhiddenWords.Count == 0 || count <= 0)
        {
            return;
        }

        // Don't try to hide more words than are available.
        int wordsToHide = Math.Min(count, unhiddenWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            // Pick a random unhidden word.
            int randomIndex = _random.Next(0, unhiddenWords.Count);
            Word wordToHide = unhiddenWords[randomIndex];

            // Hide the selected word.
            wordToHide.Hide();

            // Remove it from our temporary list so we don't hide it again in this round.
            unhiddenWords.RemoveAt(randomIndex);
        }
    }

    public string GetRenderedText()
    {
        // Build the display string efficiently.
        System.Text.StringBuilder renderedText = new System.Text.StringBuilder();

        foreach (Word word in _words)
        {
            renderedText.Append(word.GetRenderedText());
            renderedText.Append(" "); // Add a space after each word.
        }

        // Return the final string, trimming any extra space at the end.
        return renderedText.ToString().Trim();
    }

    public bool IsCompletelyHidden()
    {
        // Check if every word in the scripture is hidden.
        return _words.All(word => word.IsHidden);
    }
}