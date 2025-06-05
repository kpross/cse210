using System;

// -------------------------------------------
// AI GENERATED FOR EXAMPLE AND LEARNING
// -------------------------------------------

// The 'Reference' class encapsulates the book, chapter, and verse information
// for a scripture reference. It follows encapsulation principles by keeping
// its data private and exposing it through properties and methods.
public class aiReference
{
    // --- Private Attributes (Fields) ---
    // These fields store the actual data for the scripture reference.
    // They are declared as 'private' to enforce encapsulation, meaning
    // they can only be accessed directly from within this class.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse; // Used for scripture ranges (e.g., Proverbs 3:5-6)

    // --- Public Properties (Getters and Setters) ---
    // Properties provide a controlled way to access and modify the private fields.
    // They act as the public interface for the class's data.
    // 'get;' allows reading the value.
    // 'set;' allows writing the value.
    public string Book
    {
        get { return _book; }
        set { _book = value; } // 'value' is an implicit parameter representing the new value
    }

    public int Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public int Verse
    {
        get { return _verse; }
        set { _verse = value; }
    }

    public int EndVerse
    {
        get { return _endVerse; }
        set { _endVerse = value; }
    }

    // --- Constructors ---
    // Constructors are special methods used to create new instances (objects) of the class.
    // They initialize the object's state when it is created.

    /// <summary>
    /// Constructor for a single-verse scripture reference (e.g., John 3:16).
    /// </summary>
    /// <param name="book">The name of the book (e.g., "John").</param>
    /// <param name="chapter">The chapter number (e.g., 3).</param>
    /// <param name="verse">The verse number (e.g., 16).</param>
    public aiReference(string book, int chapter, int verse)
    {
        // Assign the passed parameters to the private fields using the properties.
        // This is good practice as it allows any validation logic in the property setters
        // to be applied during construction.
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = 0; // Indicate that this is not a verse range
    }

    /// <summary>
    /// Constructor for a multi-verse scripture reference (e.g., Proverbs 3:5-6).
    /// </summary>
    /// <param name="book">The name of the book (e.g., "Proverbs").</param>
    /// <param name="chapter">The chapter number (e.g., 3).</param>
    /// <param name="startVerse">The starting verse number (e.g., 5).</param>
    /// <param name="endVerse">The ending verse number (e.g., 6).</param>
    public aiReference(string book, int chapter, int startVerse, int endVerse)
    {
        // Assign the passed parameters to the private fields.
        Book = book;
        Chapter = chapter;
        Verse = startVerse; // The 'Verse' property stores the starting verse
        EndVerse = endVerse; // The 'EndVerse' property stores the ending verse
    }

    // --- Public Methods ---

    /// <summary>
    /// Returns a formatted string representation of the scripture reference.
    /// Handles both single-verse and multi-verse references.
    /// </summary>
    /// <returns>A string like "John 3:16" or "Proverbs 3:5-6".</returns>
    public string GetDisplayText()
    {
        // Check if EndVerse is greater than Verse.
        // This indicates a verse range (e.g., 5-6).
        if (EndVerse > 0 && EndVerse > Verse)
        {
            // Use string interpolation for clear and concise formatting.
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
        }
        else
        {
            // Otherwise, it's a single verse.
            return $"{Book} {Chapter}:{Verse}";
        }
    }
}