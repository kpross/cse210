using System;
using System.Collections.Generic;
using System.IO;                 

// -------------------------------------------
// AI WAS USED TO HELP CLEAN UP AND ANNOTATE CODE
// -------------------------------------------


// Represents a journal containing a list of entries.
public class Journal
{
    // Member variable to store the owner's name for the journal.
    public string _owner;
    // A list to hold all the Entry objects in this journal.
    public List<Entry> _entries = new List<Entry>();

    // Displays the journal's owner and then iterates through and displays each entry.
    public void Display()
    {
        Console.WriteLine($"\n--- {_owner}'s Journal ---");
        // Check if there are any entries to display.
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal yet.");
        }
        else
        {
            // Iterate through each entry in the _entries list and call its Display method.
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        Console.WriteLine("------------------------\n");
    }

    // Adds a new Entry object to the journal's list of entries.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Saves the current journal entries to a specified file.
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.ToSavableString());
            }
        }
            Console.WriteLine($"Journal saved successfully to '{filename}'.");
    }

    // Loads journal entries from a specified file, replacing current entries.
    public void LoadFromFile(string filename)
    {

        _entries.Clear();
        using (StreamReader inputFile = new StreamReader(filename))
            {
                string line;

                while ((line = inputFile.ReadLine()) != null)
                {

                    string[] parts = line.Split('|');

                    if (parts.Length >= 2)
                    {
                        string date = parts[0];

                        string entryText = string.Join("|", parts, 1, parts.Length - 1);

                        Entry loadedEntry = new Entry(date, entryText);

                        _entries.Add(loadedEntry);
                    }
                }
            }
            Console.WriteLine($"Journal loaded successfully from '{filename}'.");
        
    }
}
