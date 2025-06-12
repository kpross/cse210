using System;
using System.Collections.Generic; // Required for List<T>
using System.Linq; // Required for LINQ methods like .Where() and .ToList()

// -------------------------------------------
// AI GENERATED FOR EXAMPLE AND LEARNING
// -------------------------------------------

// The 'Scripture' class is responsible for managing a scripture reference
// and the collection of words that make up its text. It orchestrates the
// hiding of words and provides the rendered display.
public class aiScripture
{
    // --- Private Attributes (Fields) ---
    // These fields store the core data for the Scripture object.
    // '_reference' holds the location details, and '_words' holds the individual words.
    private aiReference _reference; // An instance of our Reference class
    private List<Word> _words;    // A list of Word objects representing the scripture text
    private Random _random;       // Used for randomly selecting words to hide

    // --- Public Properties (Getters) ---
    // We provide a getter for the Reference object, but no setter, as the reference
    // for a Scripture object should be immutable after creation.
    public aiReference Reference
    {
        get { return _reference; }
    }

    // --- Constructor ---
    // The constructor initializes a new Scripture object, parsing the text
    // into individual Word objects.

    /// <summary>
    /// Initializes a new instance of the Scripture class.
    /// This constructor takes a Reference object and the full text of the scripture.
    /// It then parses the text into individual Word objects and stores them internally.
    /// </summary>
    /// <param name="reference">The Reference object for this scripture.</param>
    /// <param name="text">The full string text of the scripture.</param>
    public aiScripture(aiReference reference, string text)
    {
        // Assign the provided Reference object to our private field.
        _reference = reference;

        // Initialize the list that will hold our Word objects.
        _words = new List<Word>();

        // Initialize the Random object for use in hiding words.
        _random = new Random();

        // Split the input text into individual words.
        // We use StringSplitOptions.RemoveEmptyEntries to avoid empty strings
        // if there are multiple spaces.
        string[] rawWords = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Iterate through each raw word string.
        foreach (string rawWord in rawWords)
        {
            // Create a new 'Word' object for each string and add it to our list.
            _words.Add(new Word(rawWord));
        }
    }

    // --- Public Methods ---
    // These methods define the behaviors of the Scripture class.

    /// <summary>
    /// Hides a specified number of currently unhidden words at random.
    /// </summary>
    /// <param name="count">The number of words to attempt to hide.</param>
    public void HideRandomWords(int count)
    {
        // Get a list of all words that are currently NOT hidden.
        // Using LINQ's .Where() to filter and .ToList() to create a new list.
        List<Word> unhiddenWords = _words.Where(word => !word.IsHidden).ToList();

        // If there are no unhidden words left, or if the requested count is zero,
        // there's nothing to hide, so we return.
        if (unhiddenWords.Count == 0 || count <= 0)
        {
            return;
        }

        // Ensure we don't try to hide more words than are available.
        int wordsToHide = Math.Min(count, unhiddenWords.Count);

        // Loop to hide the specified number of words.
        for (int i = 0; i < wordsToHide; i++)
        {
            // Generate a random index within the range of unhidden words.
            int randomIndex = _random.Next(0, unhiddenWords.Count);

            // Get the randomly selected word.
            Word wordToHide = unhiddenWords[randomIndex];

            // Call the Hide() method on the selected Word object.
            wordToHide.Hide();

            // Remove the hidden word from our temporary 'unhiddenWords' list
            // to ensure we don't select it again in this same hiding operation.
            unhiddenWords.RemoveAt(randomIndex);
        }
    }

    /// <summary>
    /// Returns the complete scripture text, with hidden words replaced by underscores.
    /// </summary>
    /// <returns>A string representing the scripture with hidden words rendered as underscores.</returns>
    public string GetRenderedText()
    {
        // Use a StringBuilder for efficient string concatenation, especially in loops.
        System.Text.StringBuilder renderedText = new System.Text.StringBuilder();

        // Iterate through each Word object in our '_words' list.
        foreach (Word word in _words)
        {
            // Get the rendered text for each word (either the word itself or underscores).
            renderedText.Append(word.GetRenderedText());
            renderedText.Append(" "); // Add a space after each word
        }

        // Convert the StringBuilder content to a string and trim any trailing space.
        return renderedText.ToString().Trim();
    }

    /// <summary>
    /// Checks if all words in the scripture are currently hidden.
    /// </summary>
    /// <returns>True if all words are hidden, false otherwise.</returns>
    public bool IsCompletelyHidden()
    {
        // Use LINQ's .All() method for a concise check.
        // It returns true if the condition (word.IsHidden) is true for ALL elements.
        return _words.All(word => word.IsHidden);

        // Alternatively, a traditional loop:
        // foreach (Word word in _words)
        // {
        //     if (!word.IsHidden) // If we find even one word that is NOT hidden
        //     {
        //         return false; // The scripture is not completely hidden
        //     }
        // }
        // return true; // If the loop finishes, all words must be hidden
    }
}