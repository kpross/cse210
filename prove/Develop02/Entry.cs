using System;

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------


// Represents a single journal entry with a date and the entry text.
public class Entry
{
    // Member variable to store the date of the entry.
    public string _date;
    // Member variable to store the entry text.
    public string _entryText; // Renamed from _entry to _entryText for clarity

    // Default constructor.
    public Entry()
    {
    }

    // Constructor to initialize an Entry with a date and entry text.
    public Entry(string date, string entryText)
    {
        _date = date;
        _entryText = entryText;
    }

    // Displays the entry in a formatted way to the console.
    public void Display()
    {
        // Use Console.WriteLine to output the date and entry text.
        Console.WriteLine($"Date: {_date} - Entry: {_entryText}");
    }

    // Converts the entry to a string format suitable for saving to a file.
    // Uses a pipe '|' as a separator as suggested in the problem description.
    public string ToSavableString()
    {
        return $"{_date}|{_entryText}";
    }
}
