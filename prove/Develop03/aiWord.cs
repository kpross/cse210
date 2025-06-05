using System;

// -------------------------------------------
// AI WAS USED TO HELP EDIT AND ANNOTATE CODE
// -------------------------------------------

// The 'Word' class encapsulates a single word from a scripture and manages
// its visibility (whether it is shown or hidden). It adheres to encapsulation
// by keeping its state private and providing controlled access.
public class aiWord
{
    // --- Private Attributes (Fields) ---
    // These fields store the actual data for the word.
    // '_text' holds the word itself, and '_isHidden' tracks its visibility.
    private string _text;
    private bool _isHidden;

    // --- Public Properties (Getters) ---
    // For 'Text', we only provide a 'get' accessor because the text of a word
    // should not change after the Word object is created.
    public string Text
    {
        get { return _text; }
        // No 'set' accessor here, making the 'Text' property read-only after construction.
    }

    // For 'IsHidden', we provide a 'get' accessor. The state of being hidden
    // is changed through the 'Hide()' and 'Show()' methods, not directly via a setter.
    public bool IsHidden
    {
        get { return _isHidden; }
        // No 'set' accessor here; state changes are handled by Hide() and Show().
    }

    // --- Constructor ---
    // The constructor is used to create a new Word object and set its initial state.


    // --- Initializes a new instance of the Word class with the specified text.
    // By default, a new word is created in a 'shown' (not hidden) state. ---

    /// <param name="text">The actual string content of the word (e.g., "God", "loved").</param>
    public aiWord(string text)
    {
        // Assign the passed text to the private '_text' field.
        _text = text;
        // Initialize the word as not hidden (shown) when it's created.
        _isHidden = false;
    }

    // --- Public Methods ---
    // These methods define the behaviors of the Word class, allowing external
    // code to interact with its state in a controlled manner.

    /// <summary>
    /// Marks the word as hidden.
    /// </summary>
    public void Hide()
    {
        _isHidden = true;
    }

    /// <summary>
    /// Marks the word as shown (not hidden).
    /// </summary>
    public void Show()
    {
        _isHidden = false;
    }

    /// <summary>
    /// Returns the text of the word, or a series of underscores if the word is hidden.
    /// </summary>
    /// <returns>The word's text if shown, or underscores matching its length if hidden.</returns>
    public string GetRenderedText()
    {
        // Check the current hidden state of the word.
        if (_isHidden)
        {
            // If hidden, return a string of underscores ('_') with the same length as the word's text.
            // String.Join("", Enumerable.Repeat("_", _text.Length)) is a concise way to do this,
            // but a simple loop or new string(char, int) is also valid.
            return new string('_', _text.Length);
        }
        else
        {
            // If not hidden, return the actual text of the word.
            return _text;
        }
    }
}